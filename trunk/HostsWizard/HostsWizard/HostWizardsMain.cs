﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HostsWizard.Utilit;
using DevExpress.XtraTreeList.Nodes;
using HostsWizard.Helpers;
using HostsWizard.DL;

namespace HostsWizard
{
    public partial class HostWizardsMain : Form
    {
        HostsProcesscer host;

        ToolStripMenuItem menuSolutions;

        List<HostsProcesscer> hostlist = new List<HostsProcesscer>();


        System.Timers.Timer t1=null;
        //System.Timers.Timer t2;

        public HostWizardsMain()
        {
            InitializeComponent();
        }

        private void HostWizardsMain_Load(object sender, EventArgs e)
        {
            this.Text = Constants.ApplicationName;
            t1 = new System.Timers.Timer();
            //t2 = new System.Timers.Timer();
            t1.Interval = Constants.StatusBarClearInterval;
            t1.Elapsed += new System.Timers.ElapsedEventHandler(t1_Elapsed);
            // t2.Interval = 3000;

            menuSolutions = tsMISolutions;
            menuSolutions.DropDownItemClicked += new ToolStripItemClickedEventHandler(menuSolutions_DropDownItemClicked);
            //初始化方案列表
            LoadSolutionList();
            InitSolutionMenuItems();
        }



        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开文件 打开系统默认的Hosts 文件
            LoadSystemHosts();

        }

        private void LoadSystemHosts()
        {
            SetStatusText("loading system hosts file ......");
            host = new HostsProcesscer(true);
            SetStatusText("loading completed! And now binding to treelist!");
            tlHostlist.DataSource = host.fullContent;
            SetStatusText("binding completed! Then refresh checked state!");
            CheckAllCheckState(tlHostlist.Nodes);
            tlHostlist.ExpandAll();
            SetStatusText("Init completed! Enjoy!");

            this.Text =Constants.ApplicationName+ "--[Current SolutionName:"+host.SolutionName+"]";
        }

        public void RefreshTreeList()
        {
            SetStatusText("Refreshing ... ...");
            tlHostlist.DataSource = null;           
            tlHostlist.DataSource = host.fullContent;
            tlHostlist.Refresh();
            CheckAllCheckState(tlHostlist.Nodes);
            tlHostlist.ExpandAll();
            SetStatusText("Refresh completed!");
        }

        public void AddItem(HostsItem item)
        {
            host.fullContent.Add(item);
            SetStatusText("成功添加一条Hosts!");
            RefreshTreeList();
            
        }

        public void AddGroup(HostsItem groupItem)
        {
            host.fullContent.Add(groupItem);
            SetStatusText("成功添加一条Hosts分组!");
            RefreshTreeList();
            
        }

        private void tlHostlist_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            //if (e.Node.CheckState == CheckState.Checked)
            //{
            if (((EnumItemType)e.Node["Type"]) != EnumItemType.Comment)
            {
                if ((Guid)e.Node["ParentID"] == Guid.Empty)
                {
                    //全选或全取消此分组子节点的check状态
                    var id = (Guid)e.Node["ID"];
                    SetAllChildChecked(e.Node.Checked, id, tlHostlist.Nodes);
                }
                else
                {

                    e.Node["Enable"] = e.Node.CheckState == CheckState.Checked ? true : false;

                    CheckAllGroupItemState(e.Node);
                }
                //if (e.Node.CheckState == CheckState.Unchecked)
                //{
                //    e.Node.ParentNode.CheckState = CheckState.Unchecked;
                //}
                //更新分组节点的状态
                //若所有子节点都选中,则组节点的状态必为选中,只要有一个子节点为非选中状态,则组节点也为非选中状态

            }

        }

        private void tlHostlist_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {

        }

        //检测当前节点及其子节点的选中状态并做相应设置
        private void SetAllChildChecked(bool ischecked, Guid groupid, TreeListNodes lists)
        {
            foreach (TreeListNode nod in lists)
            {
                if (((EnumItemType)nod["Type"]) != EnumItemType.Comment)
                {
                    var pid = (Guid)nod["ParentID"];
                    if (pid == groupid)
                    {
                        nod.CheckState = ischecked ? CheckState.Checked : CheckState.Unchecked;
                        nod["Enable"] = nod.CheckState == CheckState.Checked ? true : false;
                    }
                    if (nod.HasChildren)
                    {
                        SetAllChildChecked(ischecked, groupid, nod.Nodes);
                    }
                }
            }

        }

        //初始化时,初始化所有节点的选中状态
        private void CheckAllCheckState(TreeListNodes lists)
        {
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode item in lists)
            {
                if (((EnumItemType)item["Type"]) != EnumItemType.Comment)
                {

                    if (((Guid)item["ParentID"]) != Guid.Empty)
                    {
                        item.CheckState = ((bool)item["Enable"]) ? CheckState.Checked : CheckState.Unchecked;
                        if (item.CheckState == CheckState.Unchecked)
                        {
                            item.ParentNode.CheckState = CheckState.Unchecked;
                        }
                    }
                    else
                    {
                        item.CheckState = CheckState.Checked;
                    }

                    if (item.HasChildren)
                    {
                        CheckAllCheckState(item.Nodes);
                    }
                }
            }
        }


        //检测当子项被选中或取消后,统一设置父节点的状态
        private void CheckAllGroupItemState(TreeListNode node)
        {
            var ischeck = true;
            foreach (TreeListNode n in node.ParentNode.Nodes)
            {
                if (!n.Checked)
                {
                    ischeck = false;
                }
            }

            node.ParentNode.Checked = ischeck;
        }

        private void btnSaveApply_Click(object sender, EventArgs e)
        {
            SaveAndApply();
        }

        //保存并应用host,同事刷新DNS缓存
        private void SaveAndApply()
        {
            FileHelper.WriteHosts(host.ToStringList());
            Utility.FlushDNS();
            LoadSystemHosts();
            SetStatusText("已保存系统Hosts,并已刷新DNS缓存!");
        }

        private void btnFlushDns_Click(object sender, EventArgs e)
        {
            RefreshDNS();
        }

        //刷新DNS缓存
        private void RefreshDNS()
        {
            Utility.FlushDNS();
            SetStatusText("刷新DNS缓存成功!");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {//另存为
            FileHelper.WriteHosts(host.ToStringList(), "c:\\hsts");
            SetStatusText("另存为文件成功!");
        }


      

        void t1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            tslblstatus.Text = "";
            t1.Stop();
        }

        private void SetStatusText(string msg)
        {
            tslblstatus.Text = msg;
            if (t1.Enabled)
            {
                t1.Stop();              
            }
            t1.Start();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem additemForm = new AddItem();
            additemForm.hosts = host;
            additemForm.ShowDialog(this);
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            AddSolution addgroupForm = new AddSolution();
            addgroupForm.grouplist = host.fullContent.Where(p => p.Type == EnumItemType.GroupTag).ToList();
            addgroupForm.ShowDialog(this);
        }

        private void miAbout_Click(object sender, EventArgs e)
        {//关于
            AboutForm about = new AboutForm();
            about.ShowDialog(this);
        }

        private void saveAndApplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAndApply();
        }

        private void refreshDNSCacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshDNS();
        }


        //--------------solutions--------------------------------

        private void InitSolutionMenuItems()
        {
            menuSolutions.DropDownItems.Clear();
            foreach (var s in hostlist)
            {
                ToolStripMenuItem solutionMenuItem = new ToolStripMenuItem();
                solutionMenuItem.Text = s.SolutionName;
                solutionMenuItem.AutoToolTip = true;
                solutionMenuItem.ToolTipText = s.SolutionID.ToString();
                solutionMenuItem.Tag = s;
                solutionMenuItem.CheckOnClick = true;
                menuSolutions.DropDownItems.Add(solutionMenuItem);
            }

        }

        //void solutionMenuItem_CheckStateChanged(object sender, EventArgs e)
        //{
        //    //方案被选中时
        //    ToolStripMenuItem item = (ToolStripMenuItem)sender;
        //    if (item.CheckState == CheckState.Checked)
        //    {

        //    }
        //}

        void menuSolutions_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //单击方案项
            ToolStripMenuItem item = (ToolStripMenuItem)e.ClickedItem;
            if (item.CheckState == CheckState.Checked)
            {
                foreach (ToolStripMenuItem mu in menuSolutions.DropDownItems)
                {
                    if(!mu.Equals(item))
                    {
                        mu.CheckState = CheckState.Unchecked;
                    }
                }
            }
            this.host = (HostsProcesscer)item.Tag;
            RefreshTreeList();
            SaveAndApply();
        }

        private void LoadSolutionList()
        {
            SolutionDL dl = new SolutionDL();
            hostlist = dl.GetSolutionAll();
        }

        private void tsMenuSaveSolution_Click(object sender, EventArgs e)
        {// 已隐藏,暂不使用此菜单

        }

        private void SaveNewSolution()
        {
            SolutionDL dl = new SolutionDL();
            if (dl.SolutionExist(host.SolutionID))
            {
                dl.UpdateSolution(host);
            }
            else
            {
                if (host.SolutionID == Guid.Empty)
                {
                    host.SolutionID = Guid.NewGuid();
                }
                dl.AddNewSolution(host);
            }

            LoadSolutionList();
            InitSolutionMenuItems();
            SetCurrentSolutionHost();
        }

        private void SetCurrentSolutionHost()
        {
            foreach (ToolStripMenuItem item in menuSolutions.DropDownItems)
            {
                HostsProcesscer htemp = (HostsProcesscer)item.Tag;
                if (htemp.SolutionID == host.SolutionID)
                {
                    item.CheckState = CheckState.Checked;
                }
            }
        }

        public void SetSolutionName(string solutionName)
        {
            this.host.SolutionName = solutionName;

        }

        public void SetNewSolution(string solutionName)
        {
            this.host.SolutionName = solutionName;
            RefreshTreeList();
        }

        private void tsMenuUpdateSolution_Click(object sender, EventArgs e)
        {// 保存方案
            if (host != null)
            {
                SaveNewSolution();
            }
        }

        private void createNewSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.host = new HostsProcesscer();
            host.SolutionID = Guid.NewGuid();
            CreateNewSolution nesolutionForm = new CreateNewSolution();
            nesolutionForm.ShowDialog(this);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {//备份系统hosts

        }



    }
}

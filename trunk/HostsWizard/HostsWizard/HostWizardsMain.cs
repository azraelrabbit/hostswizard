using System;
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
using DevExpress.XtraTreeList;

namespace HostsWizard
{
    public partial class frmMain : Form
    {
        HostsProcesscer host;

        ToolStripMenuItem menuSolutions;

        List<HostsProcesscer> hostlist = new List<HostsProcesscer>();


        System.Timers.Timer t1 = null;
        //System.Timers.Timer t2;

        public frmMain()
        {
            InitializeComponent();
        }

        private void HostWizardsMain_Load(object sender, EventArgs e)
        {

            //多语言
            (new LanguageUtility()).SetCurrentLanguage(this);
            CheckLanguageMenuStatus();

            //检查sqlite库是否存在,不存在则拷贝自己的,存在则略过
            FileHelper.InitAppDataFile();

            this.saveFileDialog1.Filter = "HostsWizards Solution Files|*.hws";
            saveFileDialog1.DefaultExt = ".hws";
            saveFileDialog1.AddExtension = true;

            this.openFileDialog1.Filter = "HostsWizards Solution Files|*.hws";

            this.Text = Constants.ApplicationName;
            t1 = new System.Timers.Timer();
            //t2 = new System.Timers.Timer();
            t1.Interval = Constants.StatusBarClearInterval;
            t1.Elapsed += new System.Timers.ElapsedEventHandler(t1_Elapsed);
            // t2.Interval = 3000;

            menuSolutions = tsMSolutions;
            menuSolutions.DropDownItemClicked += new ToolStripItemClickedEventHandler(menuSolutions_DropDownItemClicked);
            //初始化方案列表
            LoadSolutionList();
            InitSolutionMenuItems();


        }


        public void ReloadSolution()
        {
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
            // RemGroupState();
            SetStatusText("loading system hosts file ......");
            host = new HostsProcesscer(true);
            SetStatusText("loading completed! And now binding to treelist!");
            tlHostlist.DataSource = host.fullContent;
            SetStatusText("binding completed! Then refresh checked state!");
            CheckAllCheckState(tlHostlist.Nodes);
            // tlHostlist.ExpandAll();
            //RestoreGroupState();
            CheckAllExpendedState();
            SetStatusText("Init completed! Enjoy!");

            this.Text = Constants.ApplicationName + "--[Current SolutionName:" + host.SolutionName + "]";
        }

        public void RefreshTreeList()
        {
            // RemGroupState();
            SetStatusText("Refreshing ... ...");
            tlHostlist.DataSource = null;
            tlHostlist.DataSource = host.fullContent;
            // tlHostlist.Refresh();
            CheckAllCheckState(tlHostlist.Nodes);
            // tlHostlist.ExpandAll();
            //RestoreGroupState();
            CheckAllExpendedState();
            SetStatusText("Refresh completed!");

        }

        private void CheckAllExpendedState()
        {
            foreach (TreeListNode tln in tlHostlist.Nodes)
            {
                tln.Expanded = (bool)tln["Expended"];
            }
        }

        Dictionary<string, bool> groupStatus = new Dictionary<string, bool>();

        //记录各个组节点的展开状态
        private void RemGroupState()
        {
            groupStatus.Clear();
            foreach (TreeListNode node in tlHostlist.Nodes)
            {
                groupStatus.Add(node["ID"].ToString(), node.Expanded);
            }
        }

        private void RestoreGroupState()
        {
            if (groupStatus.Count > 0)
            {
                foreach (TreeListNode node in tlHostlist.Nodes)
                {
                    node.Expanded = groupStatus[node["ID"].ToString()];
                }
            }
        }


        public void AddItem(HostsItem item)
        {
            host.fullContent.Add(item);
            SetStatusText("成功添加一条Hosts!");
            RefreshTreeList();

        }

        public void AddItems(List<HostsItem> items)
        {//批量添加item
            host.fullContent.AddRange(items);
            SetStatusText("成功添加" + items.Count + " 条 Hosts!");
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

        public void SetStatusText(string msg)
        {
            tslblstatus.Text = msg;
            t1.Dispose();
            t1 = new System.Timers.Timer();
            //t2 = new System.Timers.Timer();
            t1.Interval = Constants.StatusBarClearInterval;
            t1.Elapsed += new System.Timers.ElapsedEventHandler(t1_Elapsed);
            t1.Start();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (host == null)
            {
                MessageBox.Show("未加载任何Hosts信息!");
            }
            frmAddItem additemForm = new frmAddItem();
            additemForm.hostItemList = host.fullContent;
            additemForm.ShowDialog(this);
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {

            if (host == null)
            {
                MessageBox.Show("未加载任何Hosts信息!");
            }

            frmAddGroup addgroupForm = new frmAddGroup();
            addgroupForm.grouplist = host.fullContent.Where(p => p.Type == EnumItemType.GroupTag).ToList();
            addgroupForm.ShowDialog(this);
        }

        private void miAbout_Click(object sender, EventArgs e)
        {//关于
            frmAbout about = new frmAbout();
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
                //solutionMenuItem.CheckOnClick = true;
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
            //if (item.CheckState == CheckState.Checked)
            //{
            //foreach (ToolStripMenuItem mu in menuSolutions.DropDownItems)
            //{
            //    var it = (HostsProcesscer)mu.Tag;
            //    if(mu.Text==item.Text)
            //    {
            //        mu.CheckState = CheckState.Checked;
            //        mu.Checked = true;                       
            //    }
            //    else{
            //        mu.CheckState = CheckState.Unchecked;
            //        mu.Checked = false;
            //    }
            //}
            this.host = (HostsProcesscer)item.Tag;
            RefreshTreeList();
            //SaveAndApply();
            SetCurrentSolutionHost();
            SetStatusText("方案: " + host.SolutionName + " 加载成功!");
            //}

        }

        private void LoadSolutionList()
        {
            SolutionDL dl = new SolutionDL();
            hostlist = dl.GetSolutionAll();
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
            if (host != null)
            {
                foreach (ToolStripMenuItem item in menuSolutions.DropDownItems)
                {
                    HostsProcesscer htemp = (HostsProcesscer)item.Tag;
                    if (htemp.SolutionID == host.SolutionID)
                    {
                        item.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        item.CheckState = CheckState.Unchecked;
                    }
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
            frmCreateNewSolution nesolutionForm = new frmCreateNewSolution();
            nesolutionForm.ShowDialog(this);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {//备份系统hosts
            FileHelper.BackupSystemHost();
        }

        private void tsCDel_Click(object sender, EventArgs e)
        {
            // DeleteItem();
        }

        private void DeleteItem(HostsItem item)
        {
            string delMsg = "删除选中项?";
            DialogResult dr = MessageBox.Show(delMsg, tsCDel.Text, MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                host.fullContent.Remove(item);
                RefreshTreeList();
                SetStatusText("已删除项!");
            }
        }

        private void DeleteGroup(HostsItem item)
        {
            string delMsg = "删除选中分组?此操作将删除分组及其所有子项!";
            DialogResult dr = MessageBox.Show(delMsg, tsCDel.Text, MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                host.fullContent.Remove(item);
                host.fullContent.RemoveAll(p => p.ParentID == item.ID);
                RefreshTreeList();
                SetStatusText("已删除分组!");
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExportSolutionFile()
        {
            if (host == null)
            {
                MessageBox.Show("未加载任何Hosts信息!");
            }

            DialogResult dr = saveFileDialog1.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var filePath = saveFileDialog1.FileName;
                byte[] hostcontents = SerializationHelper.GetBinaryFormatSerialize(host);
                FileHelper.WriteSolutionFile(hostcontents, filePath);
                SetStatusText("方案已导出到文件:" + filePath);
            }
        }

        private void exportCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportSolutionFile();
        }

        private void exportOthersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //导出其他方案
            frmExportForm exportForm = new frmExportForm();
            exportForm.ShowDialog(this);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = openFileDialog1.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    var filePath = openFileDialog1.FileName;
                    var item = FileHelper.ReadSolutionFile(filePath);
                    ImportSolution(item);
                    SetStatusText("导入方案成功,方案名: " + item.SolutionName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("导入失败,不是方案文件,或文件被破坏!\r\n INFO:" + ex.Message);
            }
        }
        private void ImportSolution(HostsProcesscer item)
        {
            SolutionDL dl = new SolutionDL();
            if (dl.SolutionExist(item.SolutionID))
            {
                dl.UpdateSolution(item);
            }
            else
            {
                if (item.SolutionID == Guid.Empty)
                {
                    item.SolutionID = Guid.NewGuid();
                }
                dl.AddNewSolution(item);
            }

            LoadSolutionList();
            InitSolutionMenuItems();
            SetCurrentSolutionHost();
        }

        private void tsMzhCN_Click(object sender, EventArgs e)
        {
            AppConfigHelper.UpdateAppConfig("Language", "zh-CN");
            (new LanguageUtility()).SetCurrentLanguage(this);
            CheckLanguageMenuStatus();
        }

        private void tsMenUS_Click(object sender, EventArgs e)
        {
            AppConfigHelper.UpdateAppConfig("Language", "en-US");
            (new LanguageUtility()).SetCurrentLanguage(this);
            CheckLanguageMenuStatus();
        }
        private void CheckLanguageMenuStatus()
        {
            var currentLang = AppConfigHelper.GetAppConfig("Language");

            if (currentLang == "zh-CN")
            {
                this.tsMzhCN.CheckState = CheckState.Checked;
                this.tsMenUS.CheckState = CheckState.Unchecked;
            }
            else
            {
                this.tsMzhCN.CheckState = CheckState.Unchecked;
                this.tsMenUS.CheckState = CheckState.Checked;
            }
        }

        private void tsMExit_Click(object sender, EventArgs e)
        {
            this.Close();
            // Application.Exit();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsmSolotionMgr_Click(object sender, EventArgs e)
        {//方案管理
            SolutionManageForm smf = new SolutionManageForm();
            smf.ShowDialog(this);
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {//批量添加
            if (host == null)
            {
                MessageBox.Show("未加载任何Hosts信息!");
            }
            //frmAddItem additemForm = new frmAddItem();
            //additemForm.hosts = host;
            //additemForm.ShowDialog(this);

            AddItems additems = new AddItems();
            additems.hostItemList = host.fullContent;
            additems.ShowDialog(this);
        }

        private void tlHostlist_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {//右键弹出菜单
                tlHostlist.ContextMenuStrip = null;
                TreeListHitInfo hInfo = tlHostlist.CalcHitInfo(new Point(e.X, e.Y));
                TreeListNode node = hInfo.Node;
                tlHostlist.FocusedNode = node;
                if (node != null)
                {
                    //tlHostlist.ContextMenuStrip = popUpMuChild;
                    if (((EnumItemType)node["Type"]) == EnumItemType.GroupTag)
                    {//分组
                        barManager1.SetPopupContextMenu(tlHostlist, popupMuGroup);
                    }
                    else
                    {//普通项
                        barManager1.SetPopupContextMenu(tlHostlist, popUpMuChild);
                    }
                }
            }
        }

        private void barMenuDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {//删除子项
            var node = tlHostlist.FocusedNode;
            var id = (Guid)node["ID"];
            var item = host.fullContent.FirstOrDefault(p => p.ID == id);
            DeleteItem(item);
        }

        private void barMuAddItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {//给当前选中组,批量添加项
            var node = tlHostlist.FocusedNode;
            var id = (Guid)node["ID"];
            var item = host.fullContent.FirstOrDefault(p => p.ID == id);

            if (host == null)
            {
                MessageBox.Show("未加载任何Hosts信息!");
            }
            //frmAddItem additemForm = new frmAddItem();
            //additemForm.hosts = host;
            //additemForm.ShowDialog(this);

            AddItems additems = new AddItems();
            additems.hostItemList = new List<HostsItem>() { item };
            additems.ShowDialog(this);
        }

        private void barMuDeleteGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {//删除分组
            var node = tlHostlist.FocusedNode;
            var id = (Guid)node["ID"];
            var item = host.fullContent.FirstOrDefault(p => p.ID == id);
            DeleteGroup(item);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {//给当前分组单条添加host
            var node = tlHostlist.FocusedNode;
            var id = (Guid)node["ID"];
            var item = host.fullContent.FirstOrDefault(p => p.ID == id);

            frmAddItem additem = new frmAddItem();
            additem.hostItemList = new List<HostsItem>() { item };
            additem.Show(this);
        }

        private void tlHostlist_AfterExpand(object sender, NodeEventArgs e)
        {
            e.Node["Expended"] = true;
        }

        private void tlHostlist_AfterCollapse(object sender, NodeEventArgs e)
        {
            e.Node["Expended"] = false;
        }

        private void tsMEnableDns_Click(object sender, EventArgs e)
        {
            RegisterHelper.EnableDnsCache();
        }

        private void tsMDisableDns_Click(object sender, EventArgs e)
        {
            RegisterHelper.DisableDnsCache();
        }

    }
}

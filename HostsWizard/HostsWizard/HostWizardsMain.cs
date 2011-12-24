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

namespace HostsWizard
{
    public partial class HostWizardsMain : Form
    {
        HostsProcesscer host;

        public HostWizardsMain()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开文件 打开系统默认的Hosts 文件
            host = new HostsProcesscer(true);
            tlHostlist.DataSource = host.fullContent;
            CheckAllCheckState(tlHostlist.Nodes);
            tlHostlist.ExpandAll();

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

        }

        private void btnFlushDns_Click(object sender, EventArgs e)
        {

        }
    }
}
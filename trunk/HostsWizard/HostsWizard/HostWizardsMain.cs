using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HostsWizard.Utilit;

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
            CheckAllCheckState();
        }

        private void tlHostlist_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            //if (e.Node.CheckState == CheckState.Checked)
            //{
                if ((Guid)e.Node["ParentID"] == Guid.Empty)
                {
                    //全选或全取消此分组子节点的check状态
                    var id = (Guid)e.Node["ID"];
                    SetAllChildChecked(e.Node.Checked, id);
                }
                else
                {
                    e.Node["Enable"] = e.Node.Checked;
                    //更新分组节点的状态
                    //若所有子节点都选中,则组节点的状态必为选中,只要有一个子节点为非选中状态,则组节点也为非选中状态

                }
                CheckAllCheckState();
            //}
            //else
            //{

            //}
        }

        private void tlHostlist_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {            
            //if (e.Column.Caption.Equals("Enable"))
            //{
            //    var id = e.Node["ID"].ToString();
            //    var currentItem=host.fullContent.FirstOrDefault(p => p.ID == Guid.Parse(id));
                
            //}
        }

        private void SetAllChildChecked(bool ischecked,Guid groupid)
        {            
                var items = host.fullContent.Where(p => p.ParentID.Equals(groupid));
                var uncheckItems = items.Where(p => p.Enable!=ischecked);
                if (null != uncheckItems)
                    {
                        foreach (var item in uncheckItems)
                        {
                            item.Enable = ischecked;
                        }
                    }
            
        }

        private void CheckAllCheckState()
        {
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode item in tlHostlist.Nodes)
            {
                if (((Guid)item["ParentID"]) != Guid.Empty)
                {
                    item.Checked = (bool)item["Enable"];
                }
            }
        }
    }
}

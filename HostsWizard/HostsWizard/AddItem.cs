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
    public partial class AddItem : Form
    {
        public HostsProcesscer hosts;

        public AddItem()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdditem_Click(object sender, EventArgs e)
        {//添加item
            Guid parentid=(Guid)ddlGroup.SelectedValue;
            string groupname = ddlGroup.Text;
            string ip = txtIp.Text.Trim();
            string domain = txtDomain.Text.Trim();
            HostsItem item = new HostsItem();
            item.IP = ip;
            item.Domain = domain;
            item.Enable = true;
            item.Type = EnumItemType.HostItem;
            item.ParentID=parentid;
            item.Group = groupname;
            item.ID = Guid.NewGuid();

            ((HostWizardsMain)this.Owner).AddItem(item);
            this.Close();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            //绑定group
            var group = hosts.fullContent.Where(p => p.Type == EnumItemType.GroupTag).ToList();
            ddlGroup.DataSource = group;
            ddlGroup.DisplayMember = "IP";
            ddlGroup.ValueMember = "ID";            
            
        }
    }
}

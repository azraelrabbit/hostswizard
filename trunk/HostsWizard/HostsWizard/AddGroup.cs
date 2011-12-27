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
    public partial class AddSolution : Form
    {
        public List<HostsItem> grouplist;

        public AddSolution()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            var groupname = "###" + txtGroupName.Text.Trim();
            HostsItem item = new HostsItem();
            item.IP = groupname;
            item.Domain = string.Empty;
            item.Enable = true;
            item.Type = EnumItemType.GroupTag;
            item.ParentID = Guid.Empty;
            item.Group = string.Empty;
            item.ID = Guid.NewGuid();

            ((HostWizardsMain)this.Owner).AddGroup(item);
            this.Close();
        }
       

    }
}

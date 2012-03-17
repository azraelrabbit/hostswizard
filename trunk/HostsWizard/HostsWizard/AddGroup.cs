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
    public partial class frmAddGroup : Form
    {
        public List<HostsItem> grouplist;

        public frmAddGroup()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
            //多语言
            (new LanguageUtility()).SetCurrentLanguage(this);
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

            // ((frmMain)this.Owner).AddGroup(item);

            string name = this.Owner.GetType().Name;
            switch (name)
            {
                case "frmMain":
                    ((frmMain)this.Owner).AddGroup(item);
                    break;
                case "frmMainR":
                    ((frmMainR)this.Owner).AddGroup(item);
                    break;
                default:
                    break;
            }

            this.Close();
        }


    }
}

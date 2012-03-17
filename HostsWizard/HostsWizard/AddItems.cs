using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.TextEditor;
using ICSharpCode;
using HostsWizard.Utilit;

namespace HostsWizard
{
    public partial class AddItems : Form
    {

        ICSharpCode.TextEditor.TextEditorControl tec = new TextEditorControl();
        TabPageType editPageType = TabPageType.Text;
        public HostsProcesscer hosts;
        public List<HostsItem> hostItemList;

        public AddItems()
        {
            InitializeComponent();
        }

        private void AddItems_Load(object sender, EventArgs e)
        {
            tec.Dock = DockStyle.Fill;
            xtpAddbyText.Controls.Add(tec);

            (new LanguageUtility()).SetCurrentLanguage(this);

            //绑定group
            var group = hostItemList.Where(p => p.Type == EnumItemType.GroupTag).ToList();
            ddlGroup.DataSource = group;
            ddlGroup.DisplayMember = "IP";
            ddlGroup.ValueMember = "ID";

        }


        private void btnSaveBack_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveBack_Click_1(object sender, EventArgs e)
        {//保存
            Guid parentid = (Guid)ddlGroup.SelectedValue;
            string groupname = ddlGroup.Text;

            switch (editPageType)
            {
                case TabPageType.Text:
                    AddByText(parentid, groupname);
                    break;
                case TabPageType.List:
                    AddByList(parentid, groupname);
                    break;
                default:
                    AddByText(parentid, groupname);
                    break;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {



        }

        private void AddByText(Guid groupID, string groupName)
        {
            var hostItemText = tec.Text;
            string[] splitStr = { "\r\n" };
            List<string> contentList = hostItemText.Split(splitStr, StringSplitOptions.None).ToList();
            var hostItems = ProcessBody(contentList, groupID, groupName);
            //((frmMainRibbon)this.Owner).AddItems(hostItems);
            string tname = this.Owner.GetType().Name;
            switch (tname)
            {
                case "frmMain":
                    ((frmMain)this.Owner).AddItems(hostItems);
                    break;
                case "frmMainR":
                    ((frmMainR)this.Owner).AddItems(hostItems);
                    break;
                default:
                    break;
            }
            this.Close();
        }

        private void AddByList(Guid groupID, string groupName)
        {

        }


        private void xtcAddItems_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (e.Page.Equals(xtpAddbyText))
            {
                editPageType = TabPageType.Text;
            }
            else
            {
                editPageType = TabPageType.List;
            }
        }

        private List<HostsItem> ProcessBody(List<string> itemlist, Guid groupID, string groupName)
        {
            List<HostsItem> temp = new List<HostsItem>();
            string currentGroupName = groupName;

            Guid currentGroupID = groupID;

            foreach (var item in itemlist)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    var arry = item.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    HostsItem hostitem = new HostsItem();
                    hostitem.ID = Guid.NewGuid();
                    hostitem.ParentID = currentGroupID;

                    hostitem.IP = arry[0];
                    if (arry.Length > 1)
                    {
                        hostitem.Domain = arry[1];
                        hostitem.Type = EnumItemType.HostItem;
                    }
                    else
                    {
                        hostitem.Type = EnumItemType.Comment;
                    }

                    hostitem.Group = currentGroupName;
                    hostitem.Enable = (hostitem.IP.IndexOf("#") < 0);
                    temp.Add(hostitem);
                }

            }

            return temp;
        }
    }

    internal enum TabPageType
    {
        Text,
        List
    }
}

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
    public partial class Form2 : Form
    {
        HostsProcesscer host;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Groups.Clear();
            listView1.Items.Clear();

            listView1.Columns.Add(new ColumnHeader() { Text = "Operat", Name = "Operat", Width = 60 });
            listView1.Columns.Add(new ColumnHeader() { Text="IP",Name="IP", Width=200 });
            listView1.Columns.Add(new ColumnHeader() { Text = "Domain", Name = "Domain",Width=200 });
            listView1.Columns.Add(new ColumnHeader() { Text = "Enabled", Name = "Enabled",Width=70 });

           // listView1.Items.Add(new ListViewItem("asdfasdf"));

            ListViewGroup header = new ListViewGroup("header", "header");
            
            listView1.Groups.Add(header);
            foreach (var item in host.originList)
            {
                ListViewItem im = new ListViewItem(header);
                im.SubItems.Add(new ListViewItem.ListViewSubItem() { Name="IP",Text=item.IP });
                im.SubItems.Add(new ListViewItem.ListViewSubItem() { Name = "Domain", Text = item.Domain });
                im.SubItems.Add(new ListViewItem.ListViewSubItem() { Name = "Enabled", Text = item.Enable.ToString() });

               // im.SubItems.Add(item);
                im.Checked = item.Enable;
                listView1.Items.Add(im);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             host = new HostsProcesscer(true);

             listView1.CheckBoxes = true;
             listView1.GridLines = true;
             listView1.View = View.Details;

             listView1.ItemCheck += new ItemCheckEventHandler(listView1_ItemCheck);
             listView1.ItemChecked += new ItemCheckedEventHandler(listView1_ItemChecked);
        }

        void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //ListViewItem lv = e.Item;

            //if (lv.SubItems["Enabled"].Text =="true")
            //{
            //    lv.SubItems["Enabled"].Text = "false";

            //}
            //else
            //{
            //    lv.SubItems["Enabled"].Text = "true";
            //}
        }

        void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }
    }
}

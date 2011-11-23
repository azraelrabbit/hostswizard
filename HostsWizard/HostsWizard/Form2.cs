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
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.ShowGroups = true;
            HostsProcesscer host = new HostsProcesscer();
            ListViewGroupCollection groupList =listView1.Groups;
            ListViewGroup header = new ListViewGroup("Header", "Header") { Name="header"};
            
            foreach (var item in host.hostHead)
            {
                //listBox1.Items.Add(item);
                header.Items.Add(new ListViewItem(item));
            }
            groupList.Add(header);

            foreach (var item in host.hostBody)
            {
               // listBox1.Items.Add(item.Key);

                ListViewGroup grp = new ListViewGroup(item.Key, item.Key) {  Name=item.Key};
               
                foreach (var hs in item.Value)
                {
                   // listBox1.Items.Add(hs.Value + "    " + hs.Key);

                    string [] tm={hs.Value,hs.Key};
                    ListViewItem li = new ListViewItem(hs.Value + "    " + hs.Key);
                    grp.Items.Add(li);
                }
                groupList.Add(grp);
            }

        }
    }
}

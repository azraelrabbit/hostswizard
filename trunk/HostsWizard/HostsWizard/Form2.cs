﻿using System;
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
            listView1.Groups.Clear();
            listView1.Items.Clear();
           
            HostsProcesscer host = new HostsProcesscer();

            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.Columns.Add(new ColumnHeader() { Text="IP",Name="ip", Width=200 });
            listView1.Columns.Add(new ColumnHeader() { Text = "Domain",Name="domain" });
           // listView1.Items.Add(new ListViewItem("asdfasdf"));

            ListViewGroup header = new ListViewGroup("header", "header");
            
            listView1.Groups.Add(header);
            foreach (var item in host.hostHead)
            {
                ListViewItem im = new ListViewItem(item,header);
               // im.SubItems.Add(item);

                listView1.Items.Add(im);
            }
        }
    }
}

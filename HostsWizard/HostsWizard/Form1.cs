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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //HostsProcesscer host = new HostsProcesscer();
            //listBox1.Items.Add("header:");
            //foreach (var item in host.hostHead)
            //{
            //    listBox1.Items.Add(item);
            //}
            //listBox1.Items.Add("body:");
            //foreach (var item in host.hostBody)
            //{
            //    listBox1.Items.Add(item.Key);
            //    foreach (var hs in item.Value)
            //    {
            //        listBox1.Items.Add(hs.Value + "    " + hs.Key);
            //    }
            //}
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    string filepath="c:\\hst.txt";
        //    StringBuilder sb = new StringBuilder();
        //    HostsProcesscer host = new HostsProcesscer();
        //    sb.Append("header:\r\n");
        //    foreach (var item in host.hostHead)
        //    {
        //        sb.Append(item + "\r\n");
        //    }
       
        //  //  Utility.WriteLog(filepath, "body:");
        //   sb.Append("body:" + "\r\n");
        //    foreach (var item in host.hostBody)
        //    {
        //        sb.Append(item.Key + "\r\n");
        //        foreach (var hs in item.Value)
        //        {
        //           //  Utility.WriteLog(filepath,hs.Value + "    " + hs.Key);
        //            sb.Append(hs.Value + "    " + hs.Key + "\r\n");
        //        }
        //    }
        //    Utility.WriteLog(filepath, sb.ToString());
        //}
    }
}

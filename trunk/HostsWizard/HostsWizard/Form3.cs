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
    public partial class Form3 : Form
    {
        HostsProcesscer host;

        public Form3()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             host = new HostsProcesscer(true);

             treeList1.DataSource = host.fullContent;
             treeList1.ParentFieldName = "ParentID";
             
           
        }
    }
}

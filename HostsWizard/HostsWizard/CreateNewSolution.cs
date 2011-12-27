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
    public partial class CreateNewSolution : Form
    {
       
        public CreateNewSolution()
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
            var name = txtSolutionName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                name = "Auto" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
            ((HostWizardsMain)this.Owner).SetNewSolution(name);
            this.Close();
        }

        private void CreateNewSolution_FormClosing(object sender, FormClosingEventArgs e)
        {
           // e.Cancel = true;
        }
       

    }
}

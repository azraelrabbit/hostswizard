using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HostsWizard
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            string strAbout = "Made by Rocky.zhang . ;)__\r\n Prohibit use in a server environment!\r\n";
            strAbout += "Contact me if any problem: zhangjq@ourgame.com";
            this.richTextBox1.Text = strAbout;
            
        }

        private void About_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}

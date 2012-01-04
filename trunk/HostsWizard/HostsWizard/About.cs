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
            string strAbout = "Made by Rocky.zhang . ;)__| Prohibit use in a server environment!|";
            strAbout += "Contact me if any problem: zhangjq@ourgame.com";

            // strAbout = "Rocky.zhang出品.必属精品!\r\n 禁止用于服务器环境!\r\n 如果有问题请联系: zhangjq@ourgame.com";

            var msg = (new HostsWizard.Utilit.LanguageUtility()).getMsg("aboutMsg");

            if (!string.IsNullOrEmpty(msg))
            {
                strAbout = msg;
            }
            //this.richTextBox1.Text = strAbout;
            richTextBox1.Lines = strAbout.Split('|');

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

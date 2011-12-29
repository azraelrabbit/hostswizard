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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            //多语言
            //(new LanguageUtility()).SetCurrentLanguage("zh-CN",this);
            (new LanguageUtility()).SetCurrentLanguage(this);
        }
    }
}

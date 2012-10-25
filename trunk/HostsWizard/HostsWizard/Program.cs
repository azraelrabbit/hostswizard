using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using HostsWizard.Utilit;

namespace HostsWizard
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (AppConfigHelper.GetAppConfig("ISRIB").Trim().ToLower() == "true")
            {
                var mainR = new frmMainR();
                Application.Run(mainR);
            }
            else
            {
                var main = new frmMain();
                Application.Run(main);
            }
        }
    }
}

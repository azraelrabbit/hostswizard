using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using HostsWizard.Utilit;
using System.Windows.Forms;

namespace HostsWizard.Helpers
{
    public class ProcessHelper
    {
        private static void ProcessRegFile(string filePath)
        {
            using (Process p = new Process())
            {
                p.StartInfo = new ProcessStartInfo(filePath);
                p.Start();
            }
        }

        public static void EnableDnsCache()
        {
            var filepath = Constants.ApplicationStartUpPath + "\\EnableDnsCache.reg";
            ProcessRegFile(filepath);
        }

        public static void DisableDnsCache()
        {
            var filepath = Constants.ApplicationStartUpPath + "\\DisableDnsCache.reg";
            ProcessRegFile(filepath);
        }

        public static void RestartSelf()
        {
            using (Process p = new Process())
            {
                p.StartInfo = new ProcessStartInfo(Constants.ApplicationFilePath);
                p.Start();
            }
        }

        public static bool OpanHostByNotepad()
        {
            try
            {
                using (Process p = new Process())
                {
                    p.StartInfo = new ProcessStartInfo("notepad.exe");
                    p.StartInfo.Arguments = Constants.HostsPath;
                    p.Start();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void OpenHostFile()
        {
            if (OpenHostByEmeditor())
            {

            }
            else
            {
                MessageBox.Show("打开失败,请确认是否安装记事本,或其已被病毒破坏!");
            }

        }

        public static bool OpenHostByEmeditor()
        {
            try
            {
                var app = "emeditor.exe";
                OpenFileByApp(Constants.HostsPath, app);
                return true;
            }
            catch
            {
                return OpanHostByNotepad();
            }

        }

        public static void OpenFileByApp(string filePath, string AppPathname)
        {
            using (Process p = new Process())
            {
                p.StartInfo = new ProcessStartInfo(AppPathname);
                p.StartInfo.Arguments = filePath;
                p.Start();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using HostsWizard.Utilit;

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
    }
}

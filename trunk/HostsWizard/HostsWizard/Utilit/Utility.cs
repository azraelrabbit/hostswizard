using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace HostsWizard.Utilit
{
    public class Utility
    {
        public static void WriteLog(string filepath, string message)
        {
            //try
            //{
                using (FileStream fs = new FileStream(filepath, FileMode.Append,FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        sw.WriteLine(message);
                       // sw.Flush();
                        sw.Close();
                    }
                    //fs.Flush();
                    fs.Close();
                }
            //}
            //finally
            //{ }
        }

        public static void FlushDNS()
        {
            using (Process p = new Process())
            {
                p.StartInfo = new ProcessStartInfo("cmd.exe", "ipconfig /flushdns");
                p.Start();
                int ret = p.ExitCode;
                if (ret > 0)
                {

                }                
            }
        }
    }
}

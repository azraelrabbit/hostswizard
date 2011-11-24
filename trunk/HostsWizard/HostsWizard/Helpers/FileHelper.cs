using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using HostsWizard.Utilit;

namespace HostsWizard.Helpers
{
    public class FileHelper
    {
        public static List<string> GetHostsContent()
        {
            string[] splitStr = { "\r\n" };
            List<string> headlistconst = Constants.WinHostsHead.Split(splitStr, StringSplitOptions.None).ToList();

            List<string> hostsContentList = new List<string>();
            using (FileStream fs = new FileStream(Constants.HostsPath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    int i = 0;
                    while (!sr.EndOfStream)
                    {
                        var item = sr.ReadLine();
                        if (i < headlistconst.Count && headlistconst[i].Trim() == item.Trim())
                        {                            
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(item))
                            {
                                hostsContentList.Add(item.Replace("\t","  "));
                            }
                        }
                        i++;
                    }
                }
            }

            return hostsContentList;
        }

        public static void WriteHosts(List<string> hostContent)
        {
            using (FileStream fs = new FileStream(Constants.HostsPath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    foreach (var item in hostContent)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Flush();                    
                }

                fs.Flush();
            }
        }
    }
}

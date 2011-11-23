using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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
    }
}

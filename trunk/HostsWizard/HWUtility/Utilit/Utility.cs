using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace HWUtility.Utilit
{
    public class Utility
    {
        public static void WriteLog(string filepath, string message)
        {
            //try
            //{
            using (FileStream fs = new FileStream(filepath, FileMode.Append, FileAccess.Write))
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
                 p.StartInfo.FileName="cmd.exe"; //设置启动的进程命令

                /**设置是否标准输入输出和标准错误,当这些都设为true时

                **UseShellExcute必须为 false*/

                p.StartInfo.UseShellExecute=false;

                p.StartInfo.RedirectStandardInput=true;  

                p.StartInfo.RedirectStandardOutput=true;  

                p.StartInfo.RedirectStandardError=true;   

                p.StartInfo.CreateNoWindow=true;

                p.Start();

                //向Dos窗口中输入ping的命令,这里的IP值请自己设置

                p.StandardInput.WriteLine("ipconfig /flushdns");

                //输入退出窗口的命令

                p.StandardInput.WriteLine("Exit");

                /**这里用ReadToEnd读出输出并将其赋给一个string值,这里要

                **注意的是ReadToEnd这个命令是在调用的程序结束后才可以执行的,所以

                **要是把这句放在上面的"Exit"之后,程序就会进入一个死循环*/

                string output= p.StandardOutput.ReadToEnd();
            }
        }
    }
}

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
                using (StreamReader sr = new StreamReader(fs, Encoding.Default))
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
                                hostsContentList.Add(item.Replace("\t", "  "));
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
            string[] splitStr = { "\r\n" };
            List<string> headlistconst = Constants.WinHostsHead.Split(splitStr, StringSplitOptions.None).ToList();

            using (FileStream fs = new FileStream(Constants.HostsPath, FileMode.Create, FileAccess.ReadWrite))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    foreach (var hd in headlistconst)
                    {
                        sw.WriteLine(hd);
                    }

                    foreach (var item in hostContent)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Flush();
                }
            }
        }

        public static void WriteHosts(List<string> hostContent,string filePath)
        {
            string[] splitStr = { "\r\n" };
            List<string> headlistconst = Constants.WinHostsHead.Split(splitStr, StringSplitOptions.None).ToList();

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    foreach (var hd in headlistconst)
                    {
                        sw.WriteLine(hd);
                    }

                    foreach (var item in hostContent)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Flush();
                }
            }
        }

        public static void WriteSolutionFile(byte[] hostContent,string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    string content = Encoding.UTF8.GetString(hostContent);
                    sw.Write(content);
                    sw.Flush();
                }
            }
        }

        public static void WriteSolutionFile(string hostContent, string filePath,Encoding encoding)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
            {
                using (StreamWriter sw = new StreamWriter(fs, encoding))
                {
                    sw.Write(hostContent);
                    sw.Flush();
                }
            }
        }

        public static byte[] GetFileBytes(string filePath)
        {
            byte[] hostContent;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                  string content=sr.ReadToEnd();

                  hostContent= Encoding.UTF8.GetBytes(content);
                }
            }

            return hostContent;
        }

        public static byte[] GetStringBytes(string strContent)
        {
            byte[] hostContent = Encoding.UTF8.GetBytes(strContent);
   
            return hostContent;
        }

        public static string GetBytesString(byte[] hostContent)
        {
            string strContent = Encoding.UTF8.GetString(hostContent);

            return strContent;
        }

        public static HostsProcesscer ReadSolutionFile(string filePath)
        {
            byte[] hostContent = GetFileBytes(filePath);
            return GetSolutionFileConten(hostContent);
        }

        public static HostsProcesscer GetSolutionFileConten(byte[] hostsContent)
        {
            return SerializationHelper.RetrieveDeserialize<HostsProcesscer>(hostsContent);            
        }
    }
}

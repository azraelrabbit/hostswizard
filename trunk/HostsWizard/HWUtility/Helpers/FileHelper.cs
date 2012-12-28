using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using HWUtility.Utilit;
using System.Resources;

namespace HWUtility.Helpers
{
    public class FileHelper
    {
        public static List<string> GetHostsContent()
        {
            string[] splitStr = { "\r\n" };
            List<string> headlistconst = Constants.WinHostsHead.Split(splitStr, StringSplitOptions.None).ToList();

            List<string> hostsContentList = new List<string>();

            var hostContent = File.ReadAllLines(Constants.HostsPath,Encoding.Default).ToList();
            int i = 0;
            foreach (var hitem in hostContent)
            {
                if (i < headlistconst.Count && headlistconst[i].Trim() == hitem.Trim())
                {
                }
                else
                {
                    if (!string.IsNullOrEmpty(hitem))
                    {
                        hostsContentList.Add(hitem.Replace("\t", "  "));
                    }
                }
                i++;
            }

            return hostsContentList;
        }

        public static void WriteHosts(List<string> hostContent)
        {
            string[] splitStr = { "\r\n" };
            List<string> headlistconst = Constants.WinHostsHead.Split(splitStr, StringSplitOptions.None).ToList();
            var tmpList = new List<string>();
            tmpList.AddRange(headlistconst);
            tmpList.AddRange(hostContent);

            File.WriteAllLines(Constants.HostsPath,tmpList);
            tmpList.Clear();
        }

        public static void WriteHosts(List<string> hostContent, string filePath)
        {
            string[] splitStr = { "\r\n" };
            List<string> headlistconst = Constants.WinHostsHead.Split(splitStr, StringSplitOptions.None).ToList();

            var tmpList = new List<string>();
            tmpList.AddRange(headlistconst);
            tmpList.AddRange(hostContent);
            File.WriteAllLines(filePath, tmpList);
            tmpList.Clear();
        }

        public static void WriteSolutionFile(byte[] hostContent, string filePath)
        {
            //using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
            //{
            //    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            //    {
            //        // string content = Encoding.UTF8.GetString(hostContent);
            //        sw.BaseStream.Write(hostContent, 0, hostContent.Length);
            //        sw.Flush();
            //    }
            //}

            File.WriteAllBytes(filePath,hostContent);

        }

        public static void WriteDBFile(byte[] filebuffer, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    // string content = Encoding.UTF8.GetString(hostContent);
                    sw.BaseStream.Write(filebuffer, 0, filebuffer.Length);
                    sw.Flush();
                }
            }
        }

        public static void WriteSolutionFile(string hostContent, string filePath, Encoding encoding)
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
                    hostContent = new byte[sr.BaseStream.Length];
                    // string content=sr.ReadToEnd();
                    sr.BaseStream.Read(hostContent, 0, (int)sr.BaseStream.Length);
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

        public static void InitAppDataFile()
        {

            DirectoryInfo di = new DirectoryInfo(Constants.HWUtilitysDataPath);
            if (!di.Exists)
            {
                di.Create();
            }

            FileInfo fi = new FileInfo(Constants.HWUtilitysDataFilePath);
            //MessageBox.Show(Constants.HWUtilitysDataFilePath);
            if (!fi.Exists)
            {
                //FileInfo defaultDb = new FileInfo(Constants.DefaultAppDataFilePath);
                //defaultDb.CopyTo(Constants.HWUtilitysDataFilePath);
                WriteDBFile(HWUitlity.Properties.Resources.hsw, Constants.HWUtilitysDataFilePath);
               
            }

            //MessageBox.Show(Constants.HWUtilitysDataPath);
            //MessageBox.Show(Constants.HWUtilitysDataFilePath);
            //MessageBox.Show(Constants.DefaultAppDataFilePath);
            //MessageBox.Show(Constants.HWUtilitysDataFilePath);
            // MessageBox.Show(Constants.SqliteDBConfig);
        }

        public static void BackupSystemHost()
        {
            DirectoryInfo di = new DirectoryInfo(Constants.HostsBackUpPath);
            if (!di.Exists)
            {
                di.Create();
            }

            string backupFileName = "HostsBackup_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".hbk";

            FileInfo fi = new FileInfo(Constants.HostsPath);

            if (fi.Exists)
            {
                fi.CopyTo(Constants.HostsBackUpPath + "\\" + backupFileName, true);
            }

        }
    }
}

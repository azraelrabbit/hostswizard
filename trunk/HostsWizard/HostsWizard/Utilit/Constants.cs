using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace HostsWizard.Utilit
{
    public class Constants
    {
        public static readonly string AppDataLocalPath = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "\\Local";

        public static readonly string ApplicationName = "HostsWizards";

        public static readonly string HostsPath = (Environment.SystemDirectory + @"\drivers\etc\Hosts");

        public static readonly string HostsBackUpPath = AppDataLocalPath + "\\HostsWizards\\Backup";

        public static readonly string ApplicationStartUpPath = Application.StartupPath;

        public static readonly string DefaultAppDataFilePath = ApplicationStartUpPath + "\\hsw.db";

        public static readonly string HostsWizardsDataPath = AppDataLocalPath + "\\HostsWizards\\Data";

        public static readonly string HostsWizardsDataFilePath = HostsWizardsDataPath + "\\hsw.db";

        public static int StatusBarClearInterval = 8000;

        public static string SqliteDBConfig = "Data Source=" + HostsWizardsDataFilePath + ";Pooling=true;FailIfMissing=false";

        public static readonly string WinHostsHead = "# Copyright (c) 1993-2009 Microsoft Corp.\r\n"
+ "#\r\n"
+ "# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.\r\n"
+ "#\r\n"
+ "# This file contains the mappings of IP addresses to host names. Each\r\n"
+ "# entry should be kept on an individual line. The IP address should\r\n"
+ "# be placed in the first column followed by the corresponding host name.\r\n"
+ "# The IP address and the host name should be separated by at least one\r\n"
+ "# space.\r\n"
+ "#\r\n"
+ "# Additionally, comments (such as these) may be inserted on individual\r\n"
+ "# lines or following the machine name denoted by a '#' symbol.\r\n"
+ "#\r\n"
+ "# For example:\r\n"
+ "#\r\n"
+ "#      102.54.94.97     rhino.acme.com          # source server\r\n"
+ "#       38.25.63.10     x.acme.com              # x client host\r\n"
+ "\r\n"
+ "# localhost name resolution is handled within DNS itself.\r\n"
+ "#	127.0.0.1       localhost\r\n"
+ "#	::1             localhost\r\n";

    }
}

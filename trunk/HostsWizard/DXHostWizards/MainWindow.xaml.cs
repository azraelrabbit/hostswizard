using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Ribbon;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Layout.Core;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Printing;
using System.ComponentModel;
using System.Collections.ObjectModel;
using DevExpress.Xpf.NavBar;
using HWUtility.Helpers;
using HWUtility.Utilit;


namespace DXHostWizards
{
    public partial class MainWindow : DXRibbonWindow
    {
        public MainWindow()
        {

            InitializeComponent();

            //检查sqlite库是否存在,不存在则拷贝自己的,存在则略过
            Task.Factory.StartNew(FileHelper.InitAppDataFile);

            DataContext = new DataSource();
        }

        private void TreeListView_CellValueChanged(object sender, DevExpress.Xpf.Grid.TreeList.TreeListCellValueChangedEventArgs e)
        {
            //通过以下代码验证,当在界面更改列表数据时,数据源同时被改变.//已确认.
            //var tmp = e.Value;
            var srcData = (HostsItem)e.Node.Content;
            if (srcData.Type == EnumItemType.HostItem)
            {
                var id = srcData.ID;
                //var changedStat = srcData.Enable;
                //var changedOldStat = e.OldValue;
                if (srcData.IP.Contains("#"))
                {
                    if (srcData.Enable)
                    {
                        srcData.IP = srcData.IP.Replace("#", string.Empty);
                    }
                }
                else
                {
                    if (!srcData.Enable)
                    {
                        srcData.IP = "#" + srcData.IP;
                    }
                }

                var sourceDt = DataSource.GetItemByID(id);
                var srcStat = sourceDt.Enable;

                //var strMsg = string.Format("当前改变值为:{0},改变之前为:{1}; 数据源当前值为:{2}", changedStat, changedOldStat, srcStat);
                //MessageBox.Show(strMsg);
            }

        }

        private void TreeListView_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //  var tmps = e.OldValue;
        }

        private void btnRefreshDns_ItemClick(object sender, ItemClickEventArgs e)
        {//刷新dns
            Utility.FlushDNS();
            txtLogs.Text += string.Format("{0}  :  DNS缓存已刷新.\r\n", DateTime.Now.ToString("yyyy-MM-dd:HH:mm:ss.fff"));
        }

        private void btnApply_ItemClick(object sender, ItemClickEventArgs e)
        {//应用//保存并刷新flushDNS
            DataSource.SaveToHosts();
            txtLogs.Text += string.Format("{0}  :  Hosts已保存.\r\n", DateTime.Now.ToString("yyyy-MM-dd:HH:mm:ss.fff"));
            Utility.FlushDNS();
            txtLogs.Text += string.Format("{0}  :  DNS缓存已刷新.\r\n", DateTime.Now.ToString("yyyy-MM-dd:HH:mm:ss.fff"));
        }

        private void btnOpenSyshost_ItemClick(object sender, ItemClickEventArgs e)
        {//文本方式打开系统Hosts文件
            var ret = ProcessHelper.OpenHostByEmeditorfix();
            txtLogs.Text += string.Format("{0}  :  {1}\r\n", DateTime.Now.ToString("yyyy-MM-dd:HH:mm:ss.fff"), ret.Item2);
        }


        private void FrameworkContentElement_OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var tmp = e.OldValue;
        }

        private void btnLoadSyshost_ItemClick(object sender, ItemClickEventArgs e)
        {//reload hostfiles
            DataContext = new DataSource();
            txtLogs.Text += string.Format("{0}  :  重新加载系统Hosts文件.\r\n", DateTime.Now.ToString("yyyy-MM-dd:HH:mm:ss.fff"));
        }
    }



}

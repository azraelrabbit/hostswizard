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

    }

    public class TestData
    {
        public string Text { get; set; }
        public int Number { get; set; }
    }

    public class TestDataViewModel : INotifyPropertyChanged
    {
        TestData data;
        public TestDataViewModel()
        {
            data = new TestData() { Text = string.Empty, Number = 0 };
        }
        public string Text
        {
            get { return Data.Text; }
            set
            {
                if (Data.Text == value)
                    return;
                Data.Text = value;
                RaisePropertyChanged("Text");
            }
        }
        public int Number
        {
            get { return Data.Number; }
            set
            {
                if (Data.Number == value)
                    return;
                Data.Number = value;
                RaisePropertyChanged("Number");
            }
        }
        protected TestData Data
        {
            get { return data; }
        }
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
        protected void RaisePropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }

    public class DataSource
    {
        ObservableCollection<HostsItem> source;

        HostsProcesscer hosts=new HostsProcesscer(true);

        public DataSource()
        {
            source = CreateDataSource();
        }
        protected ObservableCollection<HostsItem> CreateDataSource()
        {
            ObservableCollection<HostsItem> res = new ObservableCollection<HostsItem>();
           HostsProcesscer host=new HostsProcesscer(true);
             
            foreach (var item in host.fullContent)
            {
                res.Add(item);
            }
            return res;
        }
        public ObservableCollection<HostsItem> Data { get { return source; } }
    }
}

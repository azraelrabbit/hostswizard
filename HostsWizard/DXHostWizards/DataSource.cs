using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using HWUtility.Utilit;
using HWUtility.Helpers;

namespace DXHostWizards
{
    public class DataSource
    {
        static ObservableCollection<HostsItem> source;

        static HostsProcesscer host = new HostsProcesscer(true);

        public DataSource()
        {
            source = CreateDataSource();
        
        }
        protected ObservableCollection<HostsItem> CreateDataSource()
        {
            ObservableCollection<HostsItem> res = new ObservableCollection<HostsItem>();
            host = new HostsProcesscer(true);

            foreach (var item in host.fullContent)
            {
                res.Add(item);
            }
            
            return res;
        }

        public ObservableCollection<HostsItem> Data { get { return source; }
            set { source = value; }

        }

        public static HostsItem GetItemByID(Guid id)
        {
            if (host != null)
            {
                return host.fullContent.FirstOrDefault(p => p.ID.Equals(id));
            }
            return null;
        }

        public static void SaveToHosts()
        {
            var hostList = host.ToStringList(host.fullContent);
            FileHelper.WriteHosts(hostList);
        }
    }
}

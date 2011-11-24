using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HostsWizard.Helpers;
using HostsWizard.Utilit;

namespace HostsWizard.Utilit
{
    public class HostsProcesscer
    {
        // public Dictionary<string, string> hostHeader = new Dictionary<string, string>();

        //public List<string> hostHead = new List<string>();

        //public Dictionary<string, Dictionary<string, string>> hostBody = new Dictionary<string, Dictionary<string, string>>();

        public List<HostsItem> originList = new List<HostsItem>();

        public Dictionary<string, List<HostsItem>> managedList = new Dictionary<string, List<HostsItem>>();

        public HostsProcesscer(bool group)
        {
            List<string> temp = FileHelper.GetHostsContent();

            originList = ProcessOrigin(temp);
            managedList = ProcessBody(temp);

        }

        private List<HostsItem> ProcessOrigin(List<string> itemlist)
        {
            List<HostsItem> temp = new List<HostsItem>();
            List<string> waitRv = new List<string>();
            
            foreach (var item in itemlist)
            {
                if (item.Length > 3 && item.Substring(0, 3) == "###")
                {
                    break;
                }
                else
                {
                    var arry = item.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    HostsItem hostitem = new HostsItem();
                    hostitem.IP = arry[0];
                    if (arry.Length > 1)
                    {
                        hostitem.Domain = arry[1];
                        hostitem.Type = EnumItemType.Comment;
                    }
                    else
                    {
                        hostitem.Type = EnumItemType.HostItem;
                    }

                    hostitem.Group = "源hosts配置项";
                    hostitem.Enable = (hostitem.IP.IndexOf("#") < 0);
                    waitRv.Add(item);
                    temp.Add(hostitem);
                   // itemlist.Remove(item);
                }
            }

            foreach (var t in waitRv)
            {
                itemlist.Remove(t);
            }

            return temp;
        }

        private Dictionary<string, List<HostsItem>> ProcessBody(List<string> itemlist)
        {
            Dictionary<string, List<HostsItem>> temp=new Dictionary<string,List<HostsItem>>();
            List<HostsItem> gpList=null;
            string currentGroupName = string.Empty;
            foreach (var item in itemlist)
            {
                if (item.Length > 3 && item.Substring(0, 3) == "###")
                {
                    if (gpList != null)
                    {
                        temp.Add(currentGroupName, gpList.ToList());
                    }
                    
                    gpList = new List<HostsItem>();
                    currentGroupName = item;
                }
                else
                {
                    var arry = item.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    HostsItem hostitem = new HostsItem();
                    hostitem.IP = arry[0];
                    if (arry.Length > 1)
                    {
                        hostitem.Domain = arry[1];
                        hostitem.Type = EnumItemType.Comment;
                    }
                    else
                    {
                        hostitem.Type = EnumItemType.HostItem;
                    }

                    hostitem.Group = currentGroupName;
                    hostitem.Enable = (hostitem.IP.IndexOf("#") < 0);
                    gpList.Add(hostitem);
                }
            }

            return temp;
        }
    }
}

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

        public List<HostsItem> bodyList = new List<HostsItem>();

        public List<HostsItem> fullContent = new List<HostsItem>();

        string SolutionName;
        Guid SolutionID;

        public HostsProcesscer(bool group)
        {
            // 默认方案名称
            SolutionName = "System";
            //默认方案ID
            SolutionID = Guid.Empty;

            List<string> temp = FileHelper.GetHostsContent();

            originList = ProcessOrigin(temp);
            //managedList = ProcessBody(temp);

            bodyList = ProcessBody2(temp);

            fullContent.AddRange(originList);
            fullContent.AddRange(bodyList);           

        }

        private List<HostsItem> ProcessOrigin(List<string> itemlist)
        {
            List<HostsItem> temp = new List<HostsItem>();
            List<string> waitRv = new List<string>();

            HostsItem groupParent = new HostsItem();
            groupParent.ID = Guid.NewGuid();
            groupParent.IP = "####源hosts配置项";
            groupParent.Type = EnumItemType.GroupTag;
            groupParent.ParentID = Guid.Empty;
            temp.Add(groupParent);

            foreach (var item in itemlist)
            {
                if (item.Length > 4 && item.Substring(0, 4) == "####")
                {
                    groupParent.ID = Guid.NewGuid();
                    groupParent.IP = item;
                    groupParent.Type = EnumItemType.GroupTag;                   
                }
                else if (item.Length>3 && item.Substring(0,3)=="###")
                {
                    break;
                }
                else if( item.Length>3 && item.Substring(0,3)=="#*#")
                {// 方案名称
                    if (!string.IsNullOrEmpty(item.Substring(3)))
                    {
                        SolutionName = item.Substring(3);
                    }
                }
                else if (item.Length > 3 && item.Substring(0, 3) == "##*")
                {// 方案ID
                    if (!string.IsNullOrEmpty(item.Substring(3)))
                    {
                        var sid = item.Substring(3);
                        var ssuid = new Guid();
                        if(Guid.TryParse(sid,out ssuid))
                        {
                            SolutionID = ssuid;
                        }
                    }
                }
                else
                {
                    var arry = item.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    HostsItem hostitem = new HostsItem();
                    hostitem.ID = Guid.NewGuid();
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

                    hostitem.Group = groupParent.IP;
                    hostitem.ParentID = groupParent.ID;
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

        private List<HostsItem> ProcessBody2(List<string> itemlist)
        {
            List<HostsItem> temp = new  List<HostsItem>();      
            string currentGroupName = string.Empty;

            Guid currentGroupID = new Guid();
            
            foreach (var item in itemlist)
            {
                
                if (item.Length > 3 && item.Substring(0, 3) == "###")
                {
                    if (!temp.Exists(p => p.IP == item.Trim()))
                    {
                        HostsItem gp = new HostsItem();
                        
                        gp.ID = Guid.NewGuid();
                        gp.IP = item.ToString();
                        gp.ParentID = Guid.Empty;

                        currentGroupID = gp.ID;
                        temp.Add(gp);
                    }
                }
                else
                {
                    var arry = item.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    HostsItem hostitem = new HostsItem();
                    hostitem.ID = Guid.NewGuid();
                    hostitem.ParentID = currentGroupID;
                    
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
                    temp.Add(hostitem);
                }
            }

            return temp;
        }
    }
}

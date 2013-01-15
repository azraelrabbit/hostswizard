using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HWUtility.Helpers;
using HWUtility.Utilit;

namespace HWUtility.Utilit
{
    [Serializable]
    public class HostsProcesscer
    {
        // public Dictionary<string, string> hostHeader = new Dictionary<string, string>();

        //public List<string> hostHead = new List<string>();

        //public Dictionary<string, Dictionary<string, string>> hostBody = new Dictionary<string, Dictionary<string, string>>();

        public List<HostsItem> originList = new List<HostsItem>();

        public Dictionary<string, List<HostsItem>> managedList = new Dictionary<string, List<HostsItem>>();

        public List<HostsItem> bodyList = new List<HostsItem>();

        public List<HostsItem> fullContent = new List<HostsItem>();

        //方案名称
        public string SolutionName
        {
            get;
            set;
        }

        //方案ID
        public Guid SolutionID
        {
            get;
            set;
        }

        public HostsProcesscer()
        {

        }

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
            groupParent.Expended = false;
            temp.Add(groupParent);

            foreach (var item in itemlist)
            {
                if (item.Length > 4 && item.Substring(0, 4) == "####")
                {
                    var arry = item.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                    string groupName = arry[0].Trim();
                    Guid oriID = Guid.NewGuid();
                    if (arry.Length > 1)
                    {
                        Guid.TryParse(arry[1].Trim(), out oriID);
                    }
                    bool expend = false;
                    if (arry.Length > 3)
                    {
                        bool.TryParse(arry[3].Trim(), out expend);
                    }
                    groupParent.Expended = expend;
                    groupParent.ID = oriID;
                    groupParent.IP = groupName;
                    groupParent.Type = EnumItemType.GroupTag;
                }
                else if (item.Length > 3 && item.Substring(0, 3) == "###")
                {
                    break;
                }
                else if (item.Length > 3 && item.Substring(0, 3) == "#*#")
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
                        if (Guid.TryParse(sid, out ssuid))
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
                        hostitem.Type = EnumItemType.HostItem;
                    }
                    else
                    {
                        hostitem.Type = EnumItemType.Comment;
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
            Dictionary<string, List<HostsItem>> temp = new Dictionary<string, List<HostsItem>>();
            List<HostsItem> gpList = null;
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
                else if (item.Length > 3 && item.Substring(0, 3) == "#*#")
                {//solution name
                }
                else if (item.Length > 3 && item.Substring(0, 3) == "##*")
                {//solution id

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
            List<HostsItem> temp = new List<HostsItem>();
            string currentGroupName = string.Empty;

            Guid currentGroupID = new Guid();

            foreach (var item in itemlist)
            {
                if (item.Length > 4 && item.Substring(0, 4) == "####")
                {
                }
                else if (item.Length > 3 && item.Substring(0, 3) == "###")
                {
                    if (!temp.Exists(p => p.IP == item.Trim()))
                    {
                        HostsItem gp = new HostsItem();
                        var arry = item.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                        string groupName = arry[0].Trim();
                        Guid grpID = Guid.NewGuid();
                        if (arry.Length > 1)
                        {
                            Guid.TryParse(arry[1].Trim(), out grpID);
                        }

                        bool expend = false;

                        if (arry.Length > 3)
                        {
                            bool.TryParse(arry[3].Trim(), out expend);
                        }

                        gp.ID = grpID;//组ID
                        gp.IP = groupName;//组名
                        gp.ParentID = Guid.Empty;
                        gp.Type = EnumItemType.GroupTag;
                        gp.Expended = expend;
                        currentGroupID = gp.ID;
                        currentGroupName = groupName;
                        temp.Add(gp);
                    }
                }
                else if (item.Length > 3 && item.Substring(0, 3) == "#*#")
                {//solution name
                }
                else if (item.Length > 3 && item.Substring(0, 3) == "##*")
                {//solution id

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
                        hostitem.Type = EnumItemType.HostItem;
                    }
                    else
                    {
                        hostitem.Type = EnumItemType.Comment;
                    }

                    hostitem.Group = currentGroupName;
                    hostitem.Enable = (hostitem.IP.IndexOf("#") < 0);
                    temp.Add(hostitem);
                }
            }

            return temp;
        }

        public List<string> ToStringList()
        {
            List<string> hostlist = new List<string>();

            // 保存solution 信息

            hostlist.Add(string.Empty);
            hostlist.Add("#*#" + SolutionName);
            hostlist.Add("##*" + SolutionID.ToString());
            hostlist.Add(string.Empty);

            var grouplist = fullContent.Where(p => p.Type == EnumItemType.GroupTag);

            foreach (var group in grouplist)
            {
                var groupstring = string.Empty;
                groupstring += group.IP + "  |" + group.ID.ToString() + "  |" + group.Domain + "  |" + group.Expended.ToString();
                hostlist.Add(groupstring);
                hostlist.Add(string.Empty);

                //查找分组下所有的item
                var itemList = fullContent.Where(p => p.ParentID == group.ID);
                foreach (var item in itemList)
                {
                    var itemstring = string.Empty;
                    if (item.Type == EnumItemType.HostItem)
                    {
                        if (item.Enable)
                        {
                            if (item.IP.Contains("#"))
                            {
                                item.IP = item.IP.Replace("#", string.Empty);
                            }
                        }
                        else
                        {
                            if (!item.IP.Contains("#"))
                            {
                                item.IP = "#" + item.IP;
                            }
                        }
                    }

                    itemstring = item.IP + "  " + item.Domain;
                    hostlist.Add(itemstring);
                }
                hostlist.Add(string.Empty);
            }
            return hostlist;
        }

        public List<string> ToStringList(List<HostsItem> tmpList )
        {
            List<string> hostlist = new List<string>();

            // 保存solution 信息

            hostlist.Add(string.Empty);
            hostlist.Add("#*#" + SolutionName);
            hostlist.Add("##*" + SolutionID.ToString());
            hostlist.Add(string.Empty);

            var grouplist = tmpList.Where(p => p.Type == EnumItemType.GroupTag);

            foreach (var group in grouplist)
            {
                var groupstring = string.Empty;
                groupstring += group.IP + "  |" + group.ID.ToString() + "  |" + group.Domain + "  |" + group.Expended.ToString();
                hostlist.Add(groupstring);
                hostlist.Add(string.Empty);

                //查找分组下所有的item
                var itemList = tmpList.Where(p => p.ParentID == group.ID);
                foreach (var item in itemList)
                {
                    var itemstring = string.Empty;
                    if (item.Type == EnumItemType.HostItem)
                    {
                        if (item.Enable)
                        {
                            if (item.IP.Contains("#"))
                            {
                                item.IP = item.IP.Replace("#", string.Empty);
                            }
                        }
                        else
                        {
                            if (!item.IP.Contains("#"))
                            {
                                item.IP = "#" + item.IP;
                            }
                        }
                    }

                    itemstring = item.IP + "  " + item.Domain;
                    hostlist.Add(itemstring);
                }
                hostlist.Add(string.Empty);
            }
            return hostlist;
        }
    }
}

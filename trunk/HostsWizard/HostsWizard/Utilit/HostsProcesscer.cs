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

        public List<string> hostHead = new List<string>();

        public Dictionary<string, Dictionary<string, string>> hostBody = new Dictionary<string, Dictionary<string, string>>();


        public HostsProcesscer()
        {

            List<string> temp = FileHelper.GetHostsContent();
            string currentGroupName = "system";
            foreach (var item in temp)
            {
                if (item.Length > 3 && item.Substring(0, 3) == "###")
                {
                    currentGroupName = item;
                }
                else
                {

                    if (currentGroupName == "system")
                    {
                        // hostHeader.Add("system", item);
                        hostHead.Add(item);
                    }
                    else
                    {

                        Dictionary<string, string> currentGroup = new Dictionary<string, string>();
                        if (!hostBody.Keys.Contains(currentGroupName))
                        {
                            currentGroup = new Dictionary<string, string>();
                            hostBody.Add(currentGroupName, currentGroup);
                        }
                        else
                        {
                            currentGroup = hostBody[currentGroupName];
                        }

                        string ip = string.Empty;
                        string host = string.Empty;

                        if (item.Substring(0, 1) == "#")
                        {
                            // 禁用
                            ip = item.Substring(2).Split('\t')[0];
                            host = item.Substring(2).Split('\t')[1];
                        }
                        else
                        {
                            ip = item.Split('\t')[0];
                            host = item.Split('\t')[1];
                        }

                        currentGroup.Add(host, ip);

                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Web;
using HWUtility.Utilit;

namespace HWUtility.Helpers
{
    public class RequestHelpers
    {

        //public static void GetNewHosts(frmMain form, string googleGroupName, Guid googleGroupID)
        //{
        //    var url = AppConfigHelper.GetAppConfig("GoogleHostsSource");
        //    var startup = AppConfigHelper.GetAppConfig("HostsStartUpString");

        //    HttpWebResponse response = SendRequest(url);

        //    var buf = new byte[response.ContentLength];

        //    var stream = response.GetResponseStream();
        //    int offset = 0;

        //    while (offset < (int)response.ContentLength)
        //    {
        //        offset += stream.Read(buf, offset, (int)response.ContentLength - offset);
        //    }
        //    string encodeName = string.IsNullOrEmpty(response.ContentEncoding.Trim()) ? "UTF-8" : response.ContentEncoding;
        //    string content = Encoding.GetEncoding(encodeName).GetString(buf);
        //    content = content.Substring(content.IndexOf(startup)).Replace("\n", "\r\n").Replace("\r\r", "\r").Replace("\t", "    ");

        //    var hostItemText = content;
        //    string[] splitStr = { "\r\n" };
        //    List<string> contentList = hostItemText.Split(splitStr, StringSplitOptions.None).ToList();
        //    var hostItems = ProcessBody(contentList, googleGroupID, googleGroupName);
        //    form.AddItems(hostItems);
        //}

        //public static void GetNewHosts(frmMainR form, string googleGroupName, Guid googleGroupID)
        //{
        //    var url = AppConfigHelper.GetAppConfig("GoogleHostsSource");
        //    var startup = AppConfigHelper.GetAppConfig("HostsStartUpString");

        //    HttpWebResponse response = SendRequest(url);

        //    var buf = new byte[response.ContentLength];

        //    var stream = response.GetResponseStream();
        //    int offset = 0;

        //    while (offset < (int)response.ContentLength)
        //    {
        //        offset += stream.Read(buf, offset, (int)response.ContentLength - offset);
        //    }
        //    string encodeName = string.IsNullOrEmpty(response.ContentEncoding.Trim()) ? "UTF-8" : response.ContentEncoding;
        //    string content = Encoding.GetEncoding(encodeName).GetString(buf);
        //    content = content.Substring(content.IndexOf(startup)).Replace("\n", "\r\n").Replace("\r\r", "\r").Replace("\t", "    ");

        //    var hostItemText = content;
        //    string[] splitStr = { "\r\n" };
        //    List<string> contentList = hostItemText.Split(splitStr, StringSplitOptions.None).ToList();
        //    var hostItems = ProcessBody(contentList, googleGroupID, googleGroupName);
        //    form.AddItems(hostItems);
        //}


        private static List<HostsItem> ProcessBody(List<string> itemlist, Guid groupID, string groupName)
        {
            List<HostsItem> temp = new List<HostsItem>();
            string currentGroupName = groupName;

            Guid currentGroupID = groupID;

            if (string.IsNullOrEmpty(groupName.Trim()))
            {
                HostsItem antiGfw = new HostsItem();
                antiGfw.ID = Guid.NewGuid();//anti_gfw
                antiGfw.IP = "###-Anti_GFW";
                antiGfw.Type = EnumItemType.GroupTag;
                antiGfw.Expended = false;
                temp.Add(antiGfw);
                currentGroupID = antiGfw.ID;
                currentGroupName = antiGfw.IP;
            }
            foreach (var item in itemlist)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    if (item.Trim().Substring(0, 1) == "#")
                    {

                    }
                    else if (!string.IsNullOrEmpty(item))
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

            }

            return temp;
        }

        private static HttpWebResponse SendRequest(string url)
        {

            var httpMethod = "GET";
            HttpWebRequest newRequest = CreateNewRequest(url, "", httpMethod);

            if (httpMethod.Equals("POST"))
            {
                //处理所有post过来的数据并转发
                ProcessPostData(null, newRequest);
            }
            else if (httpMethod.Equals("GET"))
            {
                // newRequest=
            }

            //取得请求的返回值,并写入到原请求的响应流中
            // newRequest.ContentType = "text/plain";
            HttpWebResponse newResponse = (HttpWebResponse)newRequest.GetResponse();

            return newResponse;
        }
        private static HttpWebRequest CreateNewRequest(string targetUrlHost, string queryString, string httpMethods)
        {
            HttpWebRequest newRequest = (HttpWebRequest)HttpWebRequest.Create(targetUrlHost + queryString); // .Create(targetUrlHost);
            newRequest.Method = httpMethods;// "POST";
            newRequest.KeepAlive = true;
            newRequest.ReadWriteTimeout = 3600 * 1000;
            newRequest.Timeout = 3600 * 1000;

            //newRequest.Timeout = 300 * 1000;//设置请求超时时间
            //newRequest.ReadWriteTimeout = 3000 * 1000;
            // newRequest.ContentType = "application/x-www-form-urlencoded";

            // newRequest.ServicePoint.Expect100Continue = false;
            return newRequest;
        }

        private static void ProcessPostData(List<KeyValuePair<string, string>> postParams, HttpWebRequest newRequest)
        {
            //取所有postdata,并构造新请求需要的post data
            StringBuilder sb = new StringBuilder();
            sb.Append("_v=1");

            foreach (var item in postParams)
            {
                sb.Append(string.Format("&{0}={1}", item.Key, item.Value));
            }

            var data = Encoding.UTF8.GetBytes(sb.ToString());

            newRequest.ContentLength = data.Length;

            //写入postdata            
            using (var sw = newRequest.GetRequestStream())
            {
                sw.Write(data, 0, data.Length);
            }


        }

    }
}

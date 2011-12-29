using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using HostsWizard.Helpers;
using HostsWizard.Utilit;
using DAL;
using System.Data;

namespace HostsWizard.DL
{
    public class SolutionDL
    {
        public int AddNewSolution(HostsProcesscer host)
        {
            byte[] hostsContent = SerializationHelper.GetBinaryFormatSerialize(host);
                        

            List<SQLiteParameter> paramList=new List<SQLiteParameter>();

            SQLiteParameter paramId = new SQLiteParameter("@solutionid", System.Data.DbType.Guid);
            paramId.Value = host.SolutionID;

            SQLiteParameter paramName = new SQLiteParameter("@solutionname", System.Data.DbType.String, 50);
            paramName.Value = host.SolutionName;

            SQLiteParameter paramBody = new SQLiteParameter("@solutionbody", System.Data.DbType.Object);
            paramBody.Value = hostsContent;

            paramList.Add(paramId);
            paramList.Add(paramName);
            paramList.Add(paramBody);

            string sql = "insert into Solution values(@solutionid,@solutionname,@solutionbody)";

            int ret=SqliteHelper2.ExecuteNonQuery(sql, paramList.ToArray());
            return ret;
        }

        public int UpdateSolution(HostsProcesscer host)
        {
            byte[] hostsContent = SerializationHelper.GetBinaryFormatSerialize(host);

            var strhostContent = FileHelper.GetBytesString(hostsContent);

            List<SQLiteParameter> paramList = new List<SQLiteParameter>();

            SQLiteParameter paramId = new SQLiteParameter("@solutionid", System.Data.DbType.Guid);
            paramId.Value = host.SolutionID;

            SQLiteParameter paramName = new SQLiteParameter("@solutionname", System.Data.DbType.String, 50);
            paramName.Value = host.SolutionName;

            SQLiteParameter paramBody = new SQLiteParameter("@solutionbody", System.Data.DbType.Object);
            paramBody.Value = strhostContent;

            paramList.Add(paramId);
            paramList.Add(paramName);
            paramList.Add(paramBody);

            string sql = "update Solution set [SolutionName]='@solutionname',[SolutionBody]=@solutionbody where [SolutionID]=@solutionid ";

            int ret = SqliteHelper2.ExecuteNonQuery(sql, paramList.ToArray());
            return ret;
        }

        public bool SolutionExist(Guid solutionID)
        {
            List<SQLiteParameter> paramList = new List<SQLiteParameter>();

            SQLiteParameter paramId = new SQLiteParameter("@solutionid", System.Data.DbType.Guid);
            paramId.Value = solutionID;

            paramList.Add(paramId);

            string sql = "select count(*) from Solution where [SolutionID]=@solutionid ";

            var obj = SqliteHelper2.ExecuteScalar(sql, paramList.ToArray());

            int ret = 0;
            int.TryParse(obj.ToString(), out ret);
            if (ret > 0)
            {
                return true;
            }
            return false;
        }

        public int DeleteSolution(Guid solutionID)
        {
            List<SQLiteParameter> paramList = new List<SQLiteParameter>();

            SQLiteParameter paramId = new SQLiteParameter("@solutionid", System.Data.DbType.Guid);
            paramId.Value = solutionID;

            paramList.Add(paramId);

            string sql = "delete Solution where [SolutionID]=@solutionid ";

            return SqliteHelper2.ExecuteNonQuery(sql, paramList.ToArray());
        }

        public List<HostsProcesscer> GetSolutionAll()
        {
            string sql = "select * from solution";

            List<HostsProcesscer> hostlist = new List<HostsProcesscer>();

            var datalist = SqliteHelper2.ExecuteDataSet(sql, null);
            
            if (datalist.Tables.Count > 0 && datalist.Tables[0]!=null)
            {
                foreach (DataRow dr in datalist.Tables[0].Rows)
                {
                    HostsProcesscer host = new HostsProcesscer();

                    var hostcontent = (byte[])dr["SolutionBody"];

                    host = FileHelper.GetSolutionFileConten(hostcontent);
                    hostlist.Add(host);
                }
            }

            return hostlist;
        }

        public HostsProcesscer GetSolutionByID(Guid solutionID)
        {
            string sql = "select [SolutionBody] from solution where [SolutionID]=@solutionid";
            List<SQLiteParameter> paramList = new List<SQLiteParameter>();

            SQLiteParameter paramId = new SQLiteParameter("@solutionid", System.Data.DbType.Guid);
            paramId.Value = solutionID;

            paramList.Add(paramId);

            var data = SqliteHelper2.ExecuteScalar(sql, paramList.ToArray());
            if (data!=null)
            {
                HostsProcesscer host = new HostsProcesscer();
                var hostcontent = (byte[])data;

                host = FileHelper.GetSolutionFileConten(hostcontent);
                return host;
            }

            return null;
        }
    }
}

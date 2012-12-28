using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using Community.CsharpSqlite;
using Community.CsharpSqlite.SQLiteClient;


using HWUtility.Utilit;

namespace HWUtility.Helpers
{
    public class SqliteHelper2
    {
        private static string password = "";  //请修改***为实际密码

        private static string dbFilePath = Constants.HWUtilitysDataFilePath;  //请修改***为实际Sqlite数据库名
        private static string connectString = string.Format(@"Data Source={0};Pooling=true;FailIfMissing=false;Version=3", dbFilePath);
        private static SqliteConnection myConnect = new SqliteConnection();

        /// <summary>
        /// 取当前Sqlite连接
        /// </summary>
        /// <returns>当前Sqlite连接</returns>
        public static SqliteConnection GetConnection()
        {
            return myConnect;
            
        }

        /// <summary>
        /// 执行SQL语句,返回受影响的行数
        /// </summary>
        /// <param name="commandString">SQL语句</param>
        /// <param name="parameters">SQL语句参数</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string commandString, params SqliteParameter[] parameters)
        {
            int result = 0;
            using (SqliteCommand command = new SqliteCommand())
            {
                PrepareCommand(command, null, commandString, parameters);
                result = command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            return result;
        }

        /// <summary>
        /// 执行带事务的SQL语句,返回受影响的行数
        /// </summary>
        /// <param name="transaction">SQL事务</param>
        /// <param name="commandString">SQL语句</param>
        /// <param name="parameters">SQL语句参数</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(SqliteTransaction transaction, string commandString,
            params SqliteParameter[] parameters)
        {
            int result = 0;
            using (SqliteCommand command = new SqliteCommand())
            {
                PrepareCommand(command, transaction, commandString, parameters);
                result = command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            return result;
        }

        /// <summary>
        /// 执行查询,并返回结果集的第一行第一列的值,忽略其它所有的行和列
        /// </summary>
        /// <param name="commandString">SQL语句</param>
        /// <param name="parameters">SQL语句参数</param>
        /// <returns>第一行第一列的值</returns>
        public static object ExecuteScalar(string commandString, params SqliteParameter[] parameters)
        {
            object result;
            using (SqliteCommand command = new SqliteCommand())
            {
                PrepareCommand(command, null, commandString, parameters);
                result = command.ExecuteScalar();
            }
            return result;
        }

        /// <summary>
        /// 执行SQL语句,返回结果集的DataReader
        /// </summary>
        /// <param name="commandString">SQL语句</param>
        /// <param name="parameters">SQL语句参数</param>
        /// <returns>结果集的DataReader</returns>
        public static SqliteDataReader ExecuteReader(string commandString, params SqliteParameter[] parameters)
        {
            SqliteCommand command = new SqliteCommand();
            try
            {
                PrepareCommand(command, null, commandString, parameters);
                SqliteDataReader reader = (SqliteDataReader)command.ExecuteReader(CommandBehavior.CloseConnection);
                command.Parameters.Clear();
                return reader;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 执行SQL语句,返回结果集的DataReader
        /// </summary>
        /// <param name="commandString">SQL语句</param>
        /// <param name="parameters">SQL语句参数</param>
        /// <returns>结果集的DataReader</returns>
        public static DataSet ExecuteDataSet(string commandString, params SqliteParameter[] parameters)
        {
            DataSet ds = new DataSet();
            SqliteCommand command = new SqliteCommand();
            try
            {
                PrepareCommand(command, null, commandString, parameters);
                var adapter = new SqliteDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                return ds;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 预处理Command对象,数据库链接,事务,需要执行的对象,参数等的初始化
        /// </summary>
        /// <param name="command">Command对象</param>
        /// <param name="transaction">transaction对象</param>
        /// <param name="commandString">SQL语句</param>
        /// <param name="parameters">SQL语句参数</param>
        private static void PrepareCommand(SqliteCommand command, SqliteTransaction transaction,
            string commandString, params SqliteParameter[] parameters)
        {
            if (myConnect.State != ConnectionState.Open)
            {
                myConnect.ConnectionString = connectString;
                myConnect.Open();
            }

            command.Connection = myConnect;
            command.CommandText = commandString;

            if (transaction != null)
                command.Transaction = transaction;
            if (parameters != null && parameters.Length > 0)
            {
                command.Parameters.AddRange(parameters);
            }
        }
    }
}

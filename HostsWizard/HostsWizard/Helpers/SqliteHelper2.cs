using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using HostsWizard.Utilit;

namespace HostsWizard.Helpers
{
    public class SqliteHelper2
    {
        private static string password = "";  //请修改***为实际密码

        private static string dbFilePath = Constants.HostsWizardsDataFilePath;  //请修改***为实际SQLite数据库名
        private static string connectString = string.Format(@"Data Source={0};Pooling=true;FailIfMissing=false;Version=3", dbFilePath);
        private static SQLiteConnection myConnect = new SQLiteConnection();

        /// <summary>
        /// 取当前SQLite连接
        /// </summary>
        /// <returns>当前SQLite连接</returns>
        public static SQLiteConnection GetConnection()
        {
            return myConnect;
            
        }

        /// <summary>
        /// 执行SQL语句,返回受影响的行数
        /// </summary>
        /// <param name="commandString">SQL语句</param>
        /// <param name="parameters">SQL语句参数</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string commandString, params SQLiteParameter[] parameters)
        {
            int result = 0;
            using (SQLiteCommand command = new SQLiteCommand())
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
        public static int ExecuteNonQuery(SQLiteTransaction transaction, string commandString,
            params SQLiteParameter[] parameters)
        {
            int result = 0;
            using (SQLiteCommand command = new SQLiteCommand())
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
        public static object ExecuteScalar(string commandString, params SQLiteParameter[] parameters)
        {
            object result;
            using (SQLiteCommand command = new SQLiteCommand())
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
        public static SQLiteDataReader ExecuteReader(string commandString, params SQLiteParameter[] parameters)
        {
            SQLiteCommand command = new SQLiteCommand();
            try
            {
                PrepareCommand(command, null, commandString, parameters);
                SQLiteDataReader reader = (SQLiteDataReader)command.ExecuteReader(CommandBehavior.CloseConnection);
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
        public static DataSet ExecuteDataSet(string commandString, params SQLiteParameter[] parameters)
        {
            DataSet ds = new DataSet();
            SQLiteCommand command = new SQLiteCommand();
            try
            {
                PrepareCommand(command, null, commandString, parameters);
                var adapter = new SQLiteDataAdapter();
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
        private static void PrepareCommand(SQLiteCommand command, SQLiteTransaction transaction,
            string commandString, params SQLiteParameter[] parameters)
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

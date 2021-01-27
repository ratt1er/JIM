using System;   

using System.Collections;   

using System.Collections.Specialized;   

using System.Data;   

using MySql.Data.MySqlClient;   

using System.Configuration;   

using System.Data.Common;   

using System.Collections.Generic;   

using System.Text.RegularExpressions;

namespace DataTools
{

     class MySQLHelperClass
    {

        public static string connectionString;
        //数据库连接字符串(web.config来配置)，可以动态更改connectionString支持多数据库.   

        // public static string connectionString = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;   

        #region ExecuteNonQuery

        //执行SQL语句，返回影响的记录数   

        /// <summary>   

        /// 执行SQL语句，返回影响的记录数   

        /// </summary>   

        /// <param name="SQLString">SQL语句</param>   

        /// <returns>影响的记录数</returns>   

        public static reMsg ExecuteNonQuery(string SQLString)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand(SQLString, connection))
                {

                    try
                    {

                        connection.Open();

                        int rows = cmd.ExecuteNonQuery();

                        return new reMsg(rows);

                    }

                    catch (MySql.Data.MySqlClient.MySqlException e)
                    {

                        connection.Close();
                        return new reMsg("error", e.Message);

                    }

                }

            }

        }
        #endregion
        #region ExecuteNoQueryTran
        //执行多条SQL语句，实现数据库事务。   

        /// <summary>   

        /// 执行多条SQL语句，实现数据库事务。   

        /// </summary>   

        /// <param name="SQLStringList">多条SQL语句</param>   

        public static reMsg ExecuteNoQueryTran(List<String> SQLStringList)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

                conn.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                MySqlTransaction tx = conn.BeginTransaction();

                cmd.Transaction = tx;

                try
                {

                    for (int n = 0; n < SQLStringList.Count; n++)
                    {

                        string strsql = SQLStringList[n];

                        if (strsql.Trim().Length > 1)
                        {

                            cmd.CommandText = strsql;

                            PrepareCommand(cmd, conn, tx, strsql, null);

                            cmd.ExecuteNonQuery();

                        }

                    }

                    cmd.ExecuteNonQuery();

                    tx.Commit();

                    return new reMsg("success");

                }

                catch (Exception e)
                {

                    tx.Rollback();

                    return new reMsg("error", e.ToString());

                }

            }

        }

        #endregion
        #region ExecuteScalar

        /// <summary>   

        /// 执行一条计算查询结果语句返回查询结果（object）。   

        /// </summary>   

        /// <param name="SQLString">计算查询结果语句</param>   

        /// <returns>查询结果（object）</returns>   

        public static reMsg ExecuteScalar(string SQLString)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand(SQLString, connection))
                {

                    try
                    {

                        connection.Open();

                        object obj = cmd.ExecuteScalar();

                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {

                            return null;

                        }

                        else
                        {

                            return new reMsg (obj);

                        }

                    }

                    catch (MySql.Data.MySqlClient.MySqlException e)
                    {

                        connection.Close();

                        return new reMsg("error", e.Message);

                    }

                }

            }

        }
        #endregion
        #region ExecuteReader

        /// <summary>   

        /// 执行查询语句，返回MySqlDataReader ( 注意：调用该方法后，一定要对MySqlDataReader进行Close )   

        /// </summary>   

        /// <param name="strSQL">查询语句</param>   

        /// <returns>MySqlDataReader</returns>   
         
        public static reMsg ExecuteReader(string strSQL)
        {
      
            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlCommand cmd = new MySqlCommand(strSQL, connection);

            try
            {

                connection.Open();

                MySqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                return new reMsg ( myReader);

            }

            catch (MySql.Data.MySqlClient.MySqlException e)
            {

                return new reMsg ("error",e.Message);

            }

        }
        #endregion
        #region ExecuteDataTable

        /// <summary>   

        /// 执行查询语句，返回DataTable   

        /// </summary>   

        /// <param name="SQLString">查询语句</param>   

        /// <returns>DataTable</returns>   

        public static reMsg ExecuteDataTable(string SQLString)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                DataSet ds = new DataSet();

                try
                {

                    connection.Open();

                    MySqlDataAdapter command = new MySqlDataAdapter(SQLString, connection);

                    command.Fill(ds, "ds");
                    return new reMsg(ds.Tables[0]);

                }

                catch (MySql.Data.MySqlClient.MySqlException ex)
                {

                   return new reMsg ("error",ex.Message);

                }


            }

        }


        #endregion
        #region 创建command

        private static void PrepareCommand(MySqlCommand cmd, MySqlConnection conn, MySqlTransaction trans, string cmdText, MySqlParameter[] cmdParms)
        {

            if (conn.State != ConnectionState.Open)

                conn.Open();

            cmd.Connection = conn;

            cmd.CommandText = cmdText;

            if (trans != null)

                cmd.Transaction = trans;

            cmd.CommandType = CommandType.Text;//cmdType;   

            if (cmdParms != null)
            {

                foreach (MySqlParameter parameter in cmdParms)
                {

                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&

                    (parameter.Value == null))
                    {

                        parameter.Value = DBNull.Value;

                    }

                    cmd.Parameters.Add(parameter);

                }

            }

        }
    }
        #endregion

    

}
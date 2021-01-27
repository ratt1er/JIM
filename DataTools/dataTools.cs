using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataTools
{
    public class dataTools
    {
        string conStr;
        string database;
        bool conState = false;
        public dataTools()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_server">服务器地址</param>
        /// <param name="_user">登录用户名</param>
        /// <param name="_database">数据库</param>
        /// <param name="_port">端口</param>
        /// <param name="_password">密码</param>
        public dataTools(string _server, string _user, string _database, int _port, string _password)
        {
            conStr = "server = " + _server + "; user = " + _user + "; database = " + _database + "; port = " + _port.ToString() + "; password = " + _password;
            database = _database;
            MySQLHelperClass.connectionString = conStr;
        }
        public void conMySql(string _server, string _user, string _database, int _port, string _password)
        {
            conStr = "server = " + _server + "; user = " + _user + "; database = " + _database + "; port = " + _port.ToString() + "; password = " + _password;
            database = _database;
            MySQLHelperClass.connectionString = conStr;
        }
        public void conMySql(string _server, string _user, string _database, string _password)
        {
            conStr = "server = " + _server + "; user = " + _user + "; database = " + _database + "; port = 3306; password = " + _password;
            database = _database;
            MySQLHelperClass.connectionString = conStr;
        }
        public string getConIFM()
        {
            return conStr;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_tableName">表明</param>
        /// <param name="row_1">第一个字段</param>
        /// <param name="row_2">与第一个字段匹配的字段</param>
        /// <returns></returns>
        public reMsg searchListCount(string _tableName, string[] row_1, string[] row_2)
        {

            var a = "select * from " + _tableName + " where ";
            var b = "";

            for (int i = 0; i < row_1.Length; i++)
            {
                b += row_1[i] + "='" + row_2[i] + "' ";

                if (i < row_1.Length - 1)
                {
                    b += " and ";
                }
            }

            var c = a + b;

            var remsg = MySQLHelperClass.ExecuteDataTable(c);
            if (remsg.kind == "error")
            {
                return remsg;
            }
            var table = (DataTable)remsg.msg;

            return new reMsg(remsg.kind, table.Rows.Count);
        }
        private DataRowCollection serachTable()
        {
            var table = (DataTable)(MySQLHelperClass.ExecuteDataTable("show tables").msg);
            return table.Rows;
        }

        public bool tableExit(string _database, string _tableName)
        {
            var count = MySQLHelperClass.ExecuteScalar("select count(*)  from information_schema.TABLES t where t.TABLE_SCHEMA ='" + _database + "' and t.TABLE_NAME ='" + _tableName + "'").msg.ToString();
            return int.Parse(count) == 1;
        }
        public reMsg insert(string _tableName, string[] row_1, string[] row_2)
        {

            if (tableExit(database, _tableName))
            {
                return insertSub(_tableName, row_1, row_2);

            }


            //如果表不存在就创建一个
            var str = "CREATE TABLE " + _tableName + "(id INT NOT NULL AUTO_INCREMENT, ";
            string a = "";
            for (int i = 0; i < row_1.Length; i++)
            {
                a += row_1[i] + " VARCHAR(100) NOT NULL,";
            }
            a += "PRIMARY KEY ( id ))";
            str = str + a;
            var remsg = MySQLHelperClass.ExecuteNonQuery(str);
            if (remsg.kind == "error")
            {
                return remsg;
            }
            else
            {
                return insertSub(_tableName, row_1, row_2);
            }



        }
        private reMsg insertSub(string _tableName, string[] row_1, string[] row_2)
        {

            var a = "INSERT INTO " + _tableName;
            string b = "(";
            string c = "(";
            for (int i = 0; i < row_1.Length; i++)
            {
                b += row_1[i];
                c += "'" + row_2[i] + "'";
                if (i < row_1.Length - 1)
                {
                    b += ",";
                    c += ",";
                }
            }
            b += ")";
            c += ")";
            var d = a + b + " value " + c;
            var remsg = MySQLHelperClass.ExecuteNonQuery(d);
            if (remsg.kind == "error")
            {
                return remsg;
            }
            else
            {
                return new reMsg("成功");
            }
        }
        public reMsg delete(string _tableName, string[] row_1, string[] row_2)
        {
            var a = "DELETE FROM " + _tableName + " where ";

            var b = "";

            for (int i = 0; i < row_1.Length; i++)
            {
                b += row_1[i] + "='" + row_2[i] + "'";

                if (i < row_1.Length - 1)
                {
                    b += " and ";
                }
            }

            var c = a + b;

            var remsg = MySQLHelperClass.ExecuteNonQuery(c);
            if (remsg.kind == "error")
            {
                return remsg;
            }
            else
            {
                return new reMsg("成功");
            }
        }
        public reMsg update(string _tableName, string[] name)
        {
            var a = "UPDATE " + _tableName + " set " + name[2] + " = '" + name[3] + "' where " + name[0] + " = '" + name[1] + "'";
            var remsg = MySQLHelperClass.ExecuteNonQuery(a);
            if (remsg.kind == "error")
            {
                return remsg;
            }
            else
            {
                return new reMsg("成功");
            }
        }public DataTable getTable(string _tableName) 
        {
            return (DataTable)MySQLHelperClass.ExecuteDataTable("select * from " + _tableName).msg;
        }
    }
}

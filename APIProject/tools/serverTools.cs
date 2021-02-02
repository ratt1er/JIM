using config;
using DataTools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
   public class serverTools
    {
      public static bool verifyKey(string _username,string _key)
       {

           var data = new dataTools(configClass.databaseip, configClass.databaseusername, "keydata", configClass.databaseport, configClass.psw);
           return (int)data.searchListCount(getDate(), new string[] { "username", "keydata" }, new string[] {_username, _key }).msg != 0;
       }
      public static string getDate()
       {
           return DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day;
       }
      public static void createKeydata()
        {
             string today = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day;
           
            dataTools data = new dataTools(configClass.databaseip, configClass.databaseusername, "keydata", configClass.databaseport, configClass.psw);

            if (!data.tableExit(today))
            {
            var a=data.insert(today, new string[] { "username", "IPPort", "time", "keydata" }, new string[] { "Server", "666.666.666", DateTime.Now.ToString(), login_information.set_key() });
            }
        }
      public static string[] getUserList()
      {
          var data = new dataTools(configClass.databaseip, configClass.databaseusername, "keydata", configClass.databaseport, configClass.psw);
          List<string> list = new List<string>();
          foreach (DataRow item in data.getTable(getDate()).Rows)
          {
              list.Add(item.ItemArray[1].ToString() + ":[" + item.ItemArray[2].ToString() + "]");
          }
          return list.ToArray();
      }
      public static string[] getUserList(string _database,string _tableName)
      {
          var data = new dataTools(configClass.databaseip, configClass.databaseusername, _database, configClass.databaseport, configClass.psw);
          List<string> list = new List<string>();
          foreach (DataRow item in data.getTable(_tableName).Rows)
          {
              list.Add(item.ItemArray[1].ToString() );
          }
          return list.ToArray();
      }
      public static int getUserCount()
      {
            dataTools data = new dataTools(configClass.databaseip, configClass.databaseusername, "keydata", configClass.databaseport, configClass.psw);
            return data.getTable(getDate()).Rows.Count;
      }

    }
}

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
    class searchfriendsClass
    {
        public static string searchfriends(string _username, string _msg, string _key, string IPport)
        {

            var data = new dataTools(configClass.databaseip, configClass.databaseusername, "jim", configClass.databaseport, configClass.psw);
            if (serverTools.verifyKey(_username, _key))
            {

                //验证key正确
                data.conMySql(configClass.databaseip, configClass.databaseusername, "jim", configClass.databaseport, configClass.psw);
                var dataRows1 = (DataRowCollection)data.searchOrList("user", new string[] { "username", "usermail" }, new string[] { _msg, _msg}).msg;
                List<string> list = new List<string>();
                foreach (DataRow item in dataRows1)
                {
                    list.Add("ID:[" + item.ItemArray[1].ToString() + "]  Mail:" + item.ItemArray[3].ToString());
                }
                return JsonHelper.server_local_interactive_serialization(IPport, JsonHelper.server_serialization(_username, "searchfriends", list.ToArray()));
               

            }
            else
            {
                return JsonHelper.server_local_interactive_serialization(IPport, (JsonHelper.server_serialization("server", "错误,请重新登录")));
            }
        }
    }
}

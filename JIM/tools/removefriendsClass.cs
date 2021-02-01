using config;
using DataTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    class removefriendsClass
    {
        public static string removefriends(string IPport, string _receiver, string _username, string _key)
        {

            var data = new dataTools(configClass.databaseip, configClass.databaseusername, "friends", configClass.databaseport, configClass.psw);
            data.deleteAnd(_username, new string[] { "username" }, new string[] { _receiver });

            return JsonHelper.server_local_interactive_serialization(IPport, JsonHelper.server_serialization(_username, "删除成功", "removefriends", _key));;
        }
    }
}

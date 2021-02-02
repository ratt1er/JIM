using config;
using DataTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    class addfriendsClass
    {
        public static string addfriends(string _IPport, string _username, string _msg, string _key)
        {
            if (serverTools.verifyKey(_username, _key))
            {

                if (_username == _msg)
                {
                   return JsonHelper.server_local_interactive_serialization(_IPport, JsonHelper.server_serialization(_username, "不能加自己哦~", "addfriends", _key));
                }


                var data = new dataTools(configClass.databaseip, configClass.databaseusername, "friends", configClass.databaseport, configClass.psw);


                if (!data.tableExit(_username))
                {
                    try
                    {

                        data.insert(_username, new string[] { "username", "addtime" }, new string[] { _msg, DateTime.Now.ToString() });
                        return JsonHelper.server_local_interactive_serialization(_IPport, JsonHelper.server_serialization(_username, "添加成功", "addfriends", _key));
                    }
                    catch (Exception e)
                    {
                        return JsonHelper.server_local_interactive_serialization(_IPport, JsonHelper.server_serialization(_username,  "添加失败" + e.Message.ToString(),"addfriends", _key)); 
                    }
                }
                var a = data.searchListCount(_username, new string[] { "username" }, new string[] { _msg }).msg;
                 if ((int)a != 0)
                {
                    return JsonHelper.server_local_interactive_serialization(_IPport,JsonHelper.server_serialization(_username,"已经是好友了哦~","addfriends",_key));
                }
                else
                {
                    try
                    {

                        data.insert(_username, new string[] { "username", "addtime" }, new string[] { _msg, DateTime.Now.ToString() });
                        return JsonHelper.server_local_interactive_serialization(_IPport, JsonHelper.server_serialization(_username,"添加成功","addfriends", _key));
                    }
                    catch (Exception e)
                    {
                        return JsonHelper.server_local_interactive_serialization(_IPport, JsonHelper.server_serialization(_username,  "添加失败" + e.Message.ToString(),"addfriends", _key));
                    }
                }

                //data.searchListCount()
            }
            else
            {
                return JsonHelper.server_local_interactive_serialization(_IPport, JsonHelper.server_serialization(_username, "添加失败","addfriends", _key));
            }
        }
    }
}

using config;
using DataTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
   public class loginClass
    {
      public static string loginCheck(string account, string password, string IPport)
        {

            string today = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day;
            var data = new dataTools(configClass.databaseip, configClass.databaseusername, "keydata", configClass.databaseport, configClass.psw);
            if ((int)data.searchListCount(today, new string[] { "username" }, new string[] { account }).msg != 0)
            {

                return JsonHelper.server_serialization("server", "账号已被登录!");
            }


            data.conMySql(configClass.databaseip, configClass.databaseusername, "jim", configClass.databaseport, configClass.psw);
            if ((int)data.searchListCount("user", new string[] { "username", "userpsw" }, new string[] { account, password }).msg == 0)
            {
                return JsonHelper.server_serialization("server", "账号密码不匹配!");
            }
            else
            {
               /* usersLB.Items.Add("[" + IPport + "]" + account);
                count++;
                materialLabel1.Text = "在线人数：" + count;*/
                login_information.userLogin(account, IPport, "login");
                var a = JsonHelper.server_serialization("server", "欢迎回来，" + account, "prompt",loginClass.getKey(account, IPport));
                return a;
            }
        }
      public static string getKey(string username, string IPPort)
      {
          var a = login_information.get_key(username, IPPort);
          return a;
      }
    }
}

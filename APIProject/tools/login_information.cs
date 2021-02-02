using tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTools;
using tools;
using config;
namespace tools
{
    public class login_information
    {
        public login_information()
        {

        }
        public static void userLogin(string _username, string _IPPort, string operate)
        {
            string today = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day;
            dataTools data = new dataTools(configClass.databaseip, configClass.databaseusername, "login_information", configClass.databaseport, configClass.psw);
            if (operate == "resign")
            {
                data.conMySql(configClass.databaseip, configClass.databaseusername, "keydata", configClass.psw);
                data.deleteOr(today, new string[] { "IPPort","username" }, new string[] { _IPPort ,_username});
                return;
            }
            var a = data.insert(today, new string[] { "username", "IPPort", "operate", "time" }, new string[] { _username, _IPPort, operate, DateTime.Now.ToString() });

            

        }
        public static string get_key(string username, string IPPort)
        {
            var key = set_key();

            string today = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day;
            dataTools data = new dataTools(configClass.databaseip, configClass.databaseusername, "keydata", configClass.databaseport, configClass.psw);

            while (true)
            {

                if ((int)data.searchListCount(today, new string[] { "keydata" }, new string[] { key }).msg != 0)
                {
                    key = set_key();
                }
                else
                {
                    break;
                }
            }

            data.insert(today, new string[] { "username", "IPPort", "time", "keydata" }, new string[] { username, IPPort, DateTime.Now.ToString(), key });

            return key;
        }
        public static string set_key()
        {
            Random ra = new Random();
            return Convert.ToString(ra.Next(100000000, 1000000000), 16);
        }


    }
}

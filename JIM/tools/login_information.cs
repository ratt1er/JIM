using tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTools;
namespace tools
{
    public class login_information
    {
        public login_information()
        {

        }
        public static void userLogin(string username, string IPPort, string operate)
        {
            string today = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day;
            dataTools data = new dataTools("localhost", "root", "login_information", 3306, "thisisjim1!");
            var a = data.insert(today, new string[] { "username", "IPPort", "operate", "time" }, new string[] { username, IPPort, operate, DateTime.Now.ToString() });

            if (operate == "resign")
            {
                data.conMySql("localhost", "root", "keydata", "thisisjim1!");
                data.delete(today, new string[] { "username" }, new string[] { username });
                return;
            }

        }
        public static string get_key(string username, string IPPort)
        {
            var key = set_key();

            string today = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day;
            dataTools data = new dataTools("localhost", "root", "keydata", 3306, "thisisjim1!");

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

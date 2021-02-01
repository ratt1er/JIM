using config;
using DataTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    class setMsgClass
    {
        public static void setMsg(string _sender,string _receiver,string _msg,string _key)
        {

            if (serverTools.verifyKey(_sender, _key))
            {
                var data = new dataTools(configClass.databaseip, configClass.databaseusername, "talkdata", configClass.databaseport, configClass.psw);
                data.insert(_receiver, new string[] { "sender", "receiver", "msg", "time" }, new string[] { _sender,_receiver, _msg, DateTime.Now.ToString() });
                data.insert(_sender, new string[] { "sender", "receiver", "msg", "time" }, new string[] { _sender, _receiver, _msg, DateTime.Now.ToString() });
            
            }

        }
    }
}

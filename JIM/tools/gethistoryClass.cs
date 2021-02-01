using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reply_entity;
using DataTools;
using System.Data;
using config;
namespace tools
{
   public class gethistoryClass
    {
     public  static string gethistory(string IPport,string _receiver,string _username,string _key)
        {
         if(serverTools.verifyKey(_username,_key))
         {
             List<msgClass> msgclass = new List<msgClass>();
             var data =new  dataTools(configClass.databaseip,configClass.databaseusername,"talkdata",configClass.databaseport,configClass.psw);
             if (!data.tableExit(_username))
             {
                 return JsonHelper.server_local_interactive_serialization(IPport, JsonHelper.server_serialization(_username, "sethistory", msgclass)); ;
 
             }
             var objlist = (DataRowCollection)data.searchOrList(_username, new string[] { "sender", "receiver" }, new string[] { _receiver, _receiver }).msg;
             
             foreach (DataRow item in objlist)
             {
                 msgclass.Add(new msgClass() { sender = item.ItemArray[1].ToString(), receiver = item.ItemArray[2].ToString(), msg = item.ItemArray[3].ToString(), time = item.ItemArray[4].ToString() });
             }

             return JsonHelper.server_local_interactive_serialization(IPport, JsonHelper.server_serialization(_username, "sethistory", msgclass)); ;
             
             
         }

         return JsonHelper.server_local_interactive_serialization(IPport, JsonHelper.server_serialization(_username, "sethistory", new List<msgClass>())); ;
        }
    }
}

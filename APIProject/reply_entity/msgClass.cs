using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reply_entity
{
   public class msgClass
    {
       public string sender;
       public string receiver;
       public string msg;
       public string time;
       public static bool msgEquals(List<msgClass> msgclass1,List< msgClass> msgclass2)
       {
           if (msgclass1.Count != msgclass2.Count)
               return false;
           msgClass[] array = msgclass2.ToArray();
           int i = 0;
           foreach (var item in msgclass1)
           {
               if (item.msg != array[i].msg || item.sender != array[i].sender || item.time != array[i].time || item.receiver != array[i].receiver)
               {
                   return false;
               }
               i++;
               
           }
           return true;
           
 
       }
    }
}

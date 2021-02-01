using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reply_entity
{
   public class serverJson
    {
        /// <summary>
        /// 服务器、用户
        /// </summary>
        public string sender{ get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string msg { get; set; }
        public string type="prompt";
        public string key { get; set; }
        public string[] list;
       public List<msgClass> msgclass;

    }
}

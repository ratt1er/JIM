using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reply_entity
{
   public class clientJson
    {
        /// &lt;summary&gt;
        /// 接收者
        /// &lt;/summary&gt;
        public string receiver { get; set; }
        /// &lt;summary&gt;
        /// 消息类型
        /// 
        /// &lt;/summary&gt;
        public string type { get; set; }
        /// &lt;summary&gt;
        /// 消息体
        /// &lt;/summary&gt; 
       public string msg { get; set; }
        /// &lt;summary&gt;
        /// 
        /// &lt;/summary&gt;
        public string key { get; set; }
        /// &lt;summary&gt;
        /// 
        /// &lt;/summary&gt;
        public string username { get; set; }
        /// &lt;summary&gt;
        /// 
        /// &lt;/summary&gt;
        public string psw { get; set; }
        /// &lt;summary&gt;
        /// 
        /// &lt;/summary&gt;
        public string mail { get; set; }

    }

}

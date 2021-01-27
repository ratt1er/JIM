using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reply_entity
{
   public class server_reply_entity
    {
        /// <summary>
        /// 回复的消息类型
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 服务器消息
        /// </summary>
        public string serverMessages { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string userKay { get; set; }
        /// <summary>
        /// 登录状态
        /// </summary>
        public bool loginStatus { get; set; }
    }
}

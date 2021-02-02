using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using reply_entity;
namespace tools
{
  public  class JsonHelper
    {
        public JsonHelper()
        {

        }
        /*/// <summary>
        /// 客户端请求序列化
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string client_requests_serialization(string _account, string _password)
        {
            
            user_requests_entity one = new user_requests_entity() { account = _account, password = _password };

            return JsonConvert.SerializeObject(one);
        }
        /// <summary>
        /// 客户端请求序列化
        /// </summary>
        /// <param name="_type"></param>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string client_requests_serialization(string _type, string _account, string _password)
        {
            user_requests_entity one = new user_requests_entity() { type = _type, account = _account, password = _password };

            return JsonConvert.SerializeObject(one);
        }
        /// <summary>
        /// 客户端请求反序列化
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static user_requests_entity client_requests_deserialization(string json)
        {
            return JsonConvert.DeserializeObject<user_requests_entity>(json);
        }
        /// <summary>
        /// 服务器回应序列化
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string server_reply_serialization(string _type, string _serverMessages)
        {
            server_reply_entity one = new server_reply_entity() { type = _type, serverMessages = _serverMessages };

            return JsonConvert.SerializeObject(one);
        }
        /// <summary>
        /// 服务器回应序列化
        /// </summary>
        /// <param name="_type"></param>
        /// <param name="_serverMessages"></param>
        /// <param name="_loginStatus"></param>
        /// <returns></returns>
        public static string server_reply_serialization(string _type, string _serverMessages, bool _loginStatus)
        {
            server_reply_entity one = new server_reply_entity() { type = _type, serverMessages = _serverMessages, loginStatus = _loginStatus };

            return JsonConvert.SerializeObject(one);
        }
        /// <summary>
        /// 服务器回应序列化
        /// </summary>
        /// <param name="_type"></param>
        /// <param name="_serverMessages"></param>
        /// <param name="_userKay"></param>
        /// <returns></returns>
        public static string server_reply_serialization(string _type, string _serverMessages, string _userKay)
        {
            server_reply_entity one = new server_reply_entity() { type = _type, serverMessages = _serverMessages, userKay = _userKay };

            return JsonConvert.SerializeObject(one);
        }
        /// <summary>
        /// 服务器回应序列化
        /// </summary>
        /// <param name="_type"></param>
        /// <param name="_serverMessages"></param>
        /// <param name="_userKay"></param>
        /// <param name="_loginStatus"></param>
        /// <returns></returns>
        public static string server_reply_serialization(string _type, string _serverMessages, string _userKay, bool _loginStatus)
        {
            server_reply_entity one = new server_reply_entity() { type = _type, serverMessages = _serverMessages, userKay = _userKay, loginStatus = _loginStatus };

            return JsonConvert.SerializeObject(one);
        }
        
        /// <summary>
        /// 服务器回应反序列化
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static server_reply_entity server_reply_deserialization(string json)
        {
            return JsonConvert.DeserializeObject<server_reply_entity>(json);
        }
         */
        /// <summary>
        /// 服务器本地交互序列化
        /// </summary>
        /// <param name="_msg"></param>
        /// <returns></returns>
        public static string server_local_interactive_serialization(string _msg)
        {
            server_local_interactive one = new server_local_interactive() {msg = _msg };
            return JsonConvert.SerializeObject(one);
        }
        /// <summary>
        /// 服务器本地交互序列化
        /// </summary>
        /// <param name="_IPPort"></param>
        /// <param name="_msg"></param>
        /// <returns></returns>
        public static string server_local_interactive_serialization(string _IPPort, string _msg)
        {
            server_local_interactive one = new server_local_interactive() {IPPort=_IPPort,msg=_msg };
            return JsonConvert.SerializeObject(one);
        }
        /// <summary>
        /// 服务器本地交互序列化
        /// </summary>
        /// <param name="_type"></param>
        /// <param name="_IPPort"></param>
        /// <param name="_msg"></param>
        /// <returns></returns>
        public static string server_local_interactive_serialization(string _type,string _IPPort, string _msg)
        {
            server_local_interactive one = new server_local_interactive() {type=_type, IPPort = _IPPort, msg = _msg };
            return JsonConvert.SerializeObject(one);
        }
        /// <summary>
        /// 服务器本地交互序列化
        /// </summary>
        /// <param name="_type"></param>
        /// <param name="_IPPort"></param>
        /// <param name="_msg"></param>
        /// <returns></returns>
        public static string server_local_interactive_serialization(string _type, string _IPPort, string _account, string _msg)
        {
            server_local_interactive one = new server_local_interactive() { type = _type, IPPort = _IPPort,account=_account, msg = _msg };
            return JsonConvert.SerializeObject(one);
        }
        /// <summary>
        /// 服务器本地交互反序列化
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static server_local_interactive server_local_interactive_deserialization(string json)
        {
            return JsonConvert.DeserializeObject<server_local_interactive>(json);
        }

      /// <summary>
        /// 客户端消息序列化(发送消息/查找好友)
        /// </summary>
        /// <param name="_receiver">接受者</param>
        /// <param name="_type">类型</param>
        /// <param name="_msg">消息</param>
        /// <param name="_key">用户的凭证，退出即销毁</param>
        /// <returns></returns>
        public static string client_msg_serialization(string _receiver,string _type,string _username, string _msg, string _key)
        {

            clientJson one = new clientJson() { receiver = _receiver,type=_type,username=_username, msg = _msg, key = _key };

            return JsonConvert.SerializeObject(one);
        }
        /// <summary>
        /// 客户端消息序列化(注册/登录)
        /// </summary>
        /// <param name="_receiver">接受者</param>
        /// <param name="_type">类型</param>
        /// <param name="_username">用户名</param>
        /// <param name="_psw">密码</param>
        /// <param name="_mail">邮箱</param>
        /// <returns></returns>
        public static string client_account_serialization(string _receiver, string _type, string _username, string _psw, string _mail,string _key)
        {

            clientJson one = new clientJson() { receiver = _receiver,type=_type, username = _username, psw = _psw, mail = _mail,key=_key };

            return JsonConvert.SerializeObject(one);
        }
        /// <summary>
        /// 客户端消息反序列化
        /// </summary>
        /// <param name="str">json字符串</param>
        /// <returns></returns>
        public static clientJson client_deserialization(string str)
        {
            return JsonConvert.DeserializeObject<clientJson>(str);
        }
        /// <summary>
        /// 服务器端消息序列化
        /// </summary>
        /// <param name="_sender">接受者</param>
        /// <param name="_msg">消息体</param>
        /// <returns></returns>
        public static string server_serialization(string _sender, string _msg)
        {
            serverJson one = new serverJson() { sender = _sender, msg = _msg };

            return JsonConvert.SerializeObject(one);
        }
      /// <summary>
        /// 服务器端消息序列化
      /// </summary>
      /// <param name="_sender">接受者</param>
      /// <param name="_msg">消息体</param>
      /// <param name="_type">类型</param>
      /// <param name="_key"></param>
      /// <returns></returns>
        public static string server_serialization(string _sender, string _msg, string _type,string _key)
        {
            serverJson one = new serverJson() { sender = _sender, msg = _msg ,type=_type,key=_key};

            return JsonConvert.SerializeObject(one);
        }
      /// <summary>
        /// 服务器端消息序列化
      /// </summary>
      /// <param name="_sender"></param>
      /// <param name="_type"></param>
      /// <param name="_list"></param>
      /// <returns></returns>
        public static string server_serialization(string _sender,string _type,string[] _list)
        {
            serverJson one = new serverJson() { sender = _sender,type=_type,list=_list};

            return JsonConvert.SerializeObject(one);
        }
      /// <summary>
        /// 服务器端消息序列化
      /// </summary>
      /// <param name="_sender"></param>
      /// <param name="_type"></param>
      /// <param name="_msgclass"></param>
      /// <returns></returns>
        public static string server_serialization(string _sender, string _type, List<msgClass> _msgclass)
        {
            serverJson one = new serverJson() { sender = _sender, type = _type,msgclass=_msgclass  };

            return JsonConvert.SerializeObject(one);
        }
        /// <summary>
        /// 服务器端消息反序列化
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static serverJson server_deserialization(string str)
        {
            return JsonConvert.DeserializeObject<serverJson>(str);
        }
    }
}

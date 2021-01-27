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
        /// <summary>
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
        /// 
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
    }
}

using DataTools;
using Newtonsoft.Json;
using reply_entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using tools;
namespace tools
{
    public class ServerControl
    {
        static private Socket serverSocket;
        string condition = "stop";
        string ip;
        int port;
        List<Socket> sockets = new List<Socket>();
        public string connection_status = "";
        public string clientMsg = "";
        string welcomeMsg = "欢迎使用音社内测版~";
        List<Task> tasks = new List<Task>();
        public ServerControl()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }

        private BackgroundWorker MyAccept = new BackgroundWorker();
        
        public void Start(string _ip, int _port)
        {
            ip = _ip;
            port = _port;
               serverSocket.Bind(new IPEndPoint(IPAddress.Parse(_ip), _port));
            serverSocket.Listen(1000);

            ThreadPool.QueueUserWorkItem(new WaitCallback(Accept));
            condition = "start";
            connection_status = JsonHelper.server_local_interactive_serialization("start", _ip, "服务器", "已启动");


        }
        public void Start(string _ip, int _port, string _msg)
        {

            ip = _ip;
            port = _port;
            welcomeMsg = _msg;
            serverSocket.Bind(new IPEndPoint(IPAddress.Parse(_ip), _port));
            serverSocket.Listen(20);
            ThreadPool.QueueUserWorkItem(new WaitCallback(Accept));


            condition = "start";
            connection_status = JsonHelper.server_local_interactive_serialization("start", _ip, "服务器", "已启动");


        }
        private void Accept(object obj)
        {
            while (true )
            {

                Socket client = serverSocket.Accept();
                try
                {
                    IPEndPoint point = client.RemoteEndPoint as IPEndPoint;

                    connection_status = JsonHelper.server_local_interactive_serialization("con", point.ToString(), "游客", "已连接");
                    client.Send(Encoding.UTF8.GetBytes(JsonHelper.server_serialization("server", welcomeMsg,"prompt",null)));

                    sockets.Add(client);

                    ThreadPool.QueueUserWorkItem(new WaitCallback(Receive),client);
                }
                catch (Exception ex)
                {
                    connection_status = JsonHelper.server_local_interactive_serialization("error", ip+":["+port+"]", ex.Message.ToString());
                    Thread.Sleep(1000);
                }
            }
            
            

        }
        private void Receive(object obj)
        {
            Socket client = obj as Socket;
            IPEndPoint point = client.RemoteEndPoint as IPEndPoint;
            clientJson userMsgJSON =new clientJson ();
            try
            {
                byte[] _msg = new byte[1024];
                int msgLen = client.Receive(_msg);
                if (msgLen == 0)
                {
                    return;
                }
                clientMsg = JsonHelper.server_local_interactive_serialization(point.ToString(), Encoding.UTF8.GetString(_msg, 0, msgLen));
                var IPPortJSON = JsonHelper.server_local_interactive_deserialization(clientMsg);
                var IPport = IPPortJSON.IPPort;
                userMsgJSON = JsonHelper.client_deserialization(IPPortJSON.msg);
                switch (userMsgJSON.type)
                {

                    case "login":
                        var msg = loginClass.loginCheck(userMsgJSON.username, userMsgJSON.psw, IPport);
                        Send(JsonHelper.server_local_interactive_serialization(IPport, msg));
                        connection_status = JsonHelper.server_local_interactive_serialization("login",point.ToString(),"["+userMsgJSON.username+"]", "尝试登录");
                        break;
                    case "msg":
                        setMsgClass.setMsg(userMsgJSON.username, userMsgJSON.receiver, userMsgJSON.msg, userMsgJSON.key);
                        break;
                    case "searchfriends":
                        Send(searchfriendsClass.searchfriends(userMsgJSON.username, userMsgJSON.msg, userMsgJSON.key, IPport));
                        break;
                    case "addfriends":

                       Send( addfriendsClass.addfriends(IPport,userMsgJSON.username, userMsgJSON.msg, userMsgJSON.key));
                       break;
                    case "gethistory":
                      Send( gethistoryClass.gethistory(IPport, userMsgJSON.receiver, userMsgJSON.username, userMsgJSON.key));
                        break;
                    case "removefriends":

                        Send(removefriendsClass.removefriends(IPport, userMsgJSON.receiver, userMsgJSON.username, userMsgJSON.key));
                        break;
                    default:
                        break;
                }



                clientMsg = "";
                Receive(client);
            }
            catch (Exception)
            {
                foreach (var item in sockets)
                {
                    if (item.RemoteEndPoint.ToString() == point.ToString())
                    {

                        login_information.userLogin(null, point.ToString(), "resign");
                        connection_status = JsonHelper.server_local_interactive_serialization("discon", point.ToString(), userMsgJSON.username, "已断开");
                    }
                }
               

            }
        }
        public void Stop()
        {
            try
            {

                serverSocket.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public void Send(string _json)
        {
            var json = JsonHelper.server_local_interactive_deserialization(_json);
            var item = json.IPPort;
            try
            {

                foreach (Socket socket in sockets)
                {
                    //实现服务端与某个选定的客户端进行通信
                    if (socket.RemoteEndPoint.ToString() == item)
                    {
                        if (socket.Connected)
                        {
                            string str = json.msg;
                            byte[] data = Encoding.UTF8.GetBytes(str);
                            socket.Send(data, 0, data.Length, SocketFlags.None);
                        }
                    }

                }
            }
            catch (Exception e)
            {
                connection_status = JsonHelper.server_local_interactive_serialization("error", item, e.Message.ToString());
            }

        }
    }
}

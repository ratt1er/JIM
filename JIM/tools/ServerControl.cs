using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        List<Socket> sockets = new List<Socket>();
        public string connection_status = "";
        public string clientMsg = "";
        string welcomeMsg = "欢迎使用音社内测版~";
        List<Task> tasks = new List<Task>();
        Thread threadAccept;
        Thread threadReceive;
        public ServerControl()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }

        private BackgroundWorker MyAccept = new BackgroundWorker();
        
        public void Start(string _ip, int _port)
        {
            serverSocket.Bind(new IPEndPoint(IPAddress.Parse(_ip), 10086));
            serverSocket.Listen(20);

            threadAccept = new Thread(Accept);
            threadAccept.IsBackground = true;
            threadAccept.Start();

            JsonHelper.server_local_interactive_serialization("启动成功");


        }
        public void Start(string _ip, int _port, string _msg)
        {
            welcomeMsg = _msg;
            serverSocket.Bind(new IPEndPoint(IPAddress.Parse(_ip), 10086));
            serverSocket.Listen(20);


            threadAccept = new Thread(Accept);
            threadAccept.IsBackground = true;
            threadAccept.Start();

            JsonHelper.server_local_interactive_serialization("启动成功");


        }
        private void Accept()
        {
            while (true)
            {
                try
                {
                    Socket client = serverSocket.Accept();
                    IPEndPoint point = client.RemoteEndPoint as IPEndPoint;

                    connection_status = JsonHelper.server_local_interactive_serialization(point.ToString(), "已连接");
                    client.Send(Encoding.UTF8.GetBytes(JsonHelper.server_reply_serialization("prompt", welcomeMsg)));

                    sockets.Add(client);
                    
                    threadReceive = new Thread(Receive);
                    threadReceive.IsBackground = true;
                    threadReceive.Start(client);
                }
                catch (Exception ex)
                {
                    connection_status = "错误：" + ex.Message+"(一秒后重试)";
                    Thread.Sleep(1000);
                }
            }
            
            

        }
        private void Receive(object obj)
        {
            Socket client = obj as Socket;
            IPEndPoint point = client.RemoteEndPoint as IPEndPoint;

            try
            {
                byte[] _msg = new byte[1024];
                int msgLen = client.Receive(_msg);
                if (msgLen == 0)
                {
                    return;
                }
                clientMsg = JsonHelper.server_local_interactive_serialization(point.ToString(), Encoding.UTF8.GetString(_msg, 0, msgLen));

                Receive(client);
            }
            catch (Exception)
            {
                connection_status = JsonHelper.server_local_interactive_serialization(point.ToString(), "已断开");

            }
        }
        public bool Stop()
        {
            try
            {
                if (threadReceive == null && threadAccept == null) return false;
                if (threadReceive == null)
                { 
                    threadAccept.Abort();
                } if (threadAccept == null)
                {
                    threadReceive.Abort();
                }
                serverSocket.Close();
                connection_status = "已关闭";
                return true;
            }
            catch (Exception e)
            {
                connection_status = JsonHelper.server_local_interactive_serialization("错误：" + e.Message);
                return false;
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
                connection_status = JsonHelper.server_local_interactive_serialization(item, "错误：" + e.Message);
            }

        }
    }
}

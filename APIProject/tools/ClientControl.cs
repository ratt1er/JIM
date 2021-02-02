using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tools
{
   public class ClientControl
    {
        private static Socket clientSocket;
        public string serverMsg = "";
        public string connection_status = "";
        public ClientControl()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }
        string ip;
        int port;
        public void Connet(string _ip, int _port)
        {
            if (ip == null)
            {
                ip = _ip;
                port = _port;
            }
            try
            {

                clientSocket.Connect(ip, port);

                Thread threadReceive = new Thread(Receive);
                threadReceive.IsBackground = true;
                threadReceive.Start();
                connection_status = "连接成功";
                // JsonHelper.client_requests_serialization()
                //  clientSocket.Send();
                _ip = ip;
                _port = port;
            }
            catch (Exception)
            {
                connection_status = "连接服务器失败,正在重试";
                Thread.Sleep(100);
                Connet(ip, port);
            }


        }public void disConnet()
        {
            clientSocket.Close();
        }
        private void Receive()
        {
            try
            {

                byte[] msg = new byte[1024];
                int msgLen = clientSocket.Receive(msg);
                if (msgLen == 0)
                {
                    return;
                }
                serverMsg = Encoding.UTF8.GetString(msg, 0, msgLen);
                Receive();
            }
            catch (Exception)
            {
                Thread.Sleep(1000);
                clientSocket.Close();
                clientSocket = clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Connet(ip, port);

            }

        }
        public void Send(string msg)
        {
            clientSocket.Send(Encoding.UTF8.GetBytes(msg));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Net.Sockets;
using System.Threading;
using tools;
using DataTools;
namespace Server
{
    public partial class ServerMainForm : MaterialForm
    {

        List<Task> tasks = new List<Task>();
        string serverIP = "127.0.0.1";
         int serverPort = 10086;
        int count = 0;
        public Thread threadAccept;
        static ServerControl server = new ServerControl();
        //用来存储客户端的连接对象
        List<Socket> sockets = new List<Socket>();

        public string clientMsg
        {
            get;
            set;
        }
        public ServerMainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string loginCheck(string account, string password, string IPport)
        {
            
             string today = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day;
            var data = new dataTools("localhost", "root", "keydata", 3306, "thisisjim1!");
            if ((int)data.searchListCount(today, new string[] { "username" }, new string[] { account }).msg != 0) 
            {

                return JsonHelper.server_reply_serialization("prompt", "账号已被登录!", false);
            }


            data.conMySql("localhost", "root", "jim", 3306, "thisisjim1!");
            if ((int)data.searchListCount("user",new string[]{"username","userpsw"},new string[]{account,password}).msg ==0)
            {
                return JsonHelper.server_reply_serialization("prompt", "账号密码不匹配!", false);
            }
            else
            {
                usersLB.Items.Add("[" + IPport + "]" + account);
                count++;
                materialLabel1.Text = "在线人数：" + count;
                login_information.userLogin(account, IPport, "login");
                var a = JsonHelper.server_reply_serialization("prompt", "欢迎回来，" + account, getKey(account, IPport));
                return a;
            }
        }
        string getKey(string username, string IPPort)
        {
            var a = login_information.get_key(username, IPPort);
            return a;
        }
        private async Task Accept()
        {


            while (true)
            {


                if (server.connection_status != "")
                {
                    try
                    {
                        var IPPortJSON = JsonHelper.server_local_interactive_deserialization(server.connection_status);

                        switch (IPPortJSON.msg)
                        {
                            case "已断开":

                                var list = usersLB.Items;
                                int i = 0;
                                var account = "";
                                foreach (var item in list)
                                {
                                    if (item.ToString().IndexOf(IPPortJSON.IPPort) == 1)
                                    {
                                        account = item.ToString().Split(']')[1];
                                        usersLB.Items.RemoveAt(i);
                                        count--;
                                        materialLabel1.Text = "在线人数：" + count;
                                        break;
                                    }
                                    i++;
                                }
                                txtLog.Text += "[" + IPPortJSON.IPPort + "]已断开\r\n";
                                login_information.userLogin(account, IPPortJSON.IPPort, "resign");
                                break;
                            case "已连接":
                                txtLog.Text += "[" + IPPortJSON.IPPort + "]已连接\r\n";
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception)
                    {

                        txtLog.Text += server.connection_status + "\r\n";

                    }
                    server.connection_status = "";
                }
                if (server.clientMsg != "")
                {
                    try
                    {

                        var IPPortJSON = JsonHelper.server_local_interactive_deserialization(server.clientMsg);
                        var IPport = IPPortJSON.IPPort;
                        var userMsgJSON = JsonHelper.client_requests_deserialization(IPPortJSON.msg);
                        if (userMsgJSON.type == "login")
                        {
                            var msg = loginCheck(userMsgJSON.account, userMsgJSON.password, IPport);
                            server.Send(JsonHelper.server_local_interactive_serialization(IPport, msg));
                        }
                    }
                    catch (Exception e)
                    {
                        txtLog.Text += server.clientMsg + "\r\n"+"错误："+e.Message;
                    }
                    server.clientMsg = "";

                }
                await Task.Delay(1000);
            }
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            if (usersLB.SelectedItems.Count < 1 || richTextBox2.Text == "")
            {
                MessageBox.Show("请选择用户");
                return;
            }
            foreach (var item in usersLB.SelectedItems)
            {
                var IPport = item.ToString().Split(']')[0].Replace("[", "");

                var myMsg = JsonHelper.server_reply_serialization("PersonalLetter", richTextBox2.Text);
                server.Send(JsonHelper.server_local_interactive_serialization(IPport, myMsg));
            }
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                return;
            }
            foreach (var item in usersLB.Items)
            {
                var IPport = item.ToString().Split(']')[0].Replace("[", "");
                var myMsg = JsonHelper.server_reply_serialization("GlobalMessage", richTextBox1.Text);
                server.Send(JsonHelper.server_local_interactive_serialization(IPport, myMsg));
            }
        }
        /*
        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            materialLabel2.Text = "重启中";
            server = null;
            server = new ServerControl();
            try
            {

                server.Start();
                materialLabel2.Text = "已启动";
            }
            catch (Exception ex)
            {
                txtLog.Text += ex.Message.ToString();
            }
            threadAccept = new Thread(Accept);
            threadAccept.IsBackground = true;
            threadAccept.Start();
        }*/

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (server.Stop() == false) return;
            materialLabel2.Text = "服务器状态：未运行";
            server = null;
        }

        
        async Task login()
        {
            serverIP = IPTB.Text;

            serverPort = int.Parse(PortTB.Text);
            server = new ServerControl();
            try
            {
                
                server.Start(IPTB.Text,int.Parse( PortTB.Text));
                materialLabel2.Text = "已启动";
            }
            catch (Exception ex)
            {
                txtLog.Text += "错误：" + ex.Message.ToString() + "\r\n";
            }
            



            tasks.Add(Accept());
            await Task.WhenAll(tasks);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            createKeydata();
            login();
            
        }
        void createKeydata()
        {
             string today = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day;
           
            dataTools data = new dataTools("localhost", "root", "keydata", 3306, "thisisjim1!");

            if (!data.tableExit("keydata", today))
            {
            var a=    data.insert(today, new string[] { "username", "IPPort", "time", "keydata" }, new string[] { "Server", "666.666.666", DateTime.Now.ToString(), login_information.set_key() });
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            string today = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day;
            dataTools data = new dataTools("localhost", "root", "keydata", 3306, "thisisjim1!");
            dataGridView1.DataSource = data.getTable(today);
            

        }


    }
}
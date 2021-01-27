using System;
using System.Windows.Forms;
using tools;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System.Threading;
using JIM;
using JIM.窗口;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using DSAPI;
using reply_entity;
namespace JIM
{
    public partial class ClientMainForm : MaterialForm
    {
        string code="code";

        public Thread threadAccept;
        ClientControl client;
        string key = "";
        public ClientMainForm()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
        //    MySQLHelperClass.connectionString = "server = localhost; user = root; database = jim; port = 3306; password = thisisjim1!";

        }

        private void lbt_Click(object sender, EventArgs e)
        {
            lbt_Click();


        }
        void lbt_Click() 
        {
           
            if (loginAccountTb.Text == "" ||
              loginPasswordTb.Text == "")
            {
                message("输入框不能为空");
                return;
            }
            var str = JsonHelper.client_requests_serialization("login", loginAccountTb.Text, loginPasswordTb.Text);
            client.Send(str);
        }

        void message(string msg)
        {

            MessageBox.Show(msg);
        }
        void message(string msg,string caption)
        {

            MessageBox.Show(msg,caption);
        }

        private void sendCodebt_Click(object sender, EventArgs e)
        {
            var msg = mailClass.send("from_china@163.com");
            MessageBox.Show(msg[0]);
            code = msg[1];
        }

     


        private void MainForm_Load(object sender, EventArgs e)
        {
            client = new ClientControl();
            client.Connet(ipTb.Text, int.Parse(portTb.Text));
            threadAccept = new Thread(Accept);
            threadAccept.IsBackground = true;
            threadAccept.Start();
            loginAccountTb.Focus();
            //materialLabel3.Text = "本地IP地址：" + DSAPI.网络.本机外网IP和所在地().IP;

        }

        private void Accept()
        {
            
            if (client.connection_status != "")
            {
                loginStatusTbl.Text = client.connection_status;
                client.connection_status = "";
            }
            if (client.serverMsg != "")
            {
                try
                {

                    var sre = JsonHelper.server_reply_deserialization(client.serverMsg);


                    if (sre.type == "prompt")
                    {

                        message(sre.serverMessages,"你好");
                        if (sre.userKay != null) 
                        {
                            key = sre.userKay;

                            //此处为登录成功
                            MainForm main = new MainForm(key);
                           main.ShowDialog();
                         //   talkForm talkform = new talkForm(key,loginAccountTb.Text);
                         //   talkform.ShowDialog();
                        }
                    } if (sre.type == "PersonalLetter") 
                    {
                        message(sre.serverMessages, "站内私信");
                    } if (sre.type == "GlobalMessage") 
                    {
                        message(sre.serverMessages, "全局消息");
                    }
                }
                catch (Exception)
                {
                    loginStatusTbl.Text = client.serverMsg;
                }
               
                client.serverMsg = "";
            }
            Thread.Sleep(100);
            Accept();
        }

        private void rebt_Click(object sender, EventArgs e)
        {
            message("暂不开放注册，请您耐心留意音社动态", "抱歉");
          //  rebt_Click();
        }
        void rebt_Click() 
        {
            Hide();
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
            Show();
        }

        private void lusernametb_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginPasswordTb.Focus();
            }
        }

        private void luserpswtb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbt_Click();
            }
        }

        
        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            client = new ClientControl();
            client.Connet(ipTb.Text, int.Parse(portTb.Text));
            threadAccept = new Thread(Accept);
            threadAccept.IsBackground = true;
            threadAccept.Start();
            loginAccountTb.Focus();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

    }
}

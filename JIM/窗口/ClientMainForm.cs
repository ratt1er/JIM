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
using reply_entity;
namespace JIM
{
    public partial class ClientMainForm : MaterialForm
    {

        public Thread threadAccept;
        ClientControl client;
        string key = "";
        public ClientMainForm()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void lbt_Click(object sender, EventArgs e)
        {
            if (loginAccountTb.Text == "" ||
              loginPasswordTb.Text == "")
            {
                message("输入框不能为空");
                return;
            }
            if (key != "") 
            {

                MainForm main = new MainForm(key, loginAccountTb.Text, client);
                main.ShowDialog();
                return;
                
            }
            lbt_Click();


        }
        void lbt_Click()
        {

            
            var json = JsonHelper.client_account_serialization("server", "login", loginAccountTb.Text, loginPasswordTb.Text,null,null);
            client.Send(json);
        }

        void message(string msg)
        {

            MessageBox.Show(msg);
        }
        void message(string msg, string caption)
        {

            MessageBox.Show(msg, caption);
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
                    var sre = JsonHelper.server_deserialization(client.serverMsg);

                    if (sre.sender == "server")
                    {
                        switch (sre.type)
                        {
                            case "prompt":
                                message(sre.msg, "你好");
                                if (sre.key != null)
                                {
                                    key = sre.key;

                                    //此处为登录成功
                                    loginStatusTbl.Text = sre.msg;
                                    MainForm main = new MainForm(key, loginAccountTb.Text, client);
                                    main.ShowDialog();
                                }
                                break;
                            case "PersonalLetter":

                                message(sre.msg, "站内私信");
                                break;
                            case "GlobalMessage":

                                message(sre.msg, "全局消息");

                                break;
                        }
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (key != "")
            {
                client.disConnet();
                key = "";
            }
            else
            {
                message("你还没有登录账户", "提示");
            }
        }

        private void loginStatusTbl_Click(object sender, EventArgs e)
        {

        }

    }
}
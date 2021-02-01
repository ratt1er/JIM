﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Net.Sockets;
using System.Threading;
using tools;
using DataTools;
using System.Data;
using System.Linq;
using reply_entity;
using System.Drawing;
using config;
namespace tools
{
    public partial class ServerMainForm : MaterialForm
    {

        List<Task> tasks = new List<Task>();
        string condition = "stop";
       string serverIP = configClass.serverip;
        int serverPort = configClass.listenport;
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
            IPTB.Text = configClass.serverip;
            PortTB.Text = configClass.listenport.ToString();
            sizeChange();
        }
        private async Task Accept()
        {


            while (condition == "start")
            {


               // materialLabel5.Text = "在线人数：" + serverTools.getUserCount();
                if (server.connection_status != "")
                {

                    var json = JsonHelper.server_local_interactive_deserialization(server.connection_status);
                    switch (json.type)
                    {
                        case "start":
                            txtLog.Text += "服务器已启动\r\n";
                            break;
                        case "error":

                            break;
                        case "discon":

                            txtLog.Text += "[" + json.IPPort + "]" + json.account + "已断开\r\n";
                            login_information.userLogin(json.account, json.IPPort, "resign");
                            break;
                        default:
                            txtLog.Text += "[" + json.IPPort + "]" + json.account + json.msg+"\r\n";
                            break;
                    }

                }
                server.connection_status = "";
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

                var myMsg = JsonHelper.server_serialization("PersonalLetter", richTextBox2.Text);
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
                var myMsg = JsonHelper.server_serialization("GlobalMessage", richTextBox1.Text);
                server.Send(JsonHelper.server_local_interactive_serialization(IPport, myMsg));
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (condition == "start")
            {
                server.Stop();
                condition = "stop";
                materialLabel2.Text = "服务器状态：未运行";

            }
        }


        async Task login()
        {

            try
            {
                serverIP = IPTB.Text;

                serverPort = int.Parse(PortTB.Text);
                server = new ServerControl();
                server.Start(IPTB.Text, int.Parse(PortTB.Text));
                materialLabel2.Text = "服务器状态：已启动";
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
            var list = serverTools.getUserList();
            usersLB.Items.Clear();
            foreach (var item in list)
            {

                usersLB.Items.Add(item);
            }

            materialLabel5.Text = " 在线人数：" + list.Length.ToString();
            materialLabel1.Text = "上次刷新：\r\n" + DateTime.Now.ToString();

            if (condition == "start")
            {

                
                
                txtLog.Text += "服务器正在运行\r\n";
            }
            else
            {
                condition = "start";
                serverTools.createKeydata();
                login();
            }

        }


        public static bool Delay(int delayTime)
        {
            DateTime now = DateTime.Now;
            int s;
            do
            {
                TimeSpan spand = DateTime.Now - now;
                s = spand.Seconds;
                Application.DoEvents();
            }
            while (s < delayTime);
            return true;
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            string today = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day;
            dataTools data = new dataTools(configClass.databaseip, configClass.databaseusername, "keydata", configClass.databaseport, configClass.psw);
            dataGridView1.DataSource = data.getTable(today);
            data.conMySql(configClass.databaseip, configClass.databaseusername, "login_information", configClass.databaseport, configClass.psw);
            dataGridView2.DataSource = data.getTable(today);


        }

        private void ServerMainForm_SizeChanged(object sender, EventArgs e)
        {
            sizeChange();
        }
        void sizeChange()
        {
            splitContainer1.Top = tabPage8.Height - splitContainer1.Height - 20;
            splitContainer2.Width = tabPage8.Width-10;
            materialTabControl4.Width = this.Width - 10;
            materialTabControl4.Height = this.Height - materialTabControl4.Top - 5;
            materialTabControl1.Width = tabPage10.Width;

            materialTabControl1.Height = tabPage10.Height - materialTabControl1.Top - 5;
            splitContainer1.Width = tabPage8.Width - splitContainer1.Left * 2;
        }

        private void ServerMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataTools data = new dataTools(configClass.databaseip, configClass.databaseusername, "keydata", configClass.databaseport, configClass.psw);

            string today = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day;
            data.deleteTable(today);
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            var list = serverTools.getUserList();
            usersLB.Items.Clear();
            foreach (var item in list)
            {

                usersLB.Items.Add(item);
            }
            materialLabel5.Text = " 在线人数：" + list.Length.ToString();
            materialLabel1.Text = "上次刷新：\r\n" + DateTime.Now.ToString();
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            msgrtb.Text = "";
            string[] database = new string[] { "friends", "keydata", "login_information", "talkdata" ,"aaadata"};

            dataTools data = new dataTools(configClass.databaseip, configClass.databaseusername, "information_schema", configClass.databaseport, configClass.psw);

            addMsg(new msg() { tip = "tip", thismsg = "正在检查数据库完整性" }, msgrtb);

            foreach (var item in database)
            {
                addMsg(new msg() { tip = "tip", thismsg = "检查 \'"+item+"'是否存在" }, msgrtb);
                object count=null;
                try
                {
                    count = data.searchListCount("schemata", new string[] { "SCHEMA_NAME" }, new string[] { item }).msg;
                if ((int)count != 0)
                {

                    addMsg(new msg() { tip = "success", thismsg = "存在" }, msgrtb);
                }
                else 
                {

                    addMsg(new msg() { tip = "tip", thismsg = "不存在，正在新建'"+item+"'数据库" }, msgrtb);
                    data = new dataTools(configClass.databaseip, configClass.databaseusername, configClass.databaseport, configClass.psw);
                   count= data.createDataBase(item);

                    addMsg(new msg() { tip = "success", thismsg = "新建'"+item+"'数据库成功" }, msgrtb);

                     data = new dataTools(configClass.databaseip, configClass.databaseusername, "information_schema", configClass.databaseport, configClass.psw);
                }
                }
                catch (Exception)
                {

                    addMsg(new msg() { tip = "error", thismsg = "错误:" + count.ToString() }, msgrtb);

                    addMsg(new msg() { tip = "error", thismsg = "修复失败，请检测MySQL服务器是否开启,服务器密码是否为正确" }, msgrtb);
                    return;
                }
            }


            addMsg(new msg() { tip = "success", thismsg = "修复成功" }, msgrtb);
        }
        void addMsg(msg data, RichTextBox _msgrtb)
        {
            switch (data.tip)
            {
                case "error":

                    LogAppend(Color.Red, data.tip + " : ", _msgrtb);
                    break;
                case "success":
                    
                    LogAppend(Color.Green, data.tip + " : ", _msgrtb);
                    break;

                case "tip":
                    
                    LogAppend(Color.Yellow, data.tip + " : ", _msgrtb);
                    break;
                default:
                    break;
            }


            LogAppend(Color.Gray, data.thismsg + "\r\n", _msgrtb);
        }
         void LogAppend(Color color, string text,RichTextBox _msgrtb)
        {
            _msgrtb.SelectionColor = color;
            _msgrtb.AppendText(text);
        }


         class msg
         {
             public string tip;
             public string thismsg;
         }

         private void materialRaisedButton8_Click(object sender, EventArgs e)
         {
             if (usernametb.Text == "" ||
                userpswtb.Text == "" ||
                mailtb.Text == "")
             {
                 MessageBox.Show("输入框不能为空");
                 return;
             }

             var data = new dataTools(configClass.databaseip, configClass.databaseusername, "jim", configClass.databaseport, configClass.psw);
             data.insert("user", new string[] {"username", "userpsw","usermail"}, new string[] { usernametb.Text,userpswtb.Text,mailtb.Text});
             MessageBox.Show("添加成功");
         }
    }
}
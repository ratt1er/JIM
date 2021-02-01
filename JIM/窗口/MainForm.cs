using MaterialSkin.Controls;
using reply_entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using tools;
namespace JIM.窗口
{
    public partial class MainForm : MaterialForm
    {
        public Thread threadAccept;

        ClientControl client;
        string username;
        string key;
        List<msgClass> oldMsg=new List<msgClass> ();
        public MainForm(string key,string _username, ClientControl _client)
        {
            InitializeComponent();
            client = _client;
            username = _username;
            this.Text = key;
            this.key = key;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            usersLB.Items.Clear();
            var list = serverTools.getUserList("friends", username).ToArray();
            foreach (var item in list)
            {

                usersLB.Items.Add(item);
            }
            threadAccept = new Thread(Accept);
            threadAccept.IsBackground = true;
            threadAccept.Start();
            
        }
        private void Accept()
        {


            if (usersLB.SelectedItems.Count != 0)
            {
                client.Send(JsonHelper.client_msg_serialization(usersLB.SelectedItem.ToString(), "gethistory", username, "", key));
            }
            List<string> stringlist = new List<string>();
            var list=serverTools.getUserList("friends", username).ToArray();

            foreach (var item in usersLB.Items)
            {
                stringlist.Add(item.ToString());
            }
            if (!Enumerable.SequenceEqual(stringlist.ToArray(), list))
            {
                usersLB.Items.Clear();
                foreach (var item in list )
                {
                    
                    usersLB.Items.Add(item);
                }
            }
            if (client.serverMsg != "")
            {
                var sre = JsonHelper.server_deserialization(client.serverMsg);
                switch (sre.type)
                {
                    case "sethistory":
                        if (msgClass.msgEquals(oldMsg,sre.msgclass))
                        {

                            Thread.Sleep(100);
                            Accept();
                        }
                        else
                        {
                            addMsg(sre.msgclass);
                            oldMsg = sre.msgclass;
                        }
                        break;

                    case "removefriends":
                        MessageBox.Show(sre.msg);
                        break;
                    default:
                        break;
                }


                client.serverMsg = "";
            }
            
            Thread.Sleep(100);
            Accept();
        }
        void addMsg(List<msgClass> data)
        {
            msgrtb.Text = "";
            foreach (msgClass item in data)
            {
                LogAppend(Color.Blue,item.sender + " : ");
                LogAppend(Color.Yellow,item.time + "\r\n");
                LogAppend(Color.Green, item.msg + "\r\n");
            }
        }
        public void LogAppend(Color color, string text)
        {
            msgrtb.SelectionColor = color;
            msgrtb.AppendText(text);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (usersLB.Items.Count == 0) 
            {
                MessageBox.Show("还没有好友哦:(");
                return;
            }
            if (usersLB.SelectedItems.Count==0) 
            {
                MessageBox.Show("选择一个好友吧~");
                return;
            } 
            if (materialSingleLineTextField1.Text == "")
            {
                return;
            }

            client.Send(JsonHelper.client_msg_serialization(usersLB.SelectedItem.ToString(),"msg",username,materialSingleLineTextField1.Text,key));
            materialSingleLineTextField1.Text = "";
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            friendsForm friendform = new friendsForm(key,username,client);
            friendform.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersLB.SelectedItems.Count != 0)
            {

                oldMsg = new List<msgClass>();
                client.Send(JsonHelper.client_msg_serialization(usersLB.SelectedItem.ToString(), "gethistory", username, "", key));
            }
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            if (usersLB.SelectedItems.Count != 0)
            {
                client.Send(JsonHelper.client_msg_serialization(usersLB.SelectedItem.ToString(), "removefriends", username, "", key));
            }
        }
    }
}

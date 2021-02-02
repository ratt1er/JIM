using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using tools;
namespace JIM.窗口
{
    public partial class friendsForm : MaterialForm
    {
        ClientControl client;

        public Thread threadAccept;
        string username;
        string key;
        public friendsForm(string _key, string _username, ClientControl _client)
        {
            client = _client;
            key = _key;
            username = _username;
            InitializeComponent();

        }

        private void friendsForm_Load(object sender, EventArgs e)
        {
            threadAccept = new Thread(Accept);
            threadAccept.IsBackground = true;
            threadAccept.Start();
        }
        private void Accept()
        {
            if (client.serverMsg != "")
            {
                var sre = JsonHelper.server_deserialization(client.serverMsg);
                switch (sre.type)
                {
                    case"searchfriends":

                        foreach (var item in sre.list)
                        {

                            listBox1.Items.Add(item);
                        }
                        break;
                    case "addfriends":
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

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            client.Send(JsonHelper.client_msg_serialization("server","searchfriends",username,materialSingleLineTextField1.Text,key));
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            string addusername = listBox1.SelectedItem.ToString();
           addusername= addusername.Split('[')[1].Split(']')[0];
            client.Send(JsonHelper.client_msg_serialization("server", "addfriends", username, addusername, key));
        }
    }
}

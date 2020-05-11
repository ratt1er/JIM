using MySQLHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
namespace JIM
{
    public partial class talkForm : MaterialForm
    {
        string username;
        int talkcount;
        public talkForm()
        {
            InitializeComponent();
        }

        private void talkForm_Load(object sender, EventArgs e)
        {
            msgtb.Focus();
            sizeChange();
            MySQLHelperClass.connectionString = "server = localhost; user = root; database = talkdata; port = 3306; password = thisisjim1!";
          var dataTable= MySQLHelperClass.ExecuteDataTable("show tables");
        
           string today =  DateTime.Now.Year.ToString()+"_" + DateTime.Now.Month+"_" + DateTime.Now.Day;
           foreach (DataRow item in MySQLHelperClass.ExecuteDataTable("show tables").Rows)
           {
               if (item[0].ToString() == today)
               {

                  addMsg(MySQLHelperClass.ExecuteDataTable("select * from " + today));
               }
           }
           talkcount = MySQLHelperClass.ExecuteDataTable("select * from " + today).Rows.Count;
           timer1.Start();
        }
        public talkForm(string _username)
        {
            InitializeComponent();

            username= _username;
            this.Text = "你好，" + username;
        }

        private void sendbt_Click(object sender, EventArgs e)
        {
            sendMsg();

        }void sendMsg() 
        {
            if (msgtb.Text == "") return;
            string today = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day;
            foreach (DataRow item in MySQLHelperClass.ExecuteDataTable("show tables").Rows)
            {
                if (item[0].ToString() == today)
                {
                    MySQLHelperClass.ExecuteNonQuery("INSERT INTO " + today + " (username,talkdata, talkdate) VALUES ('" +
                   username + "','" +
                   msgtb.Text + "','" +
                   DateTime.Now + "')");
                    msgtb.Text = "";
                    return;
                }
            }
            var str =
              "CREATE TABLE " + today + "(id INT NOT NULL AUTO_INCREMENT, username VARCHAR(100) NOT NULL, talkdata VARCHAR(100) NOT NULL,talkdate DateTime,PRIMARY KEY ( id ))ENGINE=InnoDB DEFAULT CHARSET=utf8; ";
            MySQLHelperClass.ExecuteNonQuery(str);


            MySQLHelperClass.ExecuteNonQuery("INSERT INTO " + today + " (username,talkdata, talkdate) VALUES ('" +
                    username + "','" +
                    msgtb.Text + "','" +
                    DateTime.Now + "')");

            msgtb.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             string today =  DateTime.Now.Year.ToString()+"_" + DateTime.Now.Month+"_" + DateTime.Now.Day;
             var rows = MySQLHelperClass.ExecuteDataTable("select * from " + today).Rows;
             if (rows.Count > talkcount) 
             {

                 addMsg(MySQLHelperClass.ExecuteDataTable("select * from "+
                     today+
                     " order by id limit " + 
                     talkcount.ToString() + 
                     "," + 
                     (rows.Count - talkcount).ToString()
                     + ";"));
                 talkcount = rows.Count;
             }

        }

        private void msgrtb_TextChanged(object sender, EventArgs e)
        {
            msgrtb.SelectionStart = msgrtb.Text.Length;

            msgrtb.ScrollToCaret(); 
        }
        void addMsg(DataTable data)
        {
            foreach (DataRow item in data.Rows)
            {
                LogAppend(Color.Blue, item[1]+" : ");
                LogAppend(Color.Yellow, item[3] + "\r\n");
                LogAppend(Color.Green, item[2] + "\r\n");
            }
        }
        public void LogAppend(Color color, string text)
        {
            msgrtb.SelectionColor = color;
            msgrtb.AppendText(text);
        }

        private void talkForm_SizeChanged(object sender, EventArgs e)
        {
            sizeChange();
        }
        void sizeChange()
        {
            splitContainer1.Width = this.Width - 6;
            splitContainer1.Height = this.Height-70;
            sendbt.Left = msgrtb.Right - sendbt.Width;
            sendbt.Top = splitContainer1.Panel2.Height-40;
            msgtb.Width = splitContainer1.Panel2.Width -sendbt.Width - 30;
            msgtb.Height = splitContainer1.Panel2.Height-15;
        
        }


        private void splitContainer1_Panel2_SizeChanged(object sender, EventArgs e)
        {
            sizeChange();
        }


        private void msgtb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Modifiers.CompareTo(Keys.Control) == 0 && e.KeyCode == Keys.Enter)
            {
                sendMsg();
            }
        }

        private void talkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

    }
}

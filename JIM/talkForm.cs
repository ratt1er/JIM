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

namespace JIM
{
    public partial class talkForm : Form
    {
        string username;
        public talkForm()
        {
            InitializeComponent();
        }

        private void talkForm_Load(object sender, EventArgs e)
        {

            MySQLHelperClass.connectionString = "server = localhost; user = root; database = talkdata; port = 3306; password = thisisjim1!";
          var dataTable= MySQLHelperClass.ExecuteDataTable("show tables");
        
           string today =  DateTime.Now.Year.ToString()+"_" + DateTime.Now.Month+"_" + DateTime.Now.Day;
           foreach (DataRow item in MySQLHelperClass.ExecuteDataTable("show tables").Rows)
           {
               if (item[0].ToString() == today)
               {

                   foreach (DataRow itemb in MySQLHelperClass.ExecuteDataTable("select * from " + today).Rows)
                   {
                       msgrtb.Text += itemb[1] + ": " + itemb[3] + "\r\n" + itemb[2] + "\r\n";   
                   }

               }
           }
        }
        public talkForm(string _username)
        {
            InitializeComponent();

            username= _username;
            this.Text = "你好" + username;
        }

        private void sendbt_Click(object sender, EventArgs e)
        {

            string today =  DateTime.Now.Year.ToString()+"_" + DateTime.Now.Month+"_" + DateTime.Now.Day;
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

    }
}

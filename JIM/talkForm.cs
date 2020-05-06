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

            MySQLHelperClass.connectionString = "server = localhost; user = root; database = jim; port = 3306; password = thisisjim1!";
          var dataTable= MySQLHelperClass.ExecuteDataTable("SELECT * FROM talkdata WHERE date(talkdate) = curdate();");
        
            foreach (DataRow item in dataTable.Rows)
          {
              msgrtb.Text += item[0] + ": " + item[2] + "\r\n" + item[1]+"\r\ns";
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
            MySQLHelperClass.ExecuteNonQuery("INSERT INTO talkdata (username,usertalk, talkdate) VALUES ('" + 
                username + "','" +
                msgtb.Text  + "','" + 
                DateTime.Now.ToString() + "')");
            msgtb.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var b = MySQLHelperClass.ExecuteScalar("SELECT LAST_INSERT_ID();");
        }
    }
}

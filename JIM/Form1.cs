using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQLHelper;
namespace JIM
{
    public partial class Form1 : Form
    {
        string code="code";
        public Form1()
        {
            InitializeComponent();
            MySQLHelperClass.connectionString = "server = localhost; user = root; database = jim; port = 3306; password = thisisjim1!";

        }

        private void lbt_Click(object sender, EventArgs e)
        {
            // dataGridView1.DataSource= MySQerClass.ExecuteDataTable("select * from user;");

            if (MySQLHelperClass.ExecuteScalar("select * from user where username='" + lusernametb.Text + "' and userpsw='" + luserpswtb.Text + "'") == null)
            {
                message("账号密码不匹配");
            }
            else 
            {
                message("登录成功");
            }


        }

        private void rebt_Click(object sender, EventArgs e)
        {

            if (rusernametb.Text == "" || 
                ruserpswtb.Text == "" || 
                rerpswtb.Text == "" || 
                mailCodetb.Text == ""||
                rmailtb.Text=="") 
            {
                message("输入框不能为空");
                return;
            }
            if ( rerpswtb.Text != ruserpswtb.Text)
            {
                message("两次密码不匹配！");
                return;
            } if (mailCodetb.Text != code) 
            {
                message("验证码不匹配");
                return;
            }
            if (MySQLHelperClass.ExecuteScalar("SELECT * from user WHERE usermail='" + rmailtb.Text + "';") != null)
            {
                message("邮箱已存在");
                return;
            }
            try
            {
                MySQLHelperClass.ExecuteNonQuery("INSERT INTO user (username,usermail, userpsw) VALUES ('" + rusernametb.Text + "','" + rmailtb.Text + "','" + ruserpswtb.Text + "')");
                message("注册成功");
                if (lusernametb.Text == "" && luserpswtb.Text == "") {
                    lusernametb.Text = rusernametb.Text;
                    luserpswtb.Text = ruserpswtb.Text;
                    lartc.SelectedIndex = 0;
                }
                rusernametb.Text = ""; 
                ruserpswtb.Text = "";
                rerpswtb.Text = ""; 
                mailCodetb.Text = "";
                rmailtb.Text = "";
            }
            catch (Exception ee)
            {
                message(ee.Message);
            }
            
        }
        void message(string msg)
        {
            MessageBox.Show(msg);
        }

        private void sendCodebt_Click(object sender, EventArgs e)
        {
            var msg = mailClass.send("from_china@163.com");
            MessageBox.Show(msg[0]);
            code = msg[1];
        }
    }
}

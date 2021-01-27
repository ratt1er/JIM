using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tools;
namespace JIM
{
    public partial class RegisterForm : MaterialForm
    {
        string code = "code";
        public RegisterForm()
        {
            InitializeComponent();
       //     MySQLHelperClass.connectionString = "server = localhost; user = root; database = jim; port = 3306; password = thisisjim1!";

        }


        private void rebt_Click(object sender, EventArgs e)
        {
            if (rusernametb.Text == "" ||
                 ruserpswtb.Text == "" ||
                 rerpswtb.Text == "" ||
                 mailCodetb.Text == "" ||
                 rmailtb.Text == "")
            {
                message("输入框不能为空");
                return;
            }
            if (rerpswtb.Text != ruserpswtb.Text)
            {
                message("两次密码不匹配！");
                return;
            } if (mailCodetb.Text != code)
            {
                message("验证码不匹配");
                return;
            }
            if (MySQLHelperClass.ExecuteScalar("SELECT * from user WHERE username='" + rusernametb.Text + "';") != null)
            {
                message("用户名");
                return;
            }
            try
            {
                MySQLHelperClass.ExecuteNonQuery("INSERT INTO user (username,usermail, userpsw) VALUES ('" + rusernametb.Text + "','" + rmailtb.Text + "','" + ruserpswtb.Text + "')");
                message("注册成功");
               
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
            var msg = mailClass.send(rmailtb.Text);
            MessageBox.Show(msg[0]);
            code = msg[1];
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

    }
}

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
using MaterialSkin.Controls;
namespace JIM
{
    public partial class MainForm : MaterialForm
    {
        string code="code";
        public MainForm()
        {
            InitializeComponent();
            MySQLHelperClass.connectionString = "server = localhost; user = root; database = jim; port = 3306; password = thisisjim1!";

        }

        private void lbt_Click(object sender, EventArgs e)
        {
            lbt_Click();


        }void lbt_Click() 
        {
            MySQLHelperClass.connectionString = "server = localhost; user = root; database = jim; port = 3306; password = thisisjim1!";

            if (lusernametb.Text == "" ||
                luserpswtb.Text == "")
            {
                message("输入框不能为空");
                return;
            }
            if (MySQLHelperClass.ExecuteScalar("select * from user where username='" + lusernametb.Text + "' and userpsw='" + luserpswtb.Text + "'") == null)
            {
                message("账号密码不匹配");
            }
            else
            {
                message("欢迎回来：" + lusernametb.Text);
                Hide();
                talkForm form = new talkForm(lusernametb.Text);
                form.ShowDialog();
                Show();
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

     


        private void MainForm_Load(object sender, EventArgs e)
        {
            lusernametb.Focus();
        }


        private void rebt_Click(object sender, EventArgs e)
        {
            rebt_Click();
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
                luserpswtb.Focus();
            }
        }

        private void luserpswtb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbt_Click();
            }
        }
    }
}

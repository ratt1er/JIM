using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTools;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataTools data = new dataTools("localhost","root","test",3306,"thisisjim1!");
          var a=  data.searchListCount("testtable", new string[] { "name","psw","mail" }, new string[] { "root","toor" ,"m"}).msg;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataTools data = new dataTools("localhost", "root", "test", 3306, "thisisjim1!");
            var a = data.insert("ccc", new string[] { "name", "psw", "mail" }, new string[] { "a", "b", "c" }).msg;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             dataTools data = new dataTools("localhost", "root", "test", 3306, "thisisjim1!");
             var a = data.delete("testtable", new string[] { "name" },new string[]{"a"});
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataTools data = new dataTools("localhost", "root", "test", 3306, "thisisjim1!");
            var a = data.update("testtable", new string[] { "name", "at", "psw","123at"});
        }
    }
}

﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JIM.窗口
{
    public partial class MainForm : MaterialForm
    {
        public MainForm(string key)
        {
            InitializeComponent();
            this.Text = key;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

namespace JIM
{
    partial class ClientMainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.registerBt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.loginStatusTbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.loginPasswordTbl = new MaterialSkin.Controls.MaterialLabel();
            this.loginAccountTbl = new MaterialSkin.Controls.MaterialLabel();
            this.loginAccountTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginPasswordTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ipTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.portTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBt
            // 
            this.loginBt.AutoSize = true;
            this.loginBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginBt.Depth = 0;
            this.loginBt.Font = new System.Drawing.Font("宋体", 9F);
            this.loginBt.Icon = null;
            this.loginBt.Location = new System.Drawing.Point(19, 81);
            this.loginBt.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBt.Name = "loginBt";
            this.loginBt.Primary = true;
            this.loginBt.Size = new System.Drawing.Size(51, 36);
            this.loginBt.TabIndex = 4;
            this.loginBt.Text = "登录";
            this.loginBt.UseVisualStyleBackColor = true;
            this.loginBt.Click += new System.EventHandler(this.lbt_Click);
            // 
            // registerBt
            // 
            this.registerBt.AutoSize = true;
            this.registerBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerBt.Depth = 0;
            this.registerBt.Font = new System.Drawing.Font("宋体", 9F);
            this.registerBt.Icon = null;
            this.registerBt.Location = new System.Drawing.Point(233, 81);
            this.registerBt.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerBt.Name = "registerBt";
            this.registerBt.Primary = true;
            this.registerBt.Size = new System.Drawing.Size(51, 36);
            this.registerBt.TabIndex = 38;
            this.registerBt.Text = "注册";
            this.registerBt.UseVisualStyleBackColor = true;
            this.registerBt.Click += new System.EventHandler(this.rebt_Click);
            // 
            // loginStatusTbl
            // 
            this.loginStatusTbl.AutoSize = true;
            this.loginStatusTbl.Depth = 0;
            this.loginStatusTbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.loginStatusTbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginStatusTbl.Location = new System.Drawing.Point(24, 129);
            this.loginStatusTbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginStatusTbl.Name = "loginStatusTbl";
            this.loginStatusTbl.Size = new System.Drawing.Size(41, 19);
            this.loginStatusTbl.TabIndex = 40;
            this.loginStatusTbl.Text = "你好";
            this.loginStatusTbl.Click += new System.EventHandler(this.loginStatusTbl_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 66);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(308, 180);
            this.materialTabControl1.TabIndex = 45;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialRaisedButton1);
            this.tabPage1.Controls.Add(this.loginPasswordTbl);
            this.tabPage1.Controls.Add(this.loginAccountTbl);
            this.tabPage1.Controls.Add(this.loginAccountTb);
            this.tabPage1.Controls.Add(this.loginBt);
            this.tabPage1.Controls.Add(this.loginStatusTbl);
            this.tabPage1.Controls.Add(this.registerBt);
            this.tabPage1.Controls.Add(this.loginPasswordTb);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(300, 153);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "首页";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("宋体", 9F);
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(176, 81);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(51, 36);
            this.materialRaisedButton1.TabIndex = 48;
            this.materialRaisedButton1.Text = "退出";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // loginPasswordTbl
            // 
            this.loginPasswordTbl.AutoSize = true;
            this.loginPasswordTbl.Depth = 0;
            this.loginPasswordTbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.loginPasswordTbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginPasswordTbl.Location = new System.Drawing.Point(24, 49);
            this.loginPasswordTbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginPasswordTbl.Name = "loginPasswordTbl";
            this.loginPasswordTbl.Size = new System.Drawing.Size(41, 19);
            this.loginPasswordTbl.TabIndex = 47;
            this.loginPasswordTbl.Text = "密码";
            // 
            // loginAccountTbl
            // 
            this.loginAccountTbl.AutoSize = true;
            this.loginAccountTbl.Depth = 0;
            this.loginAccountTbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.loginAccountTbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginAccountTbl.Location = new System.Drawing.Point(24, 15);
            this.loginAccountTbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginAccountTbl.Name = "loginAccountTbl";
            this.loginAccountTbl.Size = new System.Drawing.Size(41, 19);
            this.loginAccountTbl.TabIndex = 46;
            this.loginAccountTbl.Text = "账号";
            // 
            // loginAccountTb
            // 
            this.loginAccountTb.Depth = 0;
            this.loginAccountTb.Hint = "";
            this.loginAccountTb.Location = new System.Drawing.Point(93, 15);
            this.loginAccountTb.MaxLength = 32767;
            this.loginAccountTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginAccountTb.Name = "loginAccountTb";
            this.loginAccountTb.PasswordChar = '\0';
            this.loginAccountTb.SelectedText = "";
            this.loginAccountTb.SelectionLength = 0;
            this.loginAccountTb.SelectionStart = 0;
            this.loginAccountTb.Size = new System.Drawing.Size(191, 23);
            this.loginAccountTb.TabIndex = 45;
            this.loginAccountTb.TabStop = false;
            this.loginAccountTb.Text = "root";
            this.loginAccountTb.UseSystemPasswordChar = false;
            // 
            // loginPasswordTb
            // 
            this.loginPasswordTb.Depth = 0;
            this.loginPasswordTb.Font = new System.Drawing.Font("宋体", 9F);
            this.loginPasswordTb.Hint = "";
            this.loginPasswordTb.Location = new System.Drawing.Point(93, 49);
            this.loginPasswordTb.MaxLength = 32767;
            this.loginPasswordTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginPasswordTb.Name = "loginPasswordTb";
            this.loginPasswordTb.PasswordChar = '*';
            this.loginPasswordTb.SelectedText = "";
            this.loginPasswordTb.SelectionLength = 0;
            this.loginPasswordTb.SelectionStart = 0;
            this.loginPasswordTb.Size = new System.Drawing.Size(191, 23);
            this.loginPasswordTb.TabIndex = 37;
            this.loginPasswordTb.TabStop = false;
            this.loginPasswordTb.Text = "toor";
            this.loginPasswordTb.UseSystemPasswordChar = false;
            this.loginPasswordTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.luserpswtb_KeyUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Controls.Add(this.ipTb);
            this.tabPage2.Controls.Add(this.portTb);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(300, 153);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(18, 77);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(102, 19);
            this.materialLabel3.TabIndex = 50;
            this.materialLabel3.Text = "本地IP：未知";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(18, 56);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 19);
            this.materialLabel1.TabIndex = 49;
            this.materialLabel1.Text = "端口";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(18, 22);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 19);
            this.materialLabel2.TabIndex = 48;
            this.materialLabel2.Text = "服务器IP";
            // 
            // ipTb
            // 
            this.ipTb.Depth = 0;
            this.ipTb.Hint = "";
            this.ipTb.Location = new System.Drawing.Point(94, 22);
            this.ipTb.MaxLength = 32767;
            this.ipTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.ipTb.Name = "ipTb";
            this.ipTb.PasswordChar = '\0';
            this.ipTb.SelectedText = "";
            this.ipTb.SelectionLength = 0;
            this.ipTb.SelectionStart = 0;
            this.ipTb.Size = new System.Drawing.Size(191, 23);
            this.ipTb.TabIndex = 47;
            this.ipTb.TabStop = false;
            this.ipTb.Text = "127.0.0.1";
            this.ipTb.UseSystemPasswordChar = false;
            // 
            // portTb
            // 
            this.portTb.Depth = 0;
            this.portTb.Font = new System.Drawing.Font("宋体", 9F);
            this.portTb.Hint = "";
            this.portTb.Location = new System.Drawing.Point(94, 51);
            this.portTb.MaxLength = 32767;
            this.portTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.portTb.Name = "portTb";
            this.portTb.PasswordChar = '\0';
            this.portTb.SelectedText = "";
            this.portTb.SelectionLength = 0;
            this.portTb.SelectionStart = 0;
            this.portTb.Size = new System.Drawing.Size(191, 23);
            this.portTb.TabIndex = 46;
            this.portTb.TabStop = false;
            this.portTb.Text = "10086";
            this.portTb.UseSystemPasswordChar = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 41);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(223, 23);
            this.materialTabSelector1.TabIndex = 44;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // ClientMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 248);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximizeBox = false;
            this.Name = "ClientMainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton loginBt;
        private MaterialSkin.Controls.MaterialRaisedButton registerBt;
        private MaterialSkin.Controls.MaterialLabel loginStatusTbl;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginAccountTb;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginPasswordTb;
        private MaterialSkin.Controls.MaterialLabel loginPasswordTbl;
        private MaterialSkin.Controls.MaterialLabel loginAccountTbl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField ipTb;
        private MaterialSkin.Controls.MaterialSingleLineTextField portTb;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}


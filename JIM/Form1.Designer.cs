namespace JIM
{
    partial class Form1
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
            this.lartc = new System.Windows.Forms.TabControl();
            this.ltb = new System.Windows.Forms.TabPage();
            this.lbt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.luserpsswdtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lusernametb = new System.Windows.Forms.TextBox();
            this.rtb = new System.Windows.Forms.TabPage();
            this.rebt = new System.Windows.Forms.Button();
            this.sendCodebt = new System.Windows.Forms.Button();
            this.codetb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rmailtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rruserpsswdtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ruserpsswdtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rusernametb = new System.Windows.Forms.TextBox();
            this.lartc.SuspendLayout();
            this.ltb.SuspendLayout();
            this.rtb.SuspendLayout();
            this.SuspendLayout();
            // 
            // lartc
            // 
            this.lartc.Controls.Add(this.ltb);
            this.lartc.Controls.Add(this.rtb);
            this.lartc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lartc.Location = new System.Drawing.Point(0, 0);
            this.lartc.Name = "lartc";
            this.lartc.SelectedIndex = 0;
            this.lartc.Size = new System.Drawing.Size(342, 330);
            this.lartc.TabIndex = 0;
            // 
            // ltb
            // 
            this.ltb.Controls.Add(this.lbt);
            this.ltb.Controls.Add(this.label2);
            this.ltb.Controls.Add(this.luserpsswdtb);
            this.ltb.Controls.Add(this.label1);
            this.ltb.Controls.Add(this.lusernametb);
            this.ltb.Location = new System.Drawing.Point(4, 22);
            this.ltb.Name = "ltb";
            this.ltb.Padding = new System.Windows.Forms.Padding(3);
            this.ltb.Size = new System.Drawing.Size(334, 304);
            this.ltb.TabIndex = 0;
            this.ltb.Text = "登录";
            this.ltb.UseVisualStyleBackColor = true;
            // 
            // lbt
            // 
            this.lbt.Font = new System.Drawing.Font("宋体", 13F);
            this.lbt.Location = new System.Drawing.Point(240, 269);
            this.lbt.Name = "lbt";
            this.lbt.Size = new System.Drawing.Size(75, 27);
            this.lbt.TabIndex = 1;
            this.lbt.Text = "登录";
            this.lbt.UseVisualStyleBackColor = true;
            this.lbt.Click += new System.EventHandler(this.lbt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13F);
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // luserpsswdtb
            // 
            this.luserpsswdtb.Font = new System.Drawing.Font("宋体", 13F);
            this.luserpsswdtb.Location = new System.Drawing.Point(56, 56);
            this.luserpsswdtb.Multiline = true;
            this.luserpsswdtb.Name = "luserpsswdtb";
            this.luserpsswdtb.PasswordChar = '密';
            this.luserpsswdtb.Size = new System.Drawing.Size(259, 32);
            this.luserpsswdtb.TabIndex = 2;
            this.luserpsswdtb.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "账号";
            // 
            // lusernametb
            // 
            this.lusernametb.Font = new System.Drawing.Font("宋体", 13F);
            this.lusernametb.Location = new System.Drawing.Point(56, 14);
            this.lusernametb.Multiline = true;
            this.lusernametb.Name = "lusernametb";
            this.lusernametb.Size = new System.Drawing.Size(259, 32);
            this.lusernametb.TabIndex = 0;
            // 
            // rtb
            // 
            this.rtb.Controls.Add(this.rebt);
            this.rtb.Controls.Add(this.sendCodebt);
            this.rtb.Controls.Add(this.codetb);
            this.rtb.Controls.Add(this.label7);
            this.rtb.Controls.Add(this.rmailtb);
            this.rtb.Controls.Add(this.label6);
            this.rtb.Controls.Add(this.rruserpsswdtb);
            this.rtb.Controls.Add(this.label5);
            this.rtb.Controls.Add(this.label3);
            this.rtb.Controls.Add(this.ruserpsswdtb);
            this.rtb.Controls.Add(this.label4);
            this.rtb.Controls.Add(this.rusernametb);
            this.rtb.Location = new System.Drawing.Point(4, 22);
            this.rtb.Name = "rtb";
            this.rtb.Padding = new System.Windows.Forms.Padding(3);
            this.rtb.Size = new System.Drawing.Size(334, 304);
            this.rtb.TabIndex = 1;
            this.rtb.Text = "注册";
            this.rtb.UseVisualStyleBackColor = true;
            // 
            // rebt
            // 
            this.rebt.Font = new System.Drawing.Font("宋体", 13F);
            this.rebt.Location = new System.Drawing.Point(222, 266);
            this.rebt.Name = "rebt";
            this.rebt.Size = new System.Drawing.Size(75, 30);
            this.rebt.TabIndex = 15;
            this.rebt.Text = "注册";
            this.rebt.UseVisualStyleBackColor = true;
            // 
            // sendCodebt
            // 
            this.sendCodebt.Font = new System.Drawing.Font("宋体", 13F);
            this.sendCodebt.Location = new System.Drawing.Point(222, 194);
            this.sendCodebt.Name = "sendCodebt";
            this.sendCodebt.Size = new System.Drawing.Size(75, 30);
            this.sendCodebt.TabIndex = 14;
            this.sendCodebt.Text = "发送";
            this.sendCodebt.UseVisualStyleBackColor = true;
            // 
            // codetb
            // 
            this.codetb.Font = new System.Drawing.Font("宋体", 13F);
            this.codetb.Location = new System.Drawing.Point(114, 192);
            this.codetb.Name = "codetb";
            this.codetb.PasswordChar = '密';
            this.codetb.Size = new System.Drawing.Size(89, 27);
            this.codetb.TabIndex = 13;
            this.codetb.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 13F);
            this.label7.Location = new System.Drawing.Point(28, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "验证码";
            // 
            // rmailtb
            // 
            this.rmailtb.Font = new System.Drawing.Font("宋体", 13F);
            this.rmailtb.Location = new System.Drawing.Point(114, 155);
            this.rmailtb.Name = "rmailtb";
            this.rmailtb.PasswordChar = '密';
            this.rmailtb.Size = new System.Drawing.Size(201, 27);
            this.rmailtb.TabIndex = 11;
            this.rmailtb.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 13F);
            this.label6.Location = new System.Drawing.Point(28, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "邮箱";
            // 
            // rruserpsswdtb
            // 
            this.rruserpsswdtb.Font = new System.Drawing.Font("宋体", 13F);
            this.rruserpsswdtb.Location = new System.Drawing.Point(114, 117);
            this.rruserpsswdtb.Multiline = true;
            this.rruserpsswdtb.Name = "rruserpsswdtb";
            this.rruserpsswdtb.PasswordChar = '密';
            this.rruserpsswdtb.Size = new System.Drawing.Size(201, 32);
            this.rruserpsswdtb.TabIndex = 9;
            this.rruserpsswdtb.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 13F);
            this.label5.Location = new System.Drawing.Point(28, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "重复密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13F);
            this.label3.Location = new System.Drawing.Point(28, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "密码";
            // 
            // ruserpsswdtb
            // 
            this.ruserpsswdtb.Font = new System.Drawing.Font("宋体", 13F);
            this.ruserpsswdtb.Location = new System.Drawing.Point(114, 79);
            this.ruserpsswdtb.Multiline = true;
            this.ruserpsswdtb.Name = "ruserpsswdtb";
            this.ruserpsswdtb.PasswordChar = '密';
            this.ruserpsswdtb.Size = new System.Drawing.Size(201, 32);
            this.ruserpsswdtb.TabIndex = 6;
            this.ruserpsswdtb.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13F);
            this.label4.Location = new System.Drawing.Point(28, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "账号";
            // 
            // rusernametb
            // 
            this.rusernametb.Font = new System.Drawing.Font("宋体", 13F);
            this.rusernametb.Location = new System.Drawing.Point(114, 37);
            this.rusernametb.Name = "rusernametb";
            this.rusernametb.Size = new System.Drawing.Size(201, 27);
            this.rusernametb.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 330);
            this.Controls.Add(this.lartc);
            this.Name = "Form1";
            this.Text = "JML";
            this.lartc.ResumeLayout(false);
            this.ltb.ResumeLayout(false);
            this.ltb.PerformLayout();
            this.rtb.ResumeLayout(false);
            this.rtb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl lartc;
        private System.Windows.Forms.TabPage ltb;
        private System.Windows.Forms.Button lbt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox luserpsswdtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lusernametb;
        private System.Windows.Forms.TabPage rtb;
        private System.Windows.Forms.Button rebt;
        private System.Windows.Forms.Button sendCodebt;
        private System.Windows.Forms.TextBox codetb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rmailtb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rruserpsswdtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ruserpsswdtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rusernametb;
    }
}


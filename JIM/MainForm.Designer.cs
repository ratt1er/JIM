namespace JIM
{
    partial class MainForm
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
            this.lbt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lusernametb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.luserpswtb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rebt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lbt
            // 
            this.lbt.AutoSize = true;
            this.lbt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lbt.Depth = 0;
            this.lbt.Font = new System.Drawing.Font("宋体", 9F);
            this.lbt.Icon = null;
            this.lbt.Location = new System.Drawing.Point(199, 173);
            this.lbt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbt.Name = "lbt";
            this.lbt.Primary = true;
            this.lbt.Size = new System.Drawing.Size(51, 36);
            this.lbt.TabIndex = 4;
            this.lbt.Text = "登录";
            this.lbt.UseVisualStyleBackColor = true;
            this.lbt.Click += new System.EventHandler(this.lbt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("宋体", 13F);
            this.label2.Location = new System.Drawing.Point(14, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.Location = new System.Drawing.Point(14, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "账号";
            // 
            // lusernametb
            // 
            this.lusernametb.Depth = 0;
            this.lusernametb.Font = new System.Drawing.Font("宋体", 9F);
            this.lusernametb.Hint = "";
            this.lusernametb.Location = new System.Drawing.Point(92, 87);
            this.lusernametb.MaxLength = 32767;
            this.lusernametb.MouseState = MaterialSkin.MouseState.HOVER;
            this.lusernametb.Name = "lusernametb";
            this.lusernametb.PasswordChar = '\0';
            this.lusernametb.SelectedText = "";
            this.lusernametb.SelectionLength = 0;
            this.lusernametb.SelectionStart = 0;
            this.lusernametb.Size = new System.Drawing.Size(233, 23);
            this.lusernametb.TabIndex = 36;
            this.lusernametb.TabStop = false;
            this.lusernametb.UseSystemPasswordChar = false;
            this.lusernametb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lusernametb_KeyPress);
            // 
            // luserpswtb
            // 
            this.luserpswtb.Depth = 0;
            this.luserpswtb.Font = new System.Drawing.Font("宋体", 9F);
            this.luserpswtb.Hint = "";
            this.luserpswtb.Location = new System.Drawing.Point(92, 142);
            this.luserpswtb.MaxLength = 32767;
            this.luserpswtb.MouseState = MaterialSkin.MouseState.HOVER;
            this.luserpswtb.Name = "luserpswtb";
            this.luserpswtb.PasswordChar = '*';
            this.luserpswtb.SelectedText = "";
            this.luserpswtb.SelectionLength = 0;
            this.luserpswtb.SelectionStart = 0;
            this.luserpswtb.Size = new System.Drawing.Size(233, 23);
            this.luserpswtb.TabIndex = 37;
            this.luserpswtb.TabStop = false;
            this.luserpswtb.UseSystemPasswordChar = false;
            this.luserpswtb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.luserpswtb_KeyUp);
            // 
            // rebt
            // 
            this.rebt.AutoSize = true;
            this.rebt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rebt.Depth = 0;
            this.rebt.Font = new System.Drawing.Font("宋体", 9F);
            this.rebt.Icon = null;
            this.rebt.Location = new System.Drawing.Point(266, 173);
            this.rebt.MouseState = MaterialSkin.MouseState.HOVER;
            this.rebt.Name = "rebt";
            this.rebt.Primary = true;
            this.rebt.Size = new System.Drawing.Size(51, 36);
            this.rebt.TabIndex = 38;
            this.rebt.Text = "注册";
            this.rebt.UseVisualStyleBackColor = true;
            this.rebt.Click += new System.EventHandler(this.rebt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 217);
            this.Controls.Add(this.rebt);
            this.Controls.Add(this.luserpswtb);
            this.Controls.Add(this.lusernametb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbt);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 217);
            this.MinimumSize = new System.Drawing.Size(350, 217);
            this.Name = "MainForm";
            this.Text = "JML";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton lbt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField lusernametb;
        private MaterialSkin.Controls.MaterialSingleLineTextField luserpswtb;
        private MaterialSkin.Controls.MaterialRaisedButton rebt;
    }
}


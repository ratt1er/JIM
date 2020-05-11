namespace JIM
{
    partial class talkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.msgtb = new System.Windows.Forms.TextBox();
            this.msgrtb = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sendbt = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgtb
            // 
            this.msgtb.BackColor = System.Drawing.SystemColors.Control;
            this.msgtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgtb.Font = new System.Drawing.Font("宋体", 13F);
            this.msgtb.ForeColor = System.Drawing.Color.Green;
            this.msgtb.Location = new System.Drawing.Point(12, 3);
            this.msgtb.Multiline = true;
            this.msgtb.Name = "msgtb";
            this.msgtb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.msgtb.Size = new System.Drawing.Size(329, 137);
            this.msgtb.TabIndex = 0;
            this.msgtb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.msgtb_KeyUp);
            // 
            // msgrtb
            // 
            this.msgrtb.BackColor = System.Drawing.SystemColors.InfoText;
            this.msgrtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgrtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgrtb.Font = new System.Drawing.Font("宋体", 12F);
            this.msgrtb.Location = new System.Drawing.Point(0, 0);
            this.msgrtb.Name = "msgrtb";
            this.msgrtb.ReadOnly = true;
            this.msgrtb.Size = new System.Drawing.Size(485, 158);
            this.msgrtb.TabIndex = 2;
            this.msgrtb.Text = "";
            this.msgrtb.TextChanged += new System.EventHandler(this.msgrtb_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Location = new System.Drawing.Point(3, 67);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.msgrtb);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.sendbt);
            this.splitContainer1.Panel2.Controls.Add(this.msgtb);
            this.splitContainer1.Panel2.SizeChanged += new System.EventHandler(this.splitContainer1_Panel2_SizeChanged);
            this.splitContainer1.Size = new System.Drawing.Size(485, 321);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.TabStop = false;
            // 
            // sendbt
            // 
            this.sendbt.AutoSize = true;
            this.sendbt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendbt.Depth = 0;
            this.sendbt.Icon = null;
            this.sendbt.Location = new System.Drawing.Point(413, 104);
            this.sendbt.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendbt.Name = "sendbt";
            this.sendbt.Primary = true;
            this.sendbt.Size = new System.Drawing.Size(51, 36);
            this.sendbt.TabIndex = 4;
            this.sendbt.Text = "发送";
            this.sendbt.UseVisualStyleBackColor = true;
            this.sendbt.Click += new System.EventHandler(this.sendbt_Click);
            // 
            // talkForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.splitContainer1);
            this.Name = "talkForm";
            this.Text = "talkForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.talkForm_FormClosed);
            this.Load += new System.EventHandler(this.talkForm_Load);
            this.SizeChanged += new System.EventHandler(this.talkForm_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox msgtb;
        private System.Windows.Forms.RichTextBox msgrtb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialRaisedButton sendbt;
    }
}
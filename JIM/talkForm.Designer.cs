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
            this.sendbt = new System.Windows.Forms.Button();
            this.msgtb = new System.Windows.Forms.TextBox();
            this.msgrtb = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendbt
            // 
            this.sendbt.Font = new System.Drawing.Font("宋体", 13F);
            this.sendbt.Location = new System.Drawing.Point(273, 292);
            this.sendbt.Name = "sendbt";
            this.sendbt.Size = new System.Drawing.Size(106, 37);
            this.sendbt.TabIndex = 2;
            this.sendbt.Text = "发送";
            this.sendbt.UseVisualStyleBackColor = true;
            this.sendbt.Click += new System.EventHandler(this.sendbt_Click);
            // 
            // msgtb
            // 
            this.msgtb.Font = new System.Drawing.Font("宋体", 13F);
            this.msgtb.Location = new System.Drawing.Point(12, 292);
            this.msgtb.Multiline = true;
            this.msgtb.Name = "msgtb";
            this.msgtb.Size = new System.Drawing.Size(243, 33);
            this.msgtb.TabIndex = 3;
            // 
            // msgrtb
            // 
            this.msgrtb.Font = new System.Drawing.Font("宋体", 12F);
            this.msgrtb.Location = new System.Drawing.Point(12, 12);
            this.msgrtb.Name = "msgrtb";
            this.msgrtb.Size = new System.Drawing.Size(367, 274);
            this.msgrtb.TabIndex = 4;
            this.msgrtb.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // talkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msgrtb);
            this.Controls.Add(this.msgtb);
            this.Controls.Add(this.sendbt);
            this.Name = "talkForm";
            this.Text = "talkForm";
            this.Load += new System.EventHandler(this.talkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendbt;
        private System.Windows.Forms.TextBox msgtb;
        private System.Windows.Forms.RichTextBox msgrtb;
        private System.Windows.Forms.Button button1;
    }
}
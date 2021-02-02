namespace tools
{
    partial class ServerMainForm
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
            this.startServerBt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.shutdownServerBt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.serverStatusLbe = new MaterialSkin.Controls.MaterialLabel();
            this.serverLogRtb = new System.Windows.Forms.RichTextBox();
            this.globalMsgBt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.privateMsgBt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.globalMsgRtb = new System.Windows.Forms.RichTextBox();
            this.privateMsgRtb = new System.Windows.Forms.RichTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.IPTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.currentlyOnlineTp = new System.Windows.Forms.TabPage();
            this.currentlyOnlineDgv = new System.Windows.Forms.DataGridView();
            this.logInRecordTp = new System.Windows.Forms.TabPage();
            this.logInRecordDgv = new System.Windows.Forms.DataGridView();
            this.refreshDataBt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl4 = new MaterialSkin.Controls.MaterialTabControl();
            this.ServerStatusTp = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lastRefreshLbe = new MaterialSkin.Controls.MaterialLabel();
            this.refreshUserBt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.numberOfPeopleOnlineLbe = new MaterialSkin.Controls.MaterialLabel();
            this.portTB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.onlineUsersLb = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.msgInterfaceTp = new System.Windows.Forms.TabPage();
            this.userInformationTp = new System.Windows.Forms.TabPage();
            this.databaseToolsTp = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.mailTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userpswTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.addAccountbBt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.msgrTb = new System.Windows.Forms.RichTextBox();
            this.repairServerBt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
            this.currentlyOnlineTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentlyOnlineDgv)).BeginInit();
            this.logInRecordTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logInRecordDgv)).BeginInit();
            this.materialTabControl4.SuspendLayout();
            this.ServerStatusTp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.msgInterfaceTp.SuspendLayout();
            this.userInformationTp.SuspendLayout();
            this.databaseToolsTp.SuspendLayout();
            this.SuspendLayout();
            // 
            // startServerBt
            // 
            this.startServerBt.AutoSize = true;
            this.startServerBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startServerBt.Depth = 0;
            this.startServerBt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startServerBt.Icon = null;
            this.startServerBt.Location = new System.Drawing.Point(0, 0);
            this.startServerBt.MouseState = MaterialSkin.MouseState.HOVER;
            this.startServerBt.Name = "startServerBt";
            this.startServerBt.Primary = true;
            this.startServerBt.Size = new System.Drawing.Size(204, 43);
            this.startServerBt.TabIndex = 5;
            this.startServerBt.Text = "启动服务器";
            this.startServerBt.UseVisualStyleBackColor = true;
            this.startServerBt.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // shutdownServerBt
            // 
            this.shutdownServerBt.AutoSize = true;
            this.shutdownServerBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shutdownServerBt.Depth = 0;
            this.shutdownServerBt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shutdownServerBt.Icon = null;
            this.shutdownServerBt.Location = new System.Drawing.Point(0, 0);
            this.shutdownServerBt.MouseState = MaterialSkin.MouseState.HOVER;
            this.shutdownServerBt.Name = "shutdownServerBt";
            this.shutdownServerBt.Primary = true;
            this.shutdownServerBt.Size = new System.Drawing.Size(216, 43);
            this.shutdownServerBt.TabIndex = 6;
            this.shutdownServerBt.Text = "关闭服务器";
            this.shutdownServerBt.UseVisualStyleBackColor = true;
            this.shutdownServerBt.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // serverStatusLbe
            // 
            this.serverStatusLbe.AutoSize = true;
            this.serverStatusLbe.Depth = 0;
            this.serverStatusLbe.Font = new System.Drawing.Font("Roboto", 11F);
            this.serverStatusLbe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serverStatusLbe.Location = new System.Drawing.Point(12, 89);
            this.serverStatusLbe.MouseState = MaterialSkin.MouseState.HOVER;
            this.serverStatusLbe.Name = "serverStatusLbe";
            this.serverStatusLbe.Size = new System.Drawing.Size(153, 19);
            this.serverStatusLbe.TabIndex = 7;
            this.serverStatusLbe.Text = "服务器状态：未运行";
            // 
            // serverLogRtb
            // 
            this.serverLogRtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverLogRtb.Location = new System.Drawing.Point(0, 0);
            this.serverLogRtb.Name = "serverLogRtb";
            this.serverLogRtb.Size = new System.Drawing.Size(399, 307);
            this.serverLogRtb.TabIndex = 1;
            this.serverLogRtb.Text = "";
            this.serverLogRtb.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // globalMsgBt
            // 
            this.globalMsgBt.AutoSize = true;
            this.globalMsgBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.globalMsgBt.Depth = 0;
            this.globalMsgBt.Icon = null;
            this.globalMsgBt.Location = new System.Drawing.Point(264, 7);
            this.globalMsgBt.MouseState = MaterialSkin.MouseState.HOVER;
            this.globalMsgBt.Name = "globalMsgBt";
            this.globalMsgBt.Primary = true;
            this.globalMsgBt.Size = new System.Drawing.Size(81, 36);
            this.globalMsgBt.TabIndex = 9;
            this.globalMsgBt.Text = "全局消息";
            this.globalMsgBt.UseVisualStyleBackColor = true;
            this.globalMsgBt.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // privateMsgBt
            // 
            this.privateMsgBt.AutoSize = true;
            this.privateMsgBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.privateMsgBt.Depth = 0;
            this.privateMsgBt.Icon = null;
            this.privateMsgBt.Location = new System.Drawing.Point(264, 181);
            this.privateMsgBt.MouseState = MaterialSkin.MouseState.HOVER;
            this.privateMsgBt.Name = "privateMsgBt";
            this.privateMsgBt.Primary = true;
            this.privateMsgBt.Size = new System.Drawing.Size(51, 36);
            this.privateMsgBt.TabIndex = 11;
            this.privateMsgBt.Text = "私信";
            this.privateMsgBt.UseVisualStyleBackColor = true;
            this.privateMsgBt.Click += new System.EventHandler(this.materialRaisedButton5_Click);
            // 
            // globalMsgRtb
            // 
            this.globalMsgRtb.Location = new System.Drawing.Point(11, 7);
            this.globalMsgRtb.Name = "globalMsgRtb";
            this.globalMsgRtb.Size = new System.Drawing.Size(229, 102);
            this.globalMsgRtb.TabIndex = 8;
            this.globalMsgRtb.Text = "";
            // 
            // privateMsgRtb
            // 
            this.privateMsgRtb.Location = new System.Drawing.Point(11, 115);
            this.privateMsgRtb.Name = "privateMsgRtb";
            this.privateMsgRtb.Size = new System.Drawing.Size(229, 102);
            this.privateMsgRtb.TabIndex = 10;
            this.privateMsgRtb.Text = "";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 150);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(73, 19);
            this.materialLabel3.TabIndex = 54;
            this.materialLabel3.Text = "本地端口";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 21);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(54, 19);
            this.materialLabel4.TabIndex = 53;
            this.materialLabel4.Text = "本地IP";
            // 
            // IPTb
            // 
            this.IPTb.Depth = 0;
            this.IPTb.Hint = "";
            this.IPTb.Location = new System.Drawing.Point(72, 17);
            this.IPTb.MaxLength = 32767;
            this.IPTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.IPTb.Name = "IPTb";
            this.IPTb.PasswordChar = '\0';
            this.IPTb.SelectedText = "";
            this.IPTb.SelectionLength = 0;
            this.IPTb.SelectionStart = 0;
            this.IPTb.Size = new System.Drawing.Size(155, 23);
            this.IPTb.TabIndex = 2;
            this.IPTb.TabStop = false;
            this.IPTb.UseSystemPasswordChar = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(277, 23);
            this.materialTabSelector1.TabIndex = 55;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.currentlyOnlineTp);
            this.materialTabControl1.Controls.Add(this.logInRecordTp);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 32);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(281, 347);
            this.materialTabControl1.TabIndex = 12;
            // 
            // currentlyOnlineTp
            // 
            this.currentlyOnlineTp.Controls.Add(this.currentlyOnlineDgv);
            this.currentlyOnlineTp.Location = new System.Drawing.Point(4, 22);
            this.currentlyOnlineTp.Name = "currentlyOnlineTp";
            this.currentlyOnlineTp.Padding = new System.Windows.Forms.Padding(3);
            this.currentlyOnlineTp.Size = new System.Drawing.Size(273, 321);
            this.currentlyOnlineTp.TabIndex = 0;
            this.currentlyOnlineTp.Text = "当前在线";
            this.currentlyOnlineTp.UseVisualStyleBackColor = true;
            // 
            // currentlyOnlineDgv
            // 
            this.currentlyOnlineDgv.AllowUserToAddRows = false;
            this.currentlyOnlineDgv.AllowUserToDeleteRows = false;
            this.currentlyOnlineDgv.AllowUserToResizeRows = false;
            this.currentlyOnlineDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentlyOnlineDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentlyOnlineDgv.Location = new System.Drawing.Point(3, 3);
            this.currentlyOnlineDgv.Name = "currentlyOnlineDgv";
            this.currentlyOnlineDgv.ReadOnly = true;
            this.currentlyOnlineDgv.RowTemplate.Height = 23;
            this.currentlyOnlineDgv.Size = new System.Drawing.Size(267, 315);
            this.currentlyOnlineDgv.TabIndex = 0;
            // 
            // logInRecordTp
            // 
            this.logInRecordTp.Controls.Add(this.logInRecordDgv);
            this.logInRecordTp.Location = new System.Drawing.Point(4, 22);
            this.logInRecordTp.Name = "logInRecordTp";
            this.logInRecordTp.Padding = new System.Windows.Forms.Padding(3);
            this.logInRecordTp.Size = new System.Drawing.Size(273, 321);
            this.logInRecordTp.TabIndex = 1;
            this.logInRecordTp.Text = "登录记录";
            this.logInRecordTp.UseVisualStyleBackColor = true;
            // 
            // logInRecordDgv
            // 
            this.logInRecordDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logInRecordDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logInRecordDgv.Location = new System.Drawing.Point(3, 3);
            this.logInRecordDgv.Name = "logInRecordDgv";
            this.logInRecordDgv.RowTemplate.Height = 23;
            this.logInRecordDgv.Size = new System.Drawing.Size(267, 315);
            this.logInRecordDgv.TabIndex = 0;
            // 
            // refreshDataBt
            // 
            this.refreshDataBt.AutoSize = true;
            this.refreshDataBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshDataBt.Depth = 0;
            this.refreshDataBt.Icon = null;
            this.refreshDataBt.Location = new System.Drawing.Point(287, 3);
            this.refreshDataBt.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshDataBt.Name = "refreshDataBt";
            this.refreshDataBt.Primary = true;
            this.refreshDataBt.Size = new System.Drawing.Size(51, 36);
            this.refreshDataBt.TabIndex = 13;
            this.refreshDataBt.Text = "刷新";
            this.refreshDataBt.UseVisualStyleBackColor = true;
            this.refreshDataBt.Click += new System.EventHandler(this.materialRaisedButton6_Click);
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.materialTabControl4;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(5, 66);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(478, 23);
            this.materialTabSelector2.TabIndex = 59;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // materialTabControl4
            // 
            this.materialTabControl4.Controls.Add(this.ServerStatusTp);
            this.materialTabControl4.Controls.Add(this.msgInterfaceTp);
            this.materialTabControl4.Controls.Add(this.userInformationTp);
            this.materialTabControl4.Controls.Add(this.databaseToolsTp);
            this.materialTabControl4.Depth = 0;
            this.materialTabControl4.Location = new System.Drawing.Point(5, 95);
            this.materialTabControl4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl4.Name = "materialTabControl4";
            this.materialTabControl4.SelectedIndex = 0;
            this.materialTabControl4.Size = new System.Drawing.Size(891, 461);
            this.materialTabControl4.TabIndex = 0;
            // 
            // ServerStatusTp
            // 
            this.ServerStatusTp.Controls.Add(this.splitContainer2);
            this.ServerStatusTp.Controls.Add(this.splitContainer1);
            this.ServerStatusTp.Location = new System.Drawing.Point(4, 22);
            this.ServerStatusTp.Name = "ServerStatusTp";
            this.ServerStatusTp.Padding = new System.Windows.Forms.Padding(3);
            this.ServerStatusTp.Size = new System.Drawing.Size(883, 435);
            this.ServerStatusTp.TabIndex = 0;
            this.ServerStatusTp.Text = "服务器状态";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(6, 6);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.serverLogRtb);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(871, 307);
            this.splitContainer2.SplitterDistance = 399;
            this.splitContainer2.TabIndex = 58;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lastRefreshLbe);
            this.splitContainer3.Panel1.Controls.Add(this.refreshUserBt);
            this.splitContainer3.Panel1.Controls.Add(this.numberOfPeopleOnlineLbe);
            this.splitContainer3.Panel1.Controls.Add(this.portTB);
            this.splitContainer3.Panel1.Controls.Add(this.materialLabel4);
            this.splitContainer3.Panel1.Controls.Add(this.materialLabel3);
            this.splitContainer3.Panel1.Controls.Add(this.IPTb);
            this.splitContainer3.Panel1.Controls.Add(this.serverStatusLbe);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.onlineUsersLb);
            this.splitContainer3.Size = new System.Drawing.Size(468, 307);
            this.splitContainer3.SplitterDistance = 230;
            this.splitContainer3.TabIndex = 0;
            // 
            // lastRefreshLbe
            // 
            this.lastRefreshLbe.AutoSize = true;
            this.lastRefreshLbe.Depth = 0;
            this.lastRefreshLbe.Font = new System.Drawing.Font("Roboto", 11F);
            this.lastRefreshLbe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lastRefreshLbe.Location = new System.Drawing.Point(12, 243);
            this.lastRefreshLbe.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastRefreshLbe.Name = "lastRefreshLbe";
            this.lastRefreshLbe.Size = new System.Drawing.Size(89, 19);
            this.lastRefreshLbe.TabIndex = 63;
            this.lastRefreshLbe.Text = "上次刷新：";
            // 
            // refreshUserBt
            // 
            this.refreshUserBt.AutoSize = true;
            this.refreshUserBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshUserBt.Depth = 0;
            this.refreshUserBt.Icon = null;
            this.refreshUserBt.Location = new System.Drawing.Point(152, 193);
            this.refreshUserBt.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshUserBt.Name = "refreshUserBt";
            this.refreshUserBt.Primary = true;
            this.refreshUserBt.Size = new System.Drawing.Size(51, 36);
            this.refreshUserBt.TabIndex = 4;
            this.refreshUserBt.Text = "刷新";
            this.refreshUserBt.UseVisualStyleBackColor = true;
            this.refreshUserBt.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // numberOfPeopleOnlineLbe
            // 
            this.numberOfPeopleOnlineLbe.AutoSize = true;
            this.numberOfPeopleOnlineLbe.Depth = 0;
            this.numberOfPeopleOnlineLbe.Font = new System.Drawing.Font("Roboto", 11F);
            this.numberOfPeopleOnlineLbe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numberOfPeopleOnlineLbe.Location = new System.Drawing.Point(12, 193);
            this.numberOfPeopleOnlineLbe.MouseState = MaterialSkin.MouseState.HOVER;
            this.numberOfPeopleOnlineLbe.Name = "numberOfPeopleOnlineLbe";
            this.numberOfPeopleOnlineLbe.Size = new System.Drawing.Size(121, 19);
            this.numberOfPeopleOnlineLbe.TabIndex = 56;
            this.numberOfPeopleOnlineLbe.Text = "在线人数：未知";
            // 
            // portTB
            // 
            this.portTB.Depth = 0;
            this.portTB.Hint = "";
            this.portTB.Location = new System.Drawing.Point(91, 150);
            this.portTB.MaxLength = 32767;
            this.portTB.MouseState = MaterialSkin.MouseState.HOVER;
            this.portTB.Name = "portTB";
            this.portTB.PasswordChar = '\0';
            this.portTB.SelectedText = "";
            this.portTB.SelectionLength = 0;
            this.portTB.SelectionStart = 0;
            this.portTB.Size = new System.Drawing.Size(96, 23);
            this.portTB.TabIndex = 3;
            this.portTB.TabStop = false;
            this.portTB.UseSystemPasswordChar = false;
            // 
            // onlineUsersLb
            // 
            this.onlineUsersLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onlineUsersLb.FormattingEnabled = true;
            this.onlineUsersLb.ItemHeight = 12;
            this.onlineUsersLb.Location = new System.Drawing.Point(0, 0);
            this.onlineUsersLb.Name = "onlineUsersLb";
            this.onlineUsersLb.Size = new System.Drawing.Size(234, 307);
            this.onlineUsersLb.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(227, 368);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.startServerBt);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.shutdownServerBt);
            this.splitContainer1.Size = new System.Drawing.Size(440, 43);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.SplitterWidth = 20;
            this.splitContainer1.TabIndex = 56;
            // 
            // msgInterfaceTp
            // 
            this.msgInterfaceTp.Controls.Add(this.globalMsgRtb);
            this.msgInterfaceTp.Controls.Add(this.privateMsgRtb);
            this.msgInterfaceTp.Controls.Add(this.globalMsgBt);
            this.msgInterfaceTp.Controls.Add(this.privateMsgBt);
            this.msgInterfaceTp.Location = new System.Drawing.Point(4, 22);
            this.msgInterfaceTp.Name = "msgInterfaceTp";
            this.msgInterfaceTp.Padding = new System.Windows.Forms.Padding(3);
            this.msgInterfaceTp.Size = new System.Drawing.Size(883, 435);
            this.msgInterfaceTp.TabIndex = 1;
            this.msgInterfaceTp.Text = "消息界面";
            // 
            // userInformationTp
            // 
            this.userInformationTp.Controls.Add(this.materialTabSelector1);
            this.userInformationTp.Controls.Add(this.materialTabControl1);
            this.userInformationTp.Controls.Add(this.refreshDataBt);
            this.userInformationTp.Location = new System.Drawing.Point(4, 22);
            this.userInformationTp.Name = "userInformationTp";
            this.userInformationTp.Size = new System.Drawing.Size(883, 435);
            this.userInformationTp.TabIndex = 2;
            this.userInformationTp.Text = "用户信息";
            this.userInformationTp.UseVisualStyleBackColor = true;
            // 
            // databaseToolsTp
            // 
            this.databaseToolsTp.Controls.Add(this.label3);
            this.databaseToolsTp.Controls.Add(this.mailTb);
            this.databaseToolsTp.Controls.Add(this.label2);
            this.databaseToolsTp.Controls.Add(this.userpswTb);
            this.databaseToolsTp.Controls.Add(this.label1);
            this.databaseToolsTp.Controls.Add(this.usernameTb);
            this.databaseToolsTp.Controls.Add(this.addAccountbBt);
            this.databaseToolsTp.Controls.Add(this.msgrTb);
            this.databaseToolsTp.Controls.Add(this.repairServerBt);
            this.databaseToolsTp.Location = new System.Drawing.Point(4, 22);
            this.databaseToolsTp.Name = "databaseToolsTp";
            this.databaseToolsTp.Size = new System.Drawing.Size(883, 435);
            this.databaseToolsTp.TabIndex = 3;
            this.databaseToolsTp.Text = "数据库工具";
            this.databaseToolsTp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 69;
            this.label3.Text = "邮箱";
            // 
            // mailTb
            // 
            this.mailTb.Location = new System.Drawing.Point(360, 71);
            this.mailTb.Name = "mailTb";
            this.mailTb.Size = new System.Drawing.Size(188, 21);
            this.mailTb.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 67;
            this.label2.Text = "密码";
            // 
            // userpswTb
            // 
            this.userpswTb.Location = new System.Drawing.Point(360, 44);
            this.userpswTb.Name = "userpswTb";
            this.userpswTb.Size = new System.Drawing.Size(188, 21);
            this.userpswTb.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 65;
            this.label1.Text = "账户";
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(360, 17);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(188, 21);
            this.usernameTb.TabIndex = 15;
            // 
            // addAccountbBt
            // 
            this.addAccountbBt.AutoSize = true;
            this.addAccountbBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addAccountbBt.Depth = 0;
            this.addAccountbBt.Icon = null;
            this.addAccountbBt.Location = new System.Drawing.Point(360, 98);
            this.addAccountbBt.MouseState = MaterialSkin.MouseState.HOVER;
            this.addAccountbBt.Name = "addAccountbBt";
            this.addAccountbBt.Primary = true;
            this.addAccountbBt.Size = new System.Drawing.Size(81, 36);
            this.addAccountbBt.TabIndex = 18;
            this.addAccountbBt.Text = "添加账户";
            this.addAccountbBt.UseVisualStyleBackColor = true;
            this.addAccountbBt.Click += new System.EventHandler(this.materialRaisedButton8_Click);
            // 
            // msgrTb
            // 
            this.msgrTb.BackColor = System.Drawing.SystemColors.InfoText;
            this.msgrTb.Location = new System.Drawing.Point(3, 3);
            this.msgrTb.Name = "msgrTb";
            this.msgrTb.Size = new System.Drawing.Size(346, 361);
            this.msgrTb.TabIndex = 14;
            this.msgrTb.Text = "";
            // 
            // repairServerBt
            // 
            this.repairServerBt.AutoSize = true;
            this.repairServerBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.repairServerBt.Depth = 0;
            this.repairServerBt.Icon = null;
            this.repairServerBt.Location = new System.Drawing.Point(355, 328);
            this.repairServerBt.MouseState = MaterialSkin.MouseState.HOVER;
            this.repairServerBt.Name = "repairServerBt";
            this.repairServerBt.Primary = true;
            this.repairServerBt.Size = new System.Drawing.Size(162, 36);
            this.repairServerBt.TabIndex = 19;
            this.repairServerBt.Text = "一键修复/搭建服务器";
            this.repairServerBt.UseVisualStyleBackColor = true;
            this.repairServerBt.Click += new System.EventHandler(this.materialRaisedButton7_Click);
            // 
            // ServerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 568);
            this.Controls.Add(this.materialTabControl4);
            this.Controls.Add(this.materialTabSelector2);
            this.MinimumSize = new System.Drawing.Size(648, 481);
            this.Name = "ServerMainForm";
            this.Text = "音社后台管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerMainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.ServerMainForm_SizeChanged);
            this.materialTabControl1.ResumeLayout(false);
            this.currentlyOnlineTp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentlyOnlineDgv)).EndInit();
            this.logInRecordTp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logInRecordDgv)).EndInit();
            this.materialTabControl4.ResumeLayout(false);
            this.ServerStatusTp.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.msgInterfaceTp.ResumeLayout(false);
            this.msgInterfaceTp.PerformLayout();
            this.userInformationTp.ResumeLayout(false);
            this.userInformationTp.PerformLayout();
            this.databaseToolsTp.ResumeLayout(false);
            this.databaseToolsTp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton startServerBt;
        private MaterialSkin.Controls.MaterialRaisedButton shutdownServerBt;
        private MaterialSkin.Controls.MaterialLabel serverStatusLbe;
        private System.Windows.Forms.RichTextBox serverLogRtb;
        private MaterialSkin.Controls.MaterialRaisedButton globalMsgBt;
        private MaterialSkin.Controls.MaterialRaisedButton privateMsgBt;
        private System.Windows.Forms.RichTextBox globalMsgRtb;
        private System.Windows.Forms.RichTextBox privateMsgRtb;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField IPTb;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage currentlyOnlineTp;
        private System.Windows.Forms.TabPage logInRecordTp;
        private System.Windows.Forms.DataGridView currentlyOnlineDgv;
        private System.Windows.Forms.DataGridView logInRecordDgv;
        private MaterialSkin.Controls.MaterialRaisedButton refreshDataBt;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl4;
        private System.Windows.Forms.TabPage ServerStatusTp;
        private System.Windows.Forms.TabPage msgInterfaceTp;
        private System.Windows.Forms.TabPage userInformationTp;
        private MaterialSkin.Controls.MaterialSingleLineTextField portTB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MaterialSkin.Controls.MaterialLabel numberOfPeopleOnlineLbe;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private MaterialSkin.Controls.MaterialRaisedButton refreshUserBt;
        private System.Windows.Forms.ListBox onlineUsersLb;
        private MaterialSkin.Controls.MaterialLabel lastRefreshLbe;
        private System.Windows.Forms.TabPage databaseToolsTp;
        private System.Windows.Forms.RichTextBox msgrTb;
        private MaterialSkin.Controls.MaterialRaisedButton repairServerBt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mailTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userpswTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTb;
        private MaterialSkin.Controls.MaterialRaisedButton addAccountbBt;

    }
}


namespace Human.MainWindow
{
	partial class MainForm
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
			if (disposing && (components != null)) {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.TSMnuWorkerMgmt = new System.Windows.Forms.ToolStripMenuItem();
			this.档案管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMnuSystemSetting = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMnuUserInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlTool = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblCurrentUser = new System.Windows.Forms.Label();
			this.btnLoginOut = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnlTool.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuWorkerMgmt,
            this.TSMnuSystemSetting});
			this.menuStrip1.Location = new System.Drawing.Point(0, 49);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(900, 40);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// TSMnuWorkerMgmt
			// 
			this.TSMnuWorkerMgmt.AutoSize = false;
			this.TSMnuWorkerMgmt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.档案管理ToolStripMenuItem});
			this.TSMnuWorkerMgmt.Image = global::Human.MainWindow.resIcon.ATLConsumer;
			this.TSMnuWorkerMgmt.Name = "TSMnuWorkerMgmt";
			this.TSMnuWorkerMgmt.Size = new System.Drawing.Size(91, 28);
			this.TSMnuWorkerMgmt.Text = "人力管理";
			// 
			// 档案管理ToolStripMenuItem
			// 
			this.档案管理ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
			this.档案管理ToolStripMenuItem.Image = global::Human.MainWindow.resIcon.DatabaseProject;
			this.档案管理ToolStripMenuItem.Name = "档案管理ToolStripMenuItem";
			this.档案管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.档案管理ToolStripMenuItem.Text = "档案管理";
			this.档案管理ToolStripMenuItem.Click += new System.EventHandler(this.档案管理ToolStripMenuItem_Click);
			// 
			// TSMnuSystemSetting
			// 
			this.TSMnuSystemSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMnuUserInfo});
			this.TSMnuSystemSetting.Image = global::Human.MainWindow.resIcon.Simple;
			this.TSMnuSystemSetting.Margin = new System.Windows.Forms.Padding(5);
			this.TSMnuSystemSetting.Name = "TSMnuSystemSetting";
			this.TSMnuSystemSetting.Size = new System.Drawing.Size(92, 28);
			this.TSMnuSystemSetting.Text = "系统设置";
			this.TSMnuSystemSetting.Click += new System.EventHandler(this.TSMnuSystemSetting_Click);
			// 
			// TSMnuUserInfo
			// 
			this.TSMnuUserInfo.BackColor = System.Drawing.SystemColors.ControlLight;
			this.TSMnuUserInfo.Image = global::Human.MainWindow.resIcon.propertysheets;
			this.TSMnuUserInfo.Name = "TSMnuUserInfo";
			this.TSMnuUserInfo.Size = new System.Drawing.Size(124, 22);
			this.TSMnuUserInfo.Text = "用户信息";
			this.TSMnuUserInfo.Click += new System.EventHandler(this.TSMnuUserInfo_Click);
			// 
			// pnlMain
			// 
			this.pnlMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 89);
			this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(900, 443);
			this.pnlMain.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.pnlMain);
			this.panel2.Controls.Add(this.menuStrip1);
			this.panel2.Controls.Add(this.pnlTool);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(5);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(902, 534);
			this.panel2.TabIndex = 2;
			// 
			// pnlTool
			// 
			this.pnlTool.BackColor = System.Drawing.SystemColors.MenuBar;
			this.pnlTool.BackgroundImage = global::Human.MainWindow.Properties.Resources.logHead;
			this.pnlTool.Controls.Add(this.label3);
			this.pnlTool.Controls.Add(this.panel1);
			this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTool.Location = new System.Drawing.Point(0, 0);
			this.pnlTool.Name = "pnlTool";
			this.pnlTool.Size = new System.Drawing.Size(900, 49);
			this.pnlTool.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(11, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(198, 31);
			this.label3.TabIndex = 3;
			this.label3.Text = "人力资源管理系统";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.lblCurrentUser);
			this.panel1.Controls.Add(this.btnLoginOut);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(636, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(264, 49);
			this.panel1.TabIndex = 2;
			// 
			// lblCurrentUser
			// 
			this.lblCurrentUser.AutoSize = true;
			this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentUser.ForeColor = System.Drawing.Color.White;
			this.lblCurrentUser.Location = new System.Drawing.Point(3, 34);
			this.lblCurrentUser.Name = "lblCurrentUser";
			this.lblCurrentUser.Size = new System.Drawing.Size(41, 13);
			this.lblCurrentUser.TabIndex = 0;
			this.lblCurrentUser.Text = "label1";
			// 
			// btnLoginOut
			// 
			this.btnLoginOut.ForeColor = System.Drawing.Color.Maroon;
			this.btnLoginOut.Image = global::Human.MainWindow.resIcon.messageboxerror;
			this.btnLoginOut.Location = new System.Drawing.Point(157, 9);
			this.btnLoginOut.Margin = new System.Windows.Forms.Padding(0);
			this.btnLoginOut.Name = "btnLoginOut";
			this.btnLoginOut.Size = new System.Drawing.Size(86, 23);
			this.btnLoginOut.TabIndex = 1;
			this.btnLoginOut.Text = "退出系统";
			this.btnLoginOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLoginOut.UseVisualStyleBackColor = false;
			this.btnLoginOut.Click += new System.EventHandler(this.btnLoginOut_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(902, 534);
			this.Controls.Add(this.panel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "人力资源管理系统";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.pnlTool.ResumeLayout(false);
			this.pnlTool.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem TSMnuSystemSetting;
		private System.Windows.Forms.ToolStripMenuItem TSMnuUserInfo;
		private System.Windows.Forms.ToolStripMenuItem TSMnuWorkerMgmt;
		private System.Windows.Forms.ToolStripMenuItem 档案管理ToolStripMenuItem;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnlTool;
		private System.Windows.Forms.Label lblCurrentUser;
		private System.Windows.Forms.Button btnLoginOut;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
	}
}
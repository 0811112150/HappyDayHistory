﻿namespace TCPClient
{
    partial class frmSyncTCPClient
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
            this.lblIp = new System.Windows.Forms.Label();
            this.tbxserverIp = new System.Windows.Forms.TextBox();
            this.lblport = new System.Windows.Forms.Label();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lstbxMessageView = new System.Windows.Forms.ListBox();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.statusStripInfo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(13, 13);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(47, 13);
            this.lblIp.TabIndex = 0;
            this.lblIp.Text = "IP地址：";
            // 
            // tbxserverIp
            // 
            this.tbxserverIp.Location = new System.Drawing.Point(66, 10);
            this.tbxserverIp.Name = "tbxserverIp";
            this.tbxserverIp.Size = new System.Drawing.Size(120, 20);
            this.tbxserverIp.TabIndex = 1;
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Location = new System.Drawing.Point(209, 13);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(49, 13);
            this.lblport.TabIndex = 2;
            this.lblport.Text = "端口号：";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(264, 10);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(116, 20);
            this.tbxPort.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(66, 48);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "连接服务器";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(212, 48);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "断开连接";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lstbxMessageView
            // 
            this.lstbxMessageView.FormattingEnabled = true;
            this.lstbxMessageView.Location = new System.Drawing.Point(16, 86);
            this.lstbxMessageView.Name = "lstbxMessageView";
            this.lstbxMessageView.Size = new System.Drawing.Size(364, 147);
            this.lstbxMessageView.TabIndex = 6;
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(16, 268);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(364, 56);
            this.tbxMessage.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(231, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(302, 330);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(65, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(221, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "清空消息";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(302, 239);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 11;
            this.btnReceive.Text = "接受";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // statusStripInfo
            // 
            this.statusStripInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusInfo});
            this.statusStripInfo.Location = new System.Drawing.Point(0, 380);
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Size = new System.Drawing.Size(392, 22);
            this.statusStripInfo.TabIndex = 12;
            this.statusStripInfo.Text = "statusStrip1";
            // 
            // toolStripStatusInfo
            // 
            this.toolStripStatusInfo.AutoSize = false;
            this.toolStripStatusInfo.Name = "toolStripStatusInfo";
            this.toolStripStatusInfo.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusInfo.Text = "就绪";
            // 
            // frmSyncTCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 402);
            this.Controls.Add(this.statusStripInfo);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.lstbxMessageView);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.lblport);
            this.Controls.Add(this.tbxserverIp);
            this.Controls.Add(this.lblIp);
            this.Name = "frmSyncTCPClient";
            this.Text = "客户端";
            this.statusStripInfo.ResumeLayout(false);
            this.statusStripInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox tbxserverIp;
        private System.Windows.Forms.Label lblport;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ListBox lstbxMessageView;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.StatusStrip statusStripInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusInfo;
    }
}


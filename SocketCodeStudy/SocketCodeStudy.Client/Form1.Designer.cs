namespace SocketCodeStudy.Client
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
			if (disposing && (components != null)) {
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtServerIPAddress = new System.Windows.Forms.TextBox();
			this.txtServerPort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLocalIPAddress = new System.Windows.Forms.TextBox();
			this.txtLocalPort = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnLoginOut = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "服务器";
			// 
			// txtServerIPAddress
			// 
			this.txtServerIPAddress.Location = new System.Drawing.Point(106, 23);
			this.txtServerIPAddress.Name = "txtServerIPAddress";
			this.txtServerIPAddress.Size = new System.Drawing.Size(100, 21);
			this.txtServerIPAddress.TabIndex = 1;
			// 
			// txtServerPort
			// 
			this.txtServerPort.Location = new System.Drawing.Point(243, 23);
			this.txtServerPort.Name = "txtServerPort";
			this.txtServerPort.Size = new System.Drawing.Size(100, 21);
			this.txtServerPort.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "用户名";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(106, 77);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(100, 21);
			this.txtUserName.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "本地";
			// 
			// txtLocalIPAddress
			// 
			this.txtLocalIPAddress.Location = new System.Drawing.Point(106, 121);
			this.txtLocalIPAddress.Name = "txtLocalIPAddress";
			this.txtLocalIPAddress.Size = new System.Drawing.Size(100, 21);
			this.txtLocalIPAddress.TabIndex = 1;
			// 
			// txtLocalPort
			// 
			this.txtLocalPort.Location = new System.Drawing.Point(243, 121);
			this.txtLocalPort.Name = "txtLocalPort";
			this.txtLocalPort.Size = new System.Drawing.Size(100, 21);
			this.txtLocalPort.TabIndex = 1;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(106, 187);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "登陆";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.tbnLogin_Click);
			// 
			// btnLoginOut
			// 
			this.btnLoginOut.Location = new System.Drawing.Point(243, 187);
			this.btnLoginOut.Name = "btnLoginOut";
			this.btnLoginOut.Size = new System.Drawing.Size(75, 23);
			this.btnLoginOut.TabIndex = 2;
			this.btnLoginOut.Text = "注销";
			this.btnLoginOut.UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(41, 238);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(310, 136);
			this.listBox1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(431, 381);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnLoginOut);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtLocalPort);
			this.Controls.Add(this.txtServerPort);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtLocalIPAddress);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtServerIPAddress);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtServerIPAddress;
		private System.Windows.Forms.TextBox txtServerPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtLocalIPAddress;
		private System.Windows.Forms.TextBox txtLocalPort;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnLoginOut;
		private System.Windows.Forms.ListBox listBox1;
	}
}


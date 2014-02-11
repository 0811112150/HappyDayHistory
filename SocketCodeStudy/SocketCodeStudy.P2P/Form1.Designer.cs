namespace SocketCodeStudy.P2P
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
			this.txtIPAddress = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtResource = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.richTxtSearchResult = new System.Windows.Forms.RichTextBox();
			this.cbxResourceList = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(59, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "本地IP";
			// 
			// txtIPAddress
			// 
			this.txtIPAddress.Location = new System.Drawing.Point(129, 37);
			this.txtIPAddress.Name = "txtIPAddress";
			this.txtIPAddress.Size = new System.Drawing.Size(100, 21);
			this.txtIPAddress.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(249, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "端口";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(319, 37);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(100, 21);
			this.txtPort.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(59, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "资源名";
			// 
			// txtResource
			// 
			this.txtResource.Location = new System.Drawing.Point(129, 85);
			this.txtResource.Name = "txtResource";
			this.txtResource.Size = new System.Drawing.Size(139, 21);
			this.txtResource.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(59, 154);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 0;
			this.label4.Text = "种子";
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(129, 154);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(139, 21);
			this.txtSearch.TabIndex = 1;
			// 
			// btnRegister
			// 
			this.btnRegister.Location = new System.Drawing.Point(319, 85);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(75, 23);
			this.btnRegister.TabIndex = 2;
			this.btnRegister.Text = "注册";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(319, 149);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "搜索";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// richTxtSearchResult
			// 
			this.richTxtSearchResult.Location = new System.Drawing.Point(61, 205);
			this.richTxtSearchResult.Name = "richTxtSearchResult";
			this.richTxtSearchResult.Size = new System.Drawing.Size(345, 96);
			this.richTxtSearchResult.TabIndex = 3;
			this.richTxtSearchResult.Text = "";
			// 
			// cbxResourceList
			// 
			this.cbxResourceList.FormattingEnabled = true;
			this.cbxResourceList.Location = new System.Drawing.Point(129, 113);
			this.cbxResourceList.Name = "cbxResourceList";
			this.cbxResourceList.Size = new System.Drawing.Size(139, 20);
			this.cbxResourceList.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 382);
			this.Controls.Add(this.cbxResourceList);
			this.Controls.Add(this.richTxtSearchResult);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtResource);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtIPAddress);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIPAddress;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtResource;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.RichTextBox richTxtSearchResult;
		private System.Windows.Forms.ComboBox cbxResourceList;
	}
}


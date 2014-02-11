namespace HappyDay.QrCodeWinform
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
			this.txtToConvert = new System.Windows.Forms.TextBox();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.qrCodeGraphicControl1 = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeGraphicControl();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtToConvert
			// 
			this.txtToConvert.Location = new System.Drawing.Point(13, 13);
			this.txtToConvert.Name = "txtToConvert";
			this.txtToConvert.Size = new System.Drawing.Size(331, 21);
			this.txtToConvert.TabIndex = 0;
			// 
			// btnConfirm
			// 
			this.btnConfirm.Location = new System.Drawing.Point(32, 41);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(75, 23);
			this.btnConfirm.TabIndex = 1;
			this.btnConfirm.Text = "生成";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// qrCodeGraphicControl1
			// 
			this.qrCodeGraphicControl1.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
			this.qrCodeGraphicControl1.Location = new System.Drawing.Point(32, 70);
			this.qrCodeGraphicControl1.Name = "qrCodeGraphicControl1";
			this.qrCodeGraphicControl1.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
			this.qrCodeGraphicControl1.Size = new System.Drawing.Size(240, 236);
			this.qrCodeGraphicControl1.TabIndex = 2;
			this.qrCodeGraphicControl1.Text = "qrCodeGraphicControl1";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(196, 41);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "保存";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnConfirm;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 341);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.qrCodeGraphicControl1);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.txtToConvert);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtToConvert;
		private System.Windows.Forms.Button btnConfirm;
		private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeGraphicControl qrCodeGraphicControl1;
		private System.Windows.Forms.Button btnSave;
	}
}


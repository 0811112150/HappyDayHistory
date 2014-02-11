namespace Human.MainWindow
{
	partial class PeoplePicInfoForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeoplePicInfoForm));
			this.btnSelectPic = new System.Windows.Forms.Button();
			this.txtPicTitle = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.txtPicPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSelectPic
			// 
			this.btnSelectPic.Location = new System.Drawing.Point(529, 66);
			this.btnSelectPic.Name = "btnSelectPic";
			this.btnSelectPic.Size = new System.Drawing.Size(74, 23);
			this.btnSelectPic.TabIndex = 5;
			this.btnSelectPic.Text = "选择文件";
			this.btnSelectPic.UseVisualStyleBackColor = true;
			this.btnSelectPic.Click += new System.EventHandler(this.btnSelectPic_Click);
			// 
			// txtPicTitle
			// 
			this.txtPicTitle.Location = new System.Drawing.Point(91, 27);
			this.txtPicTitle.Name = "txtPicTitle";
			this.txtPicTitle.Size = new System.Drawing.Size(420, 21);
			this.txtPicTitle.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "文件信息：";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(91, 116);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "保存";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "图片文件|*.jpg;*.png;*.bmp";
			// 
			// txtPicPath
			// 
			this.txtPicPath.Location = new System.Drawing.Point(91, 66);
			this.txtPicPath.Name = "txtPicPath";
			this.txtPicPath.ReadOnly = true;
			this.txtPicPath.Size = new System.Drawing.Size(420, 21);
			this.txtPicPath.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "文件路径：";
			// 
			// PeoplePicInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(629, 178);
			this.Controls.Add(this.txtPicPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnSelectPic);
			this.Controls.Add(this.txtPicTitle);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PeoplePicInfoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "证照影印件";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSelectPic;
		private System.Windows.Forms.TextBox txtPicTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox txtPicPath;
		private System.Windows.Forms.Label label2;
	}
}
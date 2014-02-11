namespace Human.MainWindow
{
	partial class RewardRecordInfoForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RewardRecordInfoForm));
			this.dtpRewardDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.rtxtRewardContent = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// dtpRewardDate
			// 
			this.dtpRewardDate.Location = new System.Drawing.Point(103, 14);
			this.dtpRewardDate.Name = "dtpRewardDate";
			this.dtpRewardDate.Size = new System.Drawing.Size(153, 21);
			this.dtpRewardDate.TabIndex = 84;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 12);
			this.label3.TabIndex = 59;
			this.label3.Text = "奖惩时间:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 53;
			this.label1.Text = "奖惩内容:";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(178, 211);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(78, 26);
			this.btnCancel.TabIndex = 46;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(78, 211);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(78, 26);
			this.btnSave.TabIndex = 45;
			this.btnSave.Text = "保存";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// rtxtRewardContent
			// 
			this.rtxtRewardContent.Location = new System.Drawing.Point(103, 46);
			this.rtxtRewardContent.Name = "rtxtRewardContent";
			this.rtxtRewardContent.Size = new System.Drawing.Size(420, 135);
			this.rtxtRewardContent.TabIndex = 85;
			this.rtxtRewardContent.Text = "";
			// 
			// RewardRecordInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(548, 253);
			this.Controls.Add(this.rtxtRewardContent);
			this.Controls.Add(this.dtpRewardDate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RewardRecordInfoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "奖惩记录";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpRewardDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.RichTextBox rtxtRewardContent;
	}
}
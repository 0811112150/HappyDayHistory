namespace Human.MainWindow
{
	partial class TitleWageChangeRecordInfoForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleWageChangeRecordInfoForm));
			this.dtpChangeDate = new System.Windows.Forms.DateTimePicker();
			this.txtAfterChangeYearAward = new System.Windows.Forms.TextBox();
			this.txtAfterChangeBasicWage = new System.Windows.Forms.TextBox();
			this.txtContractNum = new System.Windows.Forms.TextBox();
			this.txtBeforeChangeYearAward = new System.Windows.Forms.TextBox();
			this.txtAfterChangeAllowance = new System.Windows.Forms.TextBox();
			this.txtAfterChangeTitle = new System.Windows.Forms.TextBox();
			this.txtBeforeChangeallowance = new System.Windows.Forms.TextBox();
			this.txtBeforeChangeTitle = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.cbxChangeType = new System.Windows.Forms.ComboBox();
			this.txtBeforeChangeBasicWage = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// dtpChangeDate
			// 
			this.dtpChangeDate.Location = new System.Drawing.Point(90, 12);
			this.dtpChangeDate.Name = "dtpChangeDate";
			this.dtpChangeDate.Size = new System.Drawing.Size(186, 21);
			this.dtpChangeDate.TabIndex = 84;
			// 
			// txtAfterChangeYearAward
			// 
			this.txtAfterChangeYearAward.Location = new System.Drawing.Point(90, 253);
			this.txtAfterChangeYearAward.Name = "txtAfterChangeYearAward";
			this.txtAfterChangeYearAward.Size = new System.Drawing.Size(186, 21);
			this.txtAfterChangeYearAward.TabIndex = 70;
			this.txtAfterChangeYearAward.Validating += new System.ComponentModel.CancelEventHandler(this.txtAfterChangeYearAward_Validating);
			// 
			// txtAfterChangeBasicWage
			// 
			this.txtAfterChangeBasicWage.Location = new System.Drawing.Point(90, 205);
			this.txtAfterChangeBasicWage.Name = "txtAfterChangeBasicWage";
			this.txtAfterChangeBasicWage.Size = new System.Drawing.Size(186, 21);
			this.txtAfterChangeBasicWage.TabIndex = 67;
			this.txtAfterChangeBasicWage.Validating += new System.ComponentModel.CancelEventHandler(this.txtAfterChangeBasicWage_Validating);
			// 
			// txtContractNum
			// 
			this.txtContractNum.Location = new System.Drawing.Point(90, 61);
			this.txtContractNum.Name = "txtContractNum";
			this.txtContractNum.Size = new System.Drawing.Size(186, 21);
			this.txtContractNum.TabIndex = 68;
			// 
			// txtBeforeChangeYearAward
			// 
			this.txtBeforeChangeYearAward.Location = new System.Drawing.Point(90, 157);
			this.txtBeforeChangeYearAward.Name = "txtBeforeChangeYearAward";
			this.txtBeforeChangeYearAward.Size = new System.Drawing.Size(186, 21);
			this.txtBeforeChangeYearAward.TabIndex = 69;
			this.txtBeforeChangeYearAward.Validating += new System.ComponentModel.CancelEventHandler(this.txtBeforeChangeYearAward_Validating);
			// 
			// txtAfterChangeAllowance
			// 
			this.txtAfterChangeAllowance.Location = new System.Drawing.Point(90, 229);
			this.txtAfterChangeAllowance.Name = "txtAfterChangeAllowance";
			this.txtAfterChangeAllowance.Size = new System.Drawing.Size(186, 21);
			this.txtAfterChangeAllowance.TabIndex = 79;
			this.txtAfterChangeAllowance.Validating += new System.ComponentModel.CancelEventHandler(this.txtAfterChangeAllowance_Validating);
			// 
			// txtAfterChangeTitle
			// 
			this.txtAfterChangeTitle.Location = new System.Drawing.Point(90, 181);
			this.txtAfterChangeTitle.Name = "txtAfterChangeTitle";
			this.txtAfterChangeTitle.Size = new System.Drawing.Size(186, 21);
			this.txtAfterChangeTitle.TabIndex = 76;
			// 
			// txtBeforeChangeallowance
			// 
			this.txtBeforeChangeallowance.Location = new System.Drawing.Point(90, 133);
			this.txtBeforeChangeallowance.Name = "txtBeforeChangeallowance";
			this.txtBeforeChangeallowance.Size = new System.Drawing.Size(186, 21);
			this.txtBeforeChangeallowance.TabIndex = 78;
			this.txtBeforeChangeallowance.Validating += new System.ComponentModel.CancelEventHandler(this.txtBeforeChangeallowance_Validating);
			// 
			// txtBeforeChangeTitle
			// 
			this.txtBeforeChangeTitle.Location = new System.Drawing.Point(90, 85);
			this.txtBeforeChangeTitle.Name = "txtBeforeChangeTitle";
			this.txtBeforeChangeTitle.Size = new System.Drawing.Size(186, 21);
			this.txtBeforeChangeTitle.TabIndex = 77;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(38, 256);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(47, 12);
			this.label19.TabIndex = 54;
			this.label19.Text = "年终奖:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(26, 208);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(59, 12);
			this.label14.TabIndex = 51;
			this.label14.Text = "基本工资:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(38, 160);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(47, 12);
			this.label17.TabIndex = 47;
			this.label17.Text = "年终奖:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(26, 232);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(59, 12);
			this.label16.TabIndex = 56;
			this.label16.Text = "岗位津贴:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(26, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 12);
			this.label7.TabIndex = 63;
			this.label7.Text = "合同编号:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(14, 184);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(71, 12);
			this.label12.TabIndex = 62;
			this.label12.Text = "变更后职位:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(50, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 12);
			this.label5.TabIndex = 64;
			this.label5.Text = "类型:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(26, 112);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(59, 12);
			this.label10.TabIndex = 61;
			this.label10.Text = "基本工资:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(26, 136);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(59, 12);
			this.label11.TabIndex = 58;
			this.label11.Text = "岗位津贴:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(14, 88);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(71, 12);
			this.label9.TabIndex = 60;
			this.label9.Text = "变更前职位:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(50, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 12);
			this.label3.TabIndex = 59;
			this.label3.Text = "时间:";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(178, 291);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(78, 26);
			this.btnCancel.TabIndex = 46;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(80, 291);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(78, 26);
			this.btnSave.TabIndex = 45;
			this.btnSave.Text = "保存";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cbxChangeType
			// 
			this.cbxChangeType.FormattingEnabled = true;
			this.cbxChangeType.Location = new System.Drawing.Point(90, 36);
			this.cbxChangeType.Name = "cbxChangeType";
			this.cbxChangeType.Size = new System.Drawing.Size(186, 20);
			this.cbxChangeType.TabIndex = 85;
			// 
			// txtBeforeChangeBasicWage
			// 
			this.txtBeforeChangeBasicWage.Location = new System.Drawing.Point(90, 109);
			this.txtBeforeChangeBasicWage.Name = "txtBeforeChangeBasicWage";
			this.txtBeforeChangeBasicWage.Size = new System.Drawing.Size(186, 21);
			this.txtBeforeChangeBasicWage.TabIndex = 69;
			this.txtBeforeChangeBasicWage.Validating += new System.ComponentModel.CancelEventHandler(this.txtBeforeChangeBasicWage_Validating);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// TitleWageChangeRecordInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(304, 328);
			this.Controls.Add(this.cbxChangeType);
			this.Controls.Add(this.dtpChangeDate);
			this.Controls.Add(this.txtAfterChangeYearAward);
			this.Controls.Add(this.txtAfterChangeBasicWage);
			this.Controls.Add(this.txtContractNum);
			this.Controls.Add(this.txtBeforeChangeBasicWage);
			this.Controls.Add(this.txtBeforeChangeYearAward);
			this.Controls.Add(this.txtAfterChangeAllowance);
			this.Controls.Add(this.txtAfterChangeTitle);
			this.Controls.Add(this.txtBeforeChangeallowance);
			this.Controls.Add(this.txtBeforeChangeTitle);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TitleWageChangeRecordInfoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "职位薪酬变动";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpChangeDate;
		private System.Windows.Forms.TextBox txtAfterChangeYearAward;
		private System.Windows.Forms.TextBox txtAfterChangeBasicWage;
		private System.Windows.Forms.TextBox txtContractNum;
		private System.Windows.Forms.TextBox txtBeforeChangeYearAward;
		private System.Windows.Forms.TextBox txtAfterChangeAllowance;
		private System.Windows.Forms.TextBox txtAfterChangeTitle;
		private System.Windows.Forms.TextBox txtBeforeChangeallowance;
		private System.Windows.Forms.TextBox txtBeforeChangeTitle;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cbxChangeType;
		private System.Windows.Forms.TextBox txtBeforeChangeBasicWage;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}
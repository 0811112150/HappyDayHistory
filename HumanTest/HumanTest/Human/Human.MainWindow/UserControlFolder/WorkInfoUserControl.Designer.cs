namespace Human.MainWindow
{
	partial class WorkInfoUserControl
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

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbtnTitleOut = new System.Windows.Forms.RadioButton();
			this.rbtnTitleAt = new System.Windows.Forms.RadioButton();
			this.dtpLeftCompanyDate = new System.Windows.Forms.DateTimePicker();
			this.txtWageCardAddress = new System.Windows.Forms.TextBox();
			this.txtWageCardNumber = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtLengthOfService = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpJoinCompanyDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSpecialSkill = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtLeftCompanyReason = new System.Windows.Forms.TextBox();
			this.txtDepartment = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbtnNotCallIn = new System.Windows.Forms.RadioButton();
			this.rbtnCallIn = new System.Windows.Forms.RadioButton();
			this.txtArchivesNum = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpArchiveCallInDate = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpArchiveCallOutDate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(284, 339);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(185, 339);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "保存";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbtnTitleOut);
			this.groupBox1.Controls.Add(this.rbtnTitleAt);
			this.groupBox1.Controls.Add(this.dtpLeftCompanyDate);
			this.groupBox1.Controls.Add(this.txtWageCardAddress);
			this.groupBox1.Controls.Add(this.txtWageCardNumber);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtLengthOfService);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dtpJoinCompanyDate);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtSpecialSkill);
			this.groupBox1.Controls.Add(this.txtTitle);
			this.groupBox1.Controls.Add(this.txtLeftCompanyReason);
			this.groupBox1.Controls.Add(this.txtDepartment);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Location = new System.Drawing.Point(3, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(516, 208);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "工作信息";
			// 
			// rbtnTitleOut
			// 
			this.rbtnTitleOut.AutoSize = true;
			this.rbtnTitleOut.Location = new System.Drawing.Point(125, 74);
			this.rbtnTitleOut.Name = "rbtnTitleOut";
			this.rbtnTitleOut.Size = new System.Drawing.Size(47, 16);
			this.rbtnTitleOut.TabIndex = 4;
			this.rbtnTitleOut.TabStop = true;
			this.rbtnTitleOut.Text = "离职";
			this.rbtnTitleOut.UseVisualStyleBackColor = true;
			// 
			// rbtnTitleAt
			// 
			this.rbtnTitleAt.AutoSize = true;
			this.rbtnTitleAt.Location = new System.Drawing.Point(74, 74);
			this.rbtnTitleAt.Name = "rbtnTitleAt";
			this.rbtnTitleAt.Size = new System.Drawing.Size(47, 16);
			this.rbtnTitleAt.TabIndex = 4;
			this.rbtnTitleAt.TabStop = true;
			this.rbtnTitleAt.Text = "在职";
			this.rbtnTitleAt.UseVisualStyleBackColor = true;
			// 
			// dtpLeftCompanyDate
			// 
			this.dtpLeftCompanyDate.Location = new System.Drawing.Point(348, 72);
			this.dtpLeftCompanyDate.Name = "dtpLeftCompanyDate";
			this.dtpLeftCompanyDate.ShowCheckBox = true;
			this.dtpLeftCompanyDate.Size = new System.Drawing.Size(162, 21);
			this.dtpLeftCompanyDate.TabIndex = 5;
			// 
			// txtWageCardAddress
			// 
			this.txtWageCardAddress.Location = new System.Drawing.Point(77, 174);
			this.txtWageCardAddress.Name = "txtWageCardAddress";
			this.txtWageCardAddress.Size = new System.Drawing.Size(433, 21);
			this.txtWageCardAddress.TabIndex = 9;
			// 
			// txtWageCardNumber
			// 
			this.txtWageCardNumber.Location = new System.Drawing.Point(78, 149);
			this.txtWageCardNumber.Name = "txtWageCardNumber";
			this.txtWageCardNumber.Size = new System.Drawing.Size(162, 21);
			this.txtWageCardNumber.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 12);
			this.label2.TabIndex = 70;
			this.label2.Text = "开户地:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 12);
			this.label4.TabIndex = 71;
			this.label4.Text = "工资卡号:";
			// 
			// txtLengthOfService
			// 
			this.txtLengthOfService.Location = new System.Drawing.Point(348, 22);
			this.txtLengthOfService.Name = "txtLengthOfService";
			this.txtLengthOfService.ReadOnly = true;
			this.txtLengthOfService.Size = new System.Drawing.Size(162, 21);
			this.txtLengthOfService.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(284, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 68;
			this.label1.Text = "企业工龄:";
			// 
			// dtpJoinCompanyDate
			// 
			this.dtpJoinCompanyDate.Location = new System.Drawing.Point(77, 22);
			this.dtpJoinCompanyDate.Name = "dtpJoinCompanyDate";
			this.dtpJoinCompanyDate.Size = new System.Drawing.Size(162, 21);
			this.dtpJoinCompanyDate.TabIndex = 0;
			this.dtpJoinCompanyDate.ValueChanged += new System.EventHandler(this.dtpJoinCompanyDate_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 12);
			this.label3.TabIndex = 66;
			this.label3.Text = "入司时间:";
			// 
			// txtSpecialSkill
			// 
			this.txtSpecialSkill.Location = new System.Drawing.Point(78, 123);
			this.txtSpecialSkill.Name = "txtSpecialSkill";
			this.txtSpecialSkill.Size = new System.Drawing.Size(433, 21);
			this.txtSpecialSkill.TabIndex = 7;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(348, 48);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(162, 21);
			this.txtTitle.TabIndex = 3;
			// 
			// txtLeftCompanyReason
			// 
			this.txtLeftCompanyReason.Location = new System.Drawing.Point(78, 97);
			this.txtLeftCompanyReason.Name = "txtLeftCompanyReason";
			this.txtLeftCompanyReason.Size = new System.Drawing.Size(433, 21);
			this.txtLeftCompanyReason.TabIndex = 6;
			// 
			// txtDepartment
			// 
			this.txtDepartment.Location = new System.Drawing.Point(78, 48);
			this.txtDepartment.Name = "txtDepartment";
			this.txtDepartment.Size = new System.Drawing.Size(162, 21);
			this.txtDepartment.TabIndex = 2;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(38, 126);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(35, 12);
			this.label19.TabIndex = 56;
			this.label19.Text = "特长:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(284, 76);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(59, 12);
			this.label14.TabIndex = 57;
			this.label14.Text = "离职时间:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(308, 52);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(35, 12);
			this.label17.TabIndex = 58;
			this.label17.Text = "职务:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(14, 101);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(59, 12);
			this.label16.TabIndex = 61;
			this.label16.Text = "离职原因:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(13, 76);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(59, 12);
			this.label12.TabIndex = 59;
			this.label12.Text = "就职状态:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(14, 52);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(59, 12);
			this.label11.TabIndex = 60;
			this.label11.Text = "所属部门:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rbtnNotCallIn);
			this.groupBox3.Controls.Add(this.rbtnCallIn);
			this.groupBox3.Controls.Add(this.txtArchivesNum);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.dtpArchiveCallInDate);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.dtpArchiveCallOutDate);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Location = new System.Drawing.Point(3, 234);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(516, 99);
			this.groupBox3.TabIndex = 27;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "人事档案";
			// 
			// rbtnNotCallIn
			// 
			this.rbtnNotCallIn.AutoSize = true;
			this.rbtnNotCallIn.Location = new System.Drawing.Point(190, 18);
			this.rbtnNotCallIn.Name = "rbtnNotCallIn";
			this.rbtnNotCallIn.Size = new System.Drawing.Size(35, 16);
			this.rbtnNotCallIn.TabIndex = 75;
			this.rbtnNotCallIn.TabStop = true;
			this.rbtnNotCallIn.Text = "否";
			this.rbtnNotCallIn.UseVisualStyleBackColor = true;
			// 
			// rbtnCallIn
			// 
			this.rbtnCallIn.AutoSize = true;
			this.rbtnCallIn.Location = new System.Drawing.Point(139, 18);
			this.rbtnCallIn.Name = "rbtnCallIn";
			this.rbtnCallIn.Size = new System.Drawing.Size(35, 16);
			this.rbtnCallIn.TabIndex = 74;
			this.rbtnCallIn.TabStop = true;
			this.rbtnCallIn.Text = "是";
			this.rbtnCallIn.UseVisualStyleBackColor = true;
			// 
			// txtArchivesNum
			// 
			this.txtArchivesNum.Location = new System.Drawing.Point(139, 42);
			this.txtArchivesNum.Name = "txtArchivesNum";
			this.txtArchivesNum.Size = new System.Drawing.Size(371, 21);
			this.txtArchivesNum.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(33, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(83, 12);
			this.label8.TabIndex = 73;
			this.label8.Text = "是否调入档案:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(57, 44);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 12);
			this.label7.TabIndex = 72;
			this.label7.Text = "档案编号:";
			// 
			// dtpArchiveCallInDate
			// 
			this.dtpArchiveCallInDate.Location = new System.Drawing.Point(78, 69);
			this.dtpArchiveCallInDate.Name = "dtpArchiveCallInDate";
			this.dtpArchiveCallInDate.Size = new System.Drawing.Size(162, 21);
			this.dtpArchiveCallInDate.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 12);
			this.label6.TabIndex = 70;
			this.label6.Text = "调入时间:";
			// 
			// dtpArchiveCallOutDate
			// 
			this.dtpArchiveCallOutDate.Location = new System.Drawing.Point(348, 69);
			this.dtpArchiveCallOutDate.Name = "dtpArchiveCallOutDate";
			this.dtpArchiveCallOutDate.ShowCheckBox = true;
			this.dtpArchiveCallOutDate.Size = new System.Drawing.Size(162, 21);
			this.dtpArchiveCallOutDate.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(284, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 12);
			this.label5.TabIndex = 68;
			this.label5.Text = "调出时间:";
			// 
			// WorkInfoUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Name = "WorkInfoUserControl";
			this.Size = new System.Drawing.Size(522, 368);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbtnTitleOut;
		private System.Windows.Forms.RadioButton rbtnTitleAt;
		private System.Windows.Forms.DateTimePicker dtpLeftCompanyDate;
		private System.Windows.Forms.TextBox txtWageCardAddress;
		private System.Windows.Forms.TextBox txtWageCardNumber;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtLengthOfService;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpJoinCompanyDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSpecialSkill;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtLeftCompanyReason;
		private System.Windows.Forms.TextBox txtDepartment;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DateTimePicker dtpArchiveCallInDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpArchiveCallOutDate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtArchivesNum;
		private System.Windows.Forms.RadioButton rbtnNotCallIn;
		private System.Windows.Forms.RadioButton rbtnCallIn;
	}
}

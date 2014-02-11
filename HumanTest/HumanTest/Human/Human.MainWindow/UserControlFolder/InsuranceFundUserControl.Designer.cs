namespace Human.MainWindow
{
	partial class InsuranceFundUserControl
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
			this.txtSocialPaymentAddress = new System.Windows.Forms.TextBox();
			this.txtSocialBasicNum = new System.Windows.Forms.TextBox();
			this.txtSocialNumber = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpSocialPaymentEndDate = new System.Windows.Forms.DateTimePicker();
			this.dtpSocialPaymentStartDate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dtpHousePaymentEndDate = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtphousePaymentStartDate = new System.Windows.Forms.DateTimePicker();
			this.txtHouseBasicNum = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtHousePaymentAddress = new System.Windows.Forms.TextBox();
			this.txtHouseNumber = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(284, 339);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 18;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(185, 339);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 19;
			this.btnSave.Text = "保存";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtSocialPaymentAddress
			// 
			this.txtSocialPaymentAddress.Location = new System.Drawing.Point(110, 71);
			this.txtSocialPaymentAddress.Name = "txtSocialPaymentAddress";
			this.txtSocialPaymentAddress.Size = new System.Drawing.Size(400, 21);
			this.txtSocialPaymentAddress.TabIndex = 13;
			// 
			// txtSocialBasicNum
			// 
			this.txtSocialBasicNum.Location = new System.Drawing.Point(110, 44);
			this.txtSocialBasicNum.Name = "txtSocialBasicNum";
			this.txtSocialBasicNum.Size = new System.Drawing.Size(400, 21);
			this.txtSocialBasicNum.TabIndex = 17;
			// 
			// txtSocialNumber
			// 
			this.txtSocialNumber.Location = new System.Drawing.Point(110, 18);
			this.txtSocialNumber.Name = "txtSocialNumber";
			this.txtSocialNumber.Size = new System.Drawing.Size(400, 21);
			this.txtSocialNumber.TabIndex = 12;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(42, 75);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(59, 12);
			this.label15.TabIndex = 7;
			this.label15.Text = "缴费地区:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(66, 48);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(35, 12);
			this.label14.TabIndex = 11;
			this.label14.Text = "基数:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(66, 21);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(35, 12);
			this.label12.TabIndex = 9;
			this.label12.Text = "号码:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpSocialPaymentEndDate);
			this.groupBox1.Controls.Add(this.dtpSocialPaymentStartDate);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtSocialNumber);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.txtSocialPaymentAddress);
			this.groupBox1.Controls.Add(this.txtSocialBasicNum);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(516, 149);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "社会保障卡";
			// 
			// dtpSocialPaymentEndDate
			// 
			this.dtpSocialPaymentEndDate.Location = new System.Drawing.Point(110, 125);
			this.dtpSocialPaymentEndDate.Name = "dtpSocialPaymentEndDate";
			this.dtpSocialPaymentEndDate.ShowCheckBox = true;
			this.dtpSocialPaymentEndDate.Size = new System.Drawing.Size(153, 21);
			this.dtpSocialPaymentEndDate.TabIndex = 18;
			// 
			// dtpSocialPaymentStartDate
			// 
			this.dtpSocialPaymentStartDate.Location = new System.Drawing.Point(110, 98);
			this.dtpSocialPaymentStartDate.Name = "dtpSocialPaymentStartDate";
			this.dtpSocialPaymentStartDate.Size = new System.Drawing.Size(153, 21);
			this.dtpSocialPaymentStartDate.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 102);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 12);
			this.label5.TabIndex = 9;
			this.label5.Text = "缴费开始时间:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(42, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 12);
			this.label4.TabIndex = 7;
			this.label4.Text = "截止时间:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dtpHousePaymentEndDate);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dtphousePaymentStartDate);
			this.groupBox2.Controls.Add(this.txtHouseBasicNum);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtHousePaymentAddress);
			this.groupBox2.Controls.Add(this.txtHouseNumber);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(3, 165);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(516, 154);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "住房公积金";
			// 
			// dtpHousePaymentEndDate
			// 
			this.dtpHousePaymentEndDate.Location = new System.Drawing.Point(110, 128);
			this.dtpHousePaymentEndDate.Name = "dtpHousePaymentEndDate";
			this.dtpHousePaymentEndDate.ShowCheckBox = true;
			this.dtpHousePaymentEndDate.Size = new System.Drawing.Size(153, 21);
			this.dtpHousePaymentEndDate.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "缴费地区:";
			// 
			// dtphousePaymentStartDate
			// 
			this.dtphousePaymentStartDate.Location = new System.Drawing.Point(110, 101);
			this.dtphousePaymentStartDate.Name = "dtphousePaymentStartDate";
			this.dtphousePaymentStartDate.Size = new System.Drawing.Size(153, 21);
			this.dtphousePaymentStartDate.TabIndex = 18;
			// 
			// txtHouseBasicNum
			// 
			this.txtHouseBasicNum.Location = new System.Drawing.Point(110, 45);
			this.txtHouseBasicNum.Name = "txtHouseBasicNum";
			this.txtHouseBasicNum.Size = new System.Drawing.Size(398, 21);
			this.txtHouseBasicNum.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(18, 103);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 12);
			this.label7.TabIndex = 9;
			this.label7.Text = "缴费开始时间:";
			// 
			// txtHousePaymentAddress
			// 
			this.txtHousePaymentAddress.Location = new System.Drawing.Point(110, 73);
			this.txtHousePaymentAddress.Name = "txtHousePaymentAddress";
			this.txtHousePaymentAddress.Size = new System.Drawing.Size(400, 21);
			this.txtHousePaymentAddress.TabIndex = 13;
			// 
			// txtHouseNumber
			// 
			this.txtHouseNumber.Location = new System.Drawing.Point(110, 18);
			this.txtHouseNumber.Name = "txtHouseNumber";
			this.txtHouseNumber.Size = new System.Drawing.Size(398, 21);
			this.txtHouseNumber.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(66, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 12);
			this.label2.TabIndex = 11;
			this.label2.Text = "基数:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(66, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 12);
			this.label6.TabIndex = 9;
			this.label6.Text = "号码:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "截止时间:";
			// 
			// InsuranceFundUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Name = "InsuranceFundUserControl";
			this.Size = new System.Drawing.Size(522, 368);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtSocialPaymentAddress;
		private System.Windows.Forms.TextBox txtSocialBasicNum;
		private System.Windows.Forms.TextBox txtSocialNumber;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpSocialPaymentEndDate;
		private System.Windows.Forms.DateTimePicker dtpSocialPaymentStartDate;
		private System.Windows.Forms.DateTimePicker dtpHousePaymentEndDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtphousePaymentStartDate;
		private System.Windows.Forms.TextBox txtHouseBasicNum;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtHousePaymentAddress;
		private System.Windows.Forms.TextBox txtHouseNumber;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
	}
}

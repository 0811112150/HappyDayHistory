namespace Human.MainWindow
{
	partial class ContractInfoForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractInfoForm));
			this.label2 = new System.Windows.Forms.Label();
			this.rbtnNotFirstContract = new System.Windows.Forms.RadioButton();
			this.rbtnIsFirstContract = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.cbxContractrType = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtContractNum = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpProbationEndDate = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(48, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 12);
			this.label2.TabIndex = 59;
			this.label2.Text = "是否首签:";
			// 
			// rbtnNotFirstContract
			// 
			this.rbtnNotFirstContract.AutoSize = true;
			this.rbtnNotFirstContract.Location = new System.Drawing.Point(170, 16);
			this.rbtnNotFirstContract.Name = "rbtnNotFirstContract";
			this.rbtnNotFirstContract.Size = new System.Drawing.Size(47, 16);
			this.rbtnNotFirstContract.TabIndex = 0;
			this.rbtnNotFirstContract.Text = "续签";
			this.rbtnNotFirstContract.UseVisualStyleBackColor = true;
			// 
			// rbtnIsFirstContract
			// 
			this.rbtnIsFirstContract.AutoSize = true;
			this.rbtnIsFirstContract.Checked = true;
			this.rbtnIsFirstContract.Location = new System.Drawing.Point(116, 16);
			this.rbtnIsFirstContract.Name = "rbtnIsFirstContract";
			this.rbtnIsFirstContract.Size = new System.Drawing.Size(47, 16);
			this.rbtnIsFirstContract.TabIndex = 0;
			this.rbtnIsFirstContract.TabStop = true;
			this.rbtnIsFirstContract.Text = "首签";
			this.rbtnIsFirstContract.UseVisualStyleBackColor = true;
			this.rbtnIsFirstContract.CheckedChanged += new System.EventHandler(this.rbtnIsFirstContract_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(48, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 12);
			this.label5.TabIndex = 51;
			this.label5.Text = "合同编号:";
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.Location = new System.Drawing.Point(116, 96);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.Size = new System.Drawing.Size(173, 21);
			this.dtpStartDate.TabIndex = 62;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(48, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 12);
			this.label3.TabIndex = 49;
			this.label3.Text = "合同类型:";
			// 
			// cbxContractrType
			// 
			this.cbxContractrType.FormattingEnabled = true;
			this.cbxContractrType.Location = new System.Drawing.Point(116, 41);
			this.cbxContractrType.Name = "cbxContractrType";
			this.cbxContractrType.Size = new System.Drawing.Size(173, 20);
			this.cbxContractrType.TabIndex = 61;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(48, 100);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 12);
			this.label7.TabIndex = 50;
			this.label7.Text = "起始时间:";
			// 
			// txtContractNum
			// 
			this.txtContractNum.Location = new System.Drawing.Point(116, 66);
			this.txtContractNum.Name = "txtContractNum";
			this.txtContractNum.Size = new System.Drawing.Size(173, 21);
			this.txtContractNum.TabIndex = 55;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(48, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 12);
			this.label4.TabIndex = 50;
			this.label4.Text = "终止时间:";
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.Location = new System.Drawing.Point(116, 125);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(173, 21);
			this.dtpEndDate.TabIndex = 62;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(170, 189);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 78;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(77, 189);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 79;
			this.btnSave.Text = "保存";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.dtpProbationEndDate);
			this.panel1.Location = new System.Drawing.Point(12, 146);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(287, 31);
			this.panel1.TabIndex = 80;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 12);
			this.label1.TabIndex = 63;
			this.label1.Text = "试用期截止时间:";
			// 
			// dtpProbationEndDate
			// 
			this.dtpProbationEndDate.Location = new System.Drawing.Point(109, 9);
			this.dtpProbationEndDate.Name = "dtpProbationEndDate";
			this.dtpProbationEndDate.Size = new System.Drawing.Size(173, 21);
			this.dtpProbationEndDate.TabIndex = 64;
			// 
			// ContractInfoForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(311, 221);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.dtpEndDate);
			this.Controls.Add(this.rbtnNotFirstContract);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtContractNum);
			this.Controls.Add(this.rbtnIsFirstContract);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbxContractrType);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtpStartDate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ContractInfoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "劳动合同关系";
			this.Load += new System.EventHandler(this.ContractInfoForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtContractNum;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbxContractrType;
		private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rbtnNotFirstContract;
        private System.Windows.Forms.RadioButton rbtnIsFirstContract;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpProbationEndDate;

	}
}
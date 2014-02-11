namespace Human.MainWindow
{
	partial class FamilyInfoForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FamilyInfoForm));
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPhoneNum = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFamilyPeopleName = new System.Windows.Forms.TextBox();
			this.txtWorkUnit = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRelation = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(82, 85);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(267, 21);
			this.txtTitle.TabIndex = 75;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 12);
			this.label1.TabIndex = 74;
			this.label1.Text = "职务:";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(82, 133);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(267, 21);
			this.txtAddress.TabIndex = 73;
			// 
			// txtPhoneNum
			// 
			this.txtPhoneNum.Location = new System.Drawing.Point(82, 109);
			this.txtPhoneNum.Name = "txtPhoneNum";
			this.txtPhoneNum.Size = new System.Drawing.Size(267, 21);
			this.txtPhoneNum.TabIndex = 72;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(18, 136);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(59, 12);
			this.label17.TabIndex = 70;
			this.label17.Text = "现所在地:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(18, 112);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(59, 12);
			this.label11.TabIndex = 71;
			this.label11.Text = "联系方式:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 12);
			this.label2.TabIndex = 71;
			this.label2.Text = "姓名:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 12);
			this.label3.TabIndex = 70;
			this.label3.Text = "工作单位:";
			// 
			// txtFamilyPeopleName
			// 
			this.txtFamilyPeopleName.Location = new System.Drawing.Point(82, 37);
			this.txtFamilyPeopleName.Name = "txtFamilyPeopleName";
			this.txtFamilyPeopleName.Size = new System.Drawing.Size(267, 21);
			this.txtFamilyPeopleName.TabIndex = 72;
			this.txtFamilyPeopleName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFamilyPeopleName_Validating);
			// 
			// txtWorkUnit
			// 
			this.txtWorkUnit.Location = new System.Drawing.Point(82, 61);
			this.txtWorkUnit.Name = "txtWorkUnit";
			this.txtWorkUnit.Size = new System.Drawing.Size(267, 21);
			this.txtWorkUnit.TabIndex = 73;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(42, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 12);
			this.label4.TabIndex = 74;
			this.label4.Text = "称谓:";
			// 
			// txtRelation
			// 
			this.txtRelation.Location = new System.Drawing.Point(82, 13);
			this.txtRelation.Name = "txtRelation";
			this.txtRelation.Size = new System.Drawing.Size(267, 21);
			this.txtRelation.TabIndex = 75;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(178, 171);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 76;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(85, 171);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 77;
			this.btnSave.Text = "保存";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FamilyInfoForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(392, 218);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtRelation);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtWorkUnit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtFamilyPeopleName);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPhoneNum);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label11);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FamilyInfoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "家庭成员";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtPhoneNum;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtFamilyPeopleName;
		private System.Windows.Forms.TextBox txtWorkUnit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRelation;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}
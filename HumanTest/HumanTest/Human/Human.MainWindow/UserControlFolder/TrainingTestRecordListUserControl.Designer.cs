namespace Human.MainWindow
{
	partial class TrainingTestRecordListUserControl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvRecordList = new System.Windows.Forms.DataGridView();
			this.RecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrainingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrainingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrainingContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrainingDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TestResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TestPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDel = new System.Windows.Forms.DataGridViewLinkColumn();
			this.btnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
			this.btnNew = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvRecordList)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvRecordList
			// 
			this.dgvRecordList.AllowUserToAddRows = false;
			this.dgvRecordList.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.dgvRecordList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvRecordList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRecordList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRecordList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordID,
            this.TrainingDate,
            this.TrainingType,
            this.TrainingContent,
            this.TrainingDepartment,
            this.TestDate,
            this.TestResult,
            this.TestPeople,
            this.Remark,
            this.btnDel,
            this.btnEdit});
			this.dgvRecordList.Location = new System.Drawing.Point(0, 0);
			this.dgvRecordList.Name = "dgvRecordList";
			this.dgvRecordList.ReadOnly = true;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRecordList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvRecordList.RowHeadersVisible = false;
			this.dgvRecordList.RowHeadersWidth = 20;
			dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
			this.dgvRecordList.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvRecordList.RowTemplate.Height = 23;
			this.dgvRecordList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRecordList.Size = new System.Drawing.Size(744, 468);
			this.dgvRecordList.TabIndex = 8;
			this.dgvRecordList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecordList_CellContentClick);
			// 
			// RecordID
			// 
			this.RecordID.DataPropertyName = "RecordID";
			this.RecordID.HeaderText = "RecordID";
			this.RecordID.Name = "RecordID";
			this.RecordID.ReadOnly = true;
			this.RecordID.Visible = false;
			// 
			// TrainingDate
			// 
			this.TrainingDate.DataPropertyName = "TrainingDate";
			this.TrainingDate.HeaderText = "培训时间";
			this.TrainingDate.Name = "TrainingDate";
			this.TrainingDate.ReadOnly = true;
			// 
			// TrainingType
			// 
			this.TrainingType.DataPropertyName = "TrainingType";
			this.TrainingType.HeaderText = "培训类型";
			this.TrainingType.Name = "TrainingType";
			this.TrainingType.ReadOnly = true;
			this.TrainingType.Width = 80;
			// 
			// TrainingContent
			// 
			this.TrainingContent.DataPropertyName = "TrainingContent";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.TrainingContent.DefaultCellStyle = dataGridViewCellStyle3;
			this.TrainingContent.HeaderText = "培训内容";
			this.TrainingContent.Name = "TrainingContent";
			this.TrainingContent.ReadOnly = true;
			// 
			// TrainingDepartment
			// 
			this.TrainingDepartment.DataPropertyName = "TrainingDepartment";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.TrainingDepartment.DefaultCellStyle = dataGridViewCellStyle4;
			this.TrainingDepartment.HeaderText = "培训部门";
			this.TrainingDepartment.Name = "TrainingDepartment";
			this.TrainingDepartment.ReadOnly = true;
			// 
			// TestDate
			// 
			this.TestDate.DataPropertyName = "TestDate";
			this.TestDate.HeaderText = "考核时间";
			this.TestDate.Name = "TestDate";
			this.TestDate.ReadOnly = true;
			// 
			// TestResult
			// 
			this.TestResult.DataPropertyName = "TestResult";
			this.TestResult.HeaderText = "考核结果";
			this.TestResult.Name = "TestResult";
			this.TestResult.ReadOnly = true;
			// 
			// TestPeople
			// 
			this.TestPeople.DataPropertyName = "TestPeople";
			this.TestPeople.HeaderText = "考核人";
			this.TestPeople.Name = "TestPeople";
			this.TestPeople.ReadOnly = true;
			// 
			// Remark
			// 
			this.Remark.DataPropertyName = "Remark";
			this.Remark.HeaderText = "备注";
			this.Remark.Name = "Remark";
			this.Remark.ReadOnly = true;
			// 
			// btnDel
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
			this.btnDel.DefaultCellStyle = dataGridViewCellStyle5;
			this.btnDel.HeaderText = "删除";
			this.btnDel.Name = "btnDel";
			this.btnDel.ReadOnly = true;
			this.btnDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.btnDel.Text = "删除";
			this.btnDel.UseColumnTextForLinkValue = true;
			this.btnDel.Width = 70;
			// 
			// btnEdit
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.btnEdit.DefaultCellStyle = dataGridViewCellStyle6;
			this.btnEdit.HeaderText = "修改";
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.ReadOnly = true;
			this.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.btnEdit.Text = "修改";
			this.btnEdit.UseColumnTextForLinkValue = true;
			this.btnEdit.Width = 70;
			// 
			// btnNew
			// 
			this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNew.Location = new System.Drawing.Point(3, 475);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(90, 30);
			this.btnNew.TabIndex = 7;
			this.btnNew.Text = "新建";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// TrainingTestRecordListUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgvRecordList);
			this.Controls.Add(this.btnNew);
			this.Name = "TrainingTestRecordListUserControl";
			this.Size = new System.Drawing.Size(744, 509);
			((System.ComponentModel.ISupportInitialize)(this.dgvRecordList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvRecordList;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.DataGridViewTextBoxColumn RecordID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrainingDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrainingType;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrainingContent;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrainingDepartment;
		private System.Windows.Forms.DataGridViewTextBoxColumn TestDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn TestResult;
		private System.Windows.Forms.DataGridViewTextBoxColumn TestPeople;
		private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
		private System.Windows.Forms.DataGridViewLinkColumn btnDel;
		private System.Windows.Forms.DataGridViewLinkColumn btnEdit;
	}
}

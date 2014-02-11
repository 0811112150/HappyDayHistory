namespace Human.MainWindow
{
	partial class TitleWageChangeRecordListUserControl
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
			this.dgvContractList = new System.Windows.Forms.DataGridView();
			this.btnNew = new System.Windows.Forms.Button();
			this.RecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChangeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ContractrType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ContractNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BeforeChangeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BeforeChangeBasicWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BeforeChangeallowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BeforeChangeYearAward = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AfterChangeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AfterChangeBasicWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AfterChangeAllowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AfterChangeYearAward = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDel = new System.Windows.Forms.DataGridViewLinkColumn();
			this.btnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvContractList)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvContractList
			// 
			this.dgvContractList.AllowUserToAddRows = false;
			this.dgvContractList.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.dgvContractList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvContractList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvContractList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvContractList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContractList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordID,
            this.ChangeDate,
            this.ContractrType,
            this.ContractNum,
            this.BeforeChangeTitle,
            this.BeforeChangeBasicWage,
            this.BeforeChangeallowance,
            this.BeforeChangeYearAward,
            this.AfterChangeTitle,
            this.AfterChangeBasicWage,
            this.AfterChangeAllowance,
            this.AfterChangeYearAward,
            this.btnDel,
            this.btnEdit});
			this.dgvContractList.Location = new System.Drawing.Point(0, 0);
			this.dgvContractList.Name = "dgvContractList";
			this.dgvContractList.ReadOnly = true;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvContractList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvContractList.RowHeadersVisible = false;
			this.dgvContractList.RowHeadersWidth = 20;
			dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
			this.dgvContractList.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvContractList.RowTemplate.Height = 23;
			this.dgvContractList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvContractList.Size = new System.Drawing.Size(744, 468);
			this.dgvContractList.TabIndex = 8;
			this.dgvContractList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContractList_CellContentClick);
			// 
			// btnNew
			// 
			this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNew.Location = new System.Drawing.Point(3, 474);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(90, 30);
			this.btnNew.TabIndex = 7;
			this.btnNew.Text = "新建";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// RecordID
			// 
			this.RecordID.DataPropertyName = "TitleWageChangeRecordID";
			this.RecordID.HeaderText = "RecordID";
			this.RecordID.Name = "RecordID";
			this.RecordID.ReadOnly = true;
			this.RecordID.Visible = false;
			// 
			// ChangeDate
			// 
			this.ChangeDate.DataPropertyName = "ChangeDate";
			this.ChangeDate.HeaderText = "时间";
			this.ChangeDate.Name = "ChangeDate";
			this.ChangeDate.ReadOnly = true;
			// 
			// ContractrType
			// 
			this.ContractrType.DataPropertyName = "ChangeTypeStr";
			this.ContractrType.HeaderText = "类型";
			this.ContractrType.Name = "ContractrType";
			this.ContractrType.ReadOnly = true;
			this.ContractrType.Width = 80;
			// 
			// ContractNum
			// 
			this.ContractNum.DataPropertyName = "ContractNum";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.ContractNum.DefaultCellStyle = dataGridViewCellStyle3;
			this.ContractNum.HeaderText = "合同编号";
			this.ContractNum.Name = "ContractNum";
			this.ContractNum.ReadOnly = true;
			// 
			// BeforeChangeTitle
			// 
			this.BeforeChangeTitle.DataPropertyName = "BeforeChangeTitle";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.BeforeChangeTitle.DefaultCellStyle = dataGridViewCellStyle4;
			this.BeforeChangeTitle.HeaderText = "变更前职位";
			this.BeforeChangeTitle.Name = "BeforeChangeTitle";
			this.BeforeChangeTitle.ReadOnly = true;
			// 
			// BeforeChangeBasicWage
			// 
			this.BeforeChangeBasicWage.DataPropertyName = "BeforeChangeBasicWage";
			this.BeforeChangeBasicWage.HeaderText = "基本工资";
			this.BeforeChangeBasicWage.Name = "BeforeChangeBasicWage";
			this.BeforeChangeBasicWage.ReadOnly = true;
			// 
			// BeforeChangeallowance
			// 
			this.BeforeChangeallowance.DataPropertyName = "BeforeChangeallowance";
			this.BeforeChangeallowance.HeaderText = "岗位津贴";
			this.BeforeChangeallowance.Name = "BeforeChangeallowance";
			this.BeforeChangeallowance.ReadOnly = true;
			// 
			// BeforeChangeYearAward
			// 
			this.BeforeChangeYearAward.DataPropertyName = "BeforeChangeYearAward";
			this.BeforeChangeYearAward.HeaderText = "年终奖";
			this.BeforeChangeYearAward.Name = "BeforeChangeYearAward";
			this.BeforeChangeYearAward.ReadOnly = true;
			// 
			// AfterChangeTitle
			// 
			this.AfterChangeTitle.DataPropertyName = "AfterChangeTitle";
			this.AfterChangeTitle.HeaderText = "变更后职位";
			this.AfterChangeTitle.Name = "AfterChangeTitle";
			this.AfterChangeTitle.ReadOnly = true;
			// 
			// AfterChangeBasicWage
			// 
			this.AfterChangeBasicWage.DataPropertyName = "AfterChangeBasicWage";
			this.AfterChangeBasicWage.HeaderText = "基本工资";
			this.AfterChangeBasicWage.Name = "AfterChangeBasicWage";
			this.AfterChangeBasicWage.ReadOnly = true;
			// 
			// AfterChangeAllowance
			// 
			this.AfterChangeAllowance.DataPropertyName = "AfterChangeAllowance";
			this.AfterChangeAllowance.HeaderText = "岗位津贴";
			this.AfterChangeAllowance.Name = "AfterChangeAllowance";
			this.AfterChangeAllowance.ReadOnly = true;
			// 
			// AfterChangeYearAward
			// 
			this.AfterChangeYearAward.DataPropertyName = "AfterChangeYearAward";
			this.AfterChangeYearAward.HeaderText = "年终奖";
			this.AfterChangeYearAward.Name = "AfterChangeYearAward";
			this.AfterChangeYearAward.ReadOnly = true;
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
			// TitleWageChangeRecordListUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgvContractList);
			this.Controls.Add(this.btnNew);
			this.Name = "TitleWageChangeRecordListUserControl";
			this.Size = new System.Drawing.Size(744, 509);
			((System.ComponentModel.ISupportInitialize)(this.dgvContractList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvContractList;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.DataGridViewTextBoxColumn TitleWageChangeRecordID;
		private System.Windows.Forms.DataGridViewTextBoxColumn RecordID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChangeDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ContractrType;
		private System.Windows.Forms.DataGridViewTextBoxColumn ContractNum;
		private System.Windows.Forms.DataGridViewTextBoxColumn BeforeChangeTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn BeforeChangeBasicWage;
		private System.Windows.Forms.DataGridViewTextBoxColumn BeforeChangeallowance;
		private System.Windows.Forms.DataGridViewTextBoxColumn BeforeChangeYearAward;
		private System.Windows.Forms.DataGridViewTextBoxColumn AfterChangeTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn AfterChangeBasicWage;
		private System.Windows.Forms.DataGridViewTextBoxColumn AfterChangeAllowance;
		private System.Windows.Forms.DataGridViewTextBoxColumn AfterChangeYearAward;
		private System.Windows.Forms.DataGridViewLinkColumn btnDel;
		private System.Windows.Forms.DataGridViewLinkColumn btnEdit;

	}
}

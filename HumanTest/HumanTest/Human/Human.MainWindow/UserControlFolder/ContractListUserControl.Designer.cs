namespace Human.MainWindow
{
	partial class ContractListUserControl
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
			this.ContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsFirstContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ContractrType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ContractNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProbationEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDel = new System.Windows.Forms.DataGridViewLinkColumn();
			this.btnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
			this.btnNew = new System.Windows.Forms.Button();
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
			this.dgvContractList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContractID,
            this.IsFirstContract,
            this.ContractrType,
            this.ContractNum,
            this.StartDate,
            this.ProbationEndDate,
            this.EndDate,
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
			this.dgvContractList.Size = new System.Drawing.Size(741, 468);
			this.dgvContractList.TabIndex = 6;
			this.dgvContractList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContractList_CellContentClick);
			// 
			// ContractID
			// 
			this.ContractID.DataPropertyName = "ContractID";
			this.ContractID.HeaderText = "ContractID";
			this.ContractID.Name = "ContractID";
			this.ContractID.ReadOnly = true;
			this.ContractID.Visible = false;
			// 
			// IsFirstContract
			// 
			this.IsFirstContract.DataPropertyName = "IsFirstContractStr";
			this.IsFirstContract.HeaderText = "首签/续签";
			this.IsFirstContract.Name = "IsFirstContract";
			this.IsFirstContract.ReadOnly = true;
			// 
			// ContractrType
			// 
			this.ContractrType.DataPropertyName = "ContractrTypeStr";
			this.ContractrType.HeaderText = "合同类型";
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
			// StartDate
			// 
			this.StartDate.DataPropertyName = "StartDate";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.StartDate.DefaultCellStyle = dataGridViewCellStyle4;
			this.StartDate.HeaderText = "起始时间";
			this.StartDate.Name = "StartDate";
			this.StartDate.ReadOnly = true;
			// 
			// ProbationEndDate
			// 
			this.ProbationEndDate.DataPropertyName = "ProbationEndDate";
			this.ProbationEndDate.HeaderText = "试用期截止时间";
			this.ProbationEndDate.Name = "ProbationEndDate";
			this.ProbationEndDate.ReadOnly = true;
			// 
			// EndDate
			// 
			this.EndDate.DataPropertyName = "EndDate";
			this.EndDate.HeaderText = "终止时间";
			this.EndDate.Name = "EndDate";
			this.EndDate.ReadOnly = true;
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
			this.btnNew.Location = new System.Drawing.Point(3, 474);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(90, 30);
			this.btnNew.TabIndex = 5;
			this.btnNew.Text = "新建";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// ContractListUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgvContractList);
			this.Controls.Add(this.btnNew);
			this.Name = "ContractListUserControl";
			this.Size = new System.Drawing.Size(744, 509);
			((System.ComponentModel.ISupportInitialize)(this.dgvContractList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvContractList;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.DataGridViewTextBoxColumn ContractID;
		private System.Windows.Forms.DataGridViewTextBoxColumn IsFirstContract;
		private System.Windows.Forms.DataGridViewTextBoxColumn ContractrType;
		private System.Windows.Forms.DataGridViewTextBoxColumn ContractNum;
		private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProbationEndDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
		private System.Windows.Forms.DataGridViewLinkColumn btnDel;
		private System.Windows.Forms.DataGridViewLinkColumn btnEdit;
	}
}

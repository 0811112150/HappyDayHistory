namespace Human.MainWindow
{
	partial class RewardRecordListUserControl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvRecoedtList = new System.Windows.Forms.DataGridView();
			this.RecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RewardDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RewardContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDel = new System.Windows.Forms.DataGridViewLinkColumn();
			this.btnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
			this.btnNew = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvRecoedtList)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvRecoedtList
			// 
			this.dgvRecoedtList.AllowUserToAddRows = false;
			this.dgvRecoedtList.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.dgvRecoedtList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvRecoedtList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRecoedtList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvRecoedtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRecoedtList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordID,
            this.RewardDate,
            this.RewardContent,
            this.btnDel,
            this.btnEdit});
			this.dgvRecoedtList.Location = new System.Drawing.Point(0, 0);
			this.dgvRecoedtList.Name = "dgvRecoedtList";
			this.dgvRecoedtList.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRecoedtList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvRecoedtList.RowHeadersVisible = false;
			this.dgvRecoedtList.RowHeadersWidth = 20;
			dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
			this.dgvRecoedtList.RowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvRecoedtList.RowTemplate.Height = 23;
			this.dgvRecoedtList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRecoedtList.Size = new System.Drawing.Size(744, 468);
			this.dgvRecoedtList.TabIndex = 8;
			this.dgvRecoedtList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecoedtList_CellContentClick);
			// 
			// RecordID
			// 
			this.RecordID.DataPropertyName = "RecordID";
			this.RecordID.HeaderText = "RecordID";
			this.RecordID.Name = "RecordID";
			this.RecordID.ReadOnly = true;
			this.RecordID.Visible = false;
			// 
			// RewardDate
			// 
			this.RewardDate.DataPropertyName = "RewardDate";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.RewardDate.DefaultCellStyle = dataGridViewCellStyle3;
			this.RewardDate.HeaderText = "奖惩时间";
			this.RewardDate.Name = "RewardDate";
			this.RewardDate.ReadOnly = true;
			// 
			// RewardContent
			// 
			this.RewardContent.DataPropertyName = "RewardContent";
			this.RewardContent.HeaderText = "奖惩内容";
			this.RewardContent.Name = "RewardContent";
			this.RewardContent.ReadOnly = true;
			// 
			// btnDel
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
			this.btnDel.DefaultCellStyle = dataGridViewCellStyle4;
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
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.btnEdit.DefaultCellStyle = dataGridViewCellStyle5;
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
			this.btnNew.TabIndex = 7;
			this.btnNew.Text = "新建";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// RewardRecordListUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgvRecoedtList);
			this.Controls.Add(this.btnNew);
			this.Name = "RewardRecordListUserControl";
			this.Size = new System.Drawing.Size(744, 509);
			((System.ComponentModel.ISupportInitialize)(this.dgvRecoedtList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvRecoedtList;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.DataGridViewTextBoxColumn RecordID;
		private System.Windows.Forms.DataGridViewTextBoxColumn RewardDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn RewardContent;
		private System.Windows.Forms.DataGridViewLinkColumn btnDel;
		private System.Windows.Forms.DataGridViewLinkColumn btnEdit;
	}
}

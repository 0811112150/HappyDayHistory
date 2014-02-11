namespace Human.MainWindow
{
	partial class FamilyListUserControl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnNew = new System.Windows.Forms.Button();
			this.dgvFamilyList = new System.Windows.Forms.DataGridView();
			this.PeopleFamilyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Relation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PeopleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WorkUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDel = new System.Windows.Forms.DataGridViewLinkColumn();
			this.btnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvFamilyList)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNew
			// 
			this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNew.Location = new System.Drawing.Point(3, 474);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(90, 30);
			this.btnNew.TabIndex = 2;
			this.btnNew.Text = "新建";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// dgvFamilyList
			// 
			this.dgvFamilyList.AllowUserToAddRows = false;
			this.dgvFamilyList.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.dgvFamilyList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvFamilyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFamilyList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvFamilyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PeopleFamilyID,
            this.Relation,
            this.PeopleName,
            this.WorkUnit,
            this.Title,
            this.PhoneNum,
            this.Address,
            this.btnDel,
            this.btnEdit});
			this.dgvFamilyList.Location = new System.Drawing.Point(0, 0);
			this.dgvFamilyList.Name = "dgvFamilyList";
			this.dgvFamilyList.ReadOnly = true;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFamilyList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvFamilyList.RowHeadersVisible = false;
			this.dgvFamilyList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
			this.dgvFamilyList.RowsDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvFamilyList.RowTemplate.Height = 23;
			this.dgvFamilyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFamilyList.Size = new System.Drawing.Size(845, 468);
			this.dgvFamilyList.TabIndex = 4;
			this.dgvFamilyList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFamilyList_CellContentClick);
			// 
			// PeopleFamilyID
			// 
			this.PeopleFamilyID.DataPropertyName = "PeopleFamilyID";
			this.PeopleFamilyID.HeaderText = "PeopleFamilyID";
			this.PeopleFamilyID.Name = "PeopleFamilyID";
			this.PeopleFamilyID.ReadOnly = true;
			this.PeopleFamilyID.Visible = false;
			// 
			// Relation
			// 
			this.Relation.DataPropertyName = "Relation";
			this.Relation.HeaderText = "称谓";
			this.Relation.Name = "Relation";
			this.Relation.ReadOnly = true;
			this.Relation.Width = 80;
			// 
			// PeopleName
			// 
			this.PeopleName.DataPropertyName = "FamilyPeopleName";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.PeopleName.DefaultCellStyle = dataGridViewCellStyle3;
			this.PeopleName.HeaderText = "姓名";
			this.PeopleName.Name = "PeopleName";
			this.PeopleName.ReadOnly = true;
			// 
			// WorkUnit
			// 
			this.WorkUnit.DataPropertyName = "WorkUnit";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.WorkUnit.DefaultCellStyle = dataGridViewCellStyle4;
			this.WorkUnit.HeaderText = "工作单位";
			this.WorkUnit.Name = "WorkUnit";
			this.WorkUnit.ReadOnly = true;
			// 
			// Title
			// 
			this.Title.DataPropertyName = "Title";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Title.DefaultCellStyle = dataGridViewCellStyle5;
			this.Title.HeaderText = "职务";
			this.Title.Name = "Title";
			this.Title.ReadOnly = true;
			// 
			// PhoneNum
			// 
			this.PhoneNum.DataPropertyName = "PhoneNum";
			this.PhoneNum.HeaderText = "联系方式";
			this.PhoneNum.Name = "PhoneNum";
			this.PhoneNum.ReadOnly = true;
			// 
			// Address
			// 
			this.Address.DataPropertyName = "Address";
			this.Address.HeaderText = "现所在地";
			this.Address.Name = "Address";
			this.Address.ReadOnly = true;
			// 
			// btnDel
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
			this.btnDel.DefaultCellStyle = dataGridViewCellStyle6;
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
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.btnEdit.DefaultCellStyle = dataGridViewCellStyle7;
			this.btnEdit.HeaderText = "修改";
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.ReadOnly = true;
			this.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.btnEdit.Text = "修改";
			this.btnEdit.UseColumnTextForLinkValue = true;
			this.btnEdit.Width = 70;
			// 
			// FamilyListUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgvFamilyList);
			this.Controls.Add(this.btnNew);
			this.Name = "FamilyListUserControl";
			this.Size = new System.Drawing.Size(845, 508);
			((System.ComponentModel.ISupportInitialize)(this.dgvFamilyList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.DataGridView dgvFamilyList;
		private System.Windows.Forms.DataGridViewTextBoxColumn PeopleFamilyID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Relation;
		private System.Windows.Forms.DataGridViewTextBoxColumn PeopleName;
		private System.Windows.Forms.DataGridViewTextBoxColumn WorkUnit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Title;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
		private System.Windows.Forms.DataGridViewTextBoxColumn Address;
		private System.Windows.Forms.DataGridViewLinkColumn btnDel;
		private System.Windows.Forms.DataGridViewLinkColumn btnEdit;
	}
}

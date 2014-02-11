namespace Human.MainWindow
{
	partial class PeoplePicUserControl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.dgvPicList = new System.Windows.Forms.DataGridView();
			this.btnNew = new System.Windows.Forms.Button();
			this.PicID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PicTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PicPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDownload = new System.Windows.Forms.DataGridViewLinkColumn();
			this.btnDel = new System.Windows.Forms.DataGridViewLinkColumn();
			this.btnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dgvPicList)).BeginInit();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// dgvPicList
			// 
			this.dgvPicList.AllowUserToAddRows = false;
			this.dgvPicList.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.dgvPicList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPicList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPicList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvPicList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPicList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PicID,
            this.PicTitle,
            this.FileType,
            this.PicPath,
            this.btnDownload,
            this.btnDel,
            this.btnEdit});
			this.dgvPicList.Location = new System.Drawing.Point(0, 0);
			this.dgvPicList.Name = "dgvPicList";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPicList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvPicList.RowHeadersVisible = false;
			this.dgvPicList.RowHeadersWidth = 20;
			dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
			this.dgvPicList.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvPicList.RowTemplate.Height = 23;
			this.dgvPicList.Size = new System.Drawing.Size(744, 468);
			this.dgvPicList.TabIndex = 8;
			this.dgvPicList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPicList_CellContentClick);
			this.dgvPicList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPicList_DataBindingComplete);
			// 
			// btnNew
			// 
			this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNew.Location = new System.Drawing.Point(14, 474);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(90, 30);
			this.btnNew.TabIndex = 7;
			this.btnNew.Text = "新建";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// PicID
			// 
			this.PicID.DataPropertyName = "PicID";
			this.PicID.HeaderText = "PicID";
			this.PicID.Name = "PicID";
			this.PicID.Visible = false;
			// 
			// PicTitle
			// 
			this.PicTitle.DataPropertyName = "PicTitle";
			this.PicTitle.HeaderText = "文件信息";
			this.PicTitle.Name = "PicTitle";
			// 
			// FileType
			// 
			this.FileType.HeaderText = "类型";
			this.FileType.Name = "FileType";
			// 
			// PicPath
			// 
			this.PicPath.DataPropertyName = "PicPath";
			this.PicPath.HeaderText = "文件路径";
			this.PicPath.Name = "PicPath";
			// 
			// btnDownload
			// 
			this.btnDownload.HeaderText = "下载";
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.btnDownload.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.btnDownload.Text = "下载";
			this.btnDownload.ToolTipText = "下载";
			this.btnDownload.UseColumnTextForLinkValue = true;
			// 
			// btnDel
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
			this.btnDel.DefaultCellStyle = dataGridViewCellStyle3;
			this.btnDel.HeaderText = "删除";
			this.btnDel.Name = "btnDel";
			this.btnDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.btnDel.Text = "删除";
			this.btnDel.UseColumnTextForLinkValue = true;
			this.btnDel.Width = 70;
			// 
			// btnEdit
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.btnEdit.DefaultCellStyle = dataGridViewCellStyle4;
			this.btnEdit.HeaderText = "修改";
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.btnEdit.Text = "修改";
			this.btnEdit.UseColumnTextForLinkValue = true;
			this.btnEdit.Width = 70;
			// 
			// PeoplePicUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgvPicList);
			this.Controls.Add(this.btnNew);
			this.Name = "PeoplePicUserControl";
			this.Size = new System.Drawing.Size(744, 509);
			((System.ComponentModel.ISupportInitialize)(this.dgvPicList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.DataGridView dgvPicList;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.DataGridViewTextBoxColumn PicID;
		private System.Windows.Forms.DataGridViewTextBoxColumn PicTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn FileType;
		private System.Windows.Forms.DataGridViewTextBoxColumn PicPath;
		private System.Windows.Forms.DataGridViewLinkColumn btnDownload;
		private System.Windows.Forms.DataGridViewLinkColumn btnDel;
		private System.Windows.Forms.DataGridViewLinkColumn btnEdit;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

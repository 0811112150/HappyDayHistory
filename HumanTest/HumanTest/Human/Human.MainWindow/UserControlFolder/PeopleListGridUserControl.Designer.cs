namespace Human.MainWindow
{
	partial class WorkerListControl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnNewPeople = new System.Windows.Forms.Button();
			this.dgvPeopleList = new System.Windows.Forms.DataGridView();
			this.btnPrePage = new System.Windows.Forms.Button();
			this.btnNextPage = new System.Windows.Forms.Button();
			this.btnGo = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbxPageIndex = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearchKey = new System.Windows.Forms.TextBox();
			this.PeopleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PeopleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WorkerNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TitleState = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDelPeople = new System.Windows.Forms.DataGridViewLinkColumn();
			this.btnEditPeople = new System.Windows.Forms.DataGridViewLinkColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnNewPeople
			// 
			this.btnNewPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNewPeople.Location = new System.Drawing.Point(16, 354);
			this.btnNewPeople.Name = "btnNewPeople";
			this.btnNewPeople.Size = new System.Drawing.Size(90, 30);
			this.btnNewPeople.TabIndex = 1;
			this.btnNewPeople.Text = "新建";
			this.btnNewPeople.UseVisualStyleBackColor = true;
			this.btnNewPeople.Click += new System.EventHandler(this.btnNewPeople_Click);
			// 
			// dgvPeopleList
			// 
			this.dgvPeopleList.AllowUserToAddRows = false;
			this.dgvPeopleList.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.dgvPeopleList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPeopleList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvPeopleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPeopleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvPeopleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PeopleID,
            this.PeopleName,
            this.WorkerNum,
            this.Gender,
            this.DateOfBirth,
            this.PhoneNum,
            this.Title,
            this.Department,
            this.TitleState,
            this.Remark,
            this.btnDelPeople,
            this.btnEditPeople});
			this.dgvPeopleList.Location = new System.Drawing.Point(0, 33);
			this.dgvPeopleList.Name = "dgvPeopleList";
			this.dgvPeopleList.ReadOnly = true;
			this.dgvPeopleList.RowHeadersVisible = false;
			this.dgvPeopleList.RowHeadersWidth = 20;
			dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
			this.dgvPeopleList.RowsDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvPeopleList.RowTemplate.Height = 23;
			this.dgvPeopleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPeopleList.Size = new System.Drawing.Size(900, 309);
			this.dgvPeopleList.TabIndex = 3;
			this.dgvPeopleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeopleList_CellContentClick);
			this.dgvPeopleList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPeopleList_DataBindingComplete);
			// 
			// btnPrePage
			// 
			this.btnPrePage.Location = new System.Drawing.Point(10, 12);
			this.btnPrePage.Name = "btnPrePage";
			this.btnPrePage.Size = new System.Drawing.Size(51, 20);
			this.btnPrePage.TabIndex = 4;
			this.btnPrePage.Text = "<<";
			this.btnPrePage.UseVisualStyleBackColor = true;
			this.btnPrePage.Click += new System.EventHandler(this.btnPrePage_Click);
			// 
			// btnNextPage
			// 
			this.btnNextPage.Location = new System.Drawing.Point(67, 12);
			this.btnNextPage.Name = "btnNextPage";
			this.btnNextPage.Size = new System.Drawing.Size(51, 20);
			this.btnNextPage.TabIndex = 5;
			this.btnNextPage.Text = ">>";
			this.btnNextPage.UseVisualStyleBackColor = true;
			this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(168, 12);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(46, 20);
			this.btnGo.TabIndex = 7;
			this.btnGo.Text = "GO";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.btnGo);
			this.panel1.Controls.Add(this.btnPrePage);
			this.panel1.Controls.Add(this.cbxPageIndex);
			this.panel1.Controls.Add(this.btnNextPage);
			this.panel1.Location = new System.Drawing.Point(669, 348);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(228, 45);
			this.panel1.TabIndex = 8;
			// 
			// cbxPageIndex
			// 
			this.cbxPageIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxPageIndex.FormattingEnabled = true;
			this.cbxPageIndex.Location = new System.Drawing.Point(124, 12);
			this.cbxPageIndex.Name = "cbxPageIndex";
			this.cbxPageIndex.Size = new System.Drawing.Size(37, 20);
			this.cbxPageIndex.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(480, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 12);
			this.label1.TabIndex = 9;
			this.label1.Text = "请输入员工姓名或工号：";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(776, 7);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(61, 23);
			this.btnSearch.TabIndex = 10;
			this.btnSearch.Text = "搜索";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// txtSearchKey
			// 
			this.txtSearchKey.Location = new System.Drawing.Point(623, 7);
			this.txtSearchKey.Name = "txtSearchKey";
			this.txtSearchKey.Size = new System.Drawing.Size(147, 21);
			this.txtSearchKey.TabIndex = 11;
			// 
			// PeopleID
			// 
			this.PeopleID.DataPropertyName = "PeopleID";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.PeopleID.DefaultCellStyle = dataGridViewCellStyle3;
			this.PeopleID.HeaderText = "PeopleID";
			this.PeopleID.Name = "PeopleID";
			this.PeopleID.ReadOnly = true;
			this.PeopleID.Visible = false;
			// 
			// PeopleName
			// 
			this.PeopleName.DataPropertyName = "PeopleName";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.PeopleName.DefaultCellStyle = dataGridViewCellStyle4;
			this.PeopleName.HeaderText = "姓名";
			this.PeopleName.Name = "PeopleName";
			this.PeopleName.ReadOnly = true;
			// 
			// WorkerNum
			// 
			this.WorkerNum.DataPropertyName = "WorkerNum";
			this.WorkerNum.HeaderText = "工号";
			this.WorkerNum.Name = "WorkerNum";
			this.WorkerNum.ReadOnly = true;
			// 
			// Gender
			// 
			this.Gender.DataPropertyName = "Gender";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Gender.DefaultCellStyle = dataGridViewCellStyle5;
			this.Gender.HeaderText = "性别";
			this.Gender.Name = "Gender";
			this.Gender.ReadOnly = true;
			// 
			// DateOfBirth
			// 
			this.DateOfBirth.DataPropertyName = "DateOfBirth";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.DateOfBirth.DefaultCellStyle = dataGridViewCellStyle6;
			this.DateOfBirth.HeaderText = "出生日期";
			this.DateOfBirth.Name = "DateOfBirth";
			this.DateOfBirth.ReadOnly = true;
			// 
			// PhoneNum
			// 
			this.PhoneNum.DataPropertyName = "PhoneNum";
			this.PhoneNum.HeaderText = "手机号码";
			this.PhoneNum.Name = "PhoneNum";
			this.PhoneNum.ReadOnly = true;
			// 
			// Title
			// 
			this.Title.DataPropertyName = "Title";
			this.Title.HeaderText = "职务";
			this.Title.Name = "Title";
			this.Title.ReadOnly = true;
			// 
			// Department
			// 
			this.Department.DataPropertyName = "Department";
			this.Department.HeaderText = "部门";
			this.Department.Name = "Department";
			this.Department.ReadOnly = true;
			// 
			// TitleState
			// 
			this.TitleState.DataPropertyName = "TitleState";
			this.TitleState.HeaderText = "在职状态";
			this.TitleState.Name = "TitleState";
			this.TitleState.ReadOnly = true;
			// 
			// Remark
			// 
			this.Remark.HeaderText = "备注";
			this.Remark.Name = "Remark";
			this.Remark.ReadOnly = true;
			// 
			// btnDelPeople
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3);
			this.btnDelPeople.DefaultCellStyle = dataGridViewCellStyle7;
			this.btnDelPeople.HeaderText = "删除";
			this.btnDelPeople.Name = "btnDelPeople";
			this.btnDelPeople.ReadOnly = true;
			this.btnDelPeople.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.btnDelPeople.Text = "删除";
			this.btnDelPeople.UseColumnTextForLinkValue = true;
			// 
			// btnEditPeople
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.btnEditPeople.DefaultCellStyle = dataGridViewCellStyle8;
			this.btnEditPeople.HeaderText = "修改";
			this.btnEditPeople.Name = "btnEditPeople";
			this.btnEditPeople.ReadOnly = true;
			this.btnEditPeople.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.btnEditPeople.Text = "修改";
			this.btnEditPeople.UseColumnTextForLinkValue = true;
			// 
			// WorkerListControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtSearchKey);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvPeopleList);
			this.Controls.Add(this.btnNewPeople);
			this.Name = "WorkerListControl";
			this.Size = new System.Drawing.Size(900, 400);
			this.Load += new System.EventHandler(this.WorkerListControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnNewPeople;
		private System.Windows.Forms.DataGridView dgvPeopleList;
		private System.Windows.Forms.Button btnPrePage;
		private System.Windows.Forms.Button btnNextPage;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbxPageIndex;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearchKey;
		private System.Windows.Forms.DataGridViewTextBoxColumn PeopleID;
		private System.Windows.Forms.DataGridViewTextBoxColumn PeopleName;
		private System.Windows.Forms.DataGridViewTextBoxColumn WorkerNum;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
		private System.Windows.Forms.DataGridViewTextBoxColumn Title;
		private System.Windows.Forms.DataGridViewTextBoxColumn Department;
		private System.Windows.Forms.DataGridViewTextBoxColumn TitleState;
		private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
		private System.Windows.Forms.DataGridViewLinkColumn btnDelPeople;
		private System.Windows.Forms.DataGridViewLinkColumn btnEditPeople;
	}
}

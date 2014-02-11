using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Human.BLL;
using Human.Common;

namespace Human.MainWindow
{
	public partial class WorkerListControl : UserControl
	{
		private string _reminder = "距离合同到期不足两个月！";

		private int _currentPage = 1;
		private int _totalPage = 0;
		private string _delColumnName = "btnDelPeople";
		private string _editColumName = "btnEditPeople";

		public WorkerListControl()
		{
			InitializeComponent();
		}

		private void btnNewPeople_Click(object sender, EventArgs e)
		{
			var workerForm = new WorkerInfoForm();
			workerForm.callbackEvent += delegate {
				BindListView(pageIndex: int.Parse(this.cbxPageIndex.Text));
			};
			workerForm.ShowDialog();
		}

		private void WorkerListControl_Load(object sender, EventArgs e)
		{
			dgvPeopleList.AutoGenerateColumns = false;
			BindListView();
		}

		private void BindListView(int pageSize = 10, int pageIndex = 1)
		{
			int totalCount = 0;
			var searchKey = this.txtSearchKey.Text;
			dgvPeopleList.DataSource = new PeopleBLL().GetPeopleList(out totalCount, searchKey, pageSize, pageIndex).Data;
			foreach (DataGridViewRow row in dgvPeopleList.Rows) {
				if (CommonData.NeedReminderPeopleIDList.Contains((int)row.Cells[0].Value)) {
					//row.DefaultCellStyle.ForeColor = Color.White;
					//row.DefaultCellStyle.BackColor = Color.Red;
					row.Cells["Remark"].Value = _reminder;
					row.Cells["Remark"].Style.BackColor = Color.Red;
				}
			}

			var temp = totalCount % pageSize;
			if (temp == 0) {
				_totalPage = totalCount / pageSize;
			} else {
				_totalPage = totalCount / pageSize + 1;
			}

			if (_totalPage == 0) {
				_totalPage = 1;
			}

			this.cbxPageIndex.Items.Clear();
			for (int i = 1; i <= _totalPage; i++) {
				this.cbxPageIndex.Items.Add(i);
			}
			this.cbxPageIndex.SelectedItem = this.cbxPageIndex.Items[pageIndex - 1];

			this._currentPage = pageIndex;
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			var pageSize = 10;
			var pageIndex = int.Parse(this.cbxPageIndex.SelectedItem.ToString());
			BindListView(pageSize, pageIndex);
		}

		private void btnPrePage_Click(object sender, EventArgs e)
		{
			var pageSize = 10;
			var pageIndex = 1;
			if (this._currentPage == 1) {
				pageIndex = 1;
			} else {
				pageIndex = this._currentPage - 1;
			}

			BindListView(pageSize, pageIndex);
		}

		private void btnNextPage_Click(object sender, EventArgs e)
		{
			var pageSize = 10;
			var pageIndex = 1;

			if (this._currentPage == _totalPage) {
				pageIndex = _totalPage;
			} else {
				pageIndex = this._currentPage + 1;
			}

			BindListView(pageSize, pageIndex);
		}

		private void dgvPeopleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
			//AddCode
			if (rowIndex == -1) {
				return;
			}
			//AddCode
			if (this.dgvPeopleList.Columns[columnIndex] == this.dgvPeopleList.Columns[_delColumnName]) {
				var dialogResult = MessageBox.Show("确定要删除吗?", SystemInfo.ReminderStr, MessageBoxButtons.OKCancel);
				if (dialogResult == DialogResult.OK) {
					var peopleID = (int)dgvPeopleList.Rows[rowIndex].Cells["PeopleID"].Value;
					var result = new PeopleBLL().DeletePeople(peopleID);
					if (result.Code > 0) {
						MessageBox.Show(result.Message, SystemInfo.ErrorReminderStr, MessageBoxButtons.OK);
					} else {
						BindListView(10, this._currentPage);
					}
				}
			} else if (this.dgvPeopleList.Columns[columnIndex] == this.dgvPeopleList.Columns[_editColumName]) {
				var peopleID = (int)dgvPeopleList.Rows[rowIndex].Cells["PeopleID"].Value;
				//var workInfoForm = new WorkerInfoForm(_peopleID);
				//workInfoForm.callbackEvent += delegate {
				//    BindListView(pageIndex: int.Parse(this.cbxPageIndex.Text));
				//};
				//workInfoForm.Show();

				var peopleMgmtForm = new PeopleInfoMgmtForm(peopleID);
				peopleMgmtForm.Callback = delegate { BindListView(pageIndex: int.Parse(this.cbxPageIndex.Text)); };
				peopleMgmtForm.ShowDialog();
			}

		}

		private void dgvPeopleList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewRow row in dgvPeopleList.Rows) {
				if (CommonData.NeedReminderPeopleIDList.Contains((int)row.Cells[0].Value)) {
					//row.DefaultCellStyle.ForeColor = Color.White;
					//row.DefaultCellStyle.BackColor = Color.Red;
					row.Cells["Remark"].Value = _reminder;
					row.Cells["Remark"].Style.BackColor = Color.Red;
				}
			}
		}
	}
}

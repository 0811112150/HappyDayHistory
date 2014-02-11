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
	public partial class TrainingTestRecordListUserControl : UserControl
	{
		private string _delColumnName = "btnDel";
		private string _editColumName = "btnEdit";

		private int _currentPeopleID;

		public TrainingTestRecordListUserControl(int peopleID)
		{
			this._currentPeopleID = peopleID;
			InitializeComponent();
			BindDataList();
		}

		private void BindDataList()
		{
			this.dgvRecordList.AutoGenerateColumns = false;
			this.dgvRecordList.DataSource = new TrainingTestRecordBLL().GetTrainingTestRecordList(_currentPeopleID).Data;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			var contractInfoForm = new TrainingTestRecordInfoForm(false, null, this._currentPeopleID);
			contractInfoForm.callbackEvent += BindDataList;
			contractInfoForm.ShowDialog();
		}

		private void dgvRecordList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
            //AddCode
            if (rowIndex == -1)
            {
                return;
            }
            //AddCode
			if (this.dgvRecordList.Columns[columnIndex] == this.dgvRecordList.Columns[_delColumnName]) {
				var dialogResult = MessageBox.Show("确定要删除吗?", SystemInfo.ReminderStr, MessageBoxButtons.OKCancel);
				if (dialogResult == DialogResult.OK) {
					var RecordID = (int)dgvRecordList.Rows[rowIndex].Cells["RecordID"].Value;
					var result = new TrainingTestRecordBLL().DeleteTrainingTestRecordByID(RecordID);
					if (result.Code > 0) {
						MessageBox.Show(result.Message, SystemInfo.ErrorReminderStr, MessageBoxButtons.OK);
					}
					BindDataList();
				}
			} else if (this.dgvRecordList.Columns[columnIndex] == this.dgvRecordList.Columns[_editColumName]) {
				var RecordID = (int)dgvRecordList.Rows[rowIndex].Cells["RecordID"].Value;
				var form = new TrainingTestRecordInfoForm(true, RecordID, null);
				form.callbackEvent += delegate {
					BindDataList();
				};
				form.ShowDialog();
			}
		}
	}
}

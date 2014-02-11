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
	public partial class TitleWageChangeRecordListUserControl : UserControl
	{
		private string _delColumnName = "btnDel";
		private string _editColumName = "btnEdit";

		private int _currentPeopleID;
		public TitleWageChangeRecordListUserControl(int peopleID)
		{
			this._currentPeopleID = peopleID;
			InitializeComponent();
			BindDataList();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			var contractInfoForm = new TitleWageChangeRecordInfoForm(false, null, this._currentPeopleID);
			contractInfoForm.callbackEvent += BindDataList;
			contractInfoForm.ShowDialog();
		}

		private void BindDataList()
		{
			this.dgvContractList.AutoGenerateColumns = false;
			this.dgvContractList.DataSource = new TitleWageChangeRecordBLL().GetTitleWageChangeRecordList(_currentPeopleID).Data;
		}

		private void dgvContractList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
            //AddCode
            if (rowIndex == -1)
            {
                return;
            }
            //AddCode
			if (this.dgvContractList.Columns[columnIndex] == this.dgvContractList.Columns[_delColumnName]) {
				var dialogResult = MessageBox.Show("确定要删除吗?", SystemInfo.ReminderStr, MessageBoxButtons.OKCancel);
				if (dialogResult == DialogResult.OK) {
					var TitleWageChangeRecordID = (int)dgvContractList.Rows[rowIndex].Cells["RecordID"].Value;
					var result = new TitleWageChangeRecordBLL().DeleteTitleWageChangeRecordByID(TitleWageChangeRecordID);
					if (result.Code > 0) {
						MessageBox.Show(result.Message, SystemInfo.ErrorReminderStr, MessageBoxButtons.OK);
					}
					BindDataList();
				}
			} else if (this.dgvContractList.Columns[columnIndex] == this.dgvContractList.Columns[_editColumName]) {
				var TitleWageChangeRecordID = (int)dgvContractList.Rows[rowIndex].Cells["RecordID"].Value;
				var contractForm = new TitleWageChangeRecordInfoForm(true, TitleWageChangeRecordID, null);
				contractForm.callbackEvent += delegate {
					BindDataList();
				};
				contractForm.ShowDialog();
			}
		}


	}
}

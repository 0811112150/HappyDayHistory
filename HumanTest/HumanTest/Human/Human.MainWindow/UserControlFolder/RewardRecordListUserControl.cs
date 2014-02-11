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
	public partial class RewardRecordListUserControl : UserControl
	{
		private string _delColumnName = "btnDel";
		private string _editColumName = "btnEdit";

		private int _currentPeopleID;
		public RewardRecordListUserControl(int peopleID)
		{
			this._currentPeopleID = peopleID;
			InitializeComponent();
			BindDataList();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			var contractInfoForm = new RewardRecordInfoForm(false, null, this._currentPeopleID);
			contractInfoForm.callbackEvent += BindDataList;
			contractInfoForm.ShowDialog();
		}

		private void BindDataList()
		{
			this.dgvRecoedtList.AutoGenerateColumns = false;
			this.dgvRecoedtList.DataSource = new RewardRecordBLL().GetRewardRecordList(_currentPeopleID).Data;
		}

		private void dgvRecoedtList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
            //AddCode
            if (rowIndex == -1)
            {
                return;
            }
            //AddCode
			if (this.dgvRecoedtList.Columns[columnIndex] == this.dgvRecoedtList.Columns[_delColumnName]) {
				var dialogResult = MessageBox.Show("确定要删除吗?", SystemInfo.ReminderStr, MessageBoxButtons.OKCancel);
				if (dialogResult == DialogResult.OK) {
					var RecordID = (int)dgvRecoedtList.Rows[rowIndex].Cells["RecordID"].Value;
					var result = new RewardRecordBLL().DeleteRewardRecordByID(RecordID);
					if (result.Code > 0) {
						MessageBox.Show(result.Message, SystemInfo.ErrorReminderStr, MessageBoxButtons.OK);
					}
					BindDataList();
				}
            }
            else if (this.dgvRecoedtList.Columns[columnIndex] == this.dgvRecoedtList.Columns[_editColumName])
            {
                var TitleWageChangeRecordID = (int)dgvRecoedtList.Rows[rowIndex].Cells["RecordID"].Value;
                var contractForm = new RewardRecordInfoForm(true, TitleWageChangeRecordID, null);
                contractForm.callbackEvent += delegate
                {
                    BindDataList();
                };
                contractForm.ShowDialog();
            }
		}
	}
}

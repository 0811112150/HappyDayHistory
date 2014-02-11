using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Human.MainWindow;
using Human.Common;
using Human.BLL;

namespace Human.MainWindow
{
	public partial class ContractListUserControl : UserControl
	{
		private string _delColumnName = "btnDel";
		private string _editColumName = "btnEdit";

		private int _currentPeopleID;

		public ContractListUserControl(int peopleID)
		{
			this._currentPeopleID = peopleID;
			InitializeComponent();
			BindDataList();
		}

		private void BindDataList()
		{
			this.dgvContractList.AutoGenerateColumns = false;
			var contracts = new ContractBLL().GetContractList(_currentPeopleID).Data;
			foreach (var item in contracts) {
				if (!item.IsFirstContract) {
					item.ProbationEndDate = null;
				}
			}
			this.dgvContractList.DataSource = contracts;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			var contractInfoForm = new ContractInfoForm(false, null, this._currentPeopleID);
			contractInfoForm.callbackEvent += BindDataList;
			contractInfoForm.ShowDialog();
		}

		private void dgvContractList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
			//AddCode
			if (rowIndex == -1) {
				return;
			}
			//AddCode
			if (this.dgvContractList.Columns[columnIndex] == this.dgvContractList.Columns[_delColumnName]) {
				var dialogResult = MessageBox.Show("确定要删除吗?", SystemInfo.ReminderStr, MessageBoxButtons.OKCancel);
				if (dialogResult == DialogResult.OK) {
					var contractID = (int)dgvContractList.Rows[rowIndex].Cells["ContractID"].Value;
					var result = new ContractBLL().DeleteContractByID(contractID);
					if (result.Code > 0) {
						MessageBox.Show(result.Message, SystemInfo.ErrorReminderStr, MessageBoxButtons.OK);
					}
					BindDataList();
				}
			} else if (this.dgvContractList.Columns[columnIndex] == this.dgvContractList.Columns[_editColumName]) {
				var contractID = (int)dgvContractList.Rows[rowIndex].Cells["ContractID"].Value;
				var contractForm = new ContractInfoForm(true, contractID, null);
				contractForm.callbackEvent += delegate {
					BindDataList();
				};
				contractForm.ShowDialog();
			}
		}
	}
}

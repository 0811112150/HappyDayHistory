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
	public partial class FamilyListUserControl : UserControl
	{
		private string _delColumnName = "btnDel";
		private string _editColumName = "btnEdit";
		private int _currentPeopleID;

		public FamilyListUserControl(int peopleID)
		{
			this._currentPeopleID = peopleID;

			InitializeComponent();

			BindGridList();
		}

		private void BindGridList()
		{
			var peopleFamilyList = new PeopleFamilyBLL().GetPeopleFamilyList(_currentPeopleID).Data;
			this.dgvFamilyList.AutoGenerateColumns = false;
			this.dgvFamilyList.DataSource = peopleFamilyList;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			var familyInfoForm = new FamilyInfoForm(false, null, this._currentPeopleID);
			familyInfoForm.callbackEvent += delegate {
				BindGridList();
			};
			familyInfoForm.ShowDialog();
		}

		private void dgvFamilyList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
            //AddCode
            if (rowIndex == -1)
            {
                return;
            }
            //AddCode
			if (this.dgvFamilyList.Columns[columnIndex] == this.dgvFamilyList.Columns[_delColumnName]) {
				var dialogResult = MessageBox.Show("确定要删除吗?", SystemInfo.ReminderStr, MessageBoxButtons.OKCancel);
				if (dialogResult == DialogResult.OK) {
					var peopleFamilyID = (int)dgvFamilyList.Rows[rowIndex].Cells["PeopleFamilyID"].Value;
					var result = new PeopleFamilyBLL().DeletePeopleFamilyByID(peopleFamilyID);
					if (result.Code > 0) {
						MessageBox.Show(result.Message, SystemInfo.ErrorReminderStr, MessageBoxButtons.OK);
					}
					BindGridList();
				}
			} else if (this.dgvFamilyList.Columns[columnIndex] == this.dgvFamilyList.Columns[_editColumName]) {
				var peopleFamilyID = (int)dgvFamilyList.Rows[rowIndex].Cells["PeopleFamilyID"].Value;
				var familyInfoForm = new FamilyInfoForm(true, peopleFamilyID, null);
				familyInfoForm.callbackEvent += delegate {
					BindGridList();
				};
				familyInfoForm.ShowDialog();
			}
		}
	}
}

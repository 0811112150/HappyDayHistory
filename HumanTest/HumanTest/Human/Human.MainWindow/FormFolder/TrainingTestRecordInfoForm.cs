using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Human.BLL;
using Human.DomainModel;
using Human.Common;
using Human.MainWindow.HelperCommon;

namespace Human.MainWindow
{
	public partial class TrainingTestRecordInfoForm : Form
	{
		public delegate void CallBackFunction();
		public event CallBackFunction callbackEvent;

		private int? _currentRecordID = null;
		private int? _peopleID = null;
		private bool _isEdit = false;

		public TrainingTestRecordInfoForm(bool isEdit, int? contractID, int? peopleID)
		{
			InitializeComponent();

			this._isEdit = isEdit;
			if (contractID.HasValue) {
				this._currentRecordID = contractID;
			}
			if (peopleID.HasValue) {
				this._peopleID = peopleID;
			}

			if (isEdit) {
				InitControlValue();
			}
		}
		private void InitControlValue()
		{
			if (this._currentRecordID.HasValue) {
				var record = new TrainingTestRecordBLL().GetTrainingTestRecordByID(this._currentRecordID.Value).Data;
				if (record.TrainingDate.HasValue) {
					this.dtpTrainingDate.Value = record.TrainingDate.Value;
				}
				if (record.TestDate.HasValue) {
					this.dtpTestDate.Value = record.TestDate.Value;
				}
				this.txtTrainingType.Text = record.TrainingType;
				this.rtxtTrainingContent.Text = record.TrainingContent;
				this.txtTrainingDepartment.Text = record.TrainingDepartment;
				this.txtTestResult.Text = record.TestResult;
				this.txtTestPeople.Text = record.TestPeople;
				this.rtxtRemark.Text = record.Remark;
			}
		}
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var record = new TrainingTestRecord();
			record.Remark = this.rtxtRemark.Text;
			record.TestDate = this.dtpTestDate.Value;
			record.TestPeople = this.txtTestPeople.Text;
			record.TestResult = this.txtTestResult.Text;
			record.TrainingContent = this.rtxtTrainingContent.Text;
			record.TrainingDate = this.dtpTrainingDate.Value;
			record.TrainingDepartment = this.txtTrainingDepartment.Text;
			record.TrainingType = this.txtTrainingType.Text;

			var bll = new TrainingTestRecordBLL();
			CResult<bool> result = new CResult<bool>(false);
			if (this._isEdit) {
				record.RecordID = this._currentRecordID.Value;
				result = bll.UpdateTrainingTestRecord(record);
			} else {
				record.PeopleID = this._peopleID.Value;
				result = bll.InsertTrainingTestRecord(record);
			}

			MessageHelper.ShowSaveDbResultMessage(result);
			if (result.Code == 0) {
				this.Dispose();
				if (callbackEvent != null) {
					callbackEvent.Invoke();
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}

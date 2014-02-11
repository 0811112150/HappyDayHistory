using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Human.BLL;
using Human.Common;
using Human.DomainModel;
using Human.MainWindow.HelperCommon;

namespace Human.MainWindow
{
	public partial class TitleWageChangeRecordInfoForm : Form
	{
		public delegate void CallBackFunction();
		public event CallBackFunction callbackEvent;

		private int? _titleWageChangeRecordID = null;
		private int? _peopleID = null;
		private bool _isEdit = false;

		public TitleWageChangeRecordInfoForm(bool isEdit, int? titleWageChangeRecordID, int? peopleID)
		{
			InitializeComponent();

			foreach (var item in Enum.GetNames(typeof(TitleChangeType))) {
				this.cbxChangeType.Items.Add(item);
			}
			this.cbxChangeType.SelectedIndex = 0;

			this._isEdit = isEdit;
			if (titleWageChangeRecordID.HasValue) {
				this._titleWageChangeRecordID = titleWageChangeRecordID;
			}
			if (peopleID.HasValue) {
				this._peopleID = peopleID;
			}

			if (isEdit) {
				InitControlValue();
			}
		}

		public void InitControlValue()
		{
			if (_isEdit && _titleWageChangeRecordID.HasValue) {
				var record = new TitleWageChangeRecordBLL().GetTitleWageChangeRecordByID(_titleWageChangeRecordID.Value).Data;

				if (record.ChangeDate.HasValue) {
					dtpChangeDate.Value = record.ChangeDate.Value;
				}
				txtAfterChangeYearAward.Text = record.AfterChangeYearAward.ToString();
				txtAfterChangeBasicWage.Text = record.AfterChangeBasicWage.ToString();
				txtContractNum.Text = record.ContractNum;
				txtBeforeChangeYearAward.Text = record.BeforeChangeYearAward.ToString();
				txtAfterChangeAllowance.Text = record.AfterChangeAllowance.ToString();
				txtAfterChangeTitle.Text = record.AfterChangeTitle.ToString();
				txtBeforeChangeallowance.Text = record.BeforeChangeAllowance.ToString();
				txtBeforeChangeTitle.Text = record.BeforeChangeTitle;
				txtBeforeChangeBasicWage.Text = record.BeforeChangeBasicWage.ToString();

				cbxChangeType.SelectedItem = ((TitleChangeType)record.ChangeType).ToString();
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var record = new TitleWageChangeRecord();

			record.ChangeType = (int)(TitleChangeType)(Enum.Parse(typeof(TitleChangeType), this.cbxChangeType.SelectedItem.ToString()));
			record.AfterChangeTitle = this.txtAfterChangeTitle.Text;
			if (!string.IsNullOrWhiteSpace(this.txtAfterChangeAllowance.Text)) {
				record.AfterChangeAllowance = float.Parse(this.txtAfterChangeAllowance.Text);
			}
			if (!string.IsNullOrWhiteSpace(this.txtAfterChangeBasicWage.Text)) {
				record.AfterChangeBasicWage = float.Parse(this.txtAfterChangeBasicWage.Text);
			}
			if (!string.IsNullOrWhiteSpace(this.txtAfterChangeYearAward.Text)) {
				record.AfterChangeYearAward = float.Parse(this.txtAfterChangeYearAward.Text);
			}

			record.BeforeChangeTitle = this.txtBeforeChangeTitle.Text;
			if (!string.IsNullOrWhiteSpace(this.txtBeforeChangeallowance.Text)) {
				record.BeforeChangeAllowance = float.Parse(this.txtBeforeChangeallowance.Text);
			}
			if (!string.IsNullOrWhiteSpace(this.txtBeforeChangeBasicWage.Text)) {
				record.BeforeChangeBasicWage = float.Parse(this.txtBeforeChangeBasicWage.Text);
			}
			if (!string.IsNullOrWhiteSpace(this.txtBeforeChangeYearAward.Text)) {
				record.BeforeChangeYearAward = float.Parse(this.txtBeforeChangeYearAward.Text);
			}
			record.ChangeDate = this.dtpChangeDate.Value;
			record.ContractNum = this.txtContractNum.Text;

			CResult<bool> result = new CResult<bool>(false);
			if (_isEdit) {
				record.TitleWageChangeRecordID = this._titleWageChangeRecordID.Value;
				result = new TitleWageChangeRecordBLL().UpdateTitleWageChangeRecord(record);
			} else {
				record.PeopleID = this._peopleID.Value;
				result = new TitleWageChangeRecordBLL().InsertTitleWageChangeRecord(record);
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

		private void txtBeforeChangeBasicWage_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.FloatCheck(sender as Control, errorProvider1, e);
		}

		private void txtBeforeChangeallowance_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.FloatCheck(sender as Control, errorProvider1, e);
		}

		private void txtBeforeChangeYearAward_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.FloatCheck(sender as Control, errorProvider1, e);
		}

		private void txtAfterChangeBasicWage_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.FloatCheck(sender as Control, errorProvider1, e);
		}

		private void txtAfterChangeAllowance_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.FloatCheck(sender as Control, errorProvider1, e);
		}

		private void txtAfterChangeYearAward_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.FloatCheck(sender as Control, errorProvider1, e);
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Human.Common;
using Human.BLL;
using Human.MainWindow.HelperCommon;
using Human.DomainModel;

namespace Human.MainWindow
{
	public partial class RewardRecordInfoForm : Form
	{
		public delegate void CallBackFunction();
		public event CallBackFunction callbackEvent;

		private int? _currentRecordID = null;
		private int? _peopleID = null;
		private bool _isEdit = false;

		public RewardRecordInfoForm(bool isEdit, int? contractID, int? peopleID)
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
				var contract = new RewardRecordBLL().GetRewardRecordByID(this._currentRecordID.Value).Data;
				if (contract.RewardDate.HasValue) {
					this.dtpRewardDate.Value = contract.RewardDate.Value;
				}
				this.rtxtRewardContent.Text = contract.RewardContent;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var record = new RewardRecord();
			record.RewardDate = this.dtpRewardDate.Value;
			record.RewardContent = this.rtxtRewardContent.Text;

			var bll = new RewardRecordBLL();
			CResult<bool> result = new CResult<bool>(false);
			if (this._isEdit) {
				record.RecordID = this._currentRecordID.Value;
				result = bll.UpdateRewardRecord(record);
			} else {
				record.PeopleID = this._peopleID.Value;
				result = bll.InsertRewardRecord(record);
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Human.Common;
using Human.DomainModel;
using Human.BLL;
using Human.MainWindow.HelperCommon;

namespace Human.MainWindow
{
	public partial class ContractInfoForm : Form
	{
		public delegate void CallBackFunction();
		public event CallBackFunction callbackEvent;

		private int? _currentContractID = null;
		private int? _peopleID = null;
		private bool _isEdit = false;

		public ContractInfoForm(bool isEdit, int? contractID, int? peopleID)
		{
			InitializeComponent();

			this.rbtnIsFirstContract.Checked = true;
			foreach (var item in Enum.GetNames(typeof(ContractrTypeEnum))) {
				this.cbxContractrType.Items.Add(item);
			}
			this.cbxContractrType.SelectedIndex = 0;

			this._isEdit = isEdit;
			if (contractID.HasValue) {
				this._currentContractID = contractID;
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
			if (this._currentContractID.HasValue) {
				var contract = new ContractBLL().GetContractByID(this._currentContractID.Value).Data;
				if (contract.IsFirstContract) {
					this.rbtnIsFirstContract.Checked = true;
				} else {
					this.rbtnNotFirstContract.Checked = true;
				}

				this.cbxContractrType.SelectedItem = ((ContractrTypeEnum)contract.ContractrType).ToString();

				if (contract.StartDate.HasValue) {
					this.dtpStartDate.Value = contract.StartDate.Value;
				}
				if (contract.ProbationEndDate.HasValue) {
					this.dtpProbationEndDate.Value = contract.ProbationEndDate.Value;
				}
				if (contract.EndDate.HasValue) {
					this.dtpEndDate.Value = contract.EndDate.Value;
				}
				this.txtContractNum.Text = contract.ContractNum;
			}
		}

		private void ContractInfoForm_Load(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var contract = new Contract();
			contract.ContractNum = this.txtContractNum.Text;
			contract.ContractrType = this.cbxContractrType.SelectedIndex + 1;
			contract.EndDate = this.dtpEndDate.Value;
			contract.IsFirstContract = this.rbtnIsFirstContract.Checked;
			if (this.dtpProbationEndDate.Parent.Visible == true) {
				contract.ProbationEndDate = this.dtpProbationEndDate.Value;
			}

			contract.StartDate = this.dtpStartDate.Value;

			var bll = new ContractBLL();
			CResult<bool> result = new CResult<bool>(false);
			if (this._isEdit) {
				contract.ContractID = this._currentContractID.Value;
				result = bll.UpdateContract(contract);
			} else {
				contract.PeopleID = this._peopleID.Value;
				result = bll.InsertContract(contract);
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

		private void rbtnIsFirstContract_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbtnIsFirstContract.Checked) {
				this.dtpProbationEndDate.Enabled = true;
				this.dtpProbationEndDate.Parent.Visible = true;
			} else {
				this.dtpProbationEndDate.Enabled = false;
				this.dtpProbationEndDate.Parent.Visible = false;
			}
		}
	}
}

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
using Human.DomainModel;
using Human.MainWindow.HelperCommon;

namespace Human.MainWindow
{
	public partial class InsuranceFundUserControl : UserControl
	{
		private int _currentPeopleID;
		private int? _fundID;
		private int? _insuranceID;
		private bool isEdit = false;

		public InsuranceFundUserControl(int peopleID)
		{
			InitializeComponent();
			this._currentPeopleID = peopleID;

			InitCompontValue();
		}
		private void InitCompontValue()
		{
			var result = new InsuranceFundBLL().GetInsuranceFundList(_currentPeopleID).Data;

			if (result.Count > 0) {
				isEdit = true;

				var fund = result.FirstOrDefault(r => r.InsuranceFundType == (int)InsuranceFundType.住房公积金);
				if (fund != null) {
					this._fundID = fund.InsuranceFundID;

					this.txtHouseNumber.Text = fund.Number;
					this.txtHousePaymentAddress.Text = fund.PaymentAddress;
					if (fund.PaymentEndDate.HasValue) {
						this.dtpHousePaymentEndDate.Checked = true;
						this.dtpHousePaymentEndDate.Value = fund.PaymentEndDate.Value;
					} else {
						this.dtpHousePaymentEndDate.Checked = false;
					}
					if (fund.PaymentStartDate.HasValue) {
						this.dtphousePaymentStartDate.Value = fund.PaymentStartDate.Value;
					} 
					this.txtHouseBasicNum.Text = fund.BasicNum.ToString();
				}

				var insurance = result.FirstOrDefault(r => r.InsuranceFundType == (int)InsuranceFundType.社保);
				if (insurance != null) {
					this._insuranceID = insurance.InsuranceFundID;

					this.txtSocialNumber.Text = fund.Number;
					this.txtSocialPaymentAddress.Text = insurance.PaymentAddress;
					if (insurance.PaymentEndDate.HasValue) {
						this.dtpSocialPaymentEndDate.Checked = true;
						this.dtpSocialPaymentEndDate.Value = insurance.PaymentEndDate.Value;
					} else {
						this.dtpSocialPaymentEndDate.Checked = false;
					}
					if (insurance.PaymentStartDate.HasValue) {
						this.dtpSocialPaymentStartDate.Value = insurance.PaymentStartDate.Value;
					}
					this.txtSocialBasicNum.Text = insurance.BasicNum.ToString();
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var bll = new InsuranceFundBLL();

			var fund = new InsuranceFund();
			fund.InsuranceFundType = (int)InsuranceFundType.住房公积金;
			fund.Number = this.txtHouseNumber.Text;
			fund.PaymentAddress = this.txtHousePaymentAddress.Text;
			fund.PaymentStartDate = this.dtphousePaymentStartDate.Value;
			if (this.dtpHousePaymentEndDate.Checked) {
				fund.PaymentEndDate = this.dtpHousePaymentEndDate.Value;
			}
			if (!string.IsNullOrWhiteSpace(this.txtHouseBasicNum.Text)) {
				fund.BasicNum = float.Parse(this.txtHouseBasicNum.Text);
			}

			var insurance = new InsuranceFund();
			insurance.InsuranceFundType = (int)InsuranceFundType.社保;
			insurance.Number = this.txtSocialNumber.Text;
			insurance.PaymentAddress = this.txtSocialPaymentAddress.Text;
			insurance.PaymentStartDate = this.dtpSocialPaymentStartDate.Value;
			if (this.dtpSocialPaymentEndDate.Checked) {
				insurance.PaymentEndDate = this.dtpSocialPaymentEndDate.Value;
			}
			if (!string.IsNullOrWhiteSpace(this.txtSocialBasicNum.Text)) {
				insurance.BasicNum = float.Parse(this.txtSocialBasicNum.Text);
			}

			var result = true;
			if (isEdit) {
				fund.InsuranceFundID = this._fundID.Value;
				result = result && bll.UpdateInsuranceFund(fund).Data;

				insurance.InsuranceFundID = this._insuranceID.Value;
				result = result && bll.UpdateInsuranceFund(insurance).Data;
			} else {
				fund.PeopleID = this._currentPeopleID;
				result = result && bll.InsertInsuranceFund(fund).Data;

				insurance.PeopleID = this._currentPeopleID;
				result = result && bll.InsertInsuranceFund(insurance).Data;
			}
			if (result) {
				MessageBox.Show("操作成功!");
			} else {
				MessageBox.Show("操作失败!");
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			InitCompontValue();
		}
	}
}

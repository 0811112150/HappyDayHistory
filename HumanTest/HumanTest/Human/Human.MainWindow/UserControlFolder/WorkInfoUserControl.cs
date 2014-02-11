using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Human.ViewModel;
using Human.BLL;
using Human.MainWindow.HelperCommon;

namespace Human.MainWindow
{
	public partial class WorkInfoUserControl : UserControl
	{
		private int _currentPeopleID;

		public WorkInfoUserControl(int peopleID)
		{
			InitializeComponent();

			this._currentPeopleID = peopleID;

			InitCompontValue();

			SetLengthOfService();
		}

		private void InitCompontValue()
		{
			var result = new PeopleBLL().GetPeopleWorkInfoByPeopleID(this._currentPeopleID);
			if (result == null) {
				MessageBox.Show("工作信息不存在!");
				return;
			}
			var webWorkInfo = result.Data;

			if (webWorkInfo.JoinCompanyDate.HasValue) {
				this.dtpJoinCompanyDate.Value = webWorkInfo.JoinCompanyDate.Value;
			}

			this.txtLengthOfService.Text = webWorkInfo.LengthOfService.ToString();
			this.txtDepartment.Text = webWorkInfo.Department;
			this.txtTitle.Text = webWorkInfo.Title;
			if (webWorkInfo.TitleState == this.rbtnTitleAt.Text) {
				this.rbtnTitleAt.Checked = true;
			} else {
				this.rbtnTitleOut.Checked = true;
			}
			//this.dtpLeftCompanyDate.Value = webWorkInfo.LeftCompanyDate.Value;
			if (webWorkInfo.LeftCompanyDate.HasValue) {
				this.dtpLeftCompanyDate.Value = webWorkInfo.LeftCompanyDate.Value;
				this.dtpLeftCompanyDate.Checked = true;
			} else {
				this.dtpLeftCompanyDate.Checked = true;
			}
			this.txtLeftCompanyReason.Text = webWorkInfo.LeftCompanyReason;
			this.txtSpecialSkill.Text = webWorkInfo.SpecialSkill;
			this.txtWageCardNumber.Text = webWorkInfo.WageCardNumber;
			this.txtWageCardAddress.Text = webWorkInfo.WageCardAddress;
			if (webWorkInfo.IsCallInArchives) {
				this.rbtnCallIn.Checked = true;
			} else {
				this.rbtnNotCallIn.Checked = true;
			}

			this.txtArchivesNum.Text = webWorkInfo.ArchivesNum;
			//this.dtpArchiveCallOutDate.Value = webWorkInfo.ArchiveCallOutDate.Value;
			//this.dtpArchiveCallInDate.Value = webWorkInfo.ArchiveCallInDate.Value;
			if (webWorkInfo.ArchiveCallOutDate.HasValue) {
				this.dtpArchiveCallOutDate.Value = webWorkInfo.ArchiveCallOutDate.Value;
				this.dtpArchiveCallOutDate.Checked = true;
			} else {
				this.dtpArchiveCallOutDate.Checked = false;
			}
			if (webWorkInfo.ArchiveCallInDate.HasValue) {
				this.dtpArchiveCallInDate.Value = webWorkInfo.ArchiveCallInDate.Value;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var webWorkInfo = new WebPeopleWorkInfo();
			webWorkInfo.PeopleID = this._currentPeopleID;
			webWorkInfo.JoinCompanyDate = this.dtpJoinCompanyDate.Value;

			float lengthOfService;
			if (float.TryParse(this.txtLengthOfService.Text, out lengthOfService)) {
				webWorkInfo.LengthOfService = lengthOfService;
			}

			webWorkInfo.Department = this.txtDepartment.Text;
			webWorkInfo.Title = this.txtTitle.Text;
			webWorkInfo.TitleState = this.rbtnTitleAt.Checked ? this.rbtnTitleAt.Text : this.rbtnTitleOut.Text;
			if (this.dtpLeftCompanyDate.Checked) {
				webWorkInfo.LeftCompanyDate = this.dtpLeftCompanyDate.Value;
			}
			webWorkInfo.LeftCompanyReason = this.txtLeftCompanyReason.Text;
			webWorkInfo.SpecialSkill = this.txtSpecialSkill.Text;
			webWorkInfo.WageCardNumber = this.txtWageCardNumber.Text;
			webWorkInfo.WageCardAddress = this.txtWageCardAddress.Text;
			webWorkInfo.IsCallInArchives = this.rbtnCallIn.Checked;
			webWorkInfo.ArchivesNum = this.txtArchivesNum.Text;
			if (this.dtpArchiveCallOutDate.Checked) {
				webWorkInfo.ArchiveCallOutDate = this.dtpArchiveCallOutDate.Value;
			}
			webWorkInfo.ArchiveCallInDate = this.dtpArchiveCallInDate.Value;

			var result = new PeopleBLL().UpdatePeopleWorkInfo(webWorkInfo);

			MessageHelper.ShowSaveDbResultMessage(result);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			InitCompontValue();
		}

		private void SetLengthOfService()
		{
			this.txtLengthOfService.Text = (DateTime.Now.Year - this.dtpJoinCompanyDate.Value.Year).ToString();
		}

		private void dtpJoinCompanyDate_ValueChanged(object sender, EventArgs e)
		{
			SetLengthOfService();
		}
	}
}

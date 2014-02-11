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
using Human.ViewModel;
using Human.MainWindow.HelperCommon;

namespace Human.MainWindow
{
	public partial class PeopleBasicInfoUserControl : UserControl
	{
		private int _currentPeopleID;

		public PeopleBasicInfoUserControl(int peopleID)
		{
			InitializeComponent();

			this._currentPeopleID = peopleID;

			InitCompontValue();
		}

		private void InitCompontValue()
		{
			var result = new PeopleBLL().GetPeopleByID(_currentPeopleID);
			var peopleBaseInfo = result.Data;
			this.txtWorkerNum.Text = peopleBaseInfo.WorkerNum;
			this.txtName.Text = peopleBaseInfo.PeopleName;
			if (peopleBaseInfo.Gender == this.rbtnMan.Text) {
				this.rbtnMan.Checked = true;
			} else {
				this.rbtnWoman.Checked = true;
			}
			this.dtpDateOfBirth.Value = peopleBaseInfo.DateOfBirth.Value;
			this.txtAge.Text = peopleBaseInfo.Age.ToString();
			this.txtIDCardNum.Text = peopleBaseInfo.IDCardNum;
			//this.rbtnMarried.Checked = peopleBaseInfo.IsMarried;
			if (peopleBaseInfo.IsMarried) {
				this.rbtnMarried.Checked = true;
			} else {
				this.rbtnNotMarried.Checked = true;
			}
			this.cbxPoliticalStatus.SelectedItem = peopleBaseInfo.PoliticalStatus;
			this.cbxNation.Text = peopleBaseInfo.Nation;
			this.txtHouseholdRegisterAddress.Text = peopleBaseInfo.HouseholdRegisterAddress;
			//this..Checked = peopleBaseInfo.HouseholdRegisterType == this.rbtnPeasant.Text;
			if (peopleBaseInfo.HouseholdRegisterType == this.rbtnPeasant.Text) {
				this.rbtnPeasant.Checked = true;
			} else {
				this.rbtnNotPeasant.Checked = true;
			}
			this.txtHouseholdRegisterPostCode.Text = peopleBaseInfo.HouseholdRegisterPostCode;
			this.txtCurrentAddress.Text = peopleBaseInfo.CurrentAddress;
			this.txtPhoneNum.Text = peopleBaseInfo.PhoneNum;
			this.txtCurrentAddressPostCode.Text = peopleBaseInfo.CurrentAddressPostCode;
			this.cbxEducationGrade.Text = peopleBaseInfo.EducationGrade;
			this.txtGraduationSchool.Text = peopleBaseInfo.GraduationSchool;
			this.txtProfession.Text = peopleBaseInfo.Profession;
			this.txtEmergencyContactPerson.Text = peopleBaseInfo.EmergencyContactPerson;
			this.txtEmergencyContactPersonPhone.Text = peopleBaseInfo.EmergencyContactPersonPhone;
			this.txtEmergencyContactPersonRelation.Text = peopleBaseInfo.EmergencyContactPersonRelation;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (this.ValidateChildren(ValidationConstraints.Enabled) == false) {
				return;
			}

			var webPeople = new WebPeopleBasicInfo() {
				PeopleID = this._currentPeopleID,
				WorkerNum = this.txtWorkerNum.Text,
				PeopleName = this.txtName.Text,
				Gender = this.rbtnMan.Checked ? this.rbtnMan.Text : this.rbtnWoman.Text,
				DateOfBirth = this.dtpDateOfBirth.Value,
				//Age = int.Parse(this.txtAge.Text),
				IDCardNum = this.txtIDCardNum.Text,
				IsMarried = this.rbtnMarried.Checked,
				PoliticalStatus = this.cbxPoliticalStatus.Text,
				Nation = this.cbxNation.Text,
				HouseholdRegisterAddress = this.txtHouseholdRegisterAddress.Text,
				HouseholdRegisterType = this.rbtnPeasant.Checked ? this.rbtnPeasant.Text : this.rbtnNotPeasant.Text,
				HouseholdRegisterPostCode = this.txtHouseholdRegisterPostCode.Text,
				CurrentAddress = this.txtCurrentAddress.Text,
				PhoneNum = this.txtPhoneNum.Text,
				CurrentAddressPostCode = this.txtCurrentAddressPostCode.Text,
				EducationGrade = this.cbxEducationGrade.Text,
				GraduationSchool = this.txtGraduationSchool.Text,
				Profession = this.txtProfession.Text,
				EmergencyContactPerson = this.txtEmergencyContactPerson.Text,
				EmergencyContactPersonPhone = this.txtEmergencyContactPersonPhone.Text,
				EmergencyContactPersonRelation = this.txtEmergencyContactPersonRelation.Text,
			};
			int age;
			if (int.TryParse(this.txtAge.Text, out age)) {
				webPeople.Age = age;
			}
			var result = new PeopleBLL().UpdatePeople(webPeople);

			MessageHelper.ShowSaveDbResultMessage(result);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			InitCompontValue();
		}

		private void txtIDCardNum_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.RegexCheck((Control)sender, errorProvider1, ControlDataCheckHelper.IDCardNumberRegex, e);
		}

		private void txtIDCardNum_Validated(object sender, EventArgs e)
		{
			var dateStr = this.txtIDCardNum.Text.Substring(6, 8);
			dateStr = dateStr.Insert(4, "-");
			dateStr = dateStr.Insert(7, "-");
			DateTime parseDate;
			if (DateTime.TryParse(dateStr, out parseDate)) {
				this.dtpDateOfBirth.Value = parseDate.Date;
				this.txtAge.Text = (DateTime.Now.Year - parseDate.Year).ToString();
			} else {
				MessageBox.Show("身份证号错误！");
			}
		}

		private void txtName_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.NotNullCheck((Control)sender, errorProvider1, e);
		}
	}
}

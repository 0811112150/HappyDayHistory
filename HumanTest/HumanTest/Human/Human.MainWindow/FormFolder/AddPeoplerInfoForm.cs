using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Human.ViewModel;
using Human.BLL;
using Human.Common;
using System.IO;
using Human.MainWindow.HelperCommon;

namespace Human.MainWindow
{
	public partial class WorkerInfoForm : Form
	{
		public delegate void CallBackFunction();
		public event CallBackFunction callbackEvent;

		public WorkerInfoForm()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (this.ValidateChildren(ValidationConstraints.Enabled) == false) {
				return;
			}
			var webPeople = new WebPeopleBasicInfo() {
				WorkerNum = this.txtWorkerNum.Text,
				PeopleName = this.txtName.Text,
				Gender = this.rbtnMan.Checked ? this.rbtnMan.Text : this.rbtnWoman.Text,
				DateOfBirth = this.dtpDateOfBirth.Value.Date,
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

			var result = new PeopleBLL().AddPeople(webPeople);
			if (result.Code > 0) {
				MessageBox.Show(result.Message, SystemInfo.ErrorReminderStr, MessageBoxButtons.OK);
				return;
			} else {
				MessageBox.Show(SystemInfo.SuccessReminderStr, SystemInfo.ReminderStr, MessageBoxButtons.OK);
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

		private void WorkerInfoForm_Validating(object sender, CancelEventArgs e)
		{
			foreach (Control item in this.Controls) {
				item.Focus();
			}
		}

		private void txtAge_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.IntCheck((Control)sender, errorProvider1, e);
		}

		private void txtName_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.NotNullCheck((Control)sender, errorProvider1, e);
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
	}
}

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
using Human.DomainModel;
using Human.MainWindow.HelperCommon;

namespace Human.MainWindow
{
	public partial class FamilyInfoForm : Form
	{
		public delegate void CallBackFunction();
		public event CallBackFunction callbackEvent;

		private int? _currentPeopleFamilyID = null;
		private int? _peopleID = null;
		private bool _isEdit = false;

		public FamilyInfoForm(bool isEdit, int? peopleFamilyID, int? peopleID)
		{
			InitializeComponent();
			this._isEdit = isEdit;

			if (peopleFamilyID.HasValue) {
				this._currentPeopleFamilyID = peopleFamilyID;
				BindControlValue();
			}
			if (peopleID.HasValue) {
				this._peopleID = peopleID;
			}
		}

		private void BindControlValue()
		{
			var result = new PeopleFamilyBLL().GetPeopleFamilyByID(this._currentPeopleFamilyID.Value);
			if (result.Code > 0) {
				MessageBox.Show(result.Message, SystemInfo.ReminderStr, MessageBoxButtons.OK);
				this.Dispose();
			}
			var peopleFamily = result.Data;
			this.txtRelation.Text = peopleFamily.Relation;
			this.txtFamilyPeopleName.Text = peopleFamily.FamilyPeopleName;
			this.txtWorkUnit.Text = peopleFamily.WorkUnit;
			this.txtTitle.Text = peopleFamily.Title;
			this.txtPhoneNum.Text = peopleFamily.PhoneNum;
			this.txtAddress.Text = peopleFamily.Address;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var peopleFamily = new PeopleFamily();

			peopleFamily.Relation = this.txtRelation.Text;
			peopleFamily.FamilyPeopleName = this.txtFamilyPeopleName.Text;
			peopleFamily.WorkUnit = this.txtWorkUnit.Text;
			peopleFamily.Title = this.txtTitle.Text;
			peopleFamily.PhoneNum = this.txtPhoneNum.Text;
			peopleFamily.Address = this.txtAddress.Text;

			var bll = new PeopleFamilyBLL();
			if (this._isEdit) {
				if (this._currentPeopleFamilyID.HasValue) {
					peopleFamily.PeopleFamilyID = this._currentPeopleFamilyID.Value;
					var result = bll.UpdatePeopleFamily(peopleFamily);
					MessageHelper.ShowSaveDbResultMessage(result);
					if (result.Code == 0) {
						this.Dispose();
					}
				}
			} else {
				if (this._peopleID.HasValue) {
					peopleFamily.PeopleID = this._peopleID.Value;
					var result = bll.InsertPeopleFamily(peopleFamily);
					MessageHelper.ShowSaveDbResultMessage(result);
					if (result.Code == 0) {
						this.Dispose();
					}
				}
			}
			if (callbackEvent != null) {
				callbackEvent.Invoke();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void txtFamilyPeopleName_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.NotNullCheck((Control)sender, errorProvider1, e);
		}
	}
}

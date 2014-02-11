using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Human.MainWindow
{
	public partial class PeopleInfoMgmtForm : Form
	{
		private int _currentPeopleID;
		public Action Callback;

		public PeopleInfoMgmtForm(int peopleID)
		{
			InitializeComponent();

			this._currentPeopleID = peopleID;

			UserControl control;

			control = new PeopleBasicInfoUserControl(peopleID);
			control.Dock = DockStyle.Fill;
			this.tabPageBasicInfo.Controls.Add(control);

			control = new WorkInfoUserControl(peopleID);
			control.Dock = DockStyle.Fill;
			this.tabPageWorkInfo.Controls.Add(control);

			control = new FamilyListUserControl(peopleID);
			control.Dock = DockStyle.Fill;
			this.tabPageFamily.Controls.Add(control);

			control = new ContractListUserControl(peopleID);
			control.Dock = DockStyle.Fill;
			this.tabPageContract.Controls.Add(control);

			control = new TitleWageChangeRecordListUserControl(peopleID);
			control.Dock = DockStyle.Fill;
			this.tabPageTitleWageChangeRecord.Controls.Add(control);

			control = new RewardRecordListUserControl(peopleID);
			control.Dock = DockStyle.Fill;
			this.tabPageRewardRecord.Controls.Add(control);

			control = new InsuranceFundUserControl(peopleID);
			control.Dock = DockStyle.Fill;
			this.tabPageInsuranceFund.Controls.Add(control);

			control = new TrainingTestRecordListUserControl(peopleID);
			control.Dock = DockStyle.Fill;
			this.tabPageTrainingTestRecord.Controls.Add(control);

			control = new PeoplePicUserControl(peopleID);
			control.Dock = DockStyle.Fill;
			this.tabPagePeoplePic.Controls.Add(control);
		}

		private void PeopleInfoMgmtForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing) {
				if (Callback != null) {
					Callback();
				}
			}
		}


	}
}

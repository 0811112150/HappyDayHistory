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

		public PeopleInfoMgmtForm(int peopleID)
		{
			InitializeComponent();

			this._currentPeopleID = peopleID;

			this.tabPageBasicInfo.Controls.Add(new PeopleBasicInfoUserControl(peopleID));

			this.tabPageWorkInfo.Controls.Add(new WorkInfoUserControl(peopleID));

			this.tabPageFamily.Controls.Add(new FamilyListUserControl(peopleID));

			this.tabPageContract.Controls.Add(new ContractListUserControl(peopleID));

			this.tabPageTitleWageChangeRecord.Controls.Add(new TitleWageChangeRecordListUserControl(peopleID));

			this.tabPageRewardRecord.Controls.Add(new RewardRecordListUserControl(peopleID));

			this.tabPageInsuranceFund.Controls.Add(new InsuranceFundUserControl(peopleID));

			this.tabPageTrainingTestRecord.Controls.Add(new TrainingTestRecordListUserControl(peopleID));
		}


	}
}

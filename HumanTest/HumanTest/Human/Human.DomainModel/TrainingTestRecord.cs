using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human.DomainModel
{
	public class TrainingTestRecord
	{
		private string _trainingType;
		private string _trainingContent;
		private string _trainingDepartment;
		private string _testResult;
		private string _testPeople;
		private string _remark;


		public int RecordID { get; set; }

		public int PeopleID { get; set; }

		public DateTime? TrainingDate { get; set; }

		public string TrainingType { get { return _trainingType; } set { _trainingType = value; } }

		public string TrainingContent { get { return _trainingContent; } set { _trainingContent = value; } }

		public string TrainingDepartment { get { return _trainingDepartment; } set { _trainingDepartment = value; } }

		public DateTime? TestDate { get; set; }

		public string TestResult { get { return _testResult; } set { _testResult = value; } }

		public string TestPeople { get { return _testPeople; } set { _testPeople = value; } }

		public string Remark { get { return _remark; } set { _remark = value; } }
	}
}

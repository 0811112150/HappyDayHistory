using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.Common;

namespace Human.DomainModel
{
	public class TitleWageChangeRecord
	{
		private string _contractNum;
		private string _beforeChangeTitle;
		private string _beforeChangeBasicWage;
		private string _afterChangeTitle;

		public int TitleWageChangeRecordID { get; set; }
		public int PeopleID { get; set; }
		public DateTime? ChangeDate { get; set; }
		public int ChangeType { get; set; }
		public string ContractNum { get { return _contractNum; } set { _contractNum = value; } }
		public string BeforeChangeTitle { get { return _beforeChangeTitle; } set { _beforeChangeTitle = value; } }
		public float BeforeChangeBasicWage { get; set; }
		public float BeforeChangeAllowance { get; set; }
		public float BeforeChangeYearAward { get; set; }
		public string AfterChangeTitle { get { return _afterChangeTitle; } set { _afterChangeTitle = value; } }
		public float AfterChangeBasicWage { get; set; }
		public float AfterChangeAllowance { get; set; }
		public float AfterChangeYearAward { get; set; }

		public string ChangeTypeStr { get { return ((TitleChangeType)ChangeType).ToString(); } }
	}
}

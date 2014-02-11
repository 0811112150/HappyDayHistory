using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human.ViewModel
{
	public class WebPeopleWorkInfo
	{
		private string _department = string.Empty;
		private string _title = string.Empty;
		private string _titleState = string.Empty;
		private string _leftCompanyReason = string.Empty;
		private string _specialSkill = string.Empty;
		private string _wageCardNumber = string.Empty;
		private string _wageCardAddress = string.Empty;

		private string _archivesNum = string.Empty;

		public int PeopleID { get; set; }
		public DateTime? JoinCompanyDate { get; set; }

		public float LengthOfService { get; set; }

		public string Department { get { return _department; } set { _department = value; } }

		public string Title { get { return _title; } set { _title = value; } }

		public string TitleState { get { return _titleState; } set { _titleState = value; } }

		public DateTime? LeftCompanyDate { get; set; }

		public string LeftCompanyReason { get { return _leftCompanyReason; } set { _leftCompanyReason = value; } }

		public string SpecialSkill { get { return _specialSkill; } set { _specialSkill = value; } }

		public string WageCardNumber { get { return _wageCardNumber; } set { _wageCardNumber = value; } }

		public string WageCardAddress { get { return _wageCardAddress; } set { _wageCardAddress = value; } }


		//档案
		public bool IsCallInArchives { get; set; }

		public string ArchivesNum { get { return _archivesNum; } set { _archivesNum = value; } }

		public DateTime? ArchiveCallInDate { get; set; }

		public DateTime? ArchiveCallOutDate { get; set; }
	}
}

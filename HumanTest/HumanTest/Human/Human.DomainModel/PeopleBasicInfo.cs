using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human.DomainModel
{
	public class PeopleBasicInfo
	{
		private string _peopleName = string.Empty;
		private string _gender = string.Empty;
		private string _iDCardNum = string.Empty;
		private string _politicalStatus = string.Empty;
		private string _nation = string.Empty;
		private string _householdRegisterAddress = string.Empty;
		private string _householdRegisterType = string.Empty;
		private string _householdRegisterPostCode = string.Empty;
		private string _currentAddress = string.Empty;
		private string _phoneNum = string.Empty;
		private string _currentAddressPostCode = string.Empty;
		private string _educationGrade = string.Empty;
		private string _graduationSchool = string.Empty;
		private string _profession = string.Empty;
		private string _emergencyContactPerson = string.Empty;
		private string _emergencyContactPersonPhone = string.Empty;
		private string _emergencyContactPersonRelation = string.Empty;
		private string _department = string.Empty;
		private string _title = string.Empty;
		private string _titleState = string.Empty;
		private string _leftCompanyReason = string.Empty;
		private string _specialSkill = string.Empty;
		private string _wageCardNumber = string.Empty;
		private string _wageCardAddress = string.Empty;
		private string _archivesNum = string.Empty;
		private string _workerNum;

		public int PeopleID { get; set; }

		public string WorkerNum { get { return _workerNum; } set { _workerNum = value; } }

		public string PeopleName { get { return _peopleName; } set { _peopleName = value; } }

		public string Gender { get { return _gender; } set { _gender = value; } }

		public DateTime? DateOfBirth { get; set; }

		public int Age { get; set; }

		public string IDCardNum { get { return _iDCardNum; } set { _iDCardNum = value; } }

		public bool IsMarried { get; set; }

		public string PoliticalStatus { get { return _politicalStatus; } set { _politicalStatus = value; } }

		public string Nation { get { return _nation; } set { _nation = value; } }

		public string HouseholdRegisterAddress { get { return _householdRegisterAddress; } set { _householdRegisterAddress = value; } }

		public string HouseholdRegisterType { get { return _householdRegisterType; } set { _householdRegisterType = value; } }

		public string HouseholdRegisterPostCode { get { return _householdRegisterPostCode; } set { _householdRegisterPostCode = value; } }

		public string CurrentAddress { get { return _currentAddress; } set { _currentAddress = value; } }

		public string PhoneNum { get { return _phoneNum; } set { _phoneNum = value; } }

		public string CurrentAddressPostCode { get { return _currentAddressPostCode; } set { _currentAddressPostCode = value; } }

		public string EducationGrade { get { return _educationGrade; } set { _educationGrade = value; } }

		public string GraduationSchool { get { return _graduationSchool; } set { _graduationSchool = value; } }

		public string Profession { get { return _profession; } set { _profession = value; } }

		public string EmergencyContactPerson { get { return _emergencyContactPerson; } set { _emergencyContactPerson = value; } }

		public string EmergencyContactPersonPhone { get { return _emergencyContactPersonPhone; } set { _emergencyContactPersonPhone = value; } }

		public string EmergencyContactPersonRelation { get { return _emergencyContactPersonRelation; } set { _emergencyContactPersonRelation = value; } }

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

		public bool IsCallInArchives { get; set; }

		public string ArchivesNum { get { return _archivesNum; } set { _archivesNum = value; } }

		public DateTime? ArchiveCallInDate { get; set; }

		public DateTime? ArchiveCallOutDate { get; set; }

		//public bool IsLeftTwoMonth { get; set; }
	}
}

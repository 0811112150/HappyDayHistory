using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.DomainModel;
using Human.ViewModel;
using Human.Common;
using Human.DAL;

namespace Human.BLL
{
	public class PeopleBLL
	{

		#region 基本信息
		public CResult<WebPeopleBasicInfo> GetPeopleByID(int peopleID)
		{
			if (peopleID <= 0) {
				return new CResult<WebPeopleBasicInfo>(null, ErrorCode.ParameterError);
			}

			var domainModel = new PeopleDAL().GetPeopleBasicInfoByID(peopleID);
			if (domainModel == null) {
				return new CResult<WebPeopleBasicInfo>(null, ErrorCode.PeopleNotExist);
			} else {
				var result = new WebPeopleBasicInfo() {
					PeopleID = domainModel.PeopleID,
					WorkerNum = domainModel.WorkerNum,
					PeopleName = domainModel.PeopleName,
					DateOfBirth = domainModel.DateOfBirth,
					Gender = domainModel.Gender,
					Age = domainModel.Age,
					IDCardNum = domainModel.IDCardNum,
					IsMarried = domainModel.IsMarried,
					PoliticalStatus = domainModel.PoliticalStatus,
					Nation = domainModel.Nation,
					HouseholdRegisterAddress = domainModel.HouseholdRegisterAddress,
					HouseholdRegisterType = domainModel.HouseholdRegisterType,
					HouseholdRegisterPostCode = domainModel.HouseholdRegisterPostCode,
					CurrentAddress = domainModel.CurrentAddress,
					PhoneNum = domainModel.PhoneNum,
					CurrentAddressPostCode = domainModel.CurrentAddressPostCode,
					EducationGrade = domainModel.EducationGrade,
					GraduationSchool = domainModel.GraduationSchool,
					Profession = domainModel.Profession,
					EmergencyContactPerson = domainModel.EmergencyContactPerson,
					EmergencyContactPersonPhone = domainModel.EmergencyContactPersonPhone,
					EmergencyContactPersonRelation = domainModel.EmergencyContactPersonRelation
				};
				return new CResult<WebPeopleBasicInfo>(result);
			}
		}

		public CResult<List<PeopleBasicInfo>> GetPeopleList(out int totalCount, string searchKey = "", int pageSize = 10, int pageIndex = 1)
		{
			var result = new PeopleDAL().GetPeopleList(out totalCount, searchKey, pageIndex, pageSize);
			//foreach (var people in result) {
			//    if (CommonData.NeedReminderPeopleIDList.Contains(people.PeopleID)) {
			//        people.IsLeftTwoMonth = true;
			//    }
			//}
			return new CResult<List<PeopleBasicInfo>>(result);
		}

		public CResult<bool> AddPeople(WebPeopleBasicInfo webPeople)
		{
			var people = new PeopleBasicInfo() {
				WorkerNum = webPeople.WorkerNum,
				PeopleName = webPeople.PeopleName,
				DateOfBirth = webPeople.DateOfBirth,
				Gender = webPeople.Gender,
				Age = webPeople.Age,
				IDCardNum = webPeople.IDCardNum,
				IsMarried = webPeople.IsMarried,
				PoliticalStatus = webPeople.PoliticalStatus,
				Nation = webPeople.Nation,
				HouseholdRegisterAddress = webPeople.HouseholdRegisterAddress,
				HouseholdRegisterType = webPeople.HouseholdRegisterType,
				HouseholdRegisterPostCode = webPeople.HouseholdRegisterPostCode,
				CurrentAddress = webPeople.CurrentAddress,
				PhoneNum = webPeople.PhoneNum,
				CurrentAddressPostCode = webPeople.CurrentAddressPostCode,
				EducationGrade = webPeople.EducationGrade,
				GraduationSchool = webPeople.GraduationSchool,
				Profession = webPeople.Profession,
				EmergencyContactPerson = webPeople.EmergencyContactPerson,
				EmergencyContactPersonPhone = webPeople.EmergencyContactPersonPhone,
				EmergencyContactPersonRelation = webPeople.EmergencyContactPersonRelation
			};
			var result = new PeopleDAL().InsertPeople(people);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.SaveDataFailed);
			}
		}

		public CResult<bool> DeletePeople(int peopleID)
		{
			if (peopleID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			var dal = new PeopleDAL();

			var people = dal.GetPeopleBasicInfoByID(peopleID);
			if (people == null) {
				return new CResult<bool>(false, ErrorCode.PeopleNotExist);
			}

			var result = dal.DeletePeopleByID(peopleID);

			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.SaveDataFailed);
			}
		}

		public CResult<bool> UpdatePeople(WebPeopleBasicInfo webPeople)
		{
			var people = new PeopleBasicInfo() {
				PeopleID = webPeople.PeopleID,
				WorkerNum = webPeople.WorkerNum,
				PeopleName = webPeople.PeopleName,
				DateOfBirth = webPeople.DateOfBirth,
				Gender = webPeople.Gender,
				Age = webPeople.Age,
				IDCardNum = webPeople.IDCardNum,
				IsMarried = webPeople.IsMarried,
				PoliticalStatus = webPeople.PoliticalStatus,
				Nation = webPeople.Nation,
				HouseholdRegisterAddress = webPeople.HouseholdRegisterAddress,
				HouseholdRegisterType = webPeople.HouseholdRegisterType,
				HouseholdRegisterPostCode = webPeople.HouseholdRegisterPostCode,
				CurrentAddress = webPeople.CurrentAddress,
				PhoneNum = webPeople.PhoneNum,
				CurrentAddressPostCode = webPeople.CurrentAddressPostCode,
				EducationGrade = webPeople.EducationGrade,
				GraduationSchool = webPeople.GraduationSchool,
				Profession = webPeople.Profession,
				EmergencyContactPerson = webPeople.EmergencyContactPerson,
				EmergencyContactPersonPhone = webPeople.EmergencyContactPersonPhone,
				EmergencyContactPersonRelation = webPeople.EmergencyContactPersonRelation
			};
			var result = new PeopleDAL().UpdatePeople(people);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.SaveDataFailed);
			}
		}
		#endregion

		#region 工作信息
		public CResult<WebPeopleWorkInfo> GetPeopleWorkInfoByPeopleID(int peopleID)
		{
			if (peopleID <= 0) {
				return new CResult<WebPeopleWorkInfo>(null, ErrorCode.ParameterError);
			}

			var domainModel = new PeopleDAL().GetPeopleWorkInfoByID(peopleID);
			if (domainModel == null) {
				return new CResult<WebPeopleWorkInfo>(null, ErrorCode.PeopleNotExist);
			} else {
				var result = new WebPeopleWorkInfo() {
					PeopleID = domainModel.PeopleID,
					JoinCompanyDate = domainModel.JoinCompanyDate,
					LengthOfService = domainModel.LengthOfService,
					Department = domainModel.Department,
					Title = domainModel.Title,
					TitleState = domainModel.TitleState,
					LeftCompanyDate = domainModel.LeftCompanyDate,
					LeftCompanyReason = domainModel.LeftCompanyReason,
					SpecialSkill = domainModel.SpecialSkill,
					WageCardNumber = domainModel.WageCardNumber,
					WageCardAddress = domainModel.WageCardAddress,
					IsCallInArchives = domainModel.IsCallInArchives,
					ArchivesNum = domainModel.ArchivesNum,
					ArchiveCallInDate = domainModel.ArchiveCallInDate,
					ArchiveCallOutDate = domainModel.ArchiveCallOutDate,
				};
				return new CResult<WebPeopleWorkInfo>(result);
			}
		}

		public CResult<bool> UpdatePeopleWorkInfo(WebPeopleWorkInfo webPeopleWorkInfo)
		{
			var people = new PeopleBasicInfo() {
				PeopleID = webPeopleWorkInfo.PeopleID,
				JoinCompanyDate = webPeopleWorkInfo.JoinCompanyDate,
				LengthOfService = webPeopleWorkInfo.LengthOfService,
				Department = webPeopleWorkInfo.Department,
				Title = webPeopleWorkInfo.Title,
				TitleState = webPeopleWorkInfo.TitleState,
				LeftCompanyDate = webPeopleWorkInfo.LeftCompanyDate,
				LeftCompanyReason = webPeopleWorkInfo.LeftCompanyReason,
				SpecialSkill = webPeopleWorkInfo.SpecialSkill,
				WageCardNumber = webPeopleWorkInfo.WageCardNumber,
				WageCardAddress = webPeopleWorkInfo.WageCardAddress,
				IsCallInArchives = webPeopleWorkInfo.IsCallInArchives,
				ArchivesNum = webPeopleWorkInfo.ArchivesNum,
				ArchiveCallInDate = webPeopleWorkInfo.ArchiveCallInDate,
				ArchiveCallOutDate = webPeopleWorkInfo.ArchiveCallOutDate,
			};
			var result = new PeopleDAL().UpdatePeopleWorkInfo(people);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.SaveDataFailed);
			}
		}
		#endregion
	}
}

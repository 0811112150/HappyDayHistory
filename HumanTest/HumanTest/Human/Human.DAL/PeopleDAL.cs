using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Human.DomainModel;
using System.Data;

namespace Human.DAL
{
	public class PeopleDAL
	{
		private string _peopleTableName = "PeoplebasicInfo";

		public bool DeletePeopleByID(int peopleID)
		{
			string sqlText = string.Format("delete from {0} where PeopleID=@peopleID", _peopleTableName);
			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("peopleID", peopleID);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public PeopleBasicInfo GetPeopleBasicInfoByID(int peopleID)
		{
			using (var connection = new OleDbConnection(ConfigManagement.AccessConStr)) {
				string sqlText = string.Format(@"select PeopleID, PeopleName,Gender,DateOfBirth,Age,IDCardNum,IsMarried,PoliticalStatus,
				Nation,HouseholdRegisterAddress,HouseholdRegisterType,HouseholdRegisterPostCode,CurrentAddress,PhoneNum,CurrentAddressPostCode,
				EducationGrade,GraduationSchool,Profession,EmergencyContactPerson,EmergencyContactPersonPhone,EmergencyContactPersonRelation ,WorkerNum from {0} where PeopleID=@peopleID", _peopleTableName);
				var paras = new OleDbParameter[1];
				paras[0] = new OleDbParameter("peopleID", peopleID);

				var reader = new OLESqlHelper().GetReader(sqlText, connection, paras);
				if (reader.Read()) {
					int i = 0;
					var people = new PeopleBasicInfo();
					people.PeopleID = reader.GetInt32(i++);
					people.PeopleName = reader.GetString(i++);
					people.Gender = reader.GetString(i++);
					if (!reader.IsDBNull(i)) {
						people.DateOfBirth = reader.GetDateTime(i++);
					} else {
						i++;
					}
					people.Age = reader.GetInt32(i++);
					people.IDCardNum = reader.GetString(i++);
					people.IsMarried = reader.GetBoolean(i++);
					people.PoliticalStatus = reader.GetString(i++);
					people.Nation = reader.GetString(i++);
					people.HouseholdRegisterAddress = reader.GetString(i++);
					people.HouseholdRegisterType = reader.GetString(i++);
					people.HouseholdRegisterPostCode = reader.GetString(i++);
					people.CurrentAddress = reader.GetString(i++);
					people.PhoneNum = reader.GetString(i++);
					people.CurrentAddressPostCode = reader.GetString(i++);
					people.EducationGrade = reader.GetString(i++);
					people.GraduationSchool = reader.GetString(i++);
					people.Profession = reader.GetString(i++);
					people.EmergencyContactPerson = reader.GetString(i++);
					people.EmergencyContactPersonPhone = reader.GetString(i++);
					people.EmergencyContactPersonRelation = reader.GetString(i++);
					people.WorkerNum = reader.GetString(i++);

					return people;
				} else {
					return null;
				}
			}
		}

		public bool InsertPeople(PeopleBasicInfo people)
		{
			string sqlText = string.Format(@"insert into {0}(
				WorkerNum,PeopleName,Gender,DateOfBirth,Age,IDCardNum,IsMarried,PoliticalStatus,
				Nation,HouseholdRegisterAddress,HouseholdRegisterType,HouseholdRegisterPostCode,CurrentAddress,PhoneNum,CurrentAddressPostCode,
				EducationGrade,GraduationSchool,Profession,EmergencyContactPerson,EmergencyContactPersonPhone,EmergencyContactPersonRelation
				) 
				values(@WorkerNum,@peopleName,@gender,@dateOfBirth,@Age,@IDCardNum,@IsMarried,@PoliticalStatus,
				@Nation,@HouseholdRegisterAddress,@HouseholdRegisterType,@HouseholdRegisterPostCode,@CurrentAddress,@PhoneNum,@CurrentAddressPostCode,
				@EducationGrade,@GraduationSchool,@Profession,@EmergencyContactPerson,@EmergencyContactPersonPhone,@EmergencyContactPersonRelation)", _peopleTableName);
			var paras = new OleDbParameter[21];
			paras[0] = new OleDbParameter("WorkerNum", people.WorkerNum);
			paras[1] = new OleDbParameter("peopleName", people.PeopleName);
			paras[2] = new OleDbParameter("gender", people.Gender);
			paras[3] = new OleDbParameter("dateOfBirth", people.DateOfBirth.Value.Date);
			paras[4] = new OleDbParameter("Age", people.Age);
			paras[5] = new OleDbParameter("IDCardNum", people.IDCardNum);
			paras[6] = new OleDbParameter("IsMarried", people.IsMarried);
			paras[7] = new OleDbParameter("PoliticalStatus", people.PoliticalStatus);
			paras[8] = new OleDbParameter("Nation", people.Nation);
			paras[9] = new OleDbParameter("HouseholdRegisterAddress", people.HouseholdRegisterAddress);
			paras[10] = new OleDbParameter("HouseholdRegisterType", people.HouseholdRegisterType);
			paras[11] = new OleDbParameter("HouseholdRegisterPostCode", people.HouseholdRegisterPostCode);
			paras[12] = new OleDbParameter("CurrentAddress", people.CurrentAddress);
			paras[13] = new OleDbParameter("PhoneNum", people.PhoneNum);
			paras[14] = new OleDbParameter("CurrentAddressPostCode", people.CurrentAddressPostCode);
			paras[15] = new OleDbParameter("EducationGrade", people.EducationGrade);
			paras[16] = new OleDbParameter("GraduationSchool", people.GraduationSchool);
			paras[17] = new OleDbParameter("Profession", people.Profession);
			paras[18] = new OleDbParameter("EmergencyContactPerson", people.EmergencyContactPerson);
			paras[19] = new OleDbParameter("EmergencyContactPersonPhone", people.EmergencyContactPersonPhone);
			paras[20] = new OleDbParameter("EmergencyContactPersonRelation", people.EmergencyContactPersonRelation);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public bool UpdatePeople(PeopleBasicInfo people)
		{
			string sqlText = string.Format(@"update {0} set 
				WorkerNum=@WorkerNum,
				PeopleName=@peopleName,
				Gender=@gender,
				DateOfBirth=@dateOfBirth,
				Age=@Age,
				IDCardNum=@IDCardNum,
				IsMarried=@IsMarried,
				PoliticalStatus=@PoliticalStatus,
				Nation=@Nation,
				HouseholdRegisterAddress=@HouseholdRegisterAddress,
				HouseholdRegisterType=@HouseholdRegisterType,
				HouseholdRegisterPostCode=@HouseholdRegisterPostCode,
				CurrentAddress=@CurrentAddress,
				PhoneNum=@PhoneNum,
				CurrentAddressPostCode=@CurrentAddressPostCode,
				EducationGrade=@EducationGrade,
				GraduationSchool=@GraduationSchool,
				Profession=@Profession,
				EmergencyContactPerson=@EmergencyContactPerson,
				EmergencyContactPersonPhone=@EmergencyContactPersonPhone,
				EmergencyContactPersonRelation=@EmergencyContactPersonRelation
				where PeopleID=@peopleID", _peopleTableName);
			var paras = new OleDbParameter[22];
			paras[0] = new OleDbParameter("WorkerNum", people.WorkerNum);
			paras[1] = new OleDbParameter("peopleName", people.PeopleName);
			paras[2] = new OleDbParameter("gender", people.Gender);
			paras[3] = new OleDbParameter("dateOfBirth", people.DateOfBirth.Value);
			paras[4] = new OleDbParameter("Age", people.Age);
			paras[5] = new OleDbParameter("IDCardNum", people.IDCardNum);
			paras[6] = new OleDbParameter("IsMarried", people.IsMarried);
			paras[7] = new OleDbParameter("PoliticalStatus", people.PoliticalStatus);
			paras[8] = new OleDbParameter("Nation", people.Nation);
			paras[9] = new OleDbParameter("HouseholdRegisterAddress", people.HouseholdRegisterAddress);
			paras[10] = new OleDbParameter("HouseholdRegisterType", people.HouseholdRegisterType);
			paras[11] = new OleDbParameter("HouseholdRegisterPostCode", people.HouseholdRegisterPostCode);
			paras[12] = new OleDbParameter("CurrentAddress", people.CurrentAddress);
			paras[13] = new OleDbParameter("PhoneNum", people.PhoneNum);
			paras[14] = new OleDbParameter("CurrentAddressPostCode", people.CurrentAddressPostCode);
			paras[15] = new OleDbParameter("EducationGrade", people.EducationGrade);
			paras[16] = new OleDbParameter("GraduationSchool", people.GraduationSchool);
			paras[17] = new OleDbParameter("Profession", people.Profession);
			paras[18] = new OleDbParameter("EmergencyContactPerson", people.EmergencyContactPerson);
			paras[19] = new OleDbParameter("EmergencyContactPersonPhone", people.EmergencyContactPersonPhone);
			paras[20] = new OleDbParameter("EmergencyContactPersonRelation", people.EmergencyContactPersonRelation);
			paras[21] = new OleDbParameter("peopleID", people.PeopleID);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public List<PeopleBasicInfo> GetPeopleList(out int totalCount, string searchKey = "", int pageIndex = 1, int pageSize = 10)
		{
			searchKey = searchKey.Trim();
			string sqlText = string.Format("select count(*) from {0} where (PeopleName like '%{1}%' or WorkerNum like '%{1}%')", _peopleTableName, searchKey);
			totalCount = new OLESqlHelper().GetCount(sqlText);
			var exceptCount = (pageIndex - 1) * pageSize;
			if (exceptCount > 0) {
				sqlText = string.Format("select top {0} * from {1} where (PeopleName like '%{3}%' or WorkerNum like '%{3}%')  and PeopleID > (select max(PeopleID) from (select top {2} PeopleID from {1} where PeopleName like '%{3}%' or WorkerNum like '%{3}%'  order by PeopleID))  order by PeopleID", pageSize, _peopleTableName, exceptCount, searchKey);
			} else {
				sqlText = string.Format("select top {0} * from {1} where PeopleName like '%{2}%' or WorkerNum like '%{2}%' order by PeopleID", pageSize, _peopleTableName, searchKey);
			}

			var table = new OLESqlHelper().GetTable(sqlText);

			var peopleList = new List<PeopleBasicInfo>();
			foreach (DataRow row in table.Rows) {
				var people = new PeopleBasicInfo() {
					PeopleID = (int)row["PeopleID"],
					Gender = row["Gender"].ToString(),
					PeopleName = row["PeopleName"].ToString(),
					DateOfBirth = DateTime.Parse(row["DateOfBirth"].ToString()),
					Department = row["Department"].ToString(),
					PhoneNum = row["PhoneNum"].ToString(),
					Title = row["Title"].ToString(),
					WorkerNum = row["WorkerNum"].ToString(),
					TitleState = row["TitleState"].ToString(),
				};
				peopleList.Add(people);
			}
			return peopleList;
		}

		#region 工作信息
		public PeopleBasicInfo GetPeopleWorkInfoByID(int peopleID)
		{
			using (var connection = new OleDbConnection(ConfigManagement.AccessConStr)) {
				string sqlText = string.Format(@"select PeopleID,JoinCompanyDate,LengthOfService,Department,Title,TitleState,
											LeftCompanyDate,LeftCompanyReason,SpecialSkill,WageCardNumber,WageCardAddress,
											IsCallInArchives,ArchivesNum,ArchiveCallInDate,ArchiveCallOutDate
											from {0} where PeopleID=@peopleID", _peopleTableName);
				var paras = new OleDbParameter[1];
				paras[0] = new OleDbParameter("peopleID", peopleID);

				var reader = new OLESqlHelper().GetReader(sqlText, connection, paras);
				if (reader.Read()) {
					int i = 0;
					var people = new PeopleBasicInfo();
					people.PeopleID = reader.GetInt32(i++);
					if (!reader.IsDBNull(i)) {
						people.JoinCompanyDate = reader.GetDateTime(i++);
					} else {
						i++;
					}
					people.LengthOfService = reader.GetFloat(i++);
					people.Department = reader.IsDBNull(i) ? "" : reader.GetString(i++);
					people.Title = reader.IsDBNull(i) ? "" : reader.GetString(i++);
					people.TitleState = reader.IsDBNull(i) ? "" : reader.GetString(i++);
					people.LeftCompanyDate = reader.IsDBNull(i) ? new Nullable<DateTime>() : reader.GetDateTime(i++);
					people.LeftCompanyReason = reader.IsDBNull(i) ? "" : reader.GetString(i++);
					people.SpecialSkill = reader.IsDBNull(i) ? "" : reader.GetString(i++);
					people.WageCardNumber = reader.IsDBNull(i) ? "" : reader.GetString(i++);
					people.WageCardAddress = reader.IsDBNull(i) ? "" : reader.GetString(i++);
					people.IsCallInArchives = reader.IsDBNull(i) ? false : reader.GetBoolean(i++);
					people.ArchivesNum = reader.IsDBNull(i) ? "" : reader.GetString(i++);
					people.ArchiveCallInDate = reader.IsDBNull(i) ? new Nullable<DateTime>() : reader.GetDateTime(i++);
					people.ArchiveCallOutDate = reader.IsDBNull(i) ? new Nullable<DateTime>() : reader.GetDateTime(i++);

					return people;
				} else {
					return null;
				}
			}
		}

		public bool UpdatePeopleWorkInfo(PeopleBasicInfo people)
		{
			string sqlText = string.Format(@"update {0} set 
										JoinCompanyDate=@JoinCompanyDate,
										LengthOfService=@LengthOfService,
										Department=@Department,
										Title=@Title,
										TitleState=@TitleState,
										LeftCompanyDate=@LeftCompanyDate,
										LeftCompanyReason=@LeftCompanyReason,
										SpecialSkill=@SpecialSkill,
										WageCardNumber=@WageCardNumber,
										WageCardAddress=@WageCardAddress,
										IsCallInArchives=@IsCallInArchives,
										ArchivesNum=@ArchivesNum,
										ArchiveCallInDate=@ArchiveCallInDate,
										ArchiveCallOutDate=@ArchiveCallOutDate 
										where PeopleID=@PeopleID", _peopleTableName);
			var paras = new OleDbParameter[15];
			paras[0] = new OleDbParameter("JoinCompanyDate", people.JoinCompanyDate);
			paras[0].OleDbType = OleDbType.DBDate;
			paras[1] = new OleDbParameter("LengthOfService", people.LengthOfService);
			paras[1].OleDbType = OleDbType.Single;
			paras[2] = new OleDbParameter("Department", people.Department);
			paras[3] = new OleDbParameter("Title", people.Title);
			paras[4] = new OleDbParameter("TitleState", people.TitleState);
			paras[5] = new OleDbParameter("LeftCompanyDate", people.LeftCompanyDate);
			paras[5].OleDbType = OleDbType.DBDate;
			paras[6] = new OleDbParameter("LeftCompanyReason", people.LeftCompanyReason);
			paras[7] = new OleDbParameter("SpecialSkill", people.SpecialSkill);
			paras[8] = new OleDbParameter("WageCardNumber", people.WageCardNumber);
			paras[9] = new OleDbParameter("WageCardAddress", people.WageCardAddress);
			paras[10] = new OleDbParameter("IsCallInArchives", people.IsCallInArchives);
			paras[11] = new OleDbParameter("ArchivesNum", people.ArchivesNum);
			paras[12] = new OleDbParameter("ArchiveCallInDate", people.ArchiveCallInDate);
			paras[12].OleDbType = OleDbType.DBDate;
			paras[13] = new OleDbParameter("ArchiveCallOutDate", people.ArchiveCallOutDate);
			paras[13].OleDbType = OleDbType.DBDate;
			paras[14] = new OleDbParameter("PeopleID", people.PeopleID);
			//            string sqlText = string.Format(@"update {0} set 
			//										LengthOfService=@LengthOfService
			//										where PeopleID=@PeopleID", _ContractTableName);
			//            var paras = new OleDbParameter[2];
			//            paras[0] = new OleDbParameter("LengthOfService", contract.LengthOfService);
			//            //paras[5] = new OleDbParameter("LeftCompanyDate", contract.LeftCompanyDate.Value);
			//            //paras[6] = new OleDbParameter("LeftCompanyReason", contract.LeftCompanyReason);
			//            paras[1] = new OleDbParameter("PeopleID", contract.PeopleID);
			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}
		#endregion
	}
}

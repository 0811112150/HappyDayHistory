using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.DomainModel;
using System.Data.OleDb;
using System.Data;

namespace Human.DAL
{
	public class PeopleFamilyDAL
	{
		private string _peopleFamilyTableName = "PeopleFamily";

		public List<PeopleFamily> GetPeopleFamilyList(int peopleID)
		{
			string sqlText = string.Format(@"select 
				FamilyPeopleID,
				Relation,
				FamilyPeopleName,
				WorkUnit,
				Title,
				PhoneNum,
				Address
				from {0} 
				where PeopleID=@PeopleID"
				, _peopleFamilyTableName);

			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("PeopleID", peopleID);

			var table = new OLESqlHelper().GetTable(sqlText, paras);

			var peopleFamilyList = new List<PeopleFamily>();
			foreach (DataRow row in table.Rows) {
				var peopleFamily = new PeopleFamily() {
					PeopleFamilyID = (int)row["FamilyPeopleID"],
					Relation = row["Relation"].ToString(),
					FamilyPeopleName = row["FamilyPeopleName"].ToString(),
					WorkUnit = row["WorkUnit"].ToString(),
					Title = row["Title"].ToString(),
					PhoneNum = row["PhoneNum"].ToString(),
					Address = row["Address"].ToString()
				};
				peopleFamilyList.Add(peopleFamily);
			}
			return peopleFamilyList;
		}

		public bool DeletePeopleFamilyByID(int familyPeopleID)
		{
			string sqlText = string.Format("delete from {0} where FamilyPeopleID=@FamilyPeopleID", _peopleFamilyTableName);
			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("FamilyPeopleID", familyPeopleID);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public PeopleFamily GetPeopleFamilyByID(int familyPeopleID)
		{
			using (var connection = new OleDbConnection(ConfigManagement.AccessConStr)) {
				string sqlText = string.Format(@"select 
					PeopleFamilyID,
					PeopleID,
					Relation,
					FamilyPeopleName,
					WorkUnit,
					Title,
					PhoneNum,
					Address 
					from {0} where PeopleFamilyID=@PeopleFamilyID", _peopleFamilyTableName);
				var paras = new OleDbParameter[1];
				paras[0] = new OleDbParameter("PeopleFamilyID", familyPeopleID);

				var reader = new OLESqlHelper().GetReader(sqlText, connection, paras);
				if (reader.Read()) {
					int i = 0;
					var peopleFamily = new PeopleFamily();
					peopleFamily.PeopleFamilyID = reader.GetInt32(i++);
					peopleFamily.PeopleID = reader.GetInt32(i++);
					peopleFamily.Relation = reader.GetString(i++);
					peopleFamily.FamilyPeopleName = reader.GetString(i++);
					peopleFamily.WorkUnit = reader.GetString(i++);
					peopleFamily.Title = reader.GetString(i++);
					peopleFamily.PhoneNum = reader.GetString(i++);
					peopleFamily.Address = reader.GetString(i++);

					return peopleFamily;
				} else {
					return null;
				}
			}
		}

		public bool InsertPeopleFamily(PeopleFamily peopleFamily)
		{
			string sqlText = string.Format(@"insert into {0}(
				PeopleID,
				Relation,
				FamilyPeopleName,
				WorkUnit,
				Title,
				PhoneNum,
				Address
				) 
				values(
				@PeopleID,
				@Relation,
				@FamilyPeopleName,
				@WorkUnit,
				@Title,
				@PhoneNum,
				@Address)", _peopleFamilyTableName);
			var paras = new OleDbParameter[7];
			paras[0] = new OleDbParameter("PeopleID", peopleFamily.PeopleID);
			paras[1] = new OleDbParameter("Relation", peopleFamily.Relation);
			paras[2] = new OleDbParameter("FamilyPeopleName", peopleFamily.FamilyPeopleName);
			paras[3] = new OleDbParameter("WorkUnit", peopleFamily.WorkUnit);
			paras[4] = new OleDbParameter("Title", peopleFamily.Title);
			paras[5] = new OleDbParameter("PhoneNum", peopleFamily.PhoneNum);
			paras[6] = new OleDbParameter("Address", peopleFamily.Address);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public bool UpdatePeopleFamily(PeopleFamily peopleFamily)
		{
			string sqlText = string.Format(@"update {0} set 
				Relation=@Relation,
				FamilyPeopleName=@FamilyPeopleName,
				WorkUnit=@WorkUnit,
				Title=@Title,
				PhoneNum=@PhoneNum,
				Address=@Address
				where FamilyPeopleID=@FamilyPeopleID", _peopleFamilyTableName);
			var paras = new OleDbParameter[7];			
			paras[0] = new OleDbParameter("Relation", peopleFamily.Relation);
			paras[1] = new OleDbParameter("FamilyPeopleName", peopleFamily.FamilyPeopleName);
			paras[2] = new OleDbParameter("WorkUnit", peopleFamily.WorkUnit);
			paras[3] = new OleDbParameter("Title", peopleFamily.Title);
			paras[4] = new OleDbParameter("PhoneNum", peopleFamily.PhoneNum);
			paras[5] = new OleDbParameter("Address", peopleFamily.Address);
			paras[6] = new OleDbParameter("FamilyPeopleID", peopleFamily.PeopleFamilyID);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}
	}
}

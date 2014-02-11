using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Human.DomainModel;
using System.Data;

namespace Human.DAL
{
	public class TrainingTestRecordDAL
	{
		private string _TrainingTestRecordTableName = "TrainingTestRecord";

		public List<TrainingTestRecord> GetTrainingTestRecordList(int peopleID)
		{
			string sqlText = string.Format(@"select 
				RecordID,
				TrainingDate,
				TrainingType,
				TrainingContent,
				TrainingDepartment,
				TestDate,
				TestResult,
				TestPeople,	
				Remark
				from {0} 
				where PeopleID=@PeopleID"
				, _TrainingTestRecordTableName);

			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("PeopleID", peopleID);

			var table = new OLESqlHelper().GetTable(sqlText, paras);

			var TrainingTestRecordList = new List<TrainingTestRecord>();
			foreach (DataRow row in table.Rows) {
				var TrainingTestRecord = new TrainingTestRecord() {
					RecordID = (int)row["RecordID"],
					TrainingDate = (DateTime?)row["TrainingDate"],
					TrainingType = row["TrainingType"].ToString(),
					TrainingContent = row["TrainingContent"].ToString(),
					TrainingDepartment = row["TrainingDepartment"].ToString(),
					TestDate = (DateTime?)row["TestDate"],
					TestResult = row["TestResult"].ToString(),
					TestPeople = row["TestPeople"].ToString(),
					Remark = row["Remark"].ToString()
				};
				TrainingTestRecordList.Add(TrainingTestRecord);
			}
			return TrainingTestRecordList;
		}

		public bool DeleteTrainingTestRecordByID(int RecordID)
		{
			string sqlText = string.Format("delete from {0} where RecordID=@RecordID", _TrainingTestRecordTableName);
			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("RecordID", RecordID);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public TrainingTestRecord GetTrainingTestRecordByID(int RecordID)
		{
			using (var connection = new OleDbConnection(ConfigManagement.AccessConStr)) {
				string sqlText = string.Format(@"select 
					RecordID,
					PeopleID,				
					TrainingDate,
					TrainingType,
					TrainingContent,
					TrainingDepartment,
					TestDate,
					TestResult,
					TestPeople,	
					Remark
					from {0} where RecordID=@RecordID", _TrainingTestRecordTableName);
				var paras = new OleDbParameter[1];
				paras[0] = new OleDbParameter("RecordID", RecordID);

				var reader = new OLESqlHelper().GetReader(sqlText, connection, paras);
				if (reader.Read()) {
					int i = 0;
					var TrainingTestRecord = new TrainingTestRecord();
					TrainingTestRecord.RecordID = reader.GetInt32(i++);
					TrainingTestRecord.PeopleID = reader.GetInt32(i++);
					TrainingTestRecord.TrainingDate = reader.IsDBNull(i) ? new Nullable<DateTime>() : reader.GetDateTime(i++);
					TrainingTestRecord.TrainingType = reader.GetString(i++);
					TrainingTestRecord.TrainingContent = reader.GetString(i++);
					TrainingTestRecord.TrainingDepartment = reader.GetString(i++);
					TrainingTestRecord.TestDate = reader.IsDBNull(i) ? new Nullable<DateTime>() : reader.GetDateTime(i++);
					TrainingTestRecord.TestResult = reader.GetString(i++);
					TrainingTestRecord.TestPeople = reader.GetString(i++);
					TrainingTestRecord.Remark = reader.GetString(i++);

					return TrainingTestRecord;
				} else {
					return null;
				}
			}
		}

		public bool InsertTrainingTestRecord(TrainingTestRecord TrainingTestRecord)
		{
			string sqlText = string.Format(@"insert into {0}(
					PeopleID,				
					TrainingDate,
					TrainingType,
					TrainingContent,
					TrainingDepartment,
					TestDate,
					TestResult,
					TestPeople,	
					Remark) 
				values(
					@PeopleID,				
					@TrainingDate,
					@TrainingType,
					@TrainingContent,
					@TrainingDepartment,
					@TestDate,
					@TestResult,
					@TestPeople,	
					@Remark)", _TrainingTestRecordTableName);
			var paras = new OleDbParameter[9];
			paras[0] = new OleDbParameter("PeopleID", TrainingTestRecord.PeopleID);
			paras[1] = new OleDbParameter("TrainingDate", TrainingTestRecord.TrainingDate);
			paras[1].OleDbType = OleDbType.DBDate;
			paras[2] = new OleDbParameter("TrainingType", TrainingTestRecord.TrainingType);
			paras[3] = new OleDbParameter("TrainingContent", TrainingTestRecord.TrainingContent);
			paras[4] = new OleDbParameter("TrainingDepartment", TrainingTestRecord.TrainingDepartment);
			paras[5] = new OleDbParameter("TestDate", TrainingTestRecord.TestDate);
			paras[5].OleDbType = OleDbType.DBDate;
			paras[6] = new OleDbParameter("TestResult", TrainingTestRecord.TestResult);
			paras[7] = new OleDbParameter("TestPeople", TrainingTestRecord.TestPeople);
			paras[8] = new OleDbParameter("Remark", TrainingTestRecord.Remark);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public bool UpdateTrainingTestRecord(TrainingTestRecord TrainingTestRecord)
		{
			string sqlText = string.Format(@"update {0} set 
					TrainingDate=@TrainingDate,
					TrainingType=@TrainingType,
					TrainingContent=@TrainingContent,
					TrainingDepartment=@TrainingDepartment,
					TestDate=@TestDate,
					TestResult=@TestResult,
					TestPeople=@TestPeople,	
					Remark=@Remark
				where RecordID=@RecordID", _TrainingTestRecordTableName);
			var paras = new OleDbParameter[9];
			paras[0] = new OleDbParameter("TrainingDate", TrainingTestRecord.TrainingDate);
			paras[0].OleDbType = OleDbType.DBDate;
			paras[1] = new OleDbParameter("TrainingType", TrainingTestRecord.TrainingType);
			paras[2] = new OleDbParameter("TrainingContent", TrainingTestRecord.TrainingContent);
			paras[3] = new OleDbParameter("TrainingDepartment", TrainingTestRecord.TrainingDepartment);
			paras[4] = new OleDbParameter("TestDate", TrainingTestRecord.TestDate);
			paras[4].OleDbType = OleDbType.DBDate;
			paras[5] = new OleDbParameter("TestResult", TrainingTestRecord.TestResult);
			paras[6] = new OleDbParameter("TestPeople", TrainingTestRecord.TestPeople);
			paras[7] = new OleDbParameter("Remark", TrainingTestRecord.Remark);
			paras[8] = new OleDbParameter("RecordID", TrainingTestRecord.RecordID);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}
	}
}

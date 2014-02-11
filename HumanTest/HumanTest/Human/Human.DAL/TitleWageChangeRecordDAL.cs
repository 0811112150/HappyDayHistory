using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.DomainModel;
using System.Data.OleDb;
using System.Data;

namespace Human.DAL
{
	public class TitleWageChangeRecordDAL
	{
		private string _TitleWageChangeRecordTableName = "TitleWageChangeRecord";

		public List<TitleWageChangeRecord> GetTitleWageChangeRecordList(int peopleID)
		{
			string sqlText = string.Format(@"select 
				TitleWageChangeRecordID,
				ChangeDate,
				ChangeType,
				ContractNum,
				BeforeChangeTitle,
				BeforeChangeBasicWage,
				BeforeChangeAllowance,
				BeforeChangeYearAward,	
				AfterChangeTitle,
				AfterChangeBasicWage,
				AfterChangeAllowance,
				AfterChangeYearAward
				from {0} 
				where PeopleID=@PeopleID"
				, _TitleWageChangeRecordTableName);

			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("PeopleID", peopleID);

			var table = new OLESqlHelper().GetTable(sqlText, paras);

			var TitleWageChangeRecordList = new List<TitleWageChangeRecord>();
			foreach (DataRow row in table.Rows) {
				var TitleWageChangeRecord = new TitleWageChangeRecord() {
					TitleWageChangeRecordID = (int)row["TitleWageChangeRecordID"],
					ChangeDate = (DateTime?)row["ChangeDate"],
					ChangeType = (int)row["ChangeType"],
					ContractNum = row["ContractNum"].ToString(),
					BeforeChangeTitle = row["BeforeChangeTitle"].ToString(),
					BeforeChangeBasicWage = (float)row["BeforeChangeBasicWage"],
					BeforeChangeAllowance = (float)row["BeforeChangeAllowance"],
					BeforeChangeYearAward = (float)row["BeforeChangeYearAward"],
					AfterChangeTitle = row["AfterChangeTitle"].ToString(),
					AfterChangeBasicWage = (float)row["AfterChangeBasicWage"],
					AfterChangeAllowance = (float)row["AfterChangeAllowance"],
					AfterChangeYearAward = (float)row["AfterChangeYearAward"]
				};
				TitleWageChangeRecordList.Add(TitleWageChangeRecord);
			}
			return TitleWageChangeRecordList;
		}

		public bool DeleteTitleWageChangeRecordByID(int TitleWageChangeRecordID)
		{
			string sqlText = string.Format("delete from {0} where TitleWageChangeRecordID=@TitleWageChangeRecordID", _TitleWageChangeRecordTableName);
			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("TitleWageChangeRecordID", TitleWageChangeRecordID);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public TitleWageChangeRecord GetTitleWageChangeRecordByID(int TitleWageChangeRecordID)
		{
			using (var connection = new OleDbConnection(ConfigManagement.AccessConStr)) {
				string sqlText = string.Format(@"select 
					TitleWageChangeRecordID,
					PeopleID,				
					ChangeDate,
					ChangeType,
					ContractNum,
					BeforeChangeTitle,
					BeforeChangeBasicWage,
					BeforeChangeAllowance,
					BeforeChangeYearAward,	
					AfterChangeTitle,
					AfterChangeBasicWage,
					AfterChangeAllowance,
					AfterChangeYearAward
					from {0} where TitleWageChangeRecordID=@TitleWageChangeRecordID", _TitleWageChangeRecordTableName);
				var paras = new OleDbParameter[1];
				paras[0] = new OleDbParameter("TitleWageChangeRecordID", TitleWageChangeRecordID);

				var reader = new OLESqlHelper().GetReader(sqlText, connection, paras);
				if (reader.Read()) {
					int i = 0;
					var TitleWageChangeRecord = new TitleWageChangeRecord();
					TitleWageChangeRecord.TitleWageChangeRecordID = reader.GetInt32(i++);
					TitleWageChangeRecord.PeopleID = reader.GetInt32(i++);
					TitleWageChangeRecord.ChangeDate = reader.IsDBNull(i) ? new Nullable<DateTime>() : reader.GetDateTime(i++);
					TitleWageChangeRecord.ChangeType = reader.GetInt32(i++);
					TitleWageChangeRecord.ContractNum = reader.GetString(i++);
					TitleWageChangeRecord.BeforeChangeTitle = reader.GetString(i++);
					TitleWageChangeRecord.BeforeChangeBasicWage = reader.GetFloat(i++);
					TitleWageChangeRecord.BeforeChangeAllowance = reader.GetFloat(i++);
					TitleWageChangeRecord.BeforeChangeYearAward = reader.GetFloat(i++);
					TitleWageChangeRecord.AfterChangeTitle = reader.GetString(i++);
					TitleWageChangeRecord.AfterChangeBasicWage = reader.GetFloat(i++);
					TitleWageChangeRecord.AfterChangeAllowance = reader.GetFloat(i++);
					TitleWageChangeRecord.AfterChangeYearAward = reader.GetFloat(i++);
					return TitleWageChangeRecord;
				} else {
					return null;
				}
			}
		}

		public bool InsertTitleWageChangeRecord(TitleWageChangeRecord TitleWageChangeRecord)
		{
			string sqlText = string.Format(@"insert into {0}(
					PeopleID,				
					ChangeDate,
					ChangeType,
					ContractNum,
					BeforeChangeTitle,
					BeforeChangeBasicWage,
					BeforeChangeAllowance,
					BeforeChangeYearAward,	
					AfterChangeTitle,
					AfterChangeBasicWage,
					AfterChangeAllowance,
					AfterChangeYearAward
				) 
				values(
					@PeopleID,				
					@ChangeDate,
					@ChangeType,
					@ContractNum,
					@BeforeChangeTitle,
					@BeforeChangeBasicWage,
					@BeforeChangeAllowance,
					@BeforeChangeYearAward,	
					@AfterChangeTitle,
					@AfterChangeBasicWage,
					@AfterChangeAllowance,
					@AfterChangeYearAward)", _TitleWageChangeRecordTableName);
			var paras = new OleDbParameter[12];
			paras[0] = new OleDbParameter("PeopleID", TitleWageChangeRecord.PeopleID);
			paras[1] = new OleDbParameter("ChangeDate", TitleWageChangeRecord.ChangeDate);
			paras[1].OleDbType = OleDbType.Date;
			paras[2] = new OleDbParameter("ChangeType", TitleWageChangeRecord.ChangeType);
			paras[3] = new OleDbParameter("ContractNum", TitleWageChangeRecord.ContractNum);
			paras[4] = new OleDbParameter("BeforeChangeTitle", TitleWageChangeRecord.BeforeChangeTitle);
			paras[5] = new OleDbParameter("BeforeChangeBasicWage", TitleWageChangeRecord.BeforeChangeBasicWage);
			paras[6] = new OleDbParameter("BeforeChangeAllowance", TitleWageChangeRecord.BeforeChangeAllowance);
			paras[7] = new OleDbParameter("BeforeChangeYearAward", TitleWageChangeRecord.BeforeChangeYearAward);
			paras[8] = new OleDbParameter("AfterChangeTitle", TitleWageChangeRecord.AfterChangeTitle);
			paras[9] = new OleDbParameter("AfterChangeBasicWage", TitleWageChangeRecord.AfterChangeBasicWage);
			paras[10] = new OleDbParameter("AfterChangeAllowance", TitleWageChangeRecord.AfterChangeAllowance);
			paras[11] = new OleDbParameter("AfterChangeYearAward", TitleWageChangeRecord.AfterChangeYearAward);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public bool UpdateTitleWageChangeRecord(TitleWageChangeRecord TitleWageChangeRecord)
		{
			string sqlText = string.Format(@"update {0} set 
				ChangeDate=@ChangeDate,
				ChangeType=@ChangeType,
				ContractNum=@ContractNum,
				BeforeChangeTitle=@BeforeChangeTitle,
				BeforeChangeBasicWage=@BeforeChangeBasicWage,
				BeforeChangeallowance=@BeforeChangeAllowance,
				BeforeChangeYearAward=@BeforeChangeYearAward,	
				AfterChangeTitle=@AfterChangeTitle,
				AfterChangeBasicWage=@AfterChangeBasicWage,
				AfterChangeAllowance=@AfterChangeAllowance,
				AfterChangeYearAward=@AfterChangeYearAward  
				where TitleWageChangeRecordID=@TitleWageChangeRecordID", _TitleWageChangeRecordTableName);
			var paras = new OleDbParameter[12];
			paras[0] = new OleDbParameter("ChangeDate", TitleWageChangeRecord.ChangeDate);
			paras[0].OleDbType = OleDbType.DBDate;
			paras[1] = new OleDbParameter("ChangeType", TitleWageChangeRecord.ChangeType);
			paras[2] = new OleDbParameter("ContractNum", TitleWageChangeRecord.ContractNum);
			paras[3] = new OleDbParameter("BeforeChangeTitle", TitleWageChangeRecord.BeforeChangeTitle);
			paras[4] = new OleDbParameter("BeforeChangeBasicWage", TitleWageChangeRecord.BeforeChangeBasicWage);
			paras[5] = new OleDbParameter("BeforeChangeAllowance", TitleWageChangeRecord.BeforeChangeAllowance);
			paras[6] = new OleDbParameter("BeforeChangeYearAward", TitleWageChangeRecord.BeforeChangeYearAward);
			paras[7] = new OleDbParameter("AfterChangeTitle", TitleWageChangeRecord.AfterChangeTitle);
			paras[8] = new OleDbParameter("AfterChangeBasicWage", TitleWageChangeRecord.AfterChangeBasicWage);
			paras[9] = new OleDbParameter("AfterChangeAllowance", TitleWageChangeRecord.AfterChangeAllowance);
			paras[10] = new OleDbParameter("AfterChangeYearAward", TitleWageChangeRecord.AfterChangeYearAward);
			paras[11] = new OleDbParameter("TitleWageChangeRecordID", TitleWageChangeRecord.TitleWageChangeRecordID);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.DomainModel;
using System.Data.OleDb;
using System.Data;

namespace Human.DAL
{
	public class RewardRecordDAL
	{
		private string _RewardRecordTableName = "rewardRecord";

		public List<RewardRecord> GetRewardRecordList(int peopleID)
		{
			string sqlText = string.Format(@"select 
				RecordID,
				RewardDate,
				RewardContent
				from {0} 
				where PeopleID=@PeopleID"
				, _RewardRecordTableName);

			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("PeopleID", peopleID);

			var table = new OLESqlHelper().GetTable(sqlText, paras);

			var rewardRecordList = new List<RewardRecord>();
			foreach (DataRow row in table.Rows) {
				var rewardRecord = new RewardRecord() {
					RecordID = (int)row["RecordID"],
					RewardDate = (DateTime?)row["RewardDate"],
					RewardContent = row["RewardContent"].ToString(),
				};
				rewardRecordList.Add(rewardRecord);
			}
			return rewardRecordList;
		}

		public bool DeleteRewardRecordByID(int recordID)
		{
			string sqlText = string.Format("delete from {0} where RecordID=@RecordID", _RewardRecordTableName);
			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("RecordID", recordID);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public RewardRecord GetRewardRecordByID(int recordID)
		{
			using (var connection = new OleDbConnection(ConfigManagement.AccessConStr)) {
				string sqlText = string.Format(@"select 
					RecordID,
					PeopleID,
					RewardDate,
					RewardContent
					from {0} where RecordID=@RecordID", _RewardRecordTableName);
				var paras = new OleDbParameter[1];
				paras[0] = new OleDbParameter("RecordID", recordID);

				var reader = new OLESqlHelper().GetReader(sqlText, connection, paras);
				if (reader.Read()) {
					int i = 0;
					var RewardRecord = new RewardRecord();
					RewardRecord.RecordID = reader.GetInt32(i++);
					RewardRecord.PeopleID = reader.GetInt32(i++);
					RewardRecord.RewardDate = reader.IsDBNull(i) ? new Nullable<DateTime>() : reader.GetDateTime(i++);
					RewardRecord.RewardContent = reader.GetString(i++);
					return RewardRecord;
				} else {
					return null;
				}
			}
		}

		public bool InsertRewardRecord(RewardRecord rewardRecord)
		{
			string sqlText = string.Format(@"insert into {0}(
				PeopleID,
				RewardDate,
				RewardContent
				) 
				values(
				@PeopleID,
				@RewardDate,
				@RewardContent
				)", _RewardRecordTableName);
			var paras = new OleDbParameter[3];
			paras[0] = new OleDbParameter("PeopleID", rewardRecord.PeopleID);
			paras[1] = new OleDbParameter("RewardDate", rewardRecord.RewardDate);
			paras[1].OleDbType = OleDbType.DBDate;
			paras[2] = new OleDbParameter("RewardContent", rewardRecord.RewardContent);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public bool UpdateRewardRecord(RewardRecord RewardRecord)
		{
			string sqlText = string.Format(@"update {0} set 
				RewardDate=@RewardDate,
				RewardContent=@RewardContent
				where RecordID=@RecordID", _RewardRecordTableName);
			var paras = new OleDbParameter[3];
			paras[0] = new OleDbParameter("RewardDate", RewardRecord.RewardDate);
			paras[0].OleDbType = OleDbType.DBDate;
			paras[1] = new OleDbParameter("RewardContent", RewardRecord.RewardContent);
			paras[2] = new OleDbParameter("RecordID", RewardRecord.RecordID);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.DomainModel;
using System.Data.OleDb;
using System.Data;

namespace Human.DAL
{
	public class ContractDAL
	{
		private string _ContractTableName = "Contract";

		public List<Contract> GetContractList(int peopleID)
		{
			string sqlText = string.Format(@"select 
				ContractID,
				ContractrType,
				IsFirstContract,
				ContractNum,
				StartDate,
				EndDate,
				ProbationEndDate
				from {0} 
				where PeopleID=@PeopleID"
				, _ContractTableName);

			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("PeopleID", peopleID);

			var table = new OLESqlHelper().GetTable(sqlText, paras);

			var contractList = new List<Contract>();
			foreach (DataRow row in table.Rows) {
				var peopleFamily = new Contract() {
					ContractID = (int)row["ContractID"],
					ContractrType = (int)row["ContractrType"],
					IsFirstContract = (bool)row["IsFirstContract"],
					ContractNum = row["ContractNum"].ToString(),
					StartDate = (DateTime?)row["StartDate"],
					EndDate = (DateTime?)row["EndDate"],
					ProbationEndDate = row.IsNull("ProbationEndDate") ? new Nullable<DateTime>() : (DateTime?)row["ProbationEndDate"]
				};
				contractList.Add(peopleFamily);
			}
			return contractList;
		}

		public bool DeleteContractByID(int contractID)
		{
			string sqlText = string.Format("delete from {0} where contractID=@contractID", _ContractTableName);
			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("contractID", contractID);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public Contract GetContractByID(int contractID)
		{
			using (var connection = new OleDbConnection(ConfigManagement.AccessConStr)) {
				string sqlText = string.Format(@"select 
					ContractID,
					PeopleID,
					ContractrType,
					IsFirstContract,
					ContractNum,
					StartDate,
					EndDate,
					ProbationEndDate
					from {0} where ContractID=@ContractID", _ContractTableName);
				var paras = new OleDbParameter[1];
				paras[0] = new OleDbParameter("ContractID", contractID);

				var reader = new OLESqlHelper().GetReader(sqlText, connection, paras);
				if (reader.Read()) {
					int i = 0;
					var contract = new Contract();
					contract.ContractID = reader.GetInt32(i++);
					contract.PeopleID = reader.GetInt32(i++);
					contract.ContractrType = (int)reader.GetInt32(i++);
					contract.IsFirstContract = (bool)reader.GetBoolean(i++);
					contract.ContractNum = reader.GetString(i++);
					contract.StartDate = reader.IsDBNull(i) ? new Nullable<DateTime>() : reader.GetDateTime(i++);
					contract.EndDate = reader.IsDBNull(i) ? new Nullable<DateTime>() : reader.GetDateTime(i++);
					contract.ProbationEndDate = reader.IsDBNull(i) ? new Nullable<DateTime>() : reader.GetDateTime(i++);

					return contract;
				} else {
					return null;
				}
			}
		}

		public bool InsertContract(Contract contract)
		{
			string sqlText = string.Format(@"insert into {0}(
				PeopleID,
				ContractrType,
				IsFirstContract,
				ContractNum,
				StartDate,
				EndDate,
				ProbationEndDate
				) 
				values(
				@PeopleID,
				@ContractrType,
				@IsFirstContract,
				@ContractNum,
				@StartDate,
				@EndDate,
				@ProbationEndDate)", _ContractTableName);
			var paras = new OleDbParameter[7];
			paras[0] = new OleDbParameter("PeopleID", contract.PeopleID);
			paras[1] = new OleDbParameter("ContractrType", contract.ContractrType);
			paras[2] = new OleDbParameter("IsFirstContract", contract.IsFirstContract);
			paras[3] = new OleDbParameter("ContractNum", contract.ContractNum);
			paras[4] = new OleDbParameter("StartDate", contract.StartDate);
			paras[4].OleDbType = OleDbType.DBDate;
			paras[5] = new OleDbParameter("EndDate", contract.EndDate);
			paras[5].OleDbType = OleDbType.DBDate;
			paras[6] = new OleDbParameter("ProbationEndDate", contract.ProbationEndDate);
			paras[6].OleDbType = OleDbType.DBDate;
			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public bool UpdateContract(Contract contract)
		{
			string sqlText = string.Format(@"update {0} set 
					ContractrType=@ContractrType,
					IsFirstContract=@IsFirstContract,
					ContractNum=@ContractNum,
					StartDate=@StartDate,
					EndDate=@EndDate,
					ProbationEndDate=@ProbationEndDate
				where ContractID=@ContractID", _ContractTableName);
			var paras = new OleDbParameter[7];
			paras[0] = new OleDbParameter("ContractrType", contract.ContractrType);
			paras[1] = new OleDbParameter("IsFirstContract", contract.IsFirstContract);
			paras[2] = new OleDbParameter("ContractNum", contract.ContractNum);
			paras[3] = new OleDbParameter("StartDate", contract.StartDate);
			paras[4] = new OleDbParameter("EndDate", contract.EndDate);
			paras[5] = new OleDbParameter("ProbationEndDate", contract.ProbationEndDate);
			paras[6] = new OleDbParameter("ContractID", contract.ContractID);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public List<int> GetNeedReminderPeopleIDList()
		{
			var currentDate = DateTime.Now;
			var endDate = currentDate.AddMonths(2);
			var sqlText = @"select PeopleID from Contract where
						EndDate<@endDate and EndDate>@currentDate";
			var paras = new OleDbParameter[2];
			paras[0] = new OleDbParameter("endDate", endDate);
			paras[0].OleDbType = OleDbType.DBDate
			;
			paras[1] = new OleDbParameter("currentDate", currentDate);
			paras[1].OleDbType = OleDbType.DBDate;

			var table = new OLESqlHelper().GetTable(sqlText, paras);

			var needReminderIDList = new List<int>();
			foreach (DataRow row in table.Rows) {
				needReminderIDList.Add((int)row["PeopleID"]);
			}
			return needReminderIDList;
		}
	}
}

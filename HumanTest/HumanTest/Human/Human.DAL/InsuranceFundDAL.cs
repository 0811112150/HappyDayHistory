using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.DomainModel;
using System.Data.OleDb;
using System.Data;

namespace Human.DAL
{
	public class InsuranceFundDAL
	{
		private string _InsuranceFundTableName = "InsuranceFund";

		public List<InsuranceFund> GetInsuranceFundList(int peopleID)
		{
			string sqlText = string.Format(@"select 
				InsuranceFundID,
				InsuranceFundType,
				Number,
				PaymentAddress,
				PaymentStartDate,
				PaymentEndDate,
				BasicNum
				from {0} 
				where PeopleID=@PeopleID"
				, _InsuranceFundTableName);

			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("PeopleID", peopleID);

			var table = new OLESqlHelper().GetTable(sqlText, paras);

			var InsuranceFundList = new List<InsuranceFund>();
			foreach (DataRow row in table.Rows) {
				var peopleFamily = new InsuranceFund() {
					InsuranceFundID = (int)row["InsuranceFundID"],
					InsuranceFundType = (int)row["InsuranceFundType"],
					Number = row["Number"].ToString(),
					PaymentAddress = row["PaymentAddress"].ToString(),
					PaymentStartDate = (DateTime?)row["PaymentStartDate"],
					PaymentEndDate = row.IsNull("PaymentEndDate") ? null : (DateTime?)row["PaymentEndDate"],
					BasicNum = (float)row["BasicNum"]
				};
				InsuranceFundList.Add(peopleFamily);
			}
			return InsuranceFundList;
		}

		public bool DeleteInsuranceFundByID(int InsuranceFundID)
		{
			string sqlText = string.Format("delete from {0} where InsuranceFundID=@InsuranceFundID", _InsuranceFundTableName);
			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("InsuranceFundID", InsuranceFundID);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public InsuranceFund GetInsuranceFundByID(int InsuranceFundID)
		{
			using (var connection = new OleDbConnection(ConfigManagement.AccessConStr)) {
				string sqlText = string.Format(@"select 
					InsuranceFundID,
					PeopleID,
					InsuranceFundType,
					Number,
					PaymentAddress,
					PaymentStartDate,
					PaymentEndDate,
					BasicNum
					from {0} where InsuranceFundID=@InsuranceFundID", _InsuranceFundTableName);
				var paras = new OleDbParameter[1];
				paras[0] = new OleDbParameter("InsuranceFundID", InsuranceFundID);

				var reader = new OLESqlHelper().GetReader(sqlText, connection, paras);
				if (reader.Read()) {
					int i = 0;
					var InsuranceFund = new InsuranceFund();
					InsuranceFund.InsuranceFundID = reader.GetInt32(i++);
					InsuranceFund.PeopleID = reader.GetInt32(i++);
					InsuranceFund.InsuranceFundType = (int)reader.GetInt32(i++);
					InsuranceFund.Number = reader.GetString(i++);
					InsuranceFund.PaymentAddress = reader.GetString(i++);
					InsuranceFund.PaymentStartDate = reader.IsDBNull(i) ? new Nullable<DateTime>() : reader.GetDateTime(i++);
					InsuranceFund.PaymentEndDate = reader.IsDBNull(i) ? new Nullable<DateTime>() : reader.GetDateTime(i++);
					InsuranceFund.BasicNum = reader.GetFloat(i++);

					return InsuranceFund;
				} else {
					return null;
				}
			}
		}

		public bool InsertInsuranceFund(InsuranceFund InsuranceFund)
		{
			string sqlText = string.Format(@"insert into {0}(
				PeopleID,
				InsuranceFundType,
				[Number],
				PaymentAddress,
				PaymentStartDate,
				PaymentEndDate,
				BasicNum
				) 
				values(
				@PeopleID,
				@InsuranceFundType,
				@Number,
				@PaymentAddress,
				@PaymentStartDate,
				@PaymentEndDate,
				@BasicNum)", _InsuranceFundTableName);
			var paras = new OleDbParameter[7];
			paras[0] = new OleDbParameter("PeopleID", InsuranceFund.PeopleID);
			paras[1] = new OleDbParameter("InsuranceFundType", InsuranceFund.InsuranceFundType);
			paras[2] = new OleDbParameter("Number", InsuranceFund.Number);
			paras[3] = new OleDbParameter("PaymentAddress", InsuranceFund.PaymentAddress);
			paras[4] = new OleDbParameter("PaymentStartDate", InsuranceFund.PaymentStartDate);
			paras[4].OleDbType = OleDbType.DBDate;
			paras[5] = new OleDbParameter("PaymentEndDate", InsuranceFund.PaymentEndDate);
			paras[5].OleDbType = OleDbType.DBDate;
			paras[6] = new OleDbParameter("BasicNum", InsuranceFund.BasicNum);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public bool UpdateInsuranceFund(InsuranceFund InsuranceFund)
		{
			string sqlText = string.Format(@"update {0} set 
					InsuranceFundType=@InsuranceFundType,
					[Number]=@Number,
					PaymentAddress=@PaymentAddress,
					PaymentStartDate=@PaymentStartDate,
					PaymentEndDate=@PaymentEndDate,
					BasicNum=@BasicNum
				where InsuranceFundID=@InsuranceFundID", _InsuranceFundTableName);
			var paras = new OleDbParameter[7];
			paras[0] = new OleDbParameter("InsuranceFundType", InsuranceFund.InsuranceFundType);
			paras[1] = new OleDbParameter("Number", InsuranceFund.Number);
			paras[2] = new OleDbParameter("PaymentAddress", InsuranceFund.PaymentAddress);
			paras[3] = new OleDbParameter("PaymentStartDate", InsuranceFund.PaymentStartDate);
			paras[4] = new OleDbParameter("PaymentEndDate", InsuranceFund.PaymentEndDate);
			paras[5] = new OleDbParameter("BasicNum", InsuranceFund.BasicNum);
			paras[6] = new OleDbParameter("InsuranceFundID", InsuranceFund.InsuranceFundID);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}
	}
}

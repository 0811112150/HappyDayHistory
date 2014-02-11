using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.DomainModel;
using System.Data.OleDb;
using System.Data;

namespace Human.DAL
{
	public class PeoplePicDAL
	{
		private string _PeoplePicTableName = "PeoplePic";

		public List<PeoplePic> GetPeoplePicList(int peopleID)
		{
			string sqlText = string.Format(@"select 
				PicID,
				PicTitle,
				PicPath
				from {0} 
				where PeopleID=@PeopleID"
				, _PeoplePicTableName);

			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("PeopleID", peopleID);

			var table = new OLESqlHelper().GetTable(sqlText, paras);

			var PeoplePicList = new List<PeoplePic>();
			foreach (DataRow row in table.Rows) {
				var PeoplePic = new PeoplePic() {
					PicID = (int)row["PicID"],
					PicTitle = row["PicTitle"].ToString(),
					PicPath = row["PicPath"].ToString(),
				};
				PeoplePicList.Add(PeoplePic);
			}
			return PeoplePicList;
		}

		public bool DeletePeoplePicByID(int PicID)
		{
			string sqlText = string.Format("delete from {0} where PicID=@PicID", _PeoplePicTableName);
			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("PicID", PicID);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public PeoplePic GetPeoplePicByID(int PicID)
		{
			using (var connection = new OleDbConnection(ConfigManagement.AccessConStr)) {
				string sqlText = string.Format(@"select 
					PicID,
					PeopleID,
					PicTitle,
					PicPath
					from {0} where PicID=@PicID", _PeoplePicTableName);
				var paras = new OleDbParameter[1];
				paras[0] = new OleDbParameter("PicID", PicID);

				var reader = new OLESqlHelper().GetReader(sqlText, connection, paras);
				if (reader.Read()) {
					int i = 0;
					var PeoplePic = new PeoplePic();
					PeoplePic.PicID = reader.GetInt32(i++);
					PeoplePic.PeopleID = reader.GetInt32(i++);
					PeoplePic.PicTitle = reader.GetString(i++);
					PeoplePic.PicPath = reader.GetString(i++);
					return PeoplePic;
				} else {
					return null;
				}
			}
		}

		public bool InsertPeoplePic(PeoplePic PeoplePic)
		{
			string sqlText = string.Format(@"insert into {0}(
				PeopleID,
				PicTitle,
				PicPath
				) 
				values(
				@PeopleID,
				@PicTitle,
				@PicPath
				)", _PeoplePicTableName);
			var paras = new OleDbParameter[3];
			paras[0] = new OleDbParameter("PeopleID", PeoplePic.PeopleID);
			paras[1] = new OleDbParameter("PicTitle", PeoplePic.PicTitle);
			paras[2] = new OleDbParameter("PicPath", PeoplePic.PicPath);

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}

		public bool UpdatePeoplePic(PeoplePic PeoplePic)
		{
			string sqlText = string.Format(@"update {0} set 
				PicTitle=@PicTitle,
				PicPath=@PicPath
				where PicID=@PicID", _PeoplePicTableName);
			var paras = new OleDbParameter[3];
			paras[0] = new OleDbParameter("PicTitle", PeoplePic.PicTitle);
			paras[1] = new OleDbParameter("PicPath", PeoplePic.PicPath);
			paras[2] = new OleDbParameter("PicID", PeoplePic.PicID);			

			var result = new OLESqlHelper().ExecuteNoneQuery(sqlText, paras);
			return result;
		}
	}
}

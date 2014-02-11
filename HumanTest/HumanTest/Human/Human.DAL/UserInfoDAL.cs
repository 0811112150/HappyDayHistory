using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Human.DomainModel;

namespace Human.DAL
{
	public class UserInfoDAL
	{
		private string _userInfoTableName = "UserInfo";

		public bool IsUserCorrect(string userName, string password)
		{
			string sqlText = "select count(*) from UserInfo where userName=@userName and password=@password";
			OleDbParameter[] paras = new OleDbParameter[2];
			paras[0] = new OleDbParameter("userName", userName);
			paras[1] = new OleDbParameter("password", password);

			var result = new OLESqlHelper().IsExists(sqlText, paras);
			return result;
		}

		public UserInfo GetUserInfoByID(int userID)
		{
			var sqlText = "select * from UserInfo where UserID=@userName";
			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("userID", userID);

			using (var connection = new OleDbConnection(ConfigManagement.AccessConStr)) {
				using (var reader = new OLESqlHelper().GetReader(sqlText, connection, paras)) {
					reader.Read();
					var userInfo = new UserInfo();
					userInfo.UserID = reader.GetInt32(0);
					userInfo.UserName = reader.GetString(1);
					userInfo.Password = reader.GetString(2);
					return userInfo;
				}
			}
		}

		public UserInfo GetUserInfoByName(string userName)
		{
			var sqlText = "select * from UserInfo where UserName=@userName";
			var paras = new OleDbParameter[1];
			paras[0] = new OleDbParameter("userName", userName);

			using (var connection = new OleDbConnection(ConfigManagement.AccessConStr)) {
				using (var reader = new OLESqlHelper().GetReader(sqlText, connection, paras)) {
					reader.Read();
					var userInfo = new UserInfo();
					userInfo.UserID = reader.GetInt32(0);
					userInfo.UserName = reader.GetString(1);
					userInfo.Password = reader.GetString(2);
					return userInfo;
				}
			}
		}

		public bool UpdateUserInfo(UserInfo userInfo)
		{
			//var sqlText = string.Format("update {0} set UserName='@userName',Password='@password' where UserID=@userID", _userInfoTableName);
			//var paras = new OleDbParameter[3];
			//paras[0] = new OleDbParameter("userName", userInfo.UserName);
			//paras[1] = new OleDbParameter("password", userInfo.Password);
			//paras[2] = new OleDbParameter("userID", userInfo.UserID);

			var sqlText = string.Format("update {0} set [UserName]='{1}',[Password]='{2}' where [UserID]={3}", _userInfoTableName, userInfo.UserName, userInfo.Password, userInfo.UserID);
			return new OLESqlHelper().ExecuteNoneQuery(sqlText);
		}
	}
}

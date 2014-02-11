using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.Common;
using Human.DAL;
using System.Data.OleDb;
using Human.ViewModel;
using Human.DomainModel;

namespace Human.BLL
{
	public class UserBLL
	{
		public CResult<bool> IsUserCorrect(string userName, string password)
		{
			var result = new UserInfoDAL().IsUserCorrect(userName, password);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.UserInfoError);
			}
		}

		public CResult<WebUserInfo> GetUserInfoByID(int userID)
		{
			if (userID <= 0) {
				return new CResult<WebUserInfo>(null, ErrorCode.ParameterError);
			}

			var userInfo = new UserInfoDAL().GetUserInfoByID(userID);
			if (userInfo == null) {
				return new CResult<WebUserInfo>(null, ErrorCode.UserNotExist);
			}

			var webUserInfo = new WebUserInfo() {
				UserName = userInfo.UserName,
				UserID = userInfo.UserID,
				OldPassword = userInfo.Password,
			};

			return new CResult<WebUserInfo>(webUserInfo);
		}

		public CResult<WebUserInfo> GetUserInfoByName(string userName)
		{
			if (string.IsNullOrEmpty(userName)) {
				return new CResult<WebUserInfo>(null, ErrorCode.ParameterError);
			}

			var userInfo = new UserInfoDAL().GetUserInfoByName(userName);
			if (userInfo == null) {
				return new CResult<WebUserInfo>(null, ErrorCode.UserNotExist);
			}

			var webUserInfo = new WebUserInfo() {
				UserName = userInfo.UserName,
				UserID = userInfo.UserID
			};

			return new CResult<WebUserInfo>(webUserInfo);
		}

		public CResult<bool> UpdateUserInfo(WebUserInfo webUserInfo)
		{
			if (webUserInfo == null) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			if (string.IsNullOrEmpty(webUserInfo.UserName) || string.IsNullOrEmpty(webUserInfo.OldPassword)
			|| string.IsNullOrEmpty(webUserInfo.NewPassword) || string.IsNullOrEmpty(webUserInfo.ConfirmPassword)) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			if (webUserInfo.NewPassword != webUserInfo.ConfirmPassword) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}

			var oldUserInfo = GetUserInfoByID(webUserInfo.UserID).Data;
			if (oldUserInfo == null) {
				return new CResult<bool>(false, ErrorCode.UserNotExist);
			}
			if (oldUserInfo.OldPassword != webUserInfo.OldPassword) {
				return new CResult<bool>(false, ErrorCode.UserPasswordError);
			}

			if (oldUserInfo.UserName == webUserInfo.UserName && oldUserInfo.OldPassword == webUserInfo.NewPassword) {
				return new CResult<bool>(true);
			}

			var userInfo = new UserInfo() {
				UserID = webUserInfo.UserID,
				Password = webUserInfo.NewPassword,
				UserName = webUserInfo.UserName,
			};

			if (new UserInfoDAL().UpdateUserInfo(userInfo)) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.SaveDataFailed);
			}
		}
	}
}

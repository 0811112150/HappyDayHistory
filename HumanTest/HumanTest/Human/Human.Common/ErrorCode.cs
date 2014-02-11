using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human.Common
{
	public enum ErrorCode
	{
		/// <summary>
		/// 保存数据失败
		/// </summary>
		[ErrorDescription(Message = "保存数据失败")]
		SaveDataFailed = 20001,

		/// <summary>
		/// 参数错误
		/// </summary>
		[ErrorDescription(Message = "参数错误")]
		ParameterError = 20002,

		/// <summary>
		/// 数据不存在
		/// </summary>
		[ErrorDescription(Message = "数据不存在!")]
		DataNotExist = 20003,

		/// <summary>
		/// 用户信息错误
		/// </summary>
		[ErrorDescription(Message = "用户信息错误")]
		UserInfoError = 20101,

		/// <summary>
		/// 用户不存不
		/// </summary>
		[ErrorDescription(Message = "用户不存不")]
		UserNotExist = 20102,

		/// <summary>
		/// 用户密码错误
		/// </summary>
		[ErrorDescription(Message = "用户密码错误")]
		UserPasswordError = 20103,

		/// <summary>
		/// 员工不存在
		/// </summary>
		[ErrorDescription(Message = "员工不存在!")]
		PeopleNotExist = 20201,



		/// <summary>
		/// 删除员工失败
		/// </summary>
		[ErrorDescription(Message = "删除员工失败!")]
		DeletePeopleFail = 20202,

		/// <summary>
		/// 员工家庭成员不存在
		/// </summary>
		[ErrorDescription(Message = "员工家庭成员不存在!")]
		PeopleFamilyNotExist = 20203,
	}
}

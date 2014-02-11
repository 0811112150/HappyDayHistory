using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human.Common
{
	public class CResult<T>
	{
		private string _message;

		public ErrorCode Code { get; set; }

		public T Data { get; set; }

		public string Message { get { return _message; } set { _message = value; } }

		public CResult(T data, ErrorCode errorCode = 0)
		{
			this.Data = data;
			this.Code = errorCode;
			if (errorCode > 0) {
				var errorType = typeof(ErrorCode);
				var errorField = errorType.GetField(Enum.GetName(errorType, errorCode));
				//var errorField = errorType.GetField(errorCode.ToString());
				var attr = (ErrorDescription)Attribute.GetCustomAttribute(errorField, typeof(ErrorDescription));

				this.Message = attr.Message;
			}

		}
	}
}

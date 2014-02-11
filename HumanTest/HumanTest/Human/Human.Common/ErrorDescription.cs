using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human.Common
{
	public class ErrorDescription : Attribute
	{
		private string _message;

		public string Message { get { return _message; } set { _message = value; } }
	}
}

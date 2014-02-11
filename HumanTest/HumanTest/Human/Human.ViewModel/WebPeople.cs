using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human.ViewModel
{
	public class WebPeople
	{
		private string _peopleName = string.Empty;
		private string _gender = string.Empty;

		public int PeopleID { get; set; }

		public string PeopleName { get { return _peopleName; } set { _peopleName = value; } }

		public string Gender { get { return _gender; } set { _gender = value; } }

		public DateTime? DateOfBirth { get; set; }
	}
}

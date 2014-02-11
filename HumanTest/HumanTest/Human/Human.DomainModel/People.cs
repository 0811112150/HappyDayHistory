using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human.DomainModel
{
	public class People
	{
		private string _peopleName = string.Empty;
		private string _gender;

		public int PeopleID { get; set; }

		public string PeopleName { get { return _peopleName; } set { _peopleName = value; } }

		public string Gender { get { return _gender; } set { _gender = value; } }

		public DateTime? DateOfBirth { get; set; }
	}
}

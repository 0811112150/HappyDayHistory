using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human.DomainModel
{
	public class PeopleFamily
	{
		private string _relation = string.Empty;
		private string _familyPeopleName = string.Empty;
		private string _workUnit = string.Empty;
		private string _title = string.Empty;
		private string _phoneNum = string.Empty;
		private string _address = string.Empty;


		public int PeopleFamilyID { get; set; }
		
		public int PeopleID { get; set; }

		public string Relation { get { return _relation; } set { _relation = value; } }

		public string FamilyPeopleName { get { return _familyPeopleName; } set { _familyPeopleName = value; } }

		public string WorkUnit { get { return _workUnit; } set { _workUnit = value; } }

		public string Title { get { return _title; } set { _title = value; } }

		public string PhoneNum { get { return _phoneNum; } set { _phoneNum = value; } }

		public string Address { get { return _address; } set { _address = value; } }
	}
}

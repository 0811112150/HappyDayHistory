using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human.DomainModel
{
	public class PeoplePic
	{
		private string _picTitle;
		private string _picPath;

		public int PicID { get; set; }
		public int PeopleID { get; set; }
		public string PicTitle { get { return _picTitle; } set { _picTitle = value; } }
		public string PicPath { get { return _picPath; } set { _picPath = value; } }
	}
}

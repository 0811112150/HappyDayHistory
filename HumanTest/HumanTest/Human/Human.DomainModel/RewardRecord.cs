using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human.DomainModel
{
	public class RewardRecord
	{
		private string _rewardContent;
		public int RecordID { get; set; }
		public int PeopleID { get; set; }
		public DateTime? RewardDate { get; set; }
		public string RewardContent
		{
			get { return _rewardContent; }
			set { _rewardContent = value; }
		}
	}
}

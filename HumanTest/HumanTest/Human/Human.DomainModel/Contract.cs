using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.Common;

namespace Human.DomainModel
{
	public class Contract
	{
		private string _contractNum;


		public int ContractID { get; set; }

		public int PeopleID { get; set; }

		public int ContractrType { get; set; }

		public bool IsFirstContract { get; set; }

		public string ContractNum { get { return _contractNum; } set { _contractNum = value; } }

		public DateTime? StartDate { get; set; }

		public DateTime? ProbationEndDate { get; set; }

		public DateTime? EndDate { get; set; }


		public ContractrTypeEnum ContractrTypeStr { get { return (ContractrTypeEnum)this.ContractrType; } }

		public string IsFirstContractStr { get { return IsFirstContract ? SystemInfo.ContractFirst : SystemInfo.ContractNotFirst; } }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.DAL;

namespace Human.BLL
{
	public class CommonData
	{
		private static List<int> _needReminderPeopleIDList;

		public static List<int> NeedReminderPeopleIDList
		{
			get
			{
				//if (_needReminderPeopleIDList == null || _needReminderPeopleIDList.Count == 0) {
				FillNeedReminderPeopleIDList();
				//}
				return _needReminderPeopleIDList;
			}
		}

		private static void FillNeedReminderPeopleIDList()
		{
			_needReminderPeopleIDList = new ContractDAL().GetNeedReminderPeopleIDList();
		}
	}
}

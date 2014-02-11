using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.DomainModel;
using Human.Common;
using Human.Common;
using Human.DAL;

namespace Human.BLL
{
	public class PeopleFamilyBLL
	{
		public CResult<List<PeopleFamily>> GetPeopleFamilyList(int peopleID)
		{
			if (peopleID <= 0) {
				return new CResult<List<PeopleFamily>>(new List<PeopleFamily>(),ErrorCode.ParameterError);
			}
			var result= new PeopleFamilyDAL().GetPeopleFamilyList(peopleID);
			return new	CResult<List<PeopleFamily>>(result);
		}

		public CResult<bool> DeletePeopleFamilyByID(int peopleFamilyID)
		{
			if (peopleFamilyID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}

			var dal = new PeopleFamilyDAL();
			if (dal.GetPeopleFamilyByID(peopleFamilyID) == null) {
				return new CResult<bool>(false, ErrorCode.PeopleFamilyNotExist);
			}

			var result = dal.DeletePeopleFamilyByID(peopleFamilyID);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.PeopleFamilyNotExist);
			}
		}

		public CResult<PeopleFamily> GetPeopleFamilyByID(int peopleFamilyID)
		{
			if (peopleFamilyID <= 0) {
				return new CResult<PeopleFamily>(null, ErrorCode.ParameterError);
			}

			var peopleFamily = new PeopleFamilyDAL().GetPeopleFamilyByID(peopleFamilyID);
			if (peopleFamily == null) {
				return new CResult<PeopleFamily>(null, ErrorCode.PeopleFamilyNotExist);
			} else {
				return new CResult<PeopleFamily>(peopleFamily);
			}
		}

		public CResult<bool> InsertPeopleFamily(PeopleFamily peopleFamily)
		{
			if (peopleFamily.PeopleID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}

			var result = new PeopleFamilyDAL().InsertPeopleFamily(peopleFamily);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.PeopleFamilyNotExist);
			}
		}

		public CResult<bool> UpdatePeopleFamily(PeopleFamily peopleFamily)
		{
			if (peopleFamily.PeopleFamilyID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			var result = new PeopleFamilyDAL().UpdatePeopleFamily(peopleFamily);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.SaveDataFailed);
			}
		}
	}
}

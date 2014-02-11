using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.DomainModel;
using Human.Common;
using Human.DAL;

namespace Human.BLL
{
	public class InsuranceFundBLL
	{
		public CResult<List<InsuranceFund>> GetInsuranceFundList(int peopleID)
		{
			if (peopleID <= 0) {
				return new CResult<List<InsuranceFund>>(new List<InsuranceFund>(), ErrorCode.ParameterError);
			}
			var result = new InsuranceFundDAL().GetInsuranceFundList(peopleID);
			return new CResult<List<InsuranceFund>>(result);
		}

		public CResult<bool> DeleteInsuranceFundByID(int InsuranceFundID)
		{
			if (InsuranceFundID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}

			var dal = new InsuranceFundDAL();
			if (dal.GetInsuranceFundByID(InsuranceFundID) == null) {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}

			var result = dal.DeleteInsuranceFundByID(InsuranceFundID);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}
		}

		public CResult<InsuranceFund> GetInsuranceFundByID(int InsuranceFundID)
		{
			if (InsuranceFundID <= 0) {
				return new CResult<InsuranceFund>(null, ErrorCode.ParameterError);
			}

			var InsuranceFund = new InsuranceFundDAL().GetInsuranceFundByID(InsuranceFundID);
			if (InsuranceFund == null) {
				return new CResult<InsuranceFund>(null, ErrorCode.DataNotExist);
			} else {
				return new CResult<InsuranceFund>(InsuranceFund);
			}
		}

		public CResult<bool> InsertInsuranceFund(InsuranceFund InsuranceFund)
		{
			if (InsuranceFund.PeopleID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}

			var result = new InsuranceFundDAL().InsertInsuranceFund(InsuranceFund);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}
		}

		public CResult<bool> UpdateInsuranceFund(InsuranceFund InsuranceFund)
		{
			if (InsuranceFund.InsuranceFundID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			var result = new InsuranceFundDAL().UpdateInsuranceFund(InsuranceFund);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.SaveDataFailed);
			}
		}
	}
}

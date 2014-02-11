using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.Common;
using Human.DomainModel;
using Human.DAL;

namespace Human.BLL
{
	public class ContractBLL
	{
		public CResult<List<Contract>> GetContractList(int peopleID)
		{
			if (peopleID <= 0) {
				return new CResult<List<Contract>>(new List<Contract>(), ErrorCode.ParameterError);
			}
			var result = new ContractDAL().GetContractList(peopleID);
			return new CResult<List<Contract>>(result);
		}

		public CResult<bool> DeleteContractByID(int contractID)
		{
			if (contractID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}

			var dal = new ContractDAL();
			if (dal.GetContractByID(contractID) == null) {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}

			var result = dal.DeleteContractByID(contractID);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}
		}

		public CResult<Contract> GetContractByID(int contractID)
		{
			if (contractID <= 0) {
				return new CResult<Contract>(null, ErrorCode.ParameterError);
			}

			var Contract = new ContractDAL().GetContractByID(contractID);
			if (Contract == null) {
				return new CResult<Contract>(null, ErrorCode.DataNotExist);
			} else {
				return new CResult<Contract>(Contract);
			}
		}

		public CResult<bool> InsertContract(Contract contract)
		{
			if (contract.PeopleID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}

			var result = new ContractDAL().InsertContract(contract);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}
		}

		public CResult<bool> UpdateContract(Contract contract)
		{
			if (contract.ContractID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			var result = new ContractDAL().UpdateContract(contract);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.SaveDataFailed);
			}
		}
	}
}

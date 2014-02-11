using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.DomainModel;
using Human.Common;
using Human.DAL;

namespace Human.BLL
{
	public class TitleWageChangeRecordBLL
	{
		public CResult<List<TitleWageChangeRecord>> GetTitleWageChangeRecordList(int peopleID)
		{
			if (peopleID <= 0) {
				return new CResult<List<TitleWageChangeRecord>>(new List<TitleWageChangeRecord>(), ErrorCode.ParameterError);
			}
			var result = new TitleWageChangeRecordDAL().GetTitleWageChangeRecordList(peopleID);
			return new CResult<List<TitleWageChangeRecord>>(result);
		}

		public CResult<bool> DeleteTitleWageChangeRecordByID(int TitleWageChangeRecordID)
		{
			if (TitleWageChangeRecordID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}

			var dal = new TitleWageChangeRecordDAL();
			if (dal.GetTitleWageChangeRecordByID(TitleWageChangeRecordID) == null) {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}

			var result = dal.DeleteTitleWageChangeRecordByID(TitleWageChangeRecordID);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}
		}

		public CResult<TitleWageChangeRecord> GetTitleWageChangeRecordByID(int TitleWageChangeRecordID)
		{
			if (TitleWageChangeRecordID <= 0) {
				return new CResult<TitleWageChangeRecord>(null, ErrorCode.ParameterError);
			}

			var TitleWageChangeRecord = new TitleWageChangeRecordDAL().GetTitleWageChangeRecordByID(TitleWageChangeRecordID);
			if (TitleWageChangeRecord == null) {
				return new CResult<TitleWageChangeRecord>(null, ErrorCode.DataNotExist);
			} else {
				return new CResult<TitleWageChangeRecord>(TitleWageChangeRecord);
			}
		}

		public CResult<bool> InsertTitleWageChangeRecord(TitleWageChangeRecord TitleWageChangeRecord)
		{
			if (TitleWageChangeRecord.PeopleID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}

			var result = new TitleWageChangeRecordDAL().InsertTitleWageChangeRecord(TitleWageChangeRecord);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}
		}

		public CResult<bool> UpdateTitleWageChangeRecord(TitleWageChangeRecord TitleWageChangeRecord)
		{
			if (TitleWageChangeRecord.TitleWageChangeRecordID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			var result = new TitleWageChangeRecordDAL().UpdateTitleWageChangeRecord(TitleWageChangeRecord);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.SaveDataFailed);
			}
		}
	}
}

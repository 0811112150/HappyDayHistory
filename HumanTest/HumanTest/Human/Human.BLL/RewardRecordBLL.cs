using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.DomainModel;
using Human.Common;
using Human.DAL;

namespace Human.BLL
{
	public class RewardRecordBLL
	{
		public CResult<List<RewardRecord>> GetRewardRecordList(int peopleID)
		{
			if (peopleID <= 0) {
				return new CResult<List<RewardRecord>>(new List<RewardRecord>(), ErrorCode.ParameterError);
			}
			var result = new RewardRecordDAL().GetRewardRecordList(peopleID);
			return new CResult<List<RewardRecord>>(result);
		}

		public CResult<bool> DeleteRewardRecordByID(int RewardRecordID)
		{
			if (RewardRecordID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}

			var dal = new RewardRecordDAL();
			if (dal.GetRewardRecordByID(RewardRecordID) == null) {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}

			var result = dal.DeleteRewardRecordByID(RewardRecordID);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}
		}

		public CResult<RewardRecord> GetRewardRecordByID(int RewardRecordID)
		{
			if (RewardRecordID <= 0) {
				return new CResult<RewardRecord>(null, ErrorCode.ParameterError);
			}

			var RewardRecord = new RewardRecordDAL().GetRewardRecordByID(RewardRecordID);
			if (RewardRecord == null) {
				return new CResult<RewardRecord>(null, ErrorCode.DataNotExist);
			} else {
				return new CResult<RewardRecord>(RewardRecord);
			}
		}

		public CResult<bool> InsertRewardRecord(RewardRecord RewardRecord)
		{
			if (RewardRecord.PeopleID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}

			var result = new RewardRecordDAL().InsertRewardRecord(RewardRecord);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}
		}

		public CResult<bool> UpdateRewardRecord(RewardRecord RewardRecord)
		{
			if (RewardRecord.RecordID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			var result = new RewardRecordDAL().UpdateRewardRecord(RewardRecord);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.SaveDataFailed);
			}
		}
	}
}

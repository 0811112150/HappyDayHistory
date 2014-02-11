using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.DomainModel;
using Human.Common;
using Human.DAL;

namespace Human.BLL
{
	public class TrainingTestRecordBLL
	{
		public CResult<List<TrainingTestRecord>> GetTrainingTestRecordList(int peopleID)
		{
			if (peopleID <= 0) {
				return new CResult<List<TrainingTestRecord>>(new List<TrainingTestRecord>(), ErrorCode.ParameterError);
			}
			var result = new TrainingTestRecordDAL().GetTrainingTestRecordList(peopleID);
			return new CResult<List<TrainingTestRecord>>(result);
		}

		public CResult<bool> DeleteTrainingTestRecordByID(int TrainingTestRecordID)
		{
			if (TrainingTestRecordID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}

			var dal = new TrainingTestRecordDAL();
			if (dal.GetTrainingTestRecordByID(TrainingTestRecordID) == null) {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}

			var result = dal.DeleteTrainingTestRecordByID(TrainingTestRecordID);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}
		}

		public CResult<TrainingTestRecord> GetTrainingTestRecordByID(int TrainingTestRecordID)
		{
			if (TrainingTestRecordID <= 0) {
				return new CResult<TrainingTestRecord>(null, ErrorCode.ParameterError);
			}

			var TrainingTestRecord = new TrainingTestRecordDAL().GetTrainingTestRecordByID(TrainingTestRecordID);
			if (TrainingTestRecord == null) {
				return new CResult<TrainingTestRecord>(null, ErrorCode.DataNotExist);
			} else {
				return new CResult<TrainingTestRecord>(TrainingTestRecord);
			}
		}

		public CResult<bool> InsertTrainingTestRecord(TrainingTestRecord TrainingTestRecord)
		{
			if (TrainingTestRecord.PeopleID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}

			var result = new TrainingTestRecordDAL().InsertTrainingTestRecord(TrainingTestRecord);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}
		}

		public CResult<bool> UpdateTrainingTestRecord(TrainingTestRecord TrainingTestRecord)
		{
			if (TrainingTestRecord.RecordID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			var result = new TrainingTestRecordDAL().UpdateTrainingTestRecord(TrainingTestRecord);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.SaveDataFailed);
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.Common;
using Human.DAL;
using Human.DomainModel;
using System.IO;
using System.Windows.Forms;

namespace Human.BLL
{
	public class PeoplePicBLL
	{
		public CResult<List<PeoplePic>> GetPeoplePicList(int peopleID)
		{
			if (peopleID <= 0) {
				return new CResult<List<PeoplePic>>(new List<PeoplePic>(), ErrorCode.ParameterError);
			}
			var result = new PeoplePicDAL().GetPeoplePicList(peopleID);
			return new CResult<List<PeoplePic>>(result);
		}

		public CResult<bool> DeletePeoplePicByID(int PeoplePicID)
		{
			if (PeoplePicID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}

			var dal = new PeoplePicDAL();
			if (dal.GetPeoplePicByID(PeoplePicID) == null) {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}

			var result = dal.DeletePeoplePicByID(PeoplePicID);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}
		}

		public CResult<PeoplePic> GetPeoplePicByID(int PeoplePicID)
		{
			if (PeoplePicID <= 0) {
				return new CResult<PeoplePic>(null, ErrorCode.ParameterError);
			}

			var PeoplePic = new PeoplePicDAL().GetPeoplePicByID(PeoplePicID);
			if (PeoplePic == null) {
				return new CResult<PeoplePic>(null, ErrorCode.DataNotExist);
			} else {
				return new CResult<PeoplePic>(PeoplePic);
			}
		}

		public CResult<bool> InsertPeoplePic(PeoplePic peoplePic)
		{
			if (peoplePic.PeopleID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}

			var projectDir = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath));
			var newName = Guid.NewGuid() + Path.GetExtension(peoplePic.PicPath);
			var savePth = Path.Combine(SystemInfo.UploadPeoplePicFolder, peoplePic.PeopleID.ToString(), newName);
			var desPath = Path.Combine(projectDir, savePth);
			if (!Directory.Exists(Path.GetDirectoryName(desPath))) {
				Directory.CreateDirectory(Path.GetDirectoryName(desPath));
			}
			File.Copy(peoplePic.PicPath, desPath);

			peoplePic.PicPath = savePth;

			var result = new PeoplePicDAL().InsertPeoplePic(peoplePic);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}
		}

		public CResult<bool> UpdatePeoplePic(PeoplePic peoplePic)
		{
			if (peoplePic.PicID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			var oldPic = GetPeoplePicByID(peoplePic.PicID).Data;
			if (oldPic == null) {
				return new CResult<bool>(false, ErrorCode.DataNotExist);
			}
			if (!peoplePic.PicPath.Contains(Path.GetFileName(oldPic.PicPath))) {
				var projectDir = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath));
				var newName = Guid.NewGuid() + Path.GetExtension(peoplePic.PicPath);
				var savePth = Path.Combine(SystemInfo.UploadPeoplePicFolder, oldPic.PeopleID.ToString(), newName);
				var desPath = Path.Combine(projectDir, savePth);
				File.Copy(peoplePic.PicPath, desPath);

				peoplePic.PicPath = savePth;
			} else {
				peoplePic.PicPath = oldPic.PicPath;
			}

			var result = new PeoplePicDAL().UpdatePeoplePic(peoplePic);
			if (result) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.SaveDataFailed);
			}
		}
	}
}

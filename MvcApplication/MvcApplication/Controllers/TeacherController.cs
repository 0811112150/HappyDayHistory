using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Study.DomainModel;
using Study.DAL;
using Study.ViewModel;
using System.Data.Entity;

namespace MvcApplication.Controllers
{
	public class TeacherController : Controller
	{
		private SchoolContext _dbSchool = new SchoolContext();
		//
		// GET: /Teacher/

		public ActionResult Index(int? id, int? CourseID)
		{
			var viewModel = new TeacherIndexDate();
			viewModel.Teachers = _dbSchool.Teachsers.Include(i => i.OfficeAssignment).
								Include(i => i.Courses.Select(c => c.Department)).OrderBy(i => i.LastName);
			if (id != null) {
				ViewBag.TeacherID = id.Value;
				viewModel.Courses = viewModel.Teachers.Where(i => i.TeacherID == id.Value).Single().Courses;
			}
			if (CourseID != null) {
				ViewBag.CourseID = CourseID.Value;
				viewModel.Enrollments = viewModel.Courses.Where(x => x.CourseID == CourseID).Single().Enrollments;
			}
			return View(viewModel);
		}

		public ActionResult Create()
		{
			ViewBag.SelectCourse = _dbSchool.Courses.ToList();
			return View();
		}
	}
}

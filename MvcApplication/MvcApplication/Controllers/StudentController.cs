using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Study.DAL;
using Study.DomainModel;
using System.Data.Entity;
using System.Data;
using Webdiyer.WebControls.Mvc;

namespace MvcApplication.Controllers
{
	public class StudentController : Controller
	{
		private SchoolContext _db = new SchoolContext();

		//
		// GET: /Student/

		//public ActionResult Index()
		//{
		//    return View(_db.Students.ToList());
		//}

		public ActionResult Details(int id)
		{
			Student student = _db.Students.Find(id);
			return View(student);
		}


		public ActionResult Create()
		{
			//return View(new Student());
			return View();
		}

		[HttpPost]
		public ActionResult CreateStudent(Student student)
		{
			if (ModelState.IsValid) {
				_db.Students.Add(student);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(student);
		}

		public ActionResult Edit(int id)
		{
			Student student = _db.Students.Find(id);
			return View(student);
		}

		[HttpPost]
		public ActionResult Edit(Student student)
		{
			if (ModelState.IsValid) {
				Student oldStudent = _db.Students.Find(student.StudentID);
				oldStudent.LastName = student.LastName;
				oldStudent.FirstMidName = student.FirstMidName;
				oldStudent.EnrollmentDate = student.EnrollmentDate;
				int i = _db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(student);
		}

		public ActionResult Delete(int id)
		{
			return View(_db.Students.Find(id));
		}

		[HttpPost]
		public ActionResult Delete(Student student)
		{
			_db.Students.Remove(_db.Students.Find(student.StudentID));
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		protected override void Dispose(bool disposing)
		{
			_db.Dispose();
			base.Dispose(disposing);
		}

		public ViewResult Index(string sortOrder, string searchString, int? page = 1)
		{
			//var departments = _db.Departments.ToList();
			//foreach (Department d in departments) {
			//    _db.Entry(d).Collection(x => x.Courses).Load();
			//}
			ViewBag.NameSortParm = string.IsNullOrEmpty(sortOrder) ? "Name Desc" : "";
			ViewBag.DateSortParm = sortOrder == "Date Desc" ? "date" : "Date Desc";
			var students = from s in _db.Students
						   select s;
			if (!string.IsNullOrEmpty(searchString)) {
				students = students.Where(s => s.FirstMidName.ToUpper().Contains(searchString.ToUpper()) ||
					s.LastName.ToUpper().Contains(searchString.ToUpper()));
			}
			switch (sortOrder) {
				case "Name Desc":
					students = students.OrderByDescending(s => s.LastName);
					break;
				case "Date":
					students = students.OrderBy(s => s.EnrollmentDate);
					break;
				case "Date desc":
					students = students.OrderByDescending(s => s.EnrollmentDate);
					break;
				default:
					students = students.OrderBy(s => s.EnrollmentDate);
					break;
			}
			int pageSize = 2;
			int pageIndex = page ?? 1;
			return View(students.ToPagedList(pageIndex, pageSize));
		}

	}
}

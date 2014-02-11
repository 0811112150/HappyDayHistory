using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Study.DomainModel;

namespace Study.ViewModel
{
	public class TeacherIndexDate
	{
		public IEnumerable<Teacher> Teachers { get; set; }
		public IEnumerable<Course> Courses { get; set; }
		public IEnumerable<Enrollment> Enrollments { get; set; }
	}
}

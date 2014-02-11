using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Study.DomainModel
{
	public class Teacher
	{
		public int TeacherID { get; set; }
		[Required(ErrorMessage = "Last name is required.")]
		[Display(Name = "Last Name")]
		[MaxLength(50)]
		public string LastName { get; set; }
		[Required(ErrorMessage = "First name is required.")]
		[Column("FirstName")]
		[Display(Name = "First Name")]
		[MaxLength(50)]
		public string FirstMidName { get; set; }
		[DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
		[Required(ErrorMessage = "Hire date is required.")]
		[Display(Name = "Hire Date")]
		public DateTime? HireDate { get; set; }
		public string FullName
		{
			get
			{
				return LastName + ", " + FirstMidName;
			}
		}
		public virtual ICollection<Course> Courses { get; set; }
		public virtual OfficeAssignment OfficeAssignment { get; set; }
	}
}

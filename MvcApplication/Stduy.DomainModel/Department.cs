using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Study.DomainModel
{
 	public class Department
	{
		public int DepartmentID { get; set; }
		[Required(ErrorMessage = "Department name is required.")]
		[MaxLength(50)]
		public string Name { get; set; }
		[DisplayFormat(DataFormatString = "{0:c}")]
		[Required(ErrorMessage = "Budget is required.")]
		[Column(TypeName = "money")]
		public decimal? Budget { get; set; }

		[DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
		[Required(ErrorMessage = "Start date is required.")]
		public DateTime StartDate { get; set; }

		[Display(Name = "Administrator")]
		public int? InstructorID { get; set; }

		public virtual Teacher Administrator { get; set; }
		public virtual ICollection<Course> Courses { get; set; }
	}
}

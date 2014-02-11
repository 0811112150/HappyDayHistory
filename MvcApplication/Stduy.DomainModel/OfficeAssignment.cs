using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Study.DomainModel
{
	public class OfficeAssignment
	{
		[Key]
		public int TeacherID { get; set; }
		[MaxLength(50)]
		[Display(Name = "Office Location")]
		public string Location { get; set; }
		public virtual Teacher Teacher { get; set; }
	}
}

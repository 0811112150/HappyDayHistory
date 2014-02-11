using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Study.DomainModel;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;

namespace Study.DAL
{
	public class SchoolContext : DbContext
	{
		//private readonly static string CONNECTION_STRING = "name=WlfSys_EFCF_ConnString";

		//public DbSet<Student> Students { set; get; }
		//public DbSet<Enrollment> Enrollments { set; get; }
		//public DbSet<Course> Courses { set; get; }

		//public SchoolContext() 
		//    : base(CONNECTION_STRING) 
		//{
		//}

		//protected override void OnModelCreating(DbModelBuilder modelBuilder)
		//{
		//    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		//    modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
		//}
		private readonly static string CONNECTION_STRING = "name=WlfSys_EFCF_ConnString";

		public DbSet<Course> Courses { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
		public DbSet<Teacher> Teachsers { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<OfficeAssignment> OfficeAssignments { get; set; }

		public SchoolContext()
			: base(CONNECTION_STRING)
		{
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Entity<Teacher>()
				.HasOptional(p => p.OfficeAssignment).WithRequired(p => p.Teacher);
			modelBuilder.Entity<Course>()
				.HasMany(c => c.Teachers).WithMany(i => i.Courses)
				.Map(t => t.MapLeftKey("CourseID")
					.MapRightKey("TeacherID")
					.ToTable("CourseTeacher"));
			modelBuilder.Entity<Department>()
				.HasOptional(x => x.Administrator);
		}
	}
}

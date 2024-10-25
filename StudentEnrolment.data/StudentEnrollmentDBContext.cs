using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentEnrolment.data.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentEnrolment.data.Configuration.CourseConfiguration;

namespace StudentEnrolment.data
{
    public class StudentEnrollmentDBContext : IdentityDbContext
    {
        public StudentEnrollmentDBContext( DbContextOptions<StudentEnrollmentDBContext> options):base(options) 
        {
        }

        //default value
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CourseConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            //builder.Entity<Course>().HasData(
            //    new Course
            //    {
            //        id = 1,
            //        Title = "minimal Api development"
            //    },
            //    new Course
            //    {
            //        id = 2,
            //        Title = "minimal Api Development"
            //    }
            //    );
        }

        public DbSet<Student> Students { get; set; }
       public DbSet<Course> Courses { get; set; }
       public DbSet<Enrollment> Enrollments { get; set; }
        
    }
}

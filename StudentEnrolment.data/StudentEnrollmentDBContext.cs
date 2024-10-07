using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrolment.data
{
    public class StudentEnrollmentDBContext : IdentityDbContext
    {
        public StudentEnrollmentDBContext( DbContextOptions<StudentEnrollmentDBContext> options):base(options) 
        {
        }

       public DbSet<Student> Students { get; set; }
       public DbSet<Course> Courses { get; set; }
       public DbSet<Enrollment> Enrollmrnts { get; set; }
        
    }
}

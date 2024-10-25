using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrolment.data.Configuration
{
    internal partial class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(
               new Course
               {
                   id = 1,
                   Title = "maths",
                   Credits = 3

               },
               new Course
               {
                   id = 2,
                   Title = "physics",
                   Credits =5
               }
               );
        }
    }
}

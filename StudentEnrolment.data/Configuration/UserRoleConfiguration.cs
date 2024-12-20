﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StudentEnrolment.data.Configuration
{
    internal partial class CourseConfiguration
    {
        internal class UserRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
        {
            public void Configure(EntityTypeBuilder<IdentityRole> builder)
            {
                builder.HasData(
                   new IdentityRole
                   {
                       Name = "Administrator",
                       NormalizedName = "ADMINISTRATOR"

                   },
                   new IdentityRole
                   {
                       Name = "User",
                       NormalizedName = "USER"
                   }
                   );
            }
        }
    }
}
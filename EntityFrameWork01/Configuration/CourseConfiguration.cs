using EntityFrameWork01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWork01.Configuration
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.HasKey(x => x.Id);

            builder.Property(c => c.Title)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(x => x.Description)
                .HasMaxLength(100);

            builder.Property(x => x.Credits).HasDefaultValue(3);
            builder.Property(c => c.CourseTime)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}

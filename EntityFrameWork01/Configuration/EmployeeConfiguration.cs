using EntityFrameWork01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace EntityFrameWork01.Configuration
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> modelBuilder)
        {
         
                modelBuilder.ToTable("Employee").HasKey(P => P.EmpId);
                modelBuilder.Property(X => X.Name)
                .HasColumnType("varchar").
                HasMaxLength(100)
                .IsRequired().HasColumnName("EmployeeName");

                modelBuilder.Property(X => X.Address).HasMaxLength(100);
                modelBuilder.Property(e => e.Salary).HasColumnType("decimal(10,2)");
          
        }
    }
}

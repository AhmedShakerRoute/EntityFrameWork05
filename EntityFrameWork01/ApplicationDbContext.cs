using EntityFrameWork01.Configuration;
using EntityFrameWork01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWork01
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//Provider -- Connection string
            optionsBuilder.UseSqlServer("server=.;Database=Session01EF;Trusted_Connection=true; TrustServerCertificate = true");
            optionsBuilder.UseLazyLoadingProxies(b => b.IgnoreNonVirtualNavigations());
            //optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        //public DbSet<User> User { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Car> Cars { get; set; }

        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<CustomerServices> CustomerServices { get; set; }







        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().ToTable("Employees").HasKey(X => X.EmpId);
            //modelBuilder.Entity<Employee>().Property(X => X.Name)
            //    .HasColumnType("varchar").
            //    HasMaxLength(100)
            //    .IsRequired().HasColumnName("EmployeeName");//Employee name varchar(100)
            ////modelBuilder.Entity<Employee>().Property(typeof(string) , "Name")

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee").HasKey(P => P.EmpId);
                entity.Property(X => X.Name)
                .HasColumnType("varchar").
                HasMaxLength(100)
                .IsRequired().HasColumnName("EmployeeName");

                entity.Property(X => X.Address).HasMaxLength(100);
                entity.Property(e => e.Salary).HasColumnType("decimal(10,2)");
            });


            modelBuilder.ApplyConfiguration<Course>(new CourseConfiguration());

            modelBuilder.Entity<Test>().HasKey(x => x.TID);
            modelBuilder.Entity<Test>().Property(x => x.TID).ValueGeneratedOnAdd();
            modelBuilder.Entity<Test>().Property(x => x.TID).UseIdentityColumn(10, 10); //ValueGeneratedOnAdd + UseIdentityColumn



            modelBuilder.Entity<BookPublisher>().HasKey(P => P.PublisherId);


            //modelBuilder.Entity<Customer>()
            //    .HasMany(S => S.Services)
            //    .WithMany(S => S.Customers)
            //    .UsingEntity(ETB =>
            //    {
            //        ETB.ToTable("CustomerServices");
            //        ETB.Property<DateTime>("CreatedAte").HasDefaultValueSql("GETDATE()");
            //    });
            modelBuilder.Entity<CustomerServices>().HasKey(c => new { c.CustomerId, c.ServiceId });
            modelBuilder.Entity<Employee>().HasOne(P=>P.Manager).WithMany()
                .HasForeignKey(E=>E.ManID).OnDelete(DeleteBehavior.NoAction);







            #region Shadow Properties


            modelBuilder.Entity<Customer>(EB =>
            {
                EB.Property<DateTime>("CreatedAt").HasDefaultValueSql("GETDATE()");
                EB.Property<DateTime>("UpdatedAt").HasDefaultValueSql("GETDATE()");
                EB.Property<string>("CreatedBy");
                EB.Property<string>("LastModifiedBy");
            });







            #endregion

            #region OwnedEntity
            modelBuilder.Entity<Customer>().OwnsOne(C => C.ShipmentAddress , AB =>
            {
                AB.Property(a => a.City).HasColumnName("ShipmentCity").HasColumnType("varchar").HasMaxLength(30);
            });







            modelBuilder.Entity<Student>().OwnsOne(C => C.ShipmentAddress);
            #endregion

            modelBuilder.Entity<Customer>().HasMany(C => C.Orders).WithOne(O => O.OrderCustomer).HasForeignKey(O => O.CustomerId);


            modelBuilder.Entity<Service>().HasData(
                new Service() { Id = 1, Name = "Service 01" },
                new Service() { Id = 2, Name = "Service 02" },
                new Service() { Id = 3, Name = "Service 03" }

                );
        }
    }
}

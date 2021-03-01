using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkExam
{
    public class EnrollmentContext:DbContext
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public EnrollmentContext(string connectionString, string assemblyName)
        {
            _connectionString = connectionString;
            _assemblyName = assemblyName;
        }
        public EnrollmentContext()
        {
            _connectionString = ConnectionInfo.ConnectionString;
            _assemblyName = typeof(Program).Assembly.FullName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_assemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Enrollment>().HasKey(pc => new {pc.StudentId, pc.CourseId});
            builder.Entity<Enrollment>().HasOne(pc => pc.Student)
                .WithMany(p => p.Enrollments).HasForeignKey(pc => pc.StudentId);
            builder.Entity<Enrollment>().HasOne(pc => pc.Course).WithMany(c => c.Enrollments)
                .HasForeignKey(pc => pc.CourseId);
            base.OnModelCreating(builder);
        }
        public DbSet<Student> Students{ get; set; }
        public DbSet<Course> Courses{ get; set; }
    }
}

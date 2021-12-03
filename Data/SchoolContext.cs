
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        //public DbSet<Make> Make { get; set; }
        //public DbSet<Model> Model { get; set; }
        //public DbSet<Colour> Colour { get; set; }
        //public DbSet<Miliage> Miliage { get; set; }
        //public DbSet<Engine> Engine { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
            //modelBuilder.Entity<Make>().ToTable("Make");
            //modelBuilder.Entity<Model>().ToTable("Model");
            //modelBuilder.Entity<Colour>().ToTable("Colour");
            //modelBuilder.Entity<Miliage>().ToTable("Miliage");

        }
    }
}


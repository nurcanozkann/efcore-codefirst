using EfCore.Entity.Builder;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Entity
{
    public class EfCoreContext : DbContext
    {
        public EfCoreContext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddress { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new StudentBuilder());
            modelBuilder.ApplyConfiguration(new StudentAddressBuilder());
            modelBuilder.ApplyConfiguration(new StudentCourseBuilder());
        }
    }
}

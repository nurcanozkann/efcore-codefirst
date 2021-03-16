using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Entity.Builder
{
    public class StudentCourseBuilder : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(user => user.Id);

            builder.HasOne<Student>(m => m.Student)
                 .WithMany(c => c.StudentCourses)
                 .HasForeignKey(sc => sc.StudentId);


            builder.HasOne<Course>(c => c.Course)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(f => f.CourseId);
        }
    }
}

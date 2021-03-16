using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Entity.Builder
{
    public class StudentBuilder : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne<StudentAddress>(s => s.StudentAddress)
                .WithOne(sa => sa.Student)
                .HasForeignKey<StudentAddress>(sah => sah.AddressOfStudentId);


            builder.HasOne(s => s.CurrentGrade) //Student içerisinde :grade sınıfı bir adet özelliği içerir.
                .WithMany(g => g.Students) //Grade içerisinde: bir grade üzerinde birden fazla Student bulunabilir.
                .HasForeignKey(m => m.CurrentGradeId) //Student içerisinde
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}

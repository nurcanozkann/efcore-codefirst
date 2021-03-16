using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Entity.Builder
{
    public class StudentAddressBuilder : IEntityTypeConfiguration<StudentAddress>
    {
        public void Configure(EntityTypeBuilder<StudentAddress> builder)
        {
            builder.HasOne(sa => sa.Student)
                 .WithOne(s => s.StudentAddress)
                 .HasForeignKey<StudentAddress>(ad => ad.AddressOfStudentId);
        }
    }
}

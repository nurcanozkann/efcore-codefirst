using EfCore.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Entity
{
    public class StudentAddress : IEntity
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int AddressOfStudentId { get; set; }
        public Student Student { get; set; }
    }
}

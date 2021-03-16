using EfCore.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Entity
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}

using EfCore.Entity.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EfCore.Entity
{
    public class Student : IEntity
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public int CurrentGradeId { get; set; }
        public Grade CurrentGrade { get; set; }
        public StudentAddress StudentAddress { get; set; }
        public ICollection<StudentCourse> StudentCourses{ get; set; }
    }
}

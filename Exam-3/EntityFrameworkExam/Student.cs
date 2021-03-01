using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkExam
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public IList<Enrollment> Enrollments { get; set; }
    }
}

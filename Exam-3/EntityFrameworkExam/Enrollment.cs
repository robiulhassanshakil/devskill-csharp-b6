using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkExam
{
    public class Enrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollDate { get; set; }
    }
}

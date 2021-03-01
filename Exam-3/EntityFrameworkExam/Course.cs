using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkExam
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Fees { get; set; }
        public int DurationInHours { get; set; }

        public IList<Enrollment> Enrollments { get; set; }
    }
}

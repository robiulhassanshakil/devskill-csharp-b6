using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace EntityFrameworkExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var enrollmentContext = new EnrollmentContext();
            MultiTableInsert(enrollmentContext);

        }

        public static void MultiTableInsert(EnrollmentContext enrollmentContext)
        {

            var student = new Student()
            {
                Name = "shakil",
                DateOfBirth =DateTime.Parse("10/10/1995"),
                Address = "dhaka"


            };
            var course = new Course()
            {
                Title = "PHP",
                Fees = 10000,
                DurationInHours = 40
            };


            enrollmentContext.Students.Add(student);
            enrollmentContext.Courses.Add(course);
            enrollmentContext.SaveChanges();

        }
            
            

        
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student{Name = "shakil",Age = 25},
                new Student{Name = "victor",Age = 22},
                new Student{Name = "salma",Age = 23},
                new Student{Name = "riad",Age = 12},
                new Student{Name = "Yousuf",Age = 25},
                new Student{Name = "Mashuq",Age = 25},
            };


            var student1 = from student in students
                where student.Age >= 20
                orderby student.Name ascending
               orderby student.Age descending
               select student;
            foreach (var stu in student1)
            {
                Console.WriteLine($"student name:{stu.Name},student age:{stu.Age}");
            }


        }
    }
}

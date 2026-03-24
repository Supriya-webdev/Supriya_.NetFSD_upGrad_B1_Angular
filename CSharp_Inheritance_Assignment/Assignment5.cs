using System;
using System.Collections.Generic;
using System.Text;

namespace C__Inheritance_Assignment
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public virtual void CalculateGrade()
        {
            string grade = Marks > 50 ? "Pass" : "Fail";
            Console.WriteLine($"{Name} Grade: {grade}");
        }
    }

    class SchoolStudent : Student
    {
        public override void CalculateGrade()
        {
            string grade = Marks > 40 ? "Pass" : "Fail";
            Console.WriteLine($"{Name} Grade: {grade}");
        }
    }

    class CollegeStudent : Student
    {
        public override void CalculateGrade()
        {
            string grade = Marks > 50 ? "Pass" : "Fail";
            Console.WriteLine($"{Name} Grade: {grade}");
        }
    }

    class OnlineStudent : Student
    {
        public override void CalculateGrade()
        {
            string grade = Marks > 60 ? "Pass" : "Fail";
            Console.WriteLine($"{Name} Grade: {grade}");
        }
    }

    internal class Assignment5
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
                new SchoolStudent{StudentId=1, Name="A", Marks=45},
                new CollegeStudent{StudentId=2, Name="B", Marks=55},
                new OnlineStudent{StudentId=3, Name="C", Marks=65}
            };

            foreach (var s in students)
                s.CalculateGrade(); 
        }
    }
}
    
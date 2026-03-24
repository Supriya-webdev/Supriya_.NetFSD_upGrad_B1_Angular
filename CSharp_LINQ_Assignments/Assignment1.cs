using System;
using System.Collections.Generic;
using System.Text;


namespace C__LINQ_Assignment.Assignment1Namespace
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; 
        public int Age { get; set; }
        public int Marks { get; set; }
    }
    internal class Assignment1
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student{Id=1, Name="Alice", Age=20, Marks=80},
                new Student{Id=2, Name="Bob", Age=18, Marks=70},
                new Student{Id=3, Name="Charlie", Age=22, Marks=90},
                new Student{Id=4, Name="David", Age=26, Marks=60},
                new Student{Id=5, Name="Eva", Age=24, Marks=85}
            };

            Console.WriteLine("Students with Marks > 75:");
            var highMarks = students.Where(s => s.Marks > 75);
            foreach (var s in highMarks) Console.WriteLine($"{s.Name} - {s.Marks}");

            Console.WriteLine("\nStudents aged 18-25:");
            var ageRange = students.Where(s => s.Age >= 18 && s.Age <= 25);
            foreach (var s in ageRange) Console.WriteLine($"{s.Name} - {s.Age}");

            Console.WriteLine("\nStudents sorted by Marks (descending):");
            var sortedMarks = students.OrderByDescending(s => s.Marks);
            foreach (var s in sortedMarks) Console.WriteLine($"{s.Name} - {s.Marks}");

            Console.WriteLine("\nSelect Name and Marks:");
            var selectNameMarks = students.Select(s => new { s.Name, s.Marks });
            foreach (var s in selectNameMarks) Console.WriteLine($"{s.Name} - {s.Marks}");
        }
    }
}
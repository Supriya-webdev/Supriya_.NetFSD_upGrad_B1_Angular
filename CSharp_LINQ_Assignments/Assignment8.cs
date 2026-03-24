using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignment
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Subject { get; set; }
        public int Marks { get; set; }
    }

    internal class Assignment8
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student{Id=1, Name="Alice", Class="10A", Subject="Math", Marks=80},
                new Student{Id=2, Name="Bob", Class="10A", Subject="Science", Marks=70},
                new Student{Id=3, Name="Charlie", Class="10B", Subject="Math", Marks=90},
                new Student{Id=4, Name="David", Class="10B", Subject="Science", Marks=60},
                new Student{Id=5, Name="Eva", Class="10A", Subject="Math", Marks=85},
                new Student{Id=6, Name="Frank", Class="10B", Subject="Math", Marks=75},
                new Student{Id=7, Name="Grace", Class="10A", Subject="Science", Marks=95},
            };

            var grouped = students.GroupBy(s => s.Class)
                                  .Select(g => new
                                  {
                                      Class = g.Key,
                                      Subjects = g.GroupBy(s => s.Subject)
                                                  .Select(sg => new
                                                  {
                                                      Subject = sg.Key,
                                                      Students = sg.ToList(),
                                                      AvgMarks = sg.Average(st => st.Marks)
                                                  })
                                  });

            foreach (var cls in grouped)
            {
                Console.WriteLine($"Class: {cls.Class}");
                foreach (var subj in cls.Subjects)
                {
                    Console.WriteLine($"  Subject: {subj.Subject}");
                    Console.WriteLine($"    Average Marks: {subj.AvgMarks:F2}");
                    foreach (var student in subj.Students)
                        Console.WriteLine($"    {student.Name} - {student.Marks}");
                }
            }
        }
    }
}
   

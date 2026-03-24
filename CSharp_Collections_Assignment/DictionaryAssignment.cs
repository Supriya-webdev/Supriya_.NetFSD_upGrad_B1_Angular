using System;
using System.Collections.Generic;

namespace C__Collections_Assignment
{
    class Student
    {
        public int Id;
        public string Name = "";
        public int Marks;
    }

    internal class DictionaryAssignment
    {
        static void Main()
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {1, new Student{Id=1, Name="A", Marks=80}},
                {2, new Student{Id=2, Name="B", Marks=60}},
                {3, new Student{Id=3, Name="C", Marks=90}},
                {4, new Student{Id=4, Name="D", Marks=70}},
                {5, new Student{Id=5, Name="E", Marks=85}}
            };

            Console.WriteLine("Student with ID 3: " + students[3].Name);
            Console.WriteLine("Exists ID 2? " + (students.ContainsKey(2) ? "Yes" : "No"));

            students[2].Marks = 75; 
            students.Remove(4);     

            Console.WriteLine("\nStudents with Marks > 75:");
            foreach (var s in students.Values)
                if (s.Marks > 75)
                    Console.WriteLine(s.Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignment
{
    class Employee4
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public double Salary { get; set; }
    }
    internal class Assignment4
    {
        static void Main()
        {
            List<Employee4> employees = new List<Employee4>
            {
                new Employee4{Id=1, Name="Alice", Department="IT", Salary=5000},
                new Employee4{Id=2, Name="Bob", Department="HR", Salary=4000},
                new Employee4{Id=3, Name="Charlie", Department="IT", Salary=6000},
                new Employee4{Id=4, Name="David", Department="Finance", Salary=5500},
                new Employee4{Id=5, Name="Eva", Department="HR", Salary=4500},
            };

            var itEmployees = employees.Where(e => e.Department == "IT");
            Console.WriteLine("Employees in IT:");
            foreach (var e in itEmployees) Console.WriteLine($"{e.Name} - {e.Department}");

            var highestSalary = employees.OrderByDescending(e => e.Salary).First();
            Console.WriteLine($"\nHighest Salary: {highestSalary.Name} - {highestSalary.Salary}");

            var avgSalary = employees.Average(e => e.Salary);
            Console.WriteLine($"\nAverage Salary: {avgSalary}");

            var groupByDept = employees.GroupBy(e => e.Department);
            Console.WriteLine("\nEmployees grouped by Department:");
            foreach (var grp in groupByDept)
            {
                Console.WriteLine($"\nDepartment: {grp.Key}");
                foreach (var e in grp) Console.WriteLine($"{e.Name} - {e.Salary}");
            }

            Console.WriteLine("\nEmployee count per Department:");
            foreach (var grp in groupByDept) Console.WriteLine($"{grp.Key}: {grp.Count()}");
        }
    }
}
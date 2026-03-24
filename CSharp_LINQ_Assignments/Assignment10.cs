using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignment.Assignment10Namespace
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; 
        public string Department { get; set; } = string.Empty; 
        public double Salary { get; set; }
    }
    internal class Assignment10
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Department = "IT", Salary = 70000 },
                new Employee { Id = 2, Name = "Bob", Department = "HR", Salary = 50000 },
                new Employee { Id = 3, Name = "Charlie", Department = "IT", Salary = 90000 },
                new Employee { Id = 4, Name = "David", Department = "Finance", Salary = 60000 },
                new Employee { Id = 5, Name = "Eva", Department = "HR", Salary = 75000 }
            };

            var sortedEmployees = employees
                .OrderBy(e => e.Department)
                .ThenByDescending(e => e.Salary);

            Console.WriteLine("Employees sorted by Department (asc) and Salary (desc):");
            foreach (var e in sortedEmployees)
            {
                Console.WriteLine($"{e.Department} - {e.Name} - {e.Salary}");
            }
        }
    }
}
  

using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignment
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }
    }
    internal class Assignment15
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Department = "IT", Salary = 70000, JoiningDate = DateTime.Now.AddMonths(-2) },
                new Employee { Id = 2, Name = "Bob", Department = "HR", Salary = 50000, JoiningDate = DateTime.Now.AddMonths(-8) },
                new Employee { Id = 3, Name = "Charlie", Department = "IT", Salary = 90000, JoiningDate = DateTime.Now.AddMonths(-1) },
                new Employee { Id = 4, Name = "David", Department = "Finance", Salary = 60000, JoiningDate = DateTime.Now.AddMonths(-12) },
                new Employee { Id = 5, Name = "Eva", Department = "HR", Salary = 75000, JoiningDate = DateTime.Now.AddMonths(-4) }
            };

            Console.WriteLine($"Total Employees: {employees.Count}");

            var deptAvgSalary = employees.GroupBy(e => e.Department)
                                         .Select(g => new { Department = g.Key, AvgSalary = g.Average(e => e.Salary) });
            Console.WriteLine("\nDepartment-wise Average Salary:");
            foreach (var d in deptAvgSalary)
                Console.WriteLine($"{d.Department} - {d.AvgSalary}");

            var recentEmployees = employees.Where(e => e.JoiningDate >= DateTime.Now.AddMonths(-6));
            Console.WriteLine("\nRecently Joined Employees (Last 6 months):");
            foreach (var e in recentEmployees)
                Console.WriteLine($"{e.Name} - {e.JoiningDate.ToShortDateString()}");

            var highestPaid = employees.GroupBy(e => e.Department)
                                       .Select(g => new { Department = g.Key, Employee = g.OrderByDescending(e => e.Salary).First() });
            Console.WriteLine("\nHighest Paid Employee per Department:");
            foreach (var h in highestPaid)
                Console.WriteLine($"{h.Department} - {h.Employee.Name} - {h.Employee.Salary}");

            double minSalary = employees.Min(e => e.Salary);
            double maxSalary = employees.Max(e => e.Salary);
            double avgSalary = employees.Average(e => e.Salary);
            Console.WriteLine("\nSalary Distribution:");
            Console.WriteLine($"Min: {minSalary}, Max: {maxSalary}, Avg: {avgSalary}");
        }
    }
}
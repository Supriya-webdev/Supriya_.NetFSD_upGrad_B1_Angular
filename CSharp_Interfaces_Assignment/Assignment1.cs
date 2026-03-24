using System;
using System.Collections.Generic;
using System.Text;

namespace C__Interfaces_Assingment
{
    public interface GovtRules
    {
        double EmployeePF(double basicSalary);
        string LeaveDetails();
        double GratuityAmount(float serviceCompleted, double basicSalary);
    }

    class TCS : GovtRules
    {
        public int EmpId { get; private set; }
        public string Name { get; private set; }
        public string Dept { get; private set; }
        public string Desg { get; private set; }
        public double BasicSalary { get; private set; }

        public TCS(int empId, string name, string dept, string desg, double basicSalary)
        {
            EmpId = empId;
            Name = name;
            Dept = dept;
            Desg = desg;
            BasicSalary = basicSalary;
        }

        public double EmployeePF(double basicSalary)
        {
            double employeePF = basicSalary * 0.12;
            double employerPF = basicSalary * 0.0833;
            double pensionFund = employerPF * 0.0367;
            Console.WriteLine($"Employee PF: {employeePF:F2}, Employer PF: {employerPF:F2}, Pension Fund: {pensionFund:F2}");
            return employeePF + employerPF + pensionFund;
        }

        public string LeaveDetails()
        {
            return "Casual Leave: 1/day per month\nSick Leave: 12 days/year\nPrivilege Leave: 10 days/year";
        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted < 5) return 0;
            else if (serviceCompleted <= 10) return basicSalary * 1;
            else if (serviceCompleted <= 20) return basicSalary * 2;
            else return basicSalary * 3;
        }
    }

    class Accenture : GovtRules
    {
        public int EmpId { get; private set; }
        public string Name { get; private set; }
        public string Dept { get; private set; }
        public string Desg { get; private set; }
        public double BasicSalary { get; private set; }

        public Accenture(int empId, string name, string dept, string desg, double basicSalary)
        {
            EmpId = empId;
            Name = name;
            Dept = dept;
            Desg = desg;
            BasicSalary = basicSalary;
        }

        public double EmployeePF(double basicSalary)
        {
            double employeePF = basicSalary * 0.12;
            double employerPF = basicSalary * 0.12;
            Console.WriteLine($"Employee PF: {employeePF:F2}, Employer PF: {employerPF:F2}");
            return employeePF + employerPF;
        }

        public string LeaveDetails()
        {
            return "Casual Leave: 2/day per month\nSick Leave: 5 days/year\nPrivilege Leave: 5 days/year";
        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0; 
        }
    }
    internal class Assignment1
    {
        static void Main()
        {
            Console.WriteLine("---- TCS Employee ----");
            TCS tcsEmp = new TCS(101, "Alice", "IT", "Developer", 50000);
            Console.WriteLine($"Employee: {tcsEmp.Name}, Dept: {tcsEmp.Dept}, Basic: {tcsEmp.BasicSalary}");
            tcsEmp.EmployeePF(tcsEmp.BasicSalary);
            Console.WriteLine("Leave Details:\n" + tcsEmp.LeaveDetails());
            Console.WriteLine("Gratuity Amount for 12 years: " + tcsEmp.GratuityAmount(12, tcsEmp.BasicSalary));

            Console.WriteLine("\n---- Accenture Employee ----");
            Accenture accEmp = new Accenture(201, "Bob", "HR", "Manager", 40000);
            Console.WriteLine($"Employee: {accEmp.Name}, Dept: {accEmp.Dept}, Basic: {accEmp.BasicSalary}");
            accEmp.EmployeePF(accEmp.BasicSalary);
            Console.WriteLine("Leave Details:\n" + accEmp.LeaveDetails());
            Console.WriteLine("Gratuity Amount: " + accEmp.GratuityAmount(8, accEmp.BasicSalary));
        }
    }
}
  

using System;
using System.Collections.Generic;

namespace C__Inheritance_Assignment
{
    // Base Class
    public class Staff
    {
        public int StaffId { get; set; }
        public string Name { get; set; } = string.Empty; // non-nullable
        public double BaseSalary { get; set; }

        // Virtual method for polymorphism
        public virtual double CalculateSalary()
        {
            return BaseSalary; // generic staff salary
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {StaffId}, Name: {Name}, Salary: {CalculateSalary()}");
        }
    }

    // Derived class Doctor
    public class Doctor : Staff
    {
        public double ConsultationFee { get; set; }

        public override double CalculateSalary()
        {
            return BaseSalary + ConsultationFee;
        }
    }

    // Derived class Nurse
    public class Nurse : Staff
    {
        public double NightShiftAllowance { get; set; }

        public override double CalculateSalary()
        {
            return BaseSalary + NightShiftAllowance;
        }
    }

    // Derived class LabTechnician
    public class LabTechnician : Staff
    {
        public double EquipmentAllowance { get; set; }

        public override double CalculateSalary()
        {
            return BaseSalary + EquipmentAllowance;
        }
    }

    // Test program
    internal class Assignment1
    {
        static void Main()
        {
            List<Staff> staffList = new List<Staff>
            {
                new Doctor { StaffId = 1, Name = "Dr. Smith", BaseSalary = 50000, ConsultationFee = 20000 },
                new Nurse { StaffId = 2, Name = "Nurse Amy", BaseSalary = 30000, NightShiftAllowance = 5000 },
                new LabTechnician { StaffId = 3, Name = "Lab John", BaseSalary = 25000, EquipmentAllowance = 3000 }
            };

            Console.WriteLine("Healthcare Staff Salaries:\n");

            foreach (var staff in staffList)
            {
                staff.ShowInfo();
            }
        }
    }
}
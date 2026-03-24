using System;
using System.Collections.Generic;
using System.Text;

namespace C__File_Handling_assignment
{
    internal class Assignment2
    {
        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nStudent Report Card System");
                Console.WriteLine("1. Add Student Report");
                Console.WriteLine("2. View Student Report");
                Console.WriteLine("3. Exit");
                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddReport();
                        break;
                    case "2":
                        ViewReport();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void AddReport()
        {
            try
            {
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Roll Number: ");
                string roll = Console.ReadLine();

                int[] marks = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Enter marks for subject {i + 1}: ");
                    marks[i] = int.Parse(Console.ReadLine());
                }

                int total = marks[0] + marks[1] + marks[2];
                double average = total / 3.0;
                string grade = average >= 75 ? "A" :
                               average >= 60 ? "B" :
                               average >= 40 ? "C" : "Fail";

                string fileName = roll + ".txt";
                string content = $"Student Name: {name}\nRoll Number: {roll}\nMarks: {marks[0]}, {marks[1]}, {marks[2]}\nTotal: {total}\nAverage: {average:F2}\nGrade: {grade}";
                File.WriteAllText(fileName, content);

                Console.WriteLine("Report saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void ViewReport()
        {
            try
            {
                Console.Write("Enter Roll Number to view report: ");
                string roll = Console.ReadLine();
                string fileName = roll + ".txt";

                if (!File.Exists(fileName))
                {
                    Console.WriteLine("Report not found.");
                    return;
                }

                string content = File.ReadAllText(fileName);
                Console.WriteLine("\n" + content);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
   

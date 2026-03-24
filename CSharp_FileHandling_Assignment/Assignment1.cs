using System;
using System.Collections.Generic;
using System.Text;

namespace C__File_Handling_assignment
{
    internal class Assignment1
    {
        private static string filePath = "employee_log.txt";
        static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nEmployee Log System");
                Console.WriteLine("1. Add Login Entry");
                Console.WriteLine("2. Update Logout Time");
                Console.WriteLine("3. Display Logs");
                Console.WriteLine("4. Exit");
                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddLogin(); break;
                    case "2": UpdateLogout(); break;
                    case "3": DisplayLogs(); break;
                    case "4": exit = true; break;
                    default: Console.WriteLine("Invalid option!"); break;
                }
            }
        }

        static void AddLogin()
        {
            try
            {
                Console.Write("Enter Employee Id: ");
                string id = Console.ReadLine();
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                string loginTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Ensure file exists and append
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"{id} | {name} | {loginTime} | -");
                }

                Console.WriteLine("Login entry added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while adding login: " + ex.Message);
            }
        }

        static void UpdateLogout()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("No log file exists yet.");
                    return;
                }

                Console.Write("Enter Employee Id to logout: ");
                string id = Console.ReadLine();
                string[] lines = File.ReadAllLines(filePath);
                bool found = false;

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('|');
                    if (parts[0].Trim() == id)
                    {
                        if (parts[3].Trim() != "-")
                        {
                            Console.WriteLine("Logout already recorded for this employee.");
                        }
                        else
                        {
                            parts[3] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            lines[i] = string.Join(" | ", parts);
                            Console.WriteLine("Logout time updated successfully.");
                        }
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Employee ID not found.");
                }
                else
                {
                    File.WriteAllLines(filePath, lines);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while updating logout: " + ex.Message);
            }
        }

        static void DisplayLogs()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("No logs found.");
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine("\nEmployee Logs:");
                Console.WriteLine("ID | Name | LoginTime | LogoutTime");
                Console.WriteLine("-----------------------------------------");

                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while displaying logs: " + ex.Message);
            }
        }
    }
}
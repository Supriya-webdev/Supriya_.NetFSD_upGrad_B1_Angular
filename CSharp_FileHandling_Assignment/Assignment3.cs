using System;
using System.Collections.Generic;
using System.Text;

namespace C__File_Handling_assignment
{
    internal class Assignment3
    {
        static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nMini Notepad");
                Console.WriteLine("1. Create New File");
                Console.WriteLine("2. Write to File");
                Console.WriteLine("3. Read File");
                Console.WriteLine("4. Append Text");
                Console.WriteLine("5. Delete File");
                Console.WriteLine("6. Exit");
                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": CreateFile(); break;
                    case "2": WriteToFile(); break;
                    case "3": ReadFile(); break;
                    case "4": AppendText(); break;
                    case "5": DeleteFile(); break;
                    case "6": exit = true; break;
                    default: Console.WriteLine("Invalid choice!"); break;
                }
            }
        }

        static void CreateFile()
        {
            try
            {
                Console.Write("Enter file name: ");
                string name = Console.ReadLine();
                if (!name.EndsWith(".txt")) name += ".txt";

                if (File.Exists(name))
                    Console.WriteLine("File already exists.");
                else
                {
                    File.Create(name).Close();
                    Console.WriteLine("File created successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void WriteToFile()
        {
            try
            {
                Console.Write("Enter file name: ");
                string name = Console.ReadLine();
                if (!name.EndsWith(".txt")) name += ".txt";

                using (StreamWriter sw = new StreamWriter(name))
                {
                    Console.WriteLine("Enter text (type 'END' on a new line to finish):");
                    string line;
                    while ((line = Console.ReadLine()) != "END")
                    {
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine("Text written successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void AppendText()
        {
            try
            {
                Console.Write("Enter file name: ");
                string name = Console.ReadLine();
                if (!name.EndsWith(".txt")) name += ".txt";

                using (StreamWriter sw = new StreamWriter(name, true))
                {
                    Console.WriteLine("Enter text to append (type 'END' on a new line to finish):");
                    string line;
                    while ((line = Console.ReadLine()) != "END")
                    {
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine("Text appended successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void ReadFile()
        {
            try
            {
                Console.Write("Enter file name: ");
                string name = Console.ReadLine();
                if (!name.EndsWith(".txt")) name += ".txt";

                if (!File.Exists(name))
                {
                    Console.WriteLine("File not found.");
                    return;
                }

                string content = File.ReadAllText(name);
                Console.WriteLine("\nFile Content:\n" + content);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void DeleteFile()
        {
            try
            {
                Console.Write("Enter file name to delete: ");
                string name = Console.ReadLine();
                if (!name.EndsWith(".txt")) name += ".txt";

                if (!File.Exists(name))
                {
                    Console.WriteLine("File not found.");
                    return;
                }

                File.Delete(name);
                Console.WriteLine("File deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
    

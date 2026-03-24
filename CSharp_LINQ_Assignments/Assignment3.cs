using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignment.Assignment3Namespace
{
    internal class Assignment3
    {
        static void Main()
        {
            List<string> names = new List<string> { "Ravi", "Kiran", "Amit", "Raj", "Anil" };

            var startA = names.Where(n => n.StartsWith("A"));
            Console.WriteLine("Names starting with 'A':");
            foreach (var n in startA) Console.WriteLine(n);

            var sorted = names.OrderBy(n => n);
            Console.WriteLine("\nSorted alphabetically:");
            foreach (var n in sorted) Console.WriteLine(n);

            var upper = names.Select(n => n.ToUpper());
            Console.WriteLine("\nNames in uppercase:");
            foreach (var n in upper) Console.WriteLine(n);

            var longNames = names.Where(n => n.Length > 4);
            Console.WriteLine("\nNames with length > 4:");
            foreach (var n in longNames) Console.WriteLine(n);
        }
    }
}
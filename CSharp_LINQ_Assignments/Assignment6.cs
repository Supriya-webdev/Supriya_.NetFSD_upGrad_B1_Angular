using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignment.Assignment6Namespace
{
    internal class Assignment6
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6 };

            var distinctNumbers = numbers.Distinct();
            Console.WriteLine("Distinct Numbers:");
            foreach (var n in distinctNumbers)
                Console.WriteLine(n);

            var duplicates = numbers.GroupBy(n => n)
                                    .Where(g => g.Count() > 1)
                                    .Select(g => g.Key);
            Console.WriteLine("\nDuplicate Numbers:");
            foreach (var n in duplicates)
                Console.WriteLine(n);

            var countPerNumber = numbers.GroupBy(n => n)
                                        .Select(g => new { Number = g.Key, Count = g.Count() });
            Console.WriteLine("\nCount of Each Number:");
            foreach (var item in countPerNumber)
                Console.WriteLine($"{item.Number} - {item.Count}");
        }
    }
}
    

using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignment.Assignment2Namespace
{
    internal class Assignment2
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30 };

            var even = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even numbers:");
            foreach (var n in even) Console.WriteLine(n);

            var greater15 = numbers.Where(n => n > 15);
            Console.WriteLine("\nNumbers > 15:");
            foreach (var n in greater15) Console.WriteLine(n);

            var squares = numbers.Select(n => n * n);
            Console.WriteLine("\nSquare of each number:");
            foreach (var n in squares) Console.WriteLine(n);

            var countDiv5 = numbers.Count(n => n % 5 == 0);
            Console.WriteLine("\nCount of numbers divisible by 5:");
            Console.WriteLine(countDiv5);
        }
    }
}
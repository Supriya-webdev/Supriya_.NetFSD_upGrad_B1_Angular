using System;
using System.Collections.Generic;
using System.Text;

namespace C__Multithreading_Assignment
{
    internal class Assignment1
    {
        static int[] partialSums = new int[5]; 

        static void Main()
        {
            List<int> numbers = Enumerable.Range(1, 50).ToList(); 
            int size = numbers.Count / 5;

            Thread[] threads = new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                int index = i; 
                threads[i] = new Thread(() =>
                {
                    List<int> part = numbers.Skip(index * size).Take(size).ToList();
                    int sum = 0;
                    Console.WriteLine($"Thread {index + 1} processing: {string.Join(", ", part)}");
                    foreach (var num in part)
                        sum += num;

                    partialSums[index] = sum;
                    Console.WriteLine($"Thread {index + 1} Sum: {sum}");
                });
                threads[i].Start();
            }

            foreach (var t in threads)
                t.Join();

            int finalSum = partialSums.Sum();
            Console.WriteLine($"\nFinal Sum: {finalSum}");
        }
    }
}
  
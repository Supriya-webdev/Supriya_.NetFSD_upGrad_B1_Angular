using System;
using System.Collections.Generic;
using System.Text;

namespace C__Collections_Assignment
{
    internal class HashSetAssignment
    {
        static void Main()
        {
            HashSet<string> emails = new HashSet<string>()
            {
                "a@gmail.com","b@gmail.com","c@gmail.com","a@gmail.com",
                "d@gmail.com","e@gmail.com","f@gmail.com","g@gmail.com",
                "h@gmail.com","i@gmail.com"
            };

            Console.WriteLine("Unique Emails:");
            foreach (var e in emails)
                Console.WriteLine(e);

            Console.WriteLine("\nCheck if a@gmail.com exists: " + (emails.Contains("a@gmail.com") ? "Yes" : "No"));

            emails.Remove("b@gmail.com");

            HashSet<string> event2 = new HashSet<string> { "a@gmail.com", "x@gmail.com", "c@gmail.com" };
            var common = emails.Intersect(event2);
            Console.WriteLine("\nCommon Participants:");
            foreach (var e in common)
                Console.WriteLine(e);
        }
    }
}

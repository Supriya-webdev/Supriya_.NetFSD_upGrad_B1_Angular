using System;
using System.Collections.Generic;
using System.Text;

namespace C__Collections_Assignment
{

    class Patient
    {
        public int Id;
        public string Name = "";
        public string Disease = "";
        public bool IsVIP = false;
    }


    internal class QueueAssignment
    {
        static void Main()
        {
            Queue<Patient> queue = new Queue<Patient>();
            queue.Enqueue(new Patient { Id = 1, Name = "A", Disease = "Fever" });
            queue.Enqueue(new Patient { Id = 2, Name = "B", Disease = "Cold", IsVIP = true });
            queue.Enqueue(new Patient { Id = 3, Name = "C", Disease = "Flu" });
            queue.Enqueue(new Patient { Id = 4, Name = "D", Disease = "Cough" });
            queue.Enqueue(new Patient { Id = 5, Name = "E", Disease = "Headache" });

            Patient nextVIP = null;
            foreach (var p in queue)
            {
                if (p.IsVIP)
                {
                    nextVIP = p;
                    break;
                }
            }
            if (nextVIP != null)
            {
                Console.WriteLine("Serving VIP: " + nextVIP.Name);
                var temp = new Queue<Patient>();
                while (queue.Count > 0)
                {
                    var p = queue.Dequeue();
                    if (p != nextVIP) temp.Enqueue(p);
                }
                queue = temp;
            }

            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine("Next Patient: " + queue.Peek().Name);

            Console.WriteLine("Remaining Patients:");
            foreach (var p in queue)
                Console.WriteLine(p.Name);
        }
    }
}
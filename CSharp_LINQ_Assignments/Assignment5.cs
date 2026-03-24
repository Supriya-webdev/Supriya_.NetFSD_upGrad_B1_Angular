using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignment.Assignment5Namespace
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; 
    }

    class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public double Amount { get; set; }
    }

    internal class Assignment5
    {
        static void Main()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Alice" },
                new Customer { Id = 2, Name = "Bob" },
                new Customer { Id = 3, Name = "Charlie" },
                new Customer { Id = 4, Name = "David" }
            };

            List<Order> orders = new List<Order>
            {
                new Order { Id = 1, CustomerId = 1, Amount = 2000 },
                new Order { Id = 2, CustomerId = 1, Amount = 1500 },
                new Order { Id = 3, CustomerId = 2, Amount = 3000 },
                new Order { Id = 4, CustomerId = 3, Amount = 7000 }
            };

            var customerOrders = from c in customers
                                 join o in orders on c.Id equals o.CustomerId
                                 select new { c.Name, o.Amount };

            Console.WriteLine("Customer Orders:");
            foreach (var co in customerOrders)
                Console.WriteLine($"{co.Name} - {co.Amount}");

            var totalPerCustomer = orders
                .GroupBy(o => o.CustomerId)
                .Select(g => new
                {
                    Customer = customers.First(c => c.Id == g.Key).Name,
                    TotalAmount = g.Sum(o => o.Amount)
                });

            Console.WriteLine("\nTotal Orders per Customer:");
            foreach (var t in totalPerCustomer)
                Console.WriteLine($"{t.Customer} - {t.TotalAmount}");

            var highValueCustomers = totalPerCustomer.Where(t => t.TotalAmount > 5000);
            Console.WriteLine("\nCustomers with total orders > 5000:");
            foreach (var t in highValueCustomers)
                Console.WriteLine($"{t.Customer} - {t.TotalAmount}");

            var noOrders = customers.Where(c => !orders.Any(o => o.CustomerId == c.Id));
            Console.WriteLine("\nCustomers with no orders:");
            foreach (var c in noOrders)
                Console.WriteLine(c.Name);
        }
    }
}
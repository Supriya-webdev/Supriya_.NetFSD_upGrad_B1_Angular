using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignment
{
    class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
    }
    internal class Assignment9
    {
        static void Main()
        {
            List<Order> orders = new List<Order>
            {
                new Order{Id=1, CustomerName="Alice", OrderDate=DateTime.Now.AddDays(-5), TotalAmount=1200},
                new Order{Id=2, CustomerName="Bob", OrderDate=DateTime.Now.AddDays(-15), TotalAmount=2500},
                new Order{Id=3, CustomerName="Charlie", OrderDate=DateTime.Now.AddDays(-40), TotalAmount=3000},
                new Order{Id=4, CustomerName="Alice", OrderDate=DateTime.Now.AddDays(-10), TotalAmount=1800},
                new Order{Id=5, CustomerName="Eva", OrderDate=DateTime.Now.AddDays(-2), TotalAmount=2200},
                new Order{Id=6, CustomerName="Bob", OrderDate=DateTime.Now.AddDays(-25), TotalAmount=1500},
                new Order{Id=7, CustomerName="Charlie", OrderDate=DateTime.Now.AddDays(-5), TotalAmount=4000},
            };

            var recentOrders = orders.Where(o => o.OrderDate >= DateTime.Now.AddDays(-30));
            Console.WriteLine("Recent Orders (last 30 days):");
            foreach (var o in recentOrders)
                Console.WriteLine($"{o.CustomerName} - {o.TotalAmount} - {o.OrderDate:d}");

            var monthlySales = orders.GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
                                     .Select(g => new
                                     {
                                         Month = g.Key,
                                         TotalSales = g.Sum(o => o.TotalAmount)
                                     });
            Console.WriteLine("\nMonthly Sales Report:");
            foreach (var ms in monthlySales)
                Console.WriteLine($"{ms.Month.Month}/{ms.Month.Year} - Total Sales: {ms.TotalSales}");

            var topCustomers = orders.GroupBy(o => o.CustomerName)
                                     .Select(g => new { Customer = g.Key, TotalSpent = g.Sum(o => o.TotalAmount) })
                                     .OrderByDescending(c => c.TotalSpent)
                                     .Take(5);
            Console.WriteLine("\nTop 5 Customers:");
            foreach (var c in topCustomers)
                Console.WriteLine($"{c.Customer} - {c.TotalSpent}");

            var highestPerMonth = orders.GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
                                        .Select(g => new
                                        {
                                            Month = g.Key,
                                            MaxOrder = g.OrderByDescending(o => o.TotalAmount).First()
                                        });
            Console.WriteLine("\nHighest Order Per Month:");
            foreach (var h in highestPerMonth)
                Console.WriteLine($"{h.Month.Month}/{h.Month.Year} - {h.MaxOrder.CustomerName}: {h.MaxOrder.TotalAmount}");
        }
    }
}
   
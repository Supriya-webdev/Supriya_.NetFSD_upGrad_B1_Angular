using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ_Assignment
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }

    internal class Assignment7
    {
        static void Main()
        {
            List<Product> products = new List<Product>
            {
                new Product{Id=1, Name="Laptop", Category="Electronics", Price=50000, Stock=5},
                new Product{Id=2, Name="Phone", Category="Electronics", Price=20000, Stock=15},
                new Product{Id=3, Name="Shoes", Category="Fashion", Price=1500, Stock=8},
                new Product{Id=4, Name="Watch", Category="Accessories", Price=3000, Stock=20},
                new Product{Id=5, Name="Bag", Category="Fashion", Price=1200, Stock=12},
                new Product{Id=6, Name="TV", Category="Electronics", Price=40000, Stock=3},
                new Product{Id=7, Name="Headphones", Category="Electronics", Price=800, Stock=25},
                new Product{Id=8, Name="Keyboard", Category="Electronics", Price=1500, Stock=7},
                new Product{Id=9, Name="Mouse", Category="Electronics", Price=700, Stock=0},
                new Product{Id=10, Name="Chair", Category="Furniture", Price=2500, Stock=2}
            };

            var lowStock = products.Where(p => p.Stock < 10);
            Console.WriteLine("Products with Stock < 10:");
            foreach (var p in lowStock)
                Console.WriteLine($"{p.Name} - {p.Stock}");

            var top3Expensive = products.OrderByDescending(p => p.Price).Take(3);
            Console.WriteLine("\nTop 3 Expensive Products:");
            foreach (var p in top3Expensive)
                Console.WriteLine($"{p.Name} - {p.Price}");

            var groupedByCategory = products.GroupBy(p => p.Category);
            Console.WriteLine("\nProducts Grouped by Category:");
            foreach (var group in groupedByCategory)
            {
                Console.WriteLine($"\nCategory: {group.Key}");
                foreach (var p in group)
                    Console.WriteLine($"  {p.Name} - Stock: {p.Stock}, Price: {p.Price}");
            }

            var stockPerCategory = products.GroupBy(p => p.Category)
                                           .Select(g => new { Category = g.Key, TotalStock = g.Sum(p => p.Stock) });
            Console.WriteLine("\nTotal Stock per Category:");
            foreach (var item in stockPerCategory)
                Console.WriteLine($"{item.Category} - {item.TotalStock}");

            bool anyOutOfStock = products.Any(p => p.Stock == 0);
            Console.WriteLine($"\nAny product out of stock? {(anyOutOfStock ? "Yes" : "No")}");
        }
    }
}
    

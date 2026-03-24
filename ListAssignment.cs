using System;
using System.Collections.Generic;
using System.Linq;

namespace C__Collections_Assignment
{
    class Product
    {
        public int Id;
        public string Name = "";
        public double Price;
        public string Category = "";
    }

    internal class ListAssignment
    {
        static void Main()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1, Name="Laptop", Price=50000, Category="Electronics"},
                new Product{Id=2, Name="Phone", Price=20000, Category="Electronics"},
                new Product{Id=3, Name="Shoes", Price=1500, Category="Fashion"},
                new Product{Id=4, Name="Watch", Price=3000, Category="Accessories"},
                new Product{Id=5, Name="Bag", Price=1200, Category="Fashion"},
                new Product{Id=6, Name="TV", Price=40000, Category="Electronics"},
                new Product{Id=7, Name="Headphones", Price=800, Category="Electronics"},
                new Product{Id=8, Name="Keyboard", Price=1500, Category="Electronics"},
                new Product{Id=9, Name="Mouse", Price=700, Category="Electronics"},
                new Product{Id=10, Name="Chair", Price=2500, Category="Furniture"}
            };

            Console.WriteLine("All Products:");
            foreach (var p in products)
                Console.WriteLine($"{p.Id} {p.Name} {p.Price}");

            Console.WriteLine("\nPrice > 1000:");
            foreach (var p in products.Where(p => p.Price > 1000))
                Console.WriteLine(p.Name);

            Console.WriteLine("\nSorted Ascending:");
            foreach (var p in products.OrderBy(p => p.Price))
                Console.WriteLine($"{p.Name} {p.Price}");

            Console.WriteLine("\nSorted Descending:");
            foreach (var p in products.OrderByDescending(p => p.Price))
                Console.WriteLine($"{p.Name} {p.Price}");

            products.RemoveAll(p => p.Id == 3);
            Console.WriteLine("\nAfter Removal (Id=3):");
            foreach (var p in products)
                Console.WriteLine(p.Name);

            Console.WriteLine("\nElectronics Products:");
            foreach (var p in products.Where(p => p.Category == "Electronics"))
                Console.WriteLine(p.Name);
        }
    }
}
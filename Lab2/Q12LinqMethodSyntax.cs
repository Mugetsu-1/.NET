using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    internal class LinqMethodSyntaxDemo
    {
        /*
        static void Main(string[] args)
        {
          

            // Data source: Array of integers
            int[] numbers = { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };

            // Data source: List of products
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200.00, Stock = 15 },
                new Product { Id = 2, Name = "Mouse", Category = "Electronics", Price = 25.00, Stock = 100 },
                new Product { Id = 3, Name = "Keyboard", Category = "Electronics", Price = 75.00, Stock = 50 },
                new Product { Id = 4, Name = "Desk Chair", Category = "Furniture", Price = 350.00, Stock = 10 },
                new Product { Id = 5, Name = "Notebook", Category = "Stationery", Price = 5.00, Stock = 200 },
                new Product { Id = 6, Name = "Pen Set", Category = "Stationery", Price = 12.00, Stock = 150 },
                new Product { Id = 7, Name = "Monitor", Category = "Electronics", Price = 450.00, Stock = 8 },
                new Product { Id = 8, Name = "Desk Lamp", Category = "Furniture", Price = 45.00, Stock = 30 }
            };

            // 1. Where - Filtering
            Console.WriteLine("1. Where() - Filtering:");
            var expensiveProducts = products.Where(p => p.Price > 100);
            Console.WriteLine("   Products with price > $100:");
            foreach (var p in expensiveProducts)
                Console.WriteLine($"   {p.Name}: ${p.Price}");
            Console.WriteLine();

            // 2. Select - Projection
            Console.WriteLine("2. Select() - Projection:");
            var productNames = products.Select(p => p.Name);
            Console.WriteLine($"   Product names: {string.Join(", ", productNames)}");
            Console.WriteLine();

            // 3. OrderBy / ThenBy - Sorting
            Console.WriteLine("3. OrderBy() / ThenBy() - Sorting:");
            var sortedProducts = products
                .Where(p => p.Stock > 10)
                .OrderBy(p => p.Category)
                .ThenByDescending(p => p.Price);
            Console.WriteLine("   Products (by Category, then Price descending):");
            foreach (var p in sortedProducts)
                Console.WriteLine($"   [{p.Category}] {p.Name}: ${p.Price} (Stock: {p.Stock})");
            Console.WriteLine();

            // 4. First / FirstOrDefault
            Console.WriteLine("4. First() / FirstOrDefault():");
            var firstElectronic = products.First(p => p.Category == "Electronics");
            Console.WriteLine($"   First electronic: {firstElectronic.Name} (${firstElectronic.Price})");
            var cheapProduct = products.FirstOrDefault(p => p.Price < 10);
            Console.WriteLine($"   First product under $10: {cheapProduct?.Name ?? "None"}");
            Console.WriteLine();

            // 5. Any / All
            Console.WriteLine("5. Any() / All():");
            bool hasExpensive = products.Any(p => p.Price > 1000);
            bool allInStock = products.All(p => p.Stock > 0);
            Console.WriteLine($"   Any product > $1000? {hasExpensive}");
            Console.WriteLine($"   All products in stock? {allInStock}");
            Console.WriteLine();

            // 6. Count / Sum / Average / Min / Max
            Console.WriteLine("6. Aggregation methods:");
            Console.WriteLine($"   Total products: {products.Count()}");
            Console.WriteLine($"   Total stock: {products.Sum(p => p.Stock)}");
            Console.WriteLine($"   Average price: ${products.Average(p => p.Price):F2}");
            Console.WriteLine($"   Min price: ${products.Min(p => p.Price):F2}");
            Console.WriteLine($"   Max price: ${products.Max(p => p.Price):F2}");
            Console.WriteLine();

            // 7. GroupBy
            Console.WriteLine("7. GroupBy():");
            var groupedByCategory = products.GroupBy(p => p.Category);
            foreach (var group in groupedByCategory)
            {
                Console.WriteLine($"   Category: {group.Key} ({group.Count()} products)");
                Console.WriteLine($"     Total value: ${group.Sum(p => p.Price * p.Stock):F2}");
                foreach (var p in group)
                    Console.WriteLine($"     - {p.Name} (${p.Price})");
            }
            Console.WriteLine();

            // 8. SelectMany - Flattening
            Console.WriteLine("8. SelectMany() - Flattening:");
            var categories = new[]
            {
                new { Category = "Electronics", Items = new[] { "Laptop", "Mouse", "Keyboard" } },
                new { Category = "Furniture", Items = new[] { "Chair", "Desk", "Lamp" } }
            };
            var allItems = categories.SelectMany(c => c.Items);
            Console.WriteLine($"   All items: {string.Join(", ", allItems)}");
            Console.WriteLine();

            // 9. Take / Skip
            Console.WriteLine("9. Take() / Skip():");
            var top3 = products.OrderByDescending(p => p.Price).Take(3);
            Console.WriteLine("   Top 3 most expensive products:");
            foreach (var p in top3)
                Console.WriteLine($"   {p.Name}: ${p.Price}");
            Console.WriteLine();

            // 10. Chaining multiple methods
            Console.WriteLine("10. Method chaining example:");
            var result = products
                .Where(p => p.Category == "Electronics" && p.Stock >= 10)
                .OrderBy(p => p.Price)
                .Select(p => $"{p.Name} (${p.Price}) - Stock: {p.Stock}");
            Console.WriteLine("   Affordable electronics in stock:");
            foreach (var item in result)
                Console.WriteLine($"   {item}");
        }
        */
    }

    // Helper class for the demo
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
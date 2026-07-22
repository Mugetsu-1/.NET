using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    internal class LinqQuerySyntaxDemo
    {
        /*
        static void Main(string[] args)
        {
            

            // Data source: Array of integers
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Data source: List of strings
            List<string> fruits = new List<string>
            {
                "Apple", "Banana", "Cherry", "Date", "Elderberry",
                "Fig", "Grape", "Kiwi", "Lemon", "Mango"
            };

            // Data source: Array of custom objects
            var students = new[]
            {
                new { Id = 1, Name = "Alice", Age = 20, Grade = 'A', City = "Kathmandu" },
                new { Id = 2, Name = "Bob", Age = 22, Grade = 'B', City = "Pokhara" },
                new { Id = 3, Name = "Charlie", Age = 19, Grade = 'A', City = "Kathmandu" },
                new { Id = 4, Name = "Diana", Age = 21, Grade = 'C', City = "Lalitpur" },
                new { Id = 5, Name = "Eve", Age = 23, Grade = 'B', City = "Pokhara" },
                new { Id = 6, Name = "Frank", Age = 20, Grade = 'A', City = "Kathmandu" },
                new { Id = 7, Name = "Grace", Age = 22, Grade = 'C', City = "Lalitpur" },
                new { Id = 8, Name = "Henry", Age = 24, Grade = 'B', City = "Pokhara" }
            };

            // 1. Basic filtering with WHERE clause
            Console.WriteLine("1. Basic filtering (WHERE):");
            Console.WriteLine("   Even numbers:");
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;
            foreach (var num in evenNumbers)
                Console.Write($"   {num}");
            Console.WriteLine("\n");

            // 2. Ordering with ORDER BY
            Console.WriteLine("2. Ordering (ORDER BY):");
            Console.WriteLine("   Fruits sorted by length:");
            var sortedFruits = from fruit in fruits
                               orderby fruit.Length descending
                               select fruit;
            foreach (var fruit in sortedFruits)
                Console.WriteLine($"   {fruit} ({fruit.Length} chars)");
            Console.WriteLine();

            // 3. Multiple conditions with WHERE AND
            Console.WriteLine("3. Multiple conditions:");
            Console.WriteLine("   Students with Grade A from Kathmandu:");
            var topStudents = from s in students
                              where s.Grade == 'A' && s.City == "Kathmandu"
                              select s;
            foreach (var s in topStudents)
                Console.WriteLine($"   {s.Name}, Age {s.Age}");
            Console.WriteLine();

            // 4. Projection with SELECT
            Console.WriteLine("4. Projection (SELECT specific fields):");
            var studentNames = from s in students
                               select new { s.Name, s.City, s.Grade };
            foreach (var s in studentNames)
                Console.WriteLine($"   {s.Name} | City: {s.City} | Grade: {s.Grade}");
            Console.WriteLine();

            // 5. GROUP BY
            Console.WriteLine("5. Grouping (GROUP BY):");
            var groupedByCity = from s in students
                                group s by s.City into cityGroup
                                select new
                                {
                                    City = cityGroup.Key,
                                    Count = cityGroup.Count(),
                                    Students = cityGroup
                                };
            foreach (var group in groupedByCity)
            {
                Console.WriteLine($"   City: {group.City} ({group.Count} students):");
                foreach (var s in group.Students)
                    Console.WriteLine($"     - {s.Name} (Grade: {s.Grade})");
            }
            Console.WriteLine();

            // 6. JOIN (Simulating with 2 data sources)
            Console.WriteLine("6. Join (using LET for calculated values):");
            var numbersWithParity = from num in numbers
                                    let parity = num % 2 == 0 ? "Even" : "Odd"
                                    select new { Number = num, Parity = parity };
            Console.WriteLine("   Numbers with parity:");
            foreach (var item in numbersWithParity)
                Console.WriteLine($"   {item.Number} is {item.Parity}");
            Console.WriteLine();

            // 7. Aggregation
            Console.WriteLine("7. Aggregation (using multiple queries):");
            var totalStudents = (from s in students select s).Count();
            var averageAge = (from s in students select s.Age).Average();
            var maxAge = (from s in students select s.Age).Max();
            var minAge = (from s in students select s.Age).Min();
            Console.WriteLine($"   Total Students: {totalStudents}");
            Console.WriteLine($"   Average Age: {averageAge:F1}");
            Console.WriteLine($"   Max Age: {maxAge}");
            Console.WriteLine($"   Min Age: {minAge}");
            Console.WriteLine();

            // 8. Filter with range
            Console.WriteLine("8. Range filter:");
            var rangeNumbers = from num in numbers
                               where num >= 3 && num <= 7
                               select num;
            Console.WriteLine($"   Numbers 3 to 7: {string.Join(", ", rangeNumbers)}");
        }
        */
    }
}

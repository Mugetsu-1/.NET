using System;
using System.Collections.Generic;

namespace Lab2
{
    internal class GenericCollectionsDemo
    {
        /*
        static void Main(string[] args)
        {
            

            // 1. List<T>
            Console.WriteLine("1. List<T>:");
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date" };
            fruits.Add("Elderberry");
            fruits.Insert(1, "Blueberry");
            fruits.Remove("Banana");
            Console.WriteLine($"  Count: {fruits.Count}, Capacity: {fruits.Capacity}");
            Console.WriteLine("  Fruits:");
            foreach (string fruit in fruits)
                Console.WriteLine($"    {fruit}");
            Console.WriteLine($"  First: {fruits[0]}, Last: {fruits[^1]}");
            Console.WriteLine();

            // 2. Dictionary<TKey, TValue>
            Console.WriteLine("2. Dictionary<TKey, TValue>:");
            Dictionary<int, string> students = new Dictionary<int, string>
            {
                { 101, "Alice" },
                { 102, "Bob" },
                { 103, "Charlie" }
            };
            students.Add(104, "Diana");
            students[105] = "Eve";
            Console.WriteLine("  Students:");
            foreach (var kvp in students)
                Console.WriteLine($"    ID: {kvp.Key}, Name: {kvp.Value}");
            Console.WriteLine($"  Student with ID 103: {students[103]}");
            Console.WriteLine();

            // 3. SortedList<TKey, TValue>
            Console.WriteLine("3. SortedList<TKey, TValue>:");
            SortedList<int, string> sorted = new SortedList<int, string>
            {
                { 5, "Five" },
                { 1, "One" },
                { 3, "Three" },
                { 2, "Two" },
                { 4, "Four" }
            };
            Console.WriteLine("  Elements (automatically sorted by key):");
            foreach (var kvp in sorted)
                Console.WriteLine($"    Key: {kvp.Key}, Value: {kvp.Value}");
            Console.WriteLine();

            // 4. Queue<T> (FIFO)
            Console.WriteLine("4. Queue<T> (FIFO):");
            Queue<double> queue = new Queue<double>();
            queue.Enqueue(1.1);
            queue.Enqueue(2.2);
            queue.Enqueue(3.3);
            queue.Enqueue(4.4);
            Console.WriteLine($"  Front (Peek): {queue.Peek()}");
            Console.Write("  Dequeuing all: ");
            while (queue.Count > 0)
                Console.Write($"{queue.Dequeue()} ");
            Console.WriteLine("\n");

            // 5. Stack<T> (LIFO)
            Console.WriteLine("5. Stack<T> (LIFO):");
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            Console.WriteLine($"  Top (Peek): {stack.Peek()}");
            Console.Write("  Popping all: ");
            while (stack.Count > 0)
                Console.Write($"{stack.Pop()} ");
            Console.WriteLine("\n");

            // 6. HashSet<T>
            Console.WriteLine("6. HashSet<T> (no duplicates):");
            HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 4, 5, 3, 2, 1, 6, 7, 5 };
            Console.WriteLine("  Numbers:");
            foreach (int num in numbers)
                Console.WriteLine($"    {num}");
            Console.WriteLine($"  Count: {numbers.Count} (duplicates removed)");
            Console.WriteLine($"  Contains 3? {numbers.Contains(3)}");
            Console.WriteLine($"  Contains 10? {numbers.Contains(10)}");
        }
        */
    }
}

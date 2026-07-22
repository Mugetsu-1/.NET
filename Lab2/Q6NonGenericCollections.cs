using System;
using System.Collections;

namespace Lab2
{
    internal class NonGenericCollectionsDemo
    {
        /*
        static void Main(string[] args)
        {
          

            // 1. ArrayList
            Console.WriteLine("1. ArrayList:");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(100);
            arrayList.Add("Hello World");
            arrayList.Add(99.99);
            arrayList.Add(true);
            arrayList.Add('A');
            Console.WriteLine($"  Count: {arrayList.Count}, Capacity: {arrayList.Capacity}");
            Console.WriteLine("  Elements:");
            foreach (var item in arrayList)
                Console.WriteLine($"    {item} (Type: {item.GetType().Name})");
            Console.WriteLine();

            // 2. SortedList
            Console.WriteLine("2. SortedList:");
            SortedList sortedList = new SortedList();
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(4, "Four");
            sortedList.Add(2, "Two");
            Console.WriteLine("  Elements (sorted by key):");
            foreach (DictionaryEntry entry in sortedList)
                Console.WriteLine($"    Key: {entry.Key}, Value: {entry.Value}");
            Console.WriteLine();

            // 3. Stack (LIFO)
            Console.WriteLine("3. Stack (LIFO):");
            Stack stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");
            Console.WriteLine($"  Top element (Peek): {stack.Peek()}");
            Console.Write("  Popping all: ");
            while (stack.Count > 0)
                Console.Write($"{stack.Pop()} ");
            Console.WriteLine("\n");

            // 4. Queue (FIFO)
            Console.WriteLine("4. Queue (FIFO):");
            Queue queue = new Queue();
            queue.Enqueue("Item 1");
            queue.Enqueue("Item 2");
            queue.Enqueue("Item 3");
            Console.WriteLine($"  Front element (Peek): {queue.Peek()}");
            Console.Write("  Dequeuing all: ");
            while (queue.Count > 0)
                Console.Write($"{queue.Dequeue()} ");
            Console.WriteLine("\n");

            // 5. Hashtable
            Console.WriteLine("5. Hashtable:");
            Hashtable hashtable = new Hashtable();
            hashtable.Add("name", "Saugat Thapa");
            hashtable.Add("age", 21);
            hashtable.Add("course", "CSIT");
            hashtable.Add("city", "Kathmandu");
            hashtable.Add("gpa", 3.45);
            Console.WriteLine("  Elements:");
            foreach (DictionaryEntry entry in hashtable)
                Console.WriteLine($"    Key: {entry.Key}, Value: {entry.Value}");

            Console.WriteLine($"\n  Name: {hashtable["name"]}");
            Console.WriteLine($"  Age: {hashtable["age"]}");
        }
        */
    }
}

using System;
using System.Collections;

namespace Unit1CH1._6
{
    internal class NonGenericCollectionsDemo
    {
        /*
        static void Main(string[] args)
        {
            // ---- ArrayList ----
            Console.WriteLine("=== ArrayList ===");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add("Hello");
            arrayList.Add(3.14);
            arrayList.Add(true);
            Console.WriteLine("ArrayList elements:");
            foreach (var item in arrayList)
                Console.WriteLine($"  {item} (Type: {item.GetType().Name})");

            // ---- SortedList ----
            Console.WriteLine("\n=== SortedList ===");
            SortedList sortedList = new SortedList();
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");
            Console.WriteLine("SortedList elements (sorted by key):");
            foreach (DictionaryEntry entry in sortedList)
                Console.WriteLine($"  Key: {entry.Key}, Value: {entry.Value}");

            // ---- Stack ----
            Console.WriteLine("\n=== Stack ===");
            Stack stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            Console.WriteLine("Stack (LIFO):");
            while (stack.Count > 0)
                Console.WriteLine($"  Pop: {stack.Pop()}");

            // ---- Queue ----
            Console.WriteLine("\n=== Queue ===");
            Queue queue = new Queue();
            queue.Enqueue("Item 1");
            queue.Enqueue("Item 2");
            queue.Enqueue("Item 3");
            Console.WriteLine("Queue (FIFO):");
            while (queue.Count > 0)
                Console.WriteLine($"  Dequeue: {queue.Dequeue()}");

            // ---- Hashtable ----
            Console.WriteLine("\n=== Hashtable ===");
            Hashtable hashtable = new Hashtable();
            hashtable.Add("name", "Saugat");
            hashtable.Add("age", 21);
            hashtable.Add("course", "CSIT");
            Console.WriteLine("Hashtable elements:");
            foreach (DictionaryEntry entry in hashtable)
                Console.WriteLine($"  Key: {entry.Key}, Value: {entry.Value}");

            // ---- BitArray ----
            Console.WriteLine("\n=== BitArray ===");
            BitArray bitArray = new BitArray(8);
            bitArray[0] = true;
            bitArray[2] = true;
            bitArray[4] = true;
            bitArray[7] = true;
            Console.Write("BitArray bits: ");
            for (int i = 0; i < bitArray.Length; i++)
                Console.Write(bitArray[i] ? "1" : "0");
            Console.WriteLine();
        }
        */
    }
}
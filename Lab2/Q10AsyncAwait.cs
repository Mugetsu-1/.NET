using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lab2
{
    internal class AsyncAwaitDemo
    {
        /*
        static async Task Main(string[] args)
        {
           
            Console.WriteLine($"Main thread ID: {Environment.CurrentManagedThreadId}\n");

            // 1. Basic async method
            Console.WriteLine("1. Basic async method - Delayed greeting:");
            string greeting = await GetGreetingAsync("Saugat");
            Console.WriteLine($"   {greeting}\n");

            // 2. Simulating multiple independent tasks running concurrently
            Console.WriteLine("2. Running multiple tasks concurrently (Download simulation):");
            Task<string> task1 = DownloadFileAsync("File1.zip", 3);
            Task<string> task2 = DownloadFileAsync("File2.zip", 2);
            Task<string> task3 = DownloadFileAsync("File3.zip", 4);

            // Do other work while downloads are in progress
            Console.WriteLine("   Main thread is free to do other work...");
            await Task.Delay(500);
            Console.WriteLine("   Doing some other work while waiting...\n");

            // Await all tasks to complete
            string[] results = await Task.WhenAll(task1, task2, task3);
            foreach (string result in results)
                Console.WriteLine($"   {result}");
            Console.WriteLine();

            // 3. Sequential vs Concurrent execution
            Console.WriteLine("3. Sequential execution (await each):\n");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await ProcessTaskAsync("Task A", 1);
            await ProcessTaskAsync("Task B", 1);
            await ProcessTaskAsync("Task C", 1);
            watch.Stop();
            Console.WriteLine($"   Sequential total time: {watch.Elapsed.TotalSeconds:F1}s\n");

            Console.WriteLine("   Concurrent execution (Task.WhenAll):\n");
            watch.Restart();
            Task taskA = ProcessTaskAsync("Task X", 1);
            Task taskB = ProcessTaskAsync("Task Y", 1);
            Task taskC = ProcessTaskAsync("Task Z", 1);
            await Task.WhenAll(taskA, taskB, taskC);
            watch.Stop();
            Console.WriteLine($"   Concurrent total time: {watch.Elapsed.TotalSeconds:F1}s\n");

            // 4. Exception handling in async methods
            Console.WriteLine("4. Exception handling in async methods:");
            try
            {
                int result = await CalculateDivisionAsync(10, 0);
                Console.WriteLine($"   Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"   Caught exception: {ex.Message}");
            }
            Console.WriteLine();

            // 5. File I/O with async
            Console.WriteLine("5. Async File I/O:");
            string filePath = "async_example.txt";
            string fileContent = "This file was written asynchronously.\n" +
                                 "Async/await makes I/O operations non-blocking.\n" +
                                 "The UI thread remains responsive during operations.";
            
            await File.WriteAllTextAsync(filePath, fileContent);
            Console.WriteLine($"   File written: {filePath}");

            string readContent = await File.ReadAllTextAsync(filePath);
            Console.WriteLine($"   File content:\n{readContent}");

            File.Delete(filePath);
            Console.WriteLine("   File cleaned up.\n");

            Console.WriteLine("=== Async/Await Demo Complete ===");
        }
        */

        static async Task<string> GetGreetingAsync(string name)
        {
            await Task.Delay(1000);
            return $"Hello, {name}! This is from an async method.";
        }

        static async Task<string> DownloadFileAsync(string fileName, int seconds)
        {
            Console.WriteLine($"   Starting download: {fileName} (will take {seconds}s)...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
            return $"Downloaded: {fileName}";
        }

        static async Task ProcessTaskAsync(string taskName, int seconds)
        {
            Console.WriteLine($"   Started: {taskName}");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
            Console.WriteLine($"   Completed: {taskName}");
        }

        static async Task<int> CalculateDivisionAsync(int a, int b)
        {
            await Task.Delay(500);
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero!");
            return a / b;
        }
    }
}
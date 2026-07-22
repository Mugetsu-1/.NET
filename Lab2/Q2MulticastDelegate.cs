using System;

namespace Lab2
{
    // Declare a delegate
    public delegate void ProgressNotifier(int percentage);

    class FileDownloader
    {
        public void DownloadFile(ProgressNotifier notifier)
        {
            Console.WriteLine("Downloading file...");
            for (int i = 0; i <= 100; i += 20)
            {
                notifier?.Invoke(i);
                System.Threading.Thread.Sleep(200); // Simulate work
            }
            Console.WriteLine("Download complete!\n");
        }
    }

    class ConsoleLogger
    {
        public void LogProgress(int percent)
        {
            Console.WriteLine($"  [Console] Download progress: {percent}%");
        }
    }

    class ProgressBar
    {
        public void ShowBar(int percent)
        {
            string bar = new string('#', percent / 5) + new string('-', 20 - percent / 5);
            Console.WriteLine($"  [Progress] [{bar}] {percent}%");
        }
    }

    class FileWriter
    {
        public void WriteToFile(int percent)
        {
            string logEntry = $"Download progress at {percent}% at {DateTime.Now:T}";
            System.IO.File.AppendAllText("download.log", logEntry + Environment.NewLine);
        }
    }

    internal class MulticastDelegateDemo
    {
        /*
        static void Main(string[] args)
        {
            

            ConsoleLogger logger = new ConsoleLogger();
            ProgressBar bar = new ProgressBar();
            FileWriter writer = new FileWriter();

            // Create multicast delegate
            ProgressNotifier notifier = logger.LogProgress;
            notifier += bar.ShowBar;
            notifier += writer.WriteToFile;

            Console.WriteLine("Starting download with all subscribers:");
            FileDownloader downloader = new FileDownloader();
            downloader.DownloadFile(notifier);

            Console.WriteLine("Removing ConsoleLogger, downloading again:");
            notifier -= logger.LogProgress;
            downloader.DownloadFile(notifier);

            // Clean up log file
            if (System.IO.File.Exists("download.log"))
            {
                string logContent = System.IO.File.ReadAllText("download.log");
                Console.WriteLine("Log file contents:");
                Console.WriteLine(logContent);
                System.IO.File.Delete("download.log");
            }
        }
        */
    }
}
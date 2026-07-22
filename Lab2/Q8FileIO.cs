using System;
using System.IO;
using System.Text;

namespace Lab2
{
    internal class FileIODemo
    {
        /*
        static void Main(string[] args)
        {
            
            string filePath = "example.txt";

            // 1. Check if file exists
            Console.WriteLine("1. Checking file existence:");
            Console.WriteLine($"   File exists: {File.Exists(filePath)}\n");

            // 2. Write text to file (overwrite)
            Console.WriteLine("2. Writing text to file:");
            string content = "Hello, this is a File I/O demonstration.\n" +
                             "This file demonstrates various file operations in C#.\n" +
                             "Line 3: File handling is essential for data persistence.";
            File.WriteAllText(filePath, content);
            Console.WriteLine($"   Written {content.Length} characters to '{filePath}'\n");

            // 3. Read all text from file
            Console.WriteLine("3. Reading all text from file:");
            string readContent = File.ReadAllText(filePath);
            Console.WriteLine($"   Content:\n{readContent}\n");

            // 4. Read all lines into array
            Console.WriteLine("4. Reading all lines into array:");
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine($"   Number of lines: {lines.Length}");
            for (int i = 0; i < lines.Length; i++)
                Console.WriteLine($"   Line {i + 1}: {lines[i]}");
            Console.WriteLine();

            // 5. Append text to file
            Console.WriteLine("5. Appending text to file:");
            File.AppendAllText(filePath, "\nThis line was appended later.\nAnother appended line.");
            Console.WriteLine("   Content after append:");
            Console.WriteLine(File.ReadAllText(filePath));
            Console.WriteLine();

            // 6. FileInfo - Get file information
            Console.WriteLine("6. FileInfo properties:");
            FileInfo fileInfo = new FileInfo(filePath);
            Console.WriteLine($"   Full Name: {fileInfo.FullName}");
            Console.WriteLine($"   Size: {fileInfo.Length} bytes");
            Console.WriteLine($"   Created: {fileInfo.CreationTime}");
            Console.WriteLine($"   Last Modified: {fileInfo.LastWriteTime}");
            Console.WriteLine($"   Extension: {fileInfo.Extension}");
            Console.WriteLine($"   Attributes: {fileInfo.Attributes}");
            Console.WriteLine();

            // 7. Directory operations
            Console.WriteLine("7. Directory operations:");
            string dirPath = "TestDirectory";
            Directory.CreateDirectory(dirPath);
            Console.WriteLine($"   Directory '{dirPath}' created.");

            string subFilePath = Path.Combine(dirPath, "subfile.txt");
            File.WriteAllText(subFilePath, "This is a file in a subdirectory.");
            Console.WriteLine($"   File created in subdirectory: {subFilePath}");

            Console.WriteLine($"   Files in '{dirPath}':");
            foreach (string file in Directory.GetFiles(dirPath))
                Console.WriteLine($"     {Path.GetFileName(file)}");

            Directory.Delete(dirPath, true);
            Console.WriteLine($"   Directory '{dirPath}' deleted.\n");

            // 8. Path operations
            Console.WriteLine("8. Path operations:");
            Console.WriteLine($"   GetFileName: {Path.GetFileName(filePath)}");
            Console.WriteLine($"   GetExtension: {Path.GetExtension(filePath)}");
            Console.WriteLine($"   GetDirectoryName: {Path.GetDirectoryName(filePath)}");
            Console.WriteLine($"   GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(filePath)}");
            Console.WriteLine($"   ChangeExtension to .bak: {Path.ChangeExtension(filePath, ".bak")}");
            Console.WriteLine($"   Combine example: {Path.Combine("folder", "sub", "file.txt")}");
            Console.WriteLine();

            // 9. Copy and Move operations
            Console.WriteLine("9. Copy and Move:");
            string copyPath = "example_copy.txt";
            File.Copy(filePath, copyPath, overwrite: true);
            Console.WriteLine($"   File copied to '{copyPath}'");

            string movePath = "example_moved.txt";
            if (File.Exists(movePath)) File.Delete(movePath);
            File.Move(copyPath, movePath);
            Console.WriteLine($"   File moved to '{movePath}'");
            Console.WriteLine($"   Copy exists? {File.Exists(copyPath)}");
            Console.WriteLine($"   Moved file exists? {File.Exists(movePath)}");
            File.Delete(movePath);
            Console.WriteLine();

            // Clean up
            File.Delete(filePath);
            Console.WriteLine("10. Cleanup: Temporary files deleted.");
        }
        */
    }
}

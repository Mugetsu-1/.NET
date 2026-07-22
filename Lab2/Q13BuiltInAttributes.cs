using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Lab2
{
    // 1. [Obsolete] attribute
    class OldMethodClass
    {
        [Obsolete("This method is obsolete. Use NewCalculate() instead.")]
        public void OldCalculate()
        {
            Console.WriteLine("   OldCalculate: Using old calculation method.");
        }

        public void NewCalculate()
        {
            Console.WriteLine("   NewCalculate: Using new calculation method (recommended).");
        }
    }

    // 2. [Serializable] attribute
    [Serializable]
    class PersonData
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public PersonData(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // 3. [Conditional] attribute
    class DebugLogger
    {
        [Conditional("DEBUG")]
        public void LogDebug(string message)
        {
            Console.WriteLine($"   [DEBUG] {message}");
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"   [INFO] {message}");
        }
    }

    // 4. [Description] attribute
    class EmployeeInfo
    {
        [Description("Employee's unique identifier")]
        public int Id { get; set; }

        [Description("Employee's full name")]
        public string Name { get; set; }

        [Description("Employee's job title")]
        public string Position { get; set; }

        [Description("Employee's annual salary")]
        public double Salary { get; set; }
    }

    // 5. [Flags] attribute
    [Flags]
    enum FilePermissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4,
        Delete = 8,
        FullControl = Read | Write | Execute | Delete
    }

    internal class BuiltInAttributesDemo
    {
        /*
        static void Main(string[] args)
        {
            

            // 1. [Obsolete] attribute
            Console.WriteLine("1. [Obsolete] Attribute:");
            OldMethodClass oldClass = new OldMethodClass();
            oldClass.NewCalculate();
            Console.WriteLine();

            // 2. [Serializable] attribute
            Console.WriteLine("2. [Serializable] Attribute:");
            PersonData person = new PersonData("Saugat", 21);
            Console.WriteLine($"   Person created: {person.Name}, Age {person.Age}");
            Console.WriteLine($"   Is type serializable? " +
                $"{typeof(PersonData).IsSerializable}");
            Console.WriteLine();

            // 3. [Conditional] attribute
            Console.WriteLine("3. [Conditional] Attribute:");
            DebugLogger logger = new DebugLogger();
            logger.LogInfo("Application started");
            logger.LogDebug("This debug message only appears in DEBUG configuration");
            Console.WriteLine("   (In RELEASE mode, LogDebug calls are removed by the compiler)");
            Console.WriteLine();

            // 4. [Description] attribute - Reading via reflection
            Console.WriteLine("4. [Description] Attribute (via Reflection):");
            var properties = typeof(EmployeeInfo).GetProperties();
            foreach (var prop in properties)
            {
                var description = (DescriptionAttribute)Attribute.GetCustomAttribute(prop, typeof(DescriptionAttribute));
                if (description != null)
                {
                    Console.WriteLine($"   Property: {prop.Name} -> {description.Description}");
                }
            }
            Console.WriteLine();

            // 5. [Flags] attribute
            Console.WriteLine("5. [Flags] Attribute:");
            FilePermissions permissions = FilePermissions.Read | FilePermissions.Write | FilePermissions.Execute;
            Console.WriteLine($"   Permissions: {permissions}");
            Console.WriteLine($"   Has Read? {permissions.HasFlag(FilePermissions.Read)}");
            Console.WriteLine($"   Has Delete? {permissions.HasFlag(FilePermissions.Delete)}");
            Console.WriteLine($"   Numeric value: {(int)permissions}");
            Console.WriteLine();

            // 6. [CallerMemberName], [CallerFilePath], [CallerLineNumber] attributes
            Console.WriteLine("6. [CallerMemberName], [CallerFilePath], [CallerLineNumber] attributes:");
            LogWithCallerInfo("This is a test message");
            Console.WriteLine();

            // 7. Getting all attributes from a type
            Console.WriteLine("7. Getting all attributes from a type:");
            object[] attributes = typeof(PersonData).GetCustomAttributes(false);
            Console.WriteLine($"   Attributes on PersonData:");
            foreach (object attr in attributes)
                Console.WriteLine($"   - {attr.GetType().Name}");
        }
        */

        // 8. [CallerMemberName], [CallerFilePath], [CallerLineNumber]
        static void LogWithCallerInfo(
            string message,
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
            [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
            [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine($"   Message: {message}");
            Console.WriteLine($"   Called from: {memberName}");
            Console.WriteLine($"   File: {System.IO.Path.GetFileName(filePath)}");
            Console.WriteLine($"   Line: {lineNumber}");
        }
    }
}
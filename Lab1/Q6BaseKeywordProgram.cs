using System;

namespace BaseKeywordApp
{
    class Person
    {
        public int id;
        public string name;
        public int age;

        public Person(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
    }


    class Employee : Person
    {
        public string department;
        public double salary;

        public Employee(int id, string name, int age, string department, double salary)
            : base(id, name, age)  // base keyword passing parameters
        {
            this.department = department;
            this.salary = salary;
        }

        public void DisplayEmployee()
        {
            DisplayPerson();
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Salary: ${salary}");
        }
    }

    
    class Manager : Employee
    {
        public int teamSize;

        public Manager(int id, string name, int age, string department, double salary, int teamSize)
            : base(id, name, age, department, salary)  // Passing to Employee constructor
        {
            this.teamSize = teamSize;
        }

        public void DisplayManager()
        {
            DisplayEmployee();
            Console.WriteLine($"Team Size: {teamSize} members");
        }
    }

    class Program
    {
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("EMPLOYEE\n");
            
            Manager mgr = new Manager(101, "Rajesh Kumar", 35, "IT", 85000, 12);
            mgr.DisplayManager();
        }
        */
    }
}
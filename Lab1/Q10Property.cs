using System;

namespace PropertyApp
{
    class Employee
    {
        private int id;
        private string name;
        private double salary;

        // Read-Write Property with validation
        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
                else
                    Console.WriteLine("Invalid ID");
            }
        }

        // Read-Only
        public string Name
        {
            get { return name; }
        }

        // auto-implemented
        public string Department { get; set; }

        // Property
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    Console.WriteLine("Salary cannot be negative");
            }
        }

        // Calculated Property
        public string Designation
        {
            get
            {
                if (salary >= 70000) return "Senior";
                else if (salary >= 40000) return "Mid-Level";
                else return "Junior";
            }
        }

        // Constructor
        public Employee(int empId, string empName, double empSalary, string dept)
        {
            Id = empId;
            name = empName;
            Salary = empSalary;
            Department = dept;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Designation: {Designation}");
        }
    }
}
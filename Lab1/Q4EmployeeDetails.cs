using System;

namespace EmployeeApp
{
    class EmployeeDetails
    {
        public int empId;
        public string empName;
        public string empGender;
        public string empAddress;
        public string empPosition;

        // Constructor
        public EmployeeDetails(int id, string name, string gender, string address, string position)
        {
            empId = id;
            empName = name;
            empGender = gender;
            empAddress = address;
            empPosition = position;
        }

        public void Display()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine($"ID: {empId}");
            Console.WriteLine($"Name: {empName}");
            Console.WriteLine($"Gender: {empGender}");
            Console.WriteLine($"Address: {empAddress}");
            Console.WriteLine($"Position: {empPosition}");
        }
    }
}
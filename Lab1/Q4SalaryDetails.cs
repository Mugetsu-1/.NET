using System;

namespace EmployeeApp
{
    class SalaryInfo : EmployeeDetails
    {
        public double salary;

        // Constructor
        public SalaryInfo(int id, string name, string gender, string address, string position, double sal)
            : base(id, name, gender, address, position)
        {
            salary = sal;
        }

        public void CalcTax()
        {
            double taxRate, tax, finalSalary;

            if (salary <= 400000)
                taxRate = 0.01;
            else if (salary <= 800000)
                taxRate = 0.10;
            else
                taxRate = 0.20;

            tax = salary * taxRate;
            finalSalary = salary - tax;

            Console.WriteLine($"\nSalary Information");
            Console.WriteLine($"Annual Salary: Rs. {salary}");
            Console.WriteLine($"Tax Rate: {taxRate * 100}%");
            Console.WriteLine($"Tax Amount: Rs. {tax}");
            Console.WriteLine($"Final Salary: Rs. {finalSalary}");
        }
    }
}
using System;

namespace Lab2
{
    // Declare a delegate
    public delegate double Operation(double a, double b);

    class Calculator
    {
        public double Add(double x, double y)
        {
            Console.WriteLine($"  Adding: {x} + {y}");
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            Console.WriteLine($"  Subtracting: {x} - {y}");
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            Console.WriteLine($"  Multiplying: {x} * {y}");
            return x * y;
        }

        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("  Cannot divide by zero!");
                return double.NaN;
            }
            Console.WriteLine($"  Dividing: {x} / {y}");
            return x / y;
        }
    }

    internal class DelegateDemo
    {
        /*
        static void Main(string[] args)
        {
            
            Calculator calc = new Calculator();

            Operation op = new Operation(calc.Add);
            Console.WriteLine("Delegate pointing to Add:");
            double result = op(15, 5);
            Console.WriteLine($"  Result: {result}\n");

            op = calc.Subtract;
            Console.WriteLine("Delegate pointing to Subtract:");
            result = op(15, 5);
            Console.WriteLine($"  Result: {result}\n");

            op = calc.Multiply;
            Console.WriteLine("Delegate pointing to Multiply:");
            result = op(15, 5);
            Console.WriteLine($"  Result: {result}\n");

            op = calc.Divide;
            Console.WriteLine("Delegate pointing to Divide:");
            result = op(15, 5);
            Console.WriteLine($"  Result: {result}\n");
        }
        */
    }
}
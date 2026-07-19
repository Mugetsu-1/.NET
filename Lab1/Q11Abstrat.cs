using System;

namespace AbstractApp
{
    // Abstract class
    abstract class Shape
    {
        public string Color { get; set; }

        // Abstract method (no implementation)
        public abstract double CalculateArea();

        // Abstract method
        public abstract void Display();

        // Non-abstract method (concrete)
        public void ShowColor()
        {
            Console.WriteLine($"Color: {Color}");
        }
    }

    // Derived class 1
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Rectangle(double length, double breadth, string color)
        {
            Length = length;
            Breadth = breadth;
            Color = color;
        }

        // abstract methods
        public override double CalculateArea()
        {
            return Length * Breadth;
        }

        public override void Display()
        {
            Console.WriteLine($"\nRectangle");
            Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
            ShowColor();
            Console.WriteLine($"Area: {CalculateArea()}");
        }
    }

    // Derived class 2
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        // abstract methods
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Display()
        {
            Console.WriteLine($"\nCircle");
            Console.WriteLine($"Radius: {Radius}");
            ShowColor();
            Console.WriteLine($"Area: {CalculateArea():F2}");
        }
    }

    // Derived class 3
    class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height, string color)
        {
            Base = baseLength;
            Height = height;
            Color = color;
        }

        // Implementing abstract methods
        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public override void Display()
        {
            Console.WriteLine($"\nTriangle");
            Console.WriteLine($"Base: {Base}, Height: {Height}");
            ShowColor();
            Console.WriteLine($"Area: {CalculateArea()}");
        }
    }
}
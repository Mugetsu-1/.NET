using System;

namespace ShapeApp
{
    class Shape
    {
        public double length, breadth, height;

 
        public Shape(double l, double b)
        {
            length = l;
            breadth = b;
            height = 0;
        }

        public Shape(double l, double b, double h)
        {
            length = l;
            breadth = b;
            height = h;
        }

        public void FindAreaRectangle()
        {
            double area = length * breadth;
            Console.WriteLine($"Area of Rectangle = {area}");
        }

        public void FindVolumeBox()
        {
            double volume = length * breadth * height;
            Console.WriteLine($"Volume of Box = {volume}");
        }
    }
}
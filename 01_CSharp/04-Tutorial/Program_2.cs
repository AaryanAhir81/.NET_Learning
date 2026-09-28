using System;

namespace _04_Tutorial
{
    internal class Shape
    {
        public double Width;
        public double Height;

        public void ShowDim()
        {
            Console.WriteLine("Width and height are " + Width + " and " + Height);
        }
    }

    class Triangle : Shape
    {
        public string Style; 

        public double Area()
        {
            return Width * Height / 2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + Style);
        }
    }

    class Driver
    {
        public static void Program_2()
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle();

            t1.Width = 4.0;
            t1.Height = 4.0;
            t1.Style = "isosceles";

            t2.Width = 8.0;
            t2.Height = 12.0;
            t2.Style = "right";

            Console.WriteLine("Info for t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area is " + t1.Area());

            Console.WriteLine();

            Console.WriteLine("Info for t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Area is " + t2.Area());

            Console.WriteLine("\n");
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
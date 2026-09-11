using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Tutorial
{
    internal class P17
    {
        // Base class
        class Shape
        {
            public virtual void CalculateArea()
            {
                Console.WriteLine("Area of Shape");
            }
        }

        // Derived class - Circle
        class Circle : Shape
        {
            public override void CalculateArea()
            {
                Console.Write("Enter radius: ");
                double radius = Convert.ToDouble(Console.ReadLine());

                double area = Math.PI * radius * radius;

                Console.WriteLine("Area of Circle = " + area);
            }
        }

        // Derived class - Rectangle
        class Rectangle : Shape
        {
            public override void CalculateArea()
            {
                Console.Write("Enter length: ");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter width: ");
                double width = Convert.ToDouble(Console.ReadLine());

                double area = length * width;

                Console.WriteLine("Area of Rectangle = " + area);
            }
        }

        public static void P17Run()
        {
            Shape shape;

            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                shape = new Circle();
                shape.CalculateArea();
            }
            else if (choice == 2)
            {
                shape = new Rectangle();
                shape.CalculateArea();
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Tutorial
{
    //Base Class
    internal class Shape
    {
        private double area;

        public virtual void CalculateArea()
        {
            Console.WriteLine("Area of shape");
        }

        //Derived Class
        class circle : Shape
        {
            public override void CalculateArea()
            {
                double radius = 5;
                double area = 3.14 * radius * radius;
                Console.WriteLine("Area of Circle: " + area);
            }

        }

        class rectangle : Shape
        {
            public override void CalculateArea()
            {
                double length = 10;
                double width = 20;
                double area = length * width;
                Console.WriteLine("Area of Rectangle: " + area);
            }
        }

        class triangle : Shape
        {
            public override void CalculateArea()
            {
                double b = 5;
                double h = 10;
                double area = 0.5 * b * h;
                Console.WriteLine("Area of Triangle: " + area);
            }
        }

        public static void AreaRun(string[] args)
        {
            circle c = new circle();
            rectangle r = new rectangle();
            triangle t = new triangle();

            c.CalculateArea();
            r.CalculateArea();
            t.CalculateArea();
        }
    }
}



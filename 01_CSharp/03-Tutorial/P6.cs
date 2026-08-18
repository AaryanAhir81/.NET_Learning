using System;

namespace _03_Tutorial
{
    internal class Line
    {
        private double length;

        public Line()
        {
            length = 10;
            Console.WriteLine("Object is being created, length = " + getLength());
            Console.WriteLine();
        }

        public void setLength(double len)
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }
    }

    class TestLine
    {
        public static void LineRun(string[] args)
        {
            Line line = new Line();

            line.setLength(10);
            Console.WriteLine("Length of line : {0}", line.getLength());

            line.setLength(6);
            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.Read();

            //Personal Details
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
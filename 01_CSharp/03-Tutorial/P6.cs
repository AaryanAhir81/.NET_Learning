using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Tutorial
{
    internal class Line
    {
        private double length;   // Length of a line

        public Line()

        {

            //………………………………Missing statement-1……………………………….// 

            //………………………………Missing statement-2……………………………….// 

        }



        public void setLength(double len)

        {

            //………………………………Missing statement-3……………………………….//      
            length = len;



        }

        public double getLength()

        {

            //………………………………Missing statement-4……………………………….//
            return length;

        }

    }



    class TestLine

    {

        public static void LineRun(string[] args)

        {

            Line line = new Line();

            // set line length
            line.setLength(10);

            Console.WriteLine("Length of line : {0}", line.getLength());

            // set line length
            line.setLength(6);

            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.Read();
        }
    }

}

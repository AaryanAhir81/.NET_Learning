using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Tutorial
{
    internal class Program_7
    {
        sealed class A
        {
            public int x;
            public int y;
        }

       public static void program_7()
        {
            A sc = new A();

            sc.x = 110;
            sc.y = 150;

            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);

            Console.WriteLine("\n");
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Tutorial
{
    internal class P14
    {
        public static void Program_14()
        {
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
            Console.WriteLine("Division: G");
            Console.WriteLine("Branch: BTech IT");
            Console.WriteLine("Roll No: 01");
            Console.WriteLine("\n");

            int Math,Physics,Chemistry;
            Console.WriteLine("Input the marks obtained in Maths:");
            Math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the marks obtained in Physics:");
            Physics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the marks obtained in Chemistry:");
            Chemistry = Convert.ToInt32(Console.ReadLine());

            int Total = Math + Physics + Chemistry;
            int mathphy = Math + Physics;

            if(Math >= 65 && Physics >= 55 && Chemistry >=50 && Total >=180 && mathphy >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            Console.ReadLine();
        }
    }
}

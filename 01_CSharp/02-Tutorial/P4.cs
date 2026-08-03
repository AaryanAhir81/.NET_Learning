using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Tutorial
{
    internal class P4
    {
        public static void Program_4()
        {
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
            Console.WriteLine("Division: G");
            Console.WriteLine("Branch: BTech IT");
            Console.WriteLine("Roll No: 01");
            Console.WriteLine("\n");
            int A, B;

            Console.Write("Enter First Number: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nArithmetic Operations");
            Console.WriteLine("Addition = " + (A + B));
            Console.WriteLine("Subtraction = " + (A - B));
            Console.WriteLine("Multiplication = " + (A * B));
            Console.WriteLine("Division = " + (A / B));
            Console.WriteLine("Modulus = " + (A % B));

            Console.WriteLine("\nRelational Operations");
            Console.WriteLine("A > B = " + (A > B));
            Console.WriteLine("A < B = " + (A < B));
            Console.WriteLine("A == B = " + (A == B));

            Console.WriteLine("\nLogical Operations");
            Console.WriteLine("(A > 0 && B > 0) = " + (A > 0 && B > 0));
            Console.WriteLine("(A > 0 || B > 0) = " + (A > 0 || B > 0));

            Console.ReadLine();
        }
    }
}

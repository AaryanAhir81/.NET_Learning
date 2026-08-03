using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Tutorial
{
    internal class P5
    {
        public static void Program_5()
        {
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
            Console.WriteLine("Division: G");
            Console.WriteLine("Branch: BTech IT");
            Console.WriteLine("Roll No: 01");
            Console.WriteLine("\n");

            int[] arr = new int[5];
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Element {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("Sum of Elements = " + sum);

            Console.ReadLine();
        }
    }
}

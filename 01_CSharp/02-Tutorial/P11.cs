using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Tutorial
{
    internal class P11
    {
        public static void Program_11()
        {
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
            Console.WriteLine("Division: G");
            Console.WriteLine("Branch: BTech IT");
            Console.WriteLine("Roll No: 01");
            Console.WriteLine("\n");

            int n, sum = 0;

            Console.Write("Enter the number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the array elements:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}

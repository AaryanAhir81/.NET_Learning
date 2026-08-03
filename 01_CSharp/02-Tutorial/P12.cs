using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Tutorial
{
    internal class P12
    {
        public static void Program_12()
        {
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
            Console.WriteLine("Division: G");
            Console.WriteLine("Branch: BTech IT");
            Console.WriteLine("Roll No: 01");
            Console.WriteLine("\n");

            int[] arr = { 10, 20, 30, 40, 50 };
            int key;
            int found = 0;

            Console.Write("Enter the element to search: ");
            key = Convert.ToInt32(Console.ReadLine());

            foreach (int item in arr)
            {
                if (item == key)
                {
                    found = 1;
                    break;
                }
            }

            Console.WriteLine(found);
        }
    }
}

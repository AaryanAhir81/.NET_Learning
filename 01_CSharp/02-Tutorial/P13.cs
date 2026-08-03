using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Tutorial
{
    internal class P13
    {
        public static void Program_13()
        {
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
            Console.WriteLine("Division: G");
            Console.WriteLine("Branch: BTech IT");
            Console.WriteLine("Roll No: 01");
            Console.WriteLine("\n");

            int amount;

            Console.Write("Enter the amount: ");
            amount = Convert.ToInt32(Console.ReadLine());

            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int note in notes)
            {
                int count = amount / note;
                Console.WriteLine("Notes of Rs.{0} = {1}", note, count);
                amount = amount % note;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class sum_series
    {
        public static void sum_series_demo()
        {
            int term, number;
            int sum = 0;
            int current = 0;
            Console.WriteLine("Enter terms: ");
            term = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter input number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for(int i = 1; i<=term; i++)
            {
                current = current + 10;
                Console.Write(current);
                sum += current;

                if (i < term)
                    Console.Write(" + ");
            }

            Console.WriteLine("\nsum is " + sum);
            Console.WriteLine();
        }
    }
}

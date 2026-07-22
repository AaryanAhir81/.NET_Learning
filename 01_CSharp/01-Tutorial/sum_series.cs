using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class sum_series
    {
        public static void sum_series_demo()
        {
            int n, digit, term = 0, sum = 0;

            Console.Write("Input the number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input number: ");
            digit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSeries:");

            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + digit;
                sum = sum + term;

                Console.Write(term);

                if (i < n)
                    Console.Write(" + ");
            }

            Console.WriteLine();
            Console.WriteLine("The Sum is : " + sum);
        }
    }
 }

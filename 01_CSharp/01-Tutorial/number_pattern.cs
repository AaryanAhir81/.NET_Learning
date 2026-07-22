using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class number_pattern
    {
        public static void number_pattern_demo()
        {
            int rows;

            Console.Write("Enter the number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class Pyramid
    {
        public static void Pyramid_Demo()
        {
            int rows;

            Console.Write("Enter the number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

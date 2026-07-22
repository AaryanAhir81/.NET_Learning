using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class right_triangle
    {
        public static void rigth_triangle_demo()
        {
            int rows;

            Console.Write("Enter the number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

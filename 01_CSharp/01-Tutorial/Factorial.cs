
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class Factorial
    {
        public static void CalculateFactorial()
        {
            int number;
            Console.WriteLine("Enter a number to calculate factorial");

            number = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial is: " + fact);
        }
    }
}

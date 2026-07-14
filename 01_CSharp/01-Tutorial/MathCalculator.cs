using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class MathCalculator
    {
        public static void CalculatorMath()
        {
            int a, b, c, result;

            Console.WriteLine("Enter a number 1: ");
            String str = Console.ReadLine();

            a = Convert.ToInt32(str);

            Console.WriteLine("Enter a number 2: ");
            String str1 = Console.ReadLine();

            b = Convert.ToInt32(str1);

            Console.WriteLine("Enter a number 3: ");
            String str2 = Console.ReadLine();

            c = Convert.ToInt32(str2);

            result = a + b + c;

            Console.WriteLine("Result of addition of 3 number is =" + result);
            Console.Read();
        }
    }
}

    using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class N_OR_P_CHECK
    {
        public static void Checknumposiornegi()
        {
            int number;
            Console.WriteLine("Enter a number: ");

            number = Convert.ToInt32(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("Number is Positive");
            }
            Console.ReadLine();
        }
    }
}

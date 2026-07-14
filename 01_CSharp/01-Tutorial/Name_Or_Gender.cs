using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class Name_Or_Gender
    {
        public static void n_or_g()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Gender (M/F): ");
            char gender = Convert.ToChar(Console.ReadLine());

            if (gender == 'M' || gender == 'm')
            {
                Console.WriteLine("Mr. " + name);
            }
            else if (gender == 'F' || gender == 'f')
            {
                Console.WriteLine("Ms. " + name);
            }
            else
            {
                Console.WriteLine("Invalid Gender");
            }

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class Uppercase1
    {
        public static void uppercasedemo()
        {
            Console.WriteLine("Enter String: ");
            string input = Console.ReadLine();
            string uppercased = input.ToUpper();
            Console.WriteLine("Uppercase String:"+ uppercased);
        }
        

    }
}

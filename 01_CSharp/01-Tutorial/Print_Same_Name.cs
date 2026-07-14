using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _01_CSharp
{
    internal class Print_Same_Name
    {
        public static void printdemo()
        {
            string name;
            Console.WriteLine("Enter a name: ");
            name = Console.ReadLine();

            Console.WriteLine("Your name is:"+name);
        }
    }
}

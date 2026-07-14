using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class Mobile_No
    {
        public static void digittox()
        {
            string number;
            Console.WriteLine("Enter a string number");
            number = Console.ReadLine();

            if(number.Length>=5)
            {
                string result = number.Substring(0, number.Length - 5) + "xxxx";
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}

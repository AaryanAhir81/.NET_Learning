using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class mNo
    {
        public static void mNO_Demo()
        {
            Console.Write("Enter Mobile Number: ");
            string mobile = Console.ReadLine();

            string result = mobile.Substring(0, 5) + "XXXXX";

            Console.WriteLine("Output: " + result);

            Console.Read();
        }
    }
}

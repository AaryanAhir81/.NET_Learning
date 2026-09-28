using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Tutorial
{
    internal class Program_10
    {
        class MyException : Exception
        {
            public MyException(string str) : base(str)
            {
                Console.WriteLine("User defined exception");
            }
        }

        public static void program_10()
        {
            try
            {
                throw new MyException("my exception generated.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught here: " + e.Message);
            }

            Console.WriteLine("LAST STATEMENT");

            Console.WriteLine("\n");
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
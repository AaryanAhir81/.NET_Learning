using System;

namespace _02_Tutorial
{
    internal class P6
    {
        public static void Program_6(string[] args)
        {
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
            Console.WriteLine("Division: G");
            Console.WriteLine("Branch: BTech IT");
            Console.WriteLine("Roll No: 01");
            Console.WriteLine("\n");

            Console.WriteLine("Hello, World!");
            Console.WriteLine("You entered the following {0} command line arguments:", args.Length);

            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
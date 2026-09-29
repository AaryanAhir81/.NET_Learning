using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Learning
{
    delegate void MyDelegate(int x, int y); //Delegate Declaration
    class Program
    {
        public static void Add(int x, int y) // Add Method
        {
            Console.WriteLine("Addition: "+(x + y));
        }

        public static void Sub(int x, int y) // Sub Method
        {
            Console.WriteLine("\nSubstraction: " + (x - y));
        }
        static void Main(string[] args)
        {
            // Instatiation
            MyDelegate obj = new MyDelegate(Add);
            //MyDelegate obj1 = new MyDelegate(Sub);

            // Invocation
            obj += Sub; // Multicast Delegate
            obj(15, 5); 
            //obj1(15, 5);
        }
    }
}
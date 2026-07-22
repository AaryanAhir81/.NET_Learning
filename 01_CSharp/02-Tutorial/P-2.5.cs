using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Tutorial
{
    internal class P_2
    {
        public static void demo_hello()
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("You entered the following {0} commad line arguments" + args.Length);

            for(int i=0; i< args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class fibo
    {
        public static void fibodemo()
        {
            int a = 0, b = 1, c;

            Console.Write(a + " " + b + " ");

            for (int i = 1; i <= 9; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }

            Console.Read();

        }
    }
}

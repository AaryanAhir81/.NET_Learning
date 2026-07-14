using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class comments
    {
        public static void com_demo()
        {
            int n, fact = 1;          // Declares variable n and initializes fact to 1.

            Console.WriteLine("Enter Number : "); // Displays a message to enter a number.

            string str = Console.ReadLine();      // Reads input from the keyboard.

            n = Convert.ToInt32(str);             // Converts the input string to an integer.

            for (int i = 1; i <= n; i++)          // Loops from 1 to n.
            {
                fact = fact * i;                  // Calculates the factorial.
            }

            Console.WriteLine("Factorial : {0}", fact); // Displays the factorial.

            Console.Read();
        }
    }
}

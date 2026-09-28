using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Tutorial
{
    internal class Program_9
    {
        public static void program_9()
        {
            int x = 0;

            try
            {
                int div = 100 / x;
                Console.WriteLine(div);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}
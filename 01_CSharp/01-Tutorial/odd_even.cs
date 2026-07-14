using System;
namespace _01_CSharp
{
    internal class odd_even
    {
        public static void odd_even_demo()
        {
            int num = 4;
            if(num %2 == 0)
            {
                Console.WriteLine(num + " is Even");
            }
            else
            {
                Console.WriteLine(num + " is Odd");
            }
        }
    }
}

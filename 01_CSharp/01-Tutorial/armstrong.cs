using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class armstrong
    {
        public static void arm_demo()
        {
            int num, temp, rem, sum = 0;

            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            temp = num;

            while (temp > 0)
            {
                rem = temp % 10;
                sum = sum + (rem * rem * rem);
                temp = temp / 10;
            }

            if (sum == num)
            {
                Console.WriteLine(num + " is an Armstrong Number.");
            }
            else
            {
                Console.WriteLine(num + " is Not an Armstrong Number.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Tutorial
{
    internal class p3
    {
        public static void p3_demo()
        {
            char firstName = 'J';
            char lastName = 'D';

            Console.WriteLine("Name: " + firstName + " " + lastName);



            Console.WriteLine("Please enter a new first name:");

            firstName = Convert.ToChar(Console.ReadLine());



            Console.WriteLine("New name: " + firstName  +" " +lastName);



            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class SwitchCase
    {
        public static void scdemo()
        {
            string number;
            Console.WriteLine("Enter a number: ");
            number = Console.ReadLine();

            foreach (char ch in number) {

                switch (ch)
                {
                    case '0':
                        Console.WriteLine("Zero");
                        break;

                    case '1':
                        Console.WriteLine("One");
                        break;

                    case '2':
                        Console.WriteLine("Two");
                        break;

                    case '3':
                        Console.WriteLine("Three");
                        break;

                    case '4':
                        Console.WriteLine("Four");
                        break;

                    case '5':
                        Console.WriteLine("Five");
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _01_CSharp
{
    internal class ToggleClass
    {
        public static void Toggledemo()
        {
            string name,result = "";
            Console.WriteLine("Enter a string to convert to Toggle Class: ");
            name = Console.ReadLine();

            foreach(char ch in name)
            {
                if (char.IsUpper(ch))
                {
                    result += char.ToLower(ch);
                }
                else if (char.IsLower(ch))
                {
                    result += char.ToUpper(ch);
                }
                else
                {
                    result += ch;
                }
            }
            Console.WriteLine("Toggle case converted: " +result);
            Console.ReadLine();
        }
    }
}

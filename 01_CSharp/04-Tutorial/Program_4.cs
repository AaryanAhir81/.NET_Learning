using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Tutorial
{
    internal class Program_4
    {
        public static int num;

        public void count()
        {
            num++;
        }

        public static int getNum()
        {
            return num;
        }

        public static void program_4()
        {
            Program_4 s = new Program_4();

            s.count();
            s.count();
            s.count();

            Console.WriteLine("Variable num: {0}", Program_4.getNum());
            Console.ReadKey();

            Console.WriteLine("\n");
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
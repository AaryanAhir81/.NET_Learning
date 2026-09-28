using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Tutorial
{
    internal class Program_6
    {
        abstract class Test
        {
            protected int a;

            public abstract void A();
        }

        class Example1 : Test
        {
            public override void A()
            {
                Console.WriteLine("Example1.A");
                base.a++;
            }
        }

        class Example2 : Test
        {
            public override void A()
            {
                Console.WriteLine("Example2.A");
                base.a--;
            }
        }

        public static void program_6()
        {
            Test test1 = new Example1();
            test1.A();

            Test test2 = new Example2();
            test2.A();

            Console.WriteLine("\n");
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Tutorial
{
            public class A
        {
            public A(int value)
            {
                Console.WriteLine("Base constructor A()");
            }
        }

        public class B : A
        {
            public B(int value) : base(value)
            {
                Console.WriteLine("Derived constructor B()");
            }

        public static void Program_5()
        {
            A a = new A(0);
            B b = new B(1);

            Console.WriteLine("\n");
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
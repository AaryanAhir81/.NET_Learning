using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Tutorial
{
    internal class Program_8
    {
        class X
        {
            public virtual void F()
            {
                Console.WriteLine("X.F");
            }

            public virtual void F2()
            {
                Console.WriteLine("X.F2");
            }
        }

        class Y : X
        {
            public sealed override void F()
            {
                Console.WriteLine("Y.F");
            }

            public override void F2()
            {
                Console.WriteLine("Y.F2");
            }
        }

        class Z : Y
        {
            public override void F2()
            {
                Console.WriteLine("Z.F2");
            }
        }

        public static void program_8()
        {
            X Obj1 = new X();
            Obj1.F();
            Obj1.F2();

            Y Obj2 = new Y();
            Obj2.F();
            Obj2.F2();

            Z Obj3 = new Z();
            Obj3.F();
            Obj3.F2();

            Console.WriteLine("\n");
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
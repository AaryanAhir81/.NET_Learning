using System;

namespace _02_Tutorial
{
    internal class P8
    {
        public static void Program_8()
        {
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
            Console.WriteLine("Division: G");
            Console.WriteLine("Branch: BTech IT");
            Console.WriteLine("Roll No: 01");
            Console.WriteLine();

            NumberManipulator8 n = new NumberManipulator8();

            int a, b, c, sum;

            sum = n.getValues(out a, out b, out c);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);
            Console.WriteLine("After method call, value of c : {0}", c);
            Console.WriteLine("Sum : {0}", sum);

            Console.ReadKey();
        }
    }

    class NumberManipulator8
    {
        public int getValues(out int x, out int y, out int z)
        {
            Console.Write("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());

            z = x + y;

            return z;
        }
    }
}
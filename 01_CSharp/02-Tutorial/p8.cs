using System;

namespace _02_Tutorial
{
    class p8
    {
        public int getValues(out int x, out int y, out int z)
        {
            Console.Write("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third value: ");
            z = Convert.ToInt32(Console.ReadLine());

            int sum = x + y + z;

            return sum;
        }
    }

    class TestOut
    {
        static void Main(string[] args)
        {
            p8 n = new p8();

            int a, b, c, sum;

            sum = n.getValues(out a, out b, out c);

            Console.WriteLine("\nAfter method call:");
            Console.WriteLine("Value of a : {0}", a);
            Console.WriteLine("Value of b : {0}", b);
            Console.WriteLine("Value of c : {0}", c);
            Console.WriteLine("Sum : {0}", sum);

            Console.ReadKey();
        }
    }
}
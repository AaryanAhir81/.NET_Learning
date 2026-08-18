using System;

namespace _03_Tutorial
{
    class Product
    {
        int pcode;
        string mname;
        string pname;

        public Product(int pcd, string pnm, string mnm)
        {
            mname = mnm;
            pname = pnm;
            pcode = pcd;
        }

        public void Display()
        {
            Console.WriteLine("\nManufacturer Name := " + mname);
            Console.WriteLine("\nProduct Code := " + pcode);
            Console.WriteLine("\nProduct Name := " + pname);
            Console.WriteLine("\n");
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }

    public class TestProduct
    {
        public static void Run(string[] args)
        {
            int n = args.Length;

            if (n < 3)
            {
                Console.WriteLine("Syntax Error\n");
                Console.WriteLine("Must Have THREE Arguments\n");
            }
            else
            {
                int pcd = Convert.ToInt32(args[0]);
                string pnm = args[1];
                string mnm = args[2];

                Product p = new Product(pcd, pnm, mnm);

                p.Display();

                Console.Read();
            }
        }
    }
}
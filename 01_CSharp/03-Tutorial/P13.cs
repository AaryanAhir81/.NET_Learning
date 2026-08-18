using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Tutorial
{
    internal class P13
    {
        private string name;
        private int quantity;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double BillAmount
        {
            get { return quantity * price; }
        }

        public static void ProductDetails(string[] args)
        {
            P13 p = new P13();

            Console.Write("Enter Product Name: ");
            p.Name = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            p.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price: ");
            p.Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n--- Product Bill ---");
            Console.WriteLine("Product Name: " + p.Name);
            Console.WriteLine("Quantity: " + p.Quantity);
            Console.WriteLine("Price: " + p.Price);
            Console.WriteLine("Bill Amount: " + p.BillAmount);
            Console.WriteLine("\n");
            //Personal Details
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");

            Console.ReadLine();
        }
    }
}

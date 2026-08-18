using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Tutorial
{
    internal class P8
    {
        private string name;
        private string enrollmentNo;
        private int age;

        public P8(string name, string enrollmentNo, int age)
        {
            this.name = name;
            this.enrollmentNo = enrollmentNo;
            this.age = age;
        }

        public void Display()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Enrollment No: " + enrollmentNo);
            Console.WriteLine("Age: " + age);
        }

        public static void P8Run(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Enrollment No: ");
            string enrollmentNo = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            P8 s = new P8(name, enrollmentNo, age);

            s.Display();

            Console.ReadLine();

            //Personal Details
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
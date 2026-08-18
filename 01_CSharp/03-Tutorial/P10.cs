using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Tutorial
{
    internal class P10
    {
        private string name;
        private double salary;

        public P10(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public double CalculateNetSalary()
        {
            return salary - (salary * 0.10);
        }

        public void Display()
        {
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Net Salary: " + CalculateNetSalary());
        }

        public static void P10Run(string[] args)
        {
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            P10 e = new P10(name, salary);

            e.Display();

            Console.ReadLine();

            //Personal Details
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
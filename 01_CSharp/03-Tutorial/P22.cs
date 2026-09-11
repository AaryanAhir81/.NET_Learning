using System;

namespace _03_Tutorial
{
    internal class P22
    {
        public static void EmpShow(string[] args)
        {
            Department d = new Department();

            d.Empname();
            d.Empstatus();

            // Personal Details
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }

        public void Empname()
        {
            Console.WriteLine("Employee is working");
        }

        class Department : P22
        {
            public void Empstatus()
            {
                Console.WriteLine("Employee is not working");
            }
        }
    }
}
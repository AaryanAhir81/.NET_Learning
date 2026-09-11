using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Tutorial
{
    internal class P18
    {
        // Base class
        class Employee
        {
            public virtual void GenerateSalarySlip()
            {
                Console.WriteLine("Employee Salary Slip");
            }
        }

        // Permanent Employee
        class PermanentEmployee : Employee
        {
            public override void GenerateSalarySlip()
            {
                Console.Write("Enter Basic Salary: ");
                double basicSalary = Convert.ToDouble(Console.ReadLine());

                double hra = basicSalary * 0.20;
                double da = basicSalary * 0.10;
                double totalSalary = basicSalary + hra + da;

                Console.WriteLine("\n--- Permanent Employee Salary Slip ---");
                Console.WriteLine("Basic Salary : " + basicSalary);
                Console.WriteLine("HRA          : " + hra);
                Console.WriteLine("DA           : " + da);
                Console.WriteLine("Total Salary : " + totalSalary);
            }
        }

        // Contract Employee
        class ContractEmployee : Employee
        {
            public override void GenerateSalarySlip()
            {
                Console.Write("Enter Contract Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n--- Contract Employee Salary Slip ---");
                Console.WriteLine("Contract Salary : " + salary);
                Console.WriteLine("Total Salary    : " + salary);
            }
        }

        public static void P18Run()
        {
            Employee employee;

            Console.WriteLine("1. Permanent Employee");
            Console.WriteLine("2. Contract Employee");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                employee = new PermanentEmployee();
                employee.GenerateSalarySlip();
            }
            else if (choice == 2)
            {
                employee = new ContractEmployee();
                employee.GenerateSalarySlip();
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }

            //Personal Details
            Console.WriteLine("\n");
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");

            Console.ReadLine();
        }
    }
}
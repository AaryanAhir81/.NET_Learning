using System;

namespace _03_Tutorial
{
    class Employee
    {
        private double salary;

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public void ShowSalary()
        {
            Console.WriteLine("Employee Salary: " + salary);
        }
    }

    class Manager : Employee
    {
        public void Display()
        {
            Console.WriteLine("\n--- Manager Details ---");
            ShowSalary();
            Console.WriteLine("\n");
        }
    }

    public class EmployeeInheritance
    {
        public static void Run()
        {
            Manager m = new Manager();

            Console.Write("Enter Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            m.SetSalary(salary);
            m.Display();

            //Personal Details
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
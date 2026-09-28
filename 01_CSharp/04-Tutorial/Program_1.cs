using System;

namespace _04_Tutorial
{
    internal class Employee
    {
        private int emp_code;
        private string emp_name;
        private string designation;
        private double basicpay;

        public Employee(int emp_code, string emp_name, string designation, double basicpay)
        {
            this.emp_code = emp_code;
            this.emp_name = emp_name;
            this.designation = designation;
            this.basicpay = basicpay;
        }

        public void calculatorPay()
        {
            double hra = 0.10 * basicpay;
            double da = 0.45 * basicpay;
            double totalpay = basicpay + hra + da;

            Console.WriteLine("Employee Code: " + emp_code);
            Console.WriteLine("Employee Name: " + emp_name);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Basic Pay: " + basicpay);
            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("DA: " + da);
            Console.WriteLine("Total Pay: " + totalpay);
            Console.WriteLine("---------------------------");
        }

        public static void Program_1()
        {
            Employee e1 = new Employee(101, "Aaryan", "Full Stack", 1200);
            e1.calculatorPay();

            Employee e2 = new Employee(102, "Smit", "Full Stack", 1300);
            e2.calculatorPay();

            Employee e3 = new Employee(103, "Rahul", "Developer", 1500);
            e3.calculatorPay();

            Console.WriteLine("\n");
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
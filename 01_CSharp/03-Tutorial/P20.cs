using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Tutorial
{
    internal class P20
    {
        class Student
        {
            string name;
            int age;

            // Constructor
            public Student(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void Display()
            {
                Console.WriteLine("Student Name : " + name);
                Console.WriteLine("Student Age  : " + age);
            }
        }

        public static void P20Run()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Student student = new Student(name, age);

            Console.WriteLine("\nStudent Details");
            Console.WriteLine("----------------");

            student.Display();

            //Personal Details
            Console.WriteLine("\n");
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");

            Console.ReadLine();
        }
    }
}
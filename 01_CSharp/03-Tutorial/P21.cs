using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Tutorial
{
    internal class P21
    {
        // Base class
        class Person
        {
            protected string name;
            protected int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        // Derived class
        class Student : Person
        {
            int rollNo;

            public Student(string name, int age, int rollNo)
                : base(name, age)
            {
                this.rollNo = rollNo;
            }

            public void Display()
            {
                Console.WriteLine("Student Name : " + name);
                Console.WriteLine("Student Age  : " + age);
                Console.WriteLine("Roll Number   : " + rollNo);
            }
        }

        public static void P21Run()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Roll Number: ");
            int rollNo = Convert.ToInt32(Console.ReadLine());

            Student student = new Student(name, age, rollNo);

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
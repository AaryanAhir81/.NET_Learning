using System;

namespace _03_Tutorial
{
    class Person
    {
        protected string name;
        protected int age;

        public void GetDetails()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Student : Person
    {
        private string course;

        public void Display()
        {
            GetDetails();

            Console.Write("Enter Course: ");
            course = Console.ReadLine();

            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("\n");
        }
    }

    public class Inheritance
    {
        public static void Run()
        {
            Student s = new Student();
            s.Display();

            //Personal Details
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Tutorial
{
    internal class P19
    {
        class Student
        {
            // Static variable shared by all objects
            static int studentCount = 0;

            public Student()
            {
                studentCount++;
            }

            public static void DisplayCount()
            {
                Console.WriteLine("Total Students Created: " + studentCount);
            }
        }

        public static void P19Run()
        {
            Console.Write("Enter number of students to create: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Student student = new Student();
            }

            Student.DisplayCount();

            //Personal Details
            Console.WriteLine("\n");
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");

            Console.ReadLine();
        }
    }
}
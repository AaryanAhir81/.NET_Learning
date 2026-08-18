using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace _03_Tutorial
{
    internal class P1
    {
        class Student
        {
            //This is Data members
            private int EnrollmentNo;
            private string name;
            private string branch;

            //This is AcceptData Method
            public void AcceptData(int e, string n, string b)
            {
                EnrollmentNo = e;
                name = n;
                branch = b;
            }

            //This is DisplayData Method
            public void DisplayData()
            {
                Console.WriteLine("--------Student Details----------");
                Console.WriteLine("\n");
                Console.WriteLine("Enrollment No: " + EnrollmentNo);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Branch: " + branch);
                Console.WriteLine("\n");

            }

        }
        public static void Program_1()
        {
            //creating a object of student class
            Student s1 = new Student();
            Student s2 = new Student();

            //Calling Methods
            s1.AcceptData(101, "Alice", "Computer Science");
            s1.DisplayData();

            s2.AcceptData(102, "John", "IT");
            s2.DisplayData();

            //Personal Details
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Tutorial
{
    internal class P3
    {
        class Student
        {
            public int id;
            public string name;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public Student() // Empty constructor
            {
                id = 0;
                name = "Unknown";
            }

            public Student(int i, string n) // Parameterized constructor
            {
                id = i;
                name = n;
            }

            public void DisplayData()
            {
                Console.WriteLine("ID: " + id);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("\n");
            }

        }

        public static void Program_3()
        {
            Student s = new Student(101,"Aaryan");
            s.DisplayData();

            //Personal Details
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}

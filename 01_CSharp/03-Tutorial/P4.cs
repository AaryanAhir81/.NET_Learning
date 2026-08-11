using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Tutorial
{
    internal class P4
    {
        class Student
        {
            private int EnrollmentNo;
            private string name;
            private string branch;

            public void AcceptData(int e, string n, string b)
            {
                EnrollmentNo = e;
                name = n;
                branch = b;
            }

            public void DisplayData()
            {
                Console.WriteLine("Enrollment No: " + EnrollmentNo);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Branch: " + branch);
            }

        }
        public static void Program_4()
        {
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            Student s5 = new Student();

            s1.AcceptData(101, "Alice", "Computer Science");
            s1.DisplayData();

            s2.AcceptData(102, "John", "Computer Science");
            s2.DisplayData();

            s3.AcceptData(102, "Aaryan", "IT");
            s3.DisplayData();

            s4.AcceptData(102, "Smit", "IT");
            s4.DisplayData();

            s5.AcceptData(102, "Yash", "IT");
            s5.DisplayData();

            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}

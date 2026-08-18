using System;

namespace _03_Tutorial
{
    internal class P7
    {
        private string enrolmentNo;
        private string name;

        public string EnrolmentNo
        {
            get { return enrolmentNo; }
            set { enrolmentNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public P7()
        {
            Console.WriteLine("Student object created.");
        }

        public void Display()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Enrolment No: " + EnrolmentNo);
            Console.WriteLine("Name: " + Name);
        }

        public static void P7Run(string[] args)
        {
            P7 s = new P7();

            Console.Write("Enter Enrolment No: ");
            s.EnrolmentNo = Console.ReadLine();

            Console.Write("Enter Name: ");
            s.Name = Console.ReadLine();

            s.Display();

            Console.ReadLine();

            //Personal Details
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
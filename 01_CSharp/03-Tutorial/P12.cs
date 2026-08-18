using System;

namespace _03_Tutorial
{
    internal class P12
    {
        private string name;
        private string enrollmentNo;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string EnrollmentNo
        {
            get { return enrollmentNo; }
            set { enrollmentNo = value; }
        }

        public void GetDetails()
        {
            Console.Write("Enter Your Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Your Enrollment No: ");
            EnrollmentNo = Console.ReadLine();
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Enrollment No: " + EnrollmentNo);
            Console.WriteLine("\n");
        }

        public static void SD(string[] args)
        {
            P12 student = new P12();

            student.GetDetails();
            student.DisplayDetails();

            //Personal Details
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
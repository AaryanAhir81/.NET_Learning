    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace _03_Tutorial
    {
        // Sealed class
        sealed class StudentResult
        {
            private int rollNo;
            private string name;
            private int marks;

            // Constructor
            public StudentResult(int rollNo, string name, int marks)
            {
                this.rollNo = rollNo;
                this.name = name;
                this.marks = marks;
            }

            // Display result
            public void DisplayResult()
            {
                Console.WriteLine("Student Result");
                Console.WriteLine("----------------");
                Console.WriteLine("Roll No : " + rollNo);
                Console.WriteLine("Name    : " + name);
                Console.WriteLine("Marks   : " + marks);

                if (marks >= 35)
                {
                    Console.WriteLine("Result  : PASS");
                }
                else
                {
                    Console.WriteLine("Result  : FAIL");
                }
            }
        }

        internal class P24
        {
            public static void Program_24()
            {
                // Create object of sealed class
                StudentResult s = new StudentResult(101, "Shreya", 78);

                // Call method
                s.DisplayResult();

                //Personal Details
                Console.WriteLine("\n");
                Console.WriteLine("Name: Bharvadiya Aaryan V");
                Console.WriteLine("Enrollment No: 25SOEIT13013");
            }
        }
    }
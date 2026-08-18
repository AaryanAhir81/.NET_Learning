using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Tutorial
{
    internal class P2
    {
        class clock
        {
            private int hour;
            private int min;
            private int sec;

            // Default Constructor
            public clock()
            {
                hour = 0;
                min = 0;
                sec = 0;
            }

            // Parameterized Constructor
            public clock(int h, int m, int s)
            {
                hour = h;
                min = m;
                sec = s;
            }

            // Increment time by 1 second
            public void increment()
            {
                sec++;

                if (sec == 60)
                {
                    sec = 0;
                    min++;

                    if (min == 60)
                    {
                        min = 0;
                        hour++;

                        if (hour == 24)
                        {
                            hour = 0;
                        }
                    }
                }
            }

            // Display time
            public void display()
            {
                Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
            }

            // Getter for Hour
            public int GetHour()
            {
                return hour;
            }

            // Getter for Minute
            public int GetMin()
            {
                return min;
            }

            // Getter for Second
            public int GetSec()
            {
                return sec;
            }
        }

        public static void Program_2()
        {
            // Using default constructor
            clock c1 = new clock();

            Console.WriteLine("Default time:");
            c1.display();

            // Using parameterized constructor
            clock c2 = new clock(10, 59, 00);

            Console.WriteLine("\nInitial time:");
            c2.display();

            // Increment by 1 second
            c2.increment();

            Console.WriteLine("\nAfter 1 second:");
            c2.display();

            // Increment by another 1 second
            c2.increment();

            Console.WriteLine("\nAfter 2 second:");
            c2.display();

            // Display individual values
            Console.WriteLine("\nHour: " + c2.GetHour());
            Console.WriteLine("Minute: " + c2.GetMin());
            Console.WriteLine("Second: " + c2.GetSec());

            // Student details
            Console.WriteLine("\nName: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
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

            public clock()
            {
                hour = 0;
                min = 0;
                sec = 0;

            }

            public clock(int h, int m, int s)
            {
                hour = h;
                min = m;
                sec = s;
            }

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

            public void display()
            {
                Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
            }

            public int GetHour()
            {
                return hour;
            }

            public int GetMin()
            {
                return min;
            }

            public int GetSec()
            {
                return sec;
            }
        }

        public static void Program_2()
        {
            clock c1 = new clock();
            Console.WriteLine("Default time: ");
            c1.display();

            clock c2 = new clock(10,59,00);
            Console.WriteLine("Initial time: ");
            c2.display();

            c2.increment();
            Console.WriteLine("After 1 second: ");
            c2.display();


            c2.increment();
            Console.WriteLine("After 2 second: ");
            c2.display();

            Console.WriteLine("Hour: " + c2.GetHour());
            Console.WriteLine("Minute: " + c2.GetMin());
            Console.WriteLine("Second: " + c2.GetSec());

            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");

        }
    }
}

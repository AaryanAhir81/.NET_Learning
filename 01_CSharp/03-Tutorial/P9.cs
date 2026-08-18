using System;

namespace _03_Tutorial
{
    class Clock
    {
        private int hour;
        private int minute;
        private int second;

        public Clock()
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
        }

        public void DisplayTime()
        {
            Console.WriteLine("Current Time: {0:D2}:{1:D2}:{2:D2}",
                hour, minute, second);
        }

        public void IncrementSecond()
        {
            second++;

            if (second == 60)
            {
                second = 0;
                minute++;
            }

            if (minute == 60)
            {
                minute = 0;
                hour++;
            }
        }
    }

    internal class P9
    {
        public static void P9Run(string[] args)
        {
            Clock c = new Clock();

            c.DisplayTime();

            c.IncrementSecond();

            Console.WriteLine("After 1 Second:");
            c.DisplayTime();

            Console.ReadLine();

            //Personal Details
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
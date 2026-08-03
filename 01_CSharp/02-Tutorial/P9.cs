using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Tutorial
{
    internal class P9
    {
        public static void Program_9()
        {
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
            Console.WriteLine("Division: G");
            Console.WriteLine("Branch: BTech IT");
            Console.WriteLine("Roll No: 01");
            Console.WriteLine("\n");
            int[] arr = { 1, 2, 3, 4, 5, 2, 6, 1 };
            //int[] arr = {2,1,3,2};

            Console.WriteLine("Numbers occuring one: ");

            for(int i=0; i < arr.Length; i++)
            {
                int count = 0;

                for(int j = 0; j < arr.Length; j++) 
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if(count == 1)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace _01_CSharp
    {
        internal class increased_by_one
        {
            public static void increased_demo()
            {
                int rows, num = 1;

                Console.Write("Enter the number of rows: ");
                rows = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(num + " ");
                        num++;
                    }
                    Console.WriteLine();
                }
            }
        }
    }

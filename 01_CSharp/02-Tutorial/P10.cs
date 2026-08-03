using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Tutorial
{
    internal class P10
    {
        public static void Program_10()
        {
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
            Console.WriteLine("Division: G");
            Console.WriteLine("Branch: BTech IT");
            Console.WriteLine("Roll No: 01");
            Console.WriteLine();

            Console.Write("Enter number of rows: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int M = Convert.ToInt32(Console.ReadLine());

            int[,] mat = new int[N, M];

            Console.WriteLine("Enter matrix elements:");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    mat[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Enter element to search: ");
            int X = Convert.ToInt32(Console.ReadLine());

            int result = MatSearch(mat, N, M, X);

            Console.WriteLine("Output: " + result);
        }

        static int MatSearch(int[,] mat, int N, int M, int X)
        {
            int i = 0;
            int j = M - 1;

            while (i < N && j >= 0)
            {
                if (mat[i, j] == X)
                {
                    return 1;
                }
                else if (mat[i, j] > X)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return 0;
        }
    }
}
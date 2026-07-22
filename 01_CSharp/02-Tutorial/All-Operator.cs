//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace _02_Tutorial
//{
//    internal class All_Operator
//    {
//        public static void operator_demo()
//        {
//            Console.Write("Enter First Number: ");
//            int a = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter Second Number: ");
//            int b = Convert.ToInt32(Console.ReadLine());

//            // =========================
//            // Arithmetic Operators
//            // =========================
//            Console.WriteLine("\nArithmetic Operators");
//            Console.WriteLine("Addition = " + (a + b));
//            Console.WriteLine("Subtraction = " + (a - b));
//            Console.WriteLine("Multiplication = " + (a * b));
//            Console.WriteLine("Division = " + (a / b));
//            Console.WriteLine("Modulus = " + (a % b));

//            // =========================
//            // Assignment Operators
//            // =========================
//            Console.WriteLine("\nAssignment Operators");

//            int x = a;

//            x += b;
//            Console.WriteLine("x += b = " + x);

//            x -= b;
//            Console.WriteLine("x -= b = " + x);

//            x *= b;
//            Console.WriteLine("x *= b = " + x);

//            x /= b;
//            Console.WriteLine("x /= b = " + x);

//            x %= b;
//            Console.WriteLine("x %= b = " + x);

//            // =========================
//            // Conditional (Relational) Operators
//            // =========================
//            Console.WriteLine("\nConditional Operators");

//            Console.WriteLine("a == b : " + (a == b));
//            Console.WriteLine("a != b : " + (a != b));
//            Console.WriteLine("a > b : " + (a > b));
//            Console.WriteLine("a < b : " + (a < b));
//            Console.WriteLine("a >= b : " + (a >= b));
//            Console.WriteLine("a <= b : " + (a <= b));

//            // =========================
//            // Logical Operators
//            // =========================
//            Console.WriteLine("\nLogical Operators");

//            bool p = a > b;
//            bool q = a == b;

//            Console.WriteLine("p && q : " + (p && q));
//            Console.WriteLine("p || q : " + (p || q));
//            Console.WriteLine("!p : " + (!p));

//            // =========================
//            // Bitwise Operators
//            // =========================
//            Console.WriteLine("\nBitwise Operators");

//            Console.WriteLine("a & b = " + (a & b));
//            Console.WriteLine("a | b = " + (a | b));
//            Console.WriteLine("a ^ b = " + (a ^ b));
//            Console.WriteLine("~a = " + (~a));
//            Console.WriteLine("a << 1 = " + (a << 1));
//            Console.WriteLine("a >> 1 = " + (a >> 1));

//            // =========================
//            // Ternary Operator
//            // =========================
//            Console.WriteLine("\nTernary Operator");

//            string result = (a > b) ? "First Number is Greater" : "Second Number is Greater or Equal";
//            Console.WriteLine(result);
//        }
//    }
//}

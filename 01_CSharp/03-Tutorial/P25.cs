using System;

namespace _03_Tutorial
{
    internal class P25
    {
        public static void Program_25()
        {
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            // Validate password length
            if (password.Length >= 8)
            {
                Console.WriteLine("Password Length: Valid");
            }
            else
            {
                Console.WriteLine("Password Length: Invalid");
            }

            // Check for digit
            if (password.Contains("1") ||
                password.Contains("2") ||
                password.Contains("3") ||
                password.Contains("4") ||
                password.Contains("5") ||
                password.Contains("6") ||
                password.Contains("7") ||
                password.Contains("8") ||
                password.Contains("9") ||
                password.Contains("0"))
            {
                Console.WriteLine("Contains Number: Yes");
            }
            else
            {
                Console.WriteLine("Contains Number: No");
            }

            // Modify password
            string newPassword = password.Replace(" ", "");

            Console.WriteLine("Original Password: " + password);
            Console.WriteLine("Modified Password: " + newPassword);
            Console.WriteLine("Uppercase: " + newPassword.ToUpper());
            Console.WriteLine("Lowercase: " + newPassword.ToLower());

            //Personal Details
            Console.WriteLine("\n");
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
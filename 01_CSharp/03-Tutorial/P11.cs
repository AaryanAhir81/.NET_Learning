using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _03_Tutorial
{
    internal class P11
    {
        private int accNo;
        private string accHolderName;
        private double accBalance;

        public P11(int ano,string name, double balance)
        {
            accNo = ano;
            accHolderName = name;
            accBalance = balance;
        }

        public void Deposite(double amount)
        {
            accBalance += amount;
            Console.WriteLine("Amount Deposited Successfully.");

        }

        public void Withdraw(double amount)
        {
            if (amount > accBalance)
            {
                Console.WriteLine("Insufficient Balance.");
            }
            else
            {
                accBalance -= amount;
                Console.WriteLine("Amount Withdrawn Successfully.");
            }
        }

            public void BalanceEnquiry()
            {
                Console.WriteLine("\n------------Balance Enquiry------------");
                Console.WriteLine("Account Number: " + accNo);
                Console.WriteLine("Account Holder Name: " + accHolderName);
                Console.WriteLine("Account Balance: " + accBalance);
            Console.WriteLine("\n");
            }

        public static void AccountDetails(string[] args)
        {
            P11 b1 = new P11(10012, "Aaryan", 50000);
            Console.WriteLine("------------Account - 1 Transaction------------");
            b1.Deposite(2000);
            b1.Withdraw(3000);
            b1.BalanceEnquiry();

            P11 b2 = new P11(10013, "Smit", 60000);
            Console.WriteLine("------------Account - 2 Transaction------------");
            b2.Deposite(2000);
            b2.Withdraw(3000);
            b2.BalanceEnquiry();

            //Personal Details
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}

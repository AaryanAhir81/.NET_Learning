using System;

namespace _03_Tutorial
{
    abstract class Account
    {
        protected double amount;

        public Account(double amount)
        {
            this.amount = amount;
        }

        public abstract void CalculateInterest();
    }

    class SavingAccount : Account
    {
        public SavingAccount(double amount) : base(amount)
        {
        }

        public override void CalculateInterest()
        {
            Console.WriteLine("Saving Account Interest = " + (amount * 4 / 100));
        }
    }

    class CurrentAccount : Account
    {
        public CurrentAccount(double amount) : base(amount)
        {
        }

        public override void CalculateInterest()
        {
            Console.WriteLine("Current Account Interest = " + (amount * 2 / 100));
        }
    }

    class P23
    {
        public static void Program_23()
        {
            // Create Saving Account object
            SavingAccount a = new SavingAccount(10000);

            // Call method
            a.CalculateInterest();

            // Create Current Account object
            CurrentAccount b = new CurrentAccount(10000);

            // Call method
            b.CalculateInterest();

            //Personal Details
            Console.WriteLine("\n");
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}
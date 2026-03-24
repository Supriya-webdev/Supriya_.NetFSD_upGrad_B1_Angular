using System;
using System.Collections.Generic;
using System.Text;

namespace C__Inheritance_Assignment
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        // Virtual method allows overriding in derived classes
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Base account interest calculation");
        }
    }

    // SavingsAccount inherits from Account
    public class SavingsAccount : Account
    {
        // Override base method
        public override void CalculateInterest()
        {
            Console.WriteLine("Savings account interest calculation");
        }
    }

    // CurrentAccount inherits from Account
    public class CurrentAccount : Account
    {
        // Override base method
        public override void CalculateInterest()
        {
            Console.WriteLine("Current account interest calculation");
        }
    }

    internal class Assignment2
    {
        static void Main()
        {
                Console.WriteLine("Using base class reference:");
                Account acc1 = new SavingsAccount();
                acc1.CalculateInterest(); // Prints Savings account interest

                Account acc2 = new CurrentAccount();
                acc2.CalculateInterest(); // Prints Current account interest

                Console.WriteLine("\nUsing derived class reference:");
                SavingsAccount sa = new SavingsAccount();
                sa.CalculateInterest(); // Prints Savings account interest

                CurrentAccount ca = new CurrentAccount();
                ca.CalculateInterest(); // Prints Current account interest

                Console.WriteLine("\nUsing base class object:");
                Account baseAcc = new Account();
                baseAcc.CalculateInterest(); // Prints Base account interest

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling_assignment
{
    public class CheckBalanceException : Exception
    {
        public CheckBalanceException(string message) : base(message) { }
    }

    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public static double Balance { get; private set; } = 500; 

        public void Transaction(char type, double amount)
        {
            try
            {
                if (type == 'd' || type == 'D') 
                {
                    Balance += amount;
                    Console.WriteLine($"Deposited {amount}. Current Balance: {Balance}");
                }
                else if (type == 'c' || type == 'C') 
                {
                    if (Balance - amount < 500)
                        throw new CheckBalanceException("Insufficient balance! Minimum balance should be 500.");
                    Balance -= amount;
                    Console.WriteLine($"Withdrawn {amount}. Current Balance: {Balance}");
                }
                else
                {
                    Console.WriteLine("Invalid transaction type. Use 'd' for deposit or 'c' for credit.");
                }
            }
            catch (CheckBalanceException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
    internal class Problem1
    {
        static void Main()
        {
            BankAccount account = new BankAccount
            {
                AccountNumber = "12345",
                Name = "Supriya"
            };

            account.Transaction('d', 200);  
            account.Transaction('c', 300);  
            account.Transaction('c', 500);  
        }
    }
}
    

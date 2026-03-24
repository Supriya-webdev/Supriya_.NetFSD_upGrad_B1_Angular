using System;
using System.Collections.Generic;
using System.Text;

namespace C__Multithreading_Assignment
{
    class BankAccount
    {
        public double Balance { get; private set; }

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        private readonly object _lock = new object(); 

        public void Withdraw(double amount)
        {
            lock (_lock) 
            {
                if (Balance >= amount)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} is withdrawing {amount}");
                    double temp = Balance;
                    Thread.Sleep(100); 
                    temp -= amount;
                    Balance = temp;
                    Console.WriteLine($"{Thread.CurrentThread.Name} completed withdrawal. Remaining Balance: {Balance}");
                }
                else
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} cannot withdraw {amount}. Insufficient balance.");
                }
            }
        }
    }
    internal class Assignment2
    {
        static void Main()
        {
            BankAccount account = new BankAccount(1000);

            Thread t1 = new Thread(() => account.Withdraw(700)) { Name = "User 1" };
            Thread t2 = new Thread(() => account.Withdraw(500)) { Name = "User 2" };
            Thread t3 = new Thread(() => account.Withdraw(300)) { Name = "User 3" };

            t1.Start(); t2.Start(); t3.Start();
            t1.Join(); t2.Join(); t3.Join();

            Console.WriteLine($"\nFinal Balance: {account.Balance}");
        }
    }
}
  

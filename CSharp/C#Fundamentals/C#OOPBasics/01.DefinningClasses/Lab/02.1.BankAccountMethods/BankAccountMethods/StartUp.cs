using System;

namespace BankAccount
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            acc.Id = 1;
            acc.Deposit(10);
            acc.Withdraw(15);

            Console.WriteLine(acc);
        }
    }
}

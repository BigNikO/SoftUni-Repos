using System;
using System.Collections.Generic;

namespace TestClient
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<int, BankAccount> bankAccounts = new Dictionary<int, BankAccount>();

            string commands = "";

            while ((commands = Console.ReadLine()) != "End")
            {
                string command = commands.Split()[0];

                switch (command)
                {
                    case "Create":
                        Create(commands, bankAccounts);
                        break;
                    case "Deposit":
                        Deposit(commands, bankAccounts);
                        break;
                    case "Withdraw":
                        Withdraw(commands, bankAccounts);
                        break;
                    case "Print":
                        Print(commands, bankAccounts);
                        break;
                    default:
                        break;
                }
            }
        }
        private static void Print(string commands, Dictionary<int, BankAccount> bankAccounts)
        {
            int id = int.Parse(commands.Split()[1]);

            if (!bankAccounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine(bankAccounts[id]);
            }
        }

        private static void Withdraw(string commands, Dictionary<int, BankAccount> bankAccounts)
        {
            int id = int.Parse(commands.Split()[1]);
            int ammount = int.Parse(commands.Split()[2]);

            if (!bankAccounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                bankAccounts[id].Withdraw(ammount);
            }
        }

        private static void Deposit(string commands, Dictionary<int, BankAccount> bankAccounts)
        {
            int id = int.Parse(commands.Split()[1]);
            int ammount = int.Parse(commands.Split()[2]);

            if (!bankAccounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                bankAccounts[id].Deposit(ammount);
            }
        }

        private static void Create(string commands, Dictionary<int, BankAccount> bankAccounts)
        {
            int id = int.Parse(commands.Split()[1]);

            if (bankAccounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var newAccount = new BankAccount();
                newAccount.Id = id;
                bankAccounts.Add(id, newAccount);
            }
        }
    }
}

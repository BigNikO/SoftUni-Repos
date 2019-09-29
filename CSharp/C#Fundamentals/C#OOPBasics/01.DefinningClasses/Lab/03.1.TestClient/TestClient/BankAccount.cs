namespace TestClient
{
    public class BankAccount
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (this.Balance>=amount)
            {
                this.Balance -= amount;
            }
            else
            {
                System.Console.WriteLine("Insufficient balance");
            }
        }

        public override string ToString()
        {
            return $"Account ID{this.Id}, balance {this.Balance:F2}";
        }
    }
}

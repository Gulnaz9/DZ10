
namespace Lab11
{
    internal class Bank
    {
        private int accountNumber;
        public int AccountNumber { get { return accountNumber;} set { accountNumber = value;} }
        private decimal balance;
        public decimal Balance { get { return balance; }  set { balance = value; } }
        internal Bank(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }
        internal Bank(int accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }
    }
}

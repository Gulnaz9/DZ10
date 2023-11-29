
namespace Lab12.Ex1
{
    internal class Bank
    {

        private int accountNumber;
        public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
        private decimal balance;
        public decimal Balance { get { return balance; } set { balance = value; } }

        public Bank(int accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountNumber = accountNumber;
            Balance = balance;
            Balance = balance;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Bank other = (Bank)obj;
            return AccountNumber == other.AccountNumber && Balance == other.Balance;
        }

        public override int GetHashCode()
        {
            return AccountNumber; 
        }
        public override string ToString()
        {
            return $"Номер аккаунта: {AccountNumber}, баланс: {Balance}";
        }

        public static bool operator ==(Bank b1, Bank b2)
        {
            if (b1 == b2)
            {
                return true;
            }
            if (b1 is null || b2 is null)
            {
                return false;
            }
            return b1.AccountNumber == b2.AccountNumber && b1.Balance == b2.Balance;
        }

        public static bool operator !=(Bank b1, Bank b2)
        {
            return !(b1 == b2);
        }
    }
}

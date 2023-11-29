using System;
using System.Collections.Generic;

namespace Lab11
{
    internal class BankFactory
    {
        private Dictionary<int, Bank> accounts = new Dictionary<int, Bank>();
        private int nextAccNumber = 1;

        public int CreateAccount()
        {
            Bank newAcc = new Bank(nextAccNumber);
            accounts.Add(nextAccNumber, newAcc);
            nextAccNumber++;
            return newAcc.AccountNumber;
        }

        public void CloseAccount(int accNumber)
        {
            accounts.Remove(accNumber);
        }

        public void AddMoney(int accountNumber, decimal m)
        {
           accounts[accountNumber].Balance += m;
        }

        public void MinusMoney(int accountNumber, decimal m)
        {
            if (accounts[accountNumber].Balance >= m)
            {
               accounts[accountNumber].Balance -= m;
            }
            else
            {
               Console.WriteLine("Недостаточно средств");
            }
        }

        public int CreateAccount(decimal initialBalance)
        {
            int accountNumber = CreateAccount();
            AddMoney(accountNumber, initialBalance);
            return accountNumber;
        }
    }
    
}

using System;
using System.Collections.Generic;

namespace ConceptArchitect.Banking
{
    public class Bank
    {
        BankAccount[] accounts = new BankAccount[10];
        public string Name { get; set; }
        public double InterestRate { get; set; }
        public int AccountCount { get; private set; }

        public Bank(string name, double interestRate)
        {
            this.Name = name;
            this.InterestRate = interestRate;
        }

        public int lastId = 0;

        public int OpenAccount(string name, string password, double amount)
        {
            AccountCount++;
            lastId++;
            var account = new BankAccount(AccountCount, name, password, amount);
            accounts[lastId] = account;
            
            return lastId;
        }

        public double CloseAccount(int accountNo, string password)
        {
            var account = GetAccount(accountNo);
            if (account==null || account.Balance < 0||!account.Authenticate(password))
                return double.NaN ;
            var balance = account.Balance;
            account.Withdraw(balance, password);
            account.AccountNumber *= -1;
            AccountCount--;
            return balance;
        }

        public double GetAccountBalance(int accountNo, string password)
        {
            var account = GetAccount(accountNo);
            if (account == null || !account.Authenticate(password))
                return double.NaN;
            return account.Balance;
        }

        public bool Deposit(int accountNo, double amount)
        {
            var account=GetAccount(accountNo);
            if (account == null) return false;
            return accounts[accountNo].Deposit(amount);
        }

        public bool Withdraw(int accountNo, double amount, string password)
        {
            var account = GetAccount(accountNo);
            if (account == null) return false;

            return accounts[accountNo].Withdraw(amount, password);
        }

        public bool Transfer(int source, double amount, string password, int target)
        {
            var account = GetAccount(source);
            var account2 = GetAccount(target);
            if (account == null || account2 == null || !account.Authenticate(password) || amount <= 0 || amount > account.Balance)
                return false;
            else
            {
                account.Withdraw(amount, password);
                account2.Deposit(amount);
                return true;
            }
        }

        public void CreditInterest()
        {

        for(int i=1; i<=lastId; i++)
            {
                var account = GetAccount(i);
                if(account.IsActive)
                {
                    account.CreditInterest(InterestRate);
                }
            }    
        }

        private BankAccount GetAccount(int accountNo)
        {
            // only if the account no. is in a valid range and not close
            // else return null
            if (accountNo <= 0 || accountNo > lastId)
                return null;
            var account = accounts[accountNo];
            if (!account.IsActive)
                return null;
            else
                return account;
        }

        public bool ChangePassword(int accountNo, string currentPassword, string newPassword)
        {
            var account = GetAccount(accountNo);
            if (account == null || !account.IsActive)
            {
                return false;
            }
            else 
            {
                return account.ChangePassword(currentPassword, newPassword);
            }
          }
    }
}

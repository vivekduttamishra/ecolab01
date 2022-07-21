using System.Collections.Generic;

namespace ConceptArchitect.Banking
{
    public class Bank
    {
        BankAccount account;
        public string Name { get; set; }
        public double InterestRate { get; set; }
        public int AccountCount { get; private set; }

        public Bank(string name, double interestRate)
        {
            this.Name = name;
            this.InterestRate = interestRate;
        }
        public int OpenAccount(string name, string password, double amount)

        {
            AccountCount++;
            account = new BankAccount(AccountCount,name, password, amount);

            
            return AccountCount;
        }
        public double CloseAccount (int accountNo , string passsword)
        {
            double balance = GetAccountBalance(accountNo, passsword);
            if(double.IsNaN(balance))
                return double.NaN;
            if(balance < 0)
                return double.NaN;
            
            AccountCount--;

            return balance ;
        }
        public double GetAccountBalance(int accountNo, string password)
        {
            if (accountNo <= 0 || accountNo > AccountCount || !account.Authenticate(password))
                return double.NaN;
            return account.Balance;
            
        }
        public bool Deposit(int accountNo, double amount)
        {
            if(accountNo <= 0 || accountNo > AccountCount)
                return false;

            return account.Deposit(amount);
        }
  

    }
}
﻿


using System;

namespace ConceptArchitect.Banking
{

    public class BankAccount
    {
        //private int accountNumber;

        public int AccountNumber { get;  }

       // private string password;


        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }   
        //}

        public string Name { get; set; }



        public  double Balance { get; private set; }

         


        


        

        public BankAccount( int accountNumber, string name, string password, 
                                double initialAmount)
        {
            this.AccountNumber = accountNumber;
            this.Name = name;
            this.Password = password;
            this.Balance = initialAmount;
            //BankAccount.interestRate = interestRate;
        }

        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            else
                return false;
            
        }

        public bool Withdraw(int amount,string password)
        {
            if (amount <= 0)
                return false;
            if (amount > Balance)
                return false;
            else if (!Authenticate(password))
                return false;
            else
            {
                Balance -= amount;
                return true;
            }

        }

        

        internal bool TransferTo(BankAccount account2, int amount, string password)
        {
           
            if (amount <= 0 || amount > Balance || !Authenticate(password))
                return false;
            else
            {
                Balance -= amount;
                account2.Balance += amount;
                return true;
            }
                
        }

        public static bool Transfer(BankAccount account1, int amount, string password, BankAccount account2)
        {
            if (account1.Withdraw(amount, password))
            {
                account2.Deposit(amount);
                return true;
            }
            else
                return false;
        }

        public void Show()
        {
            Console.WriteLine($"Account Number:{AccountNumber}" +
                $"\nName:{Name}" +
                $"\nBalance:{Balance}");
        }


        private string password;

        public string Password
        {
            get { return password; }
            set { password = Encrypt(value); }
        }

        

        public bool Authenticate(string password)
        {
            return this.password.Equals(Encrypt(password));
        }

        public void CreditInterest(double interestRate)
        {

            Balance += (Balance * interestRate / 1200);
        }

        public void ChangePassword(string oldPassword, string newPassword)
        {
            if (Authenticate(oldPassword))
                Password = newPassword;
        }

      

        private string Encrypt(string value)
        {
            string result = "";
            foreach(char ch in value)
            {
                result += ((int)ch).ToString();
            }
            return result;
        }
    }
}

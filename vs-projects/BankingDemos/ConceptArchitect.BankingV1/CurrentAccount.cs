using System;

namespace ConceptArchitect.Banking
{
    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(int accountNumber, string name, string password, double initialAmount) 
            : base(accountNumber, name, password, initialAmount)
        {
        }

        public void CreditInterest(double rate)
        {

        }
    }
}
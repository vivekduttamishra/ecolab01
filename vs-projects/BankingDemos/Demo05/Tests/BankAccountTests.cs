using ConceptArchitect.Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demo04.Tests
{
    public class BankAccountTests
    {
        BankAccount account;
        int amount = 10000;
        double rate = 12;
        string password = "p@ss";

        public BankAccountTests()
        {
            account = new BankAccount(1, "Vivek", password, amount);
        }

       [Fact]
       public void BankAccountGetsTheDefaultInterestRateSetInInitialization()
        {
            Assert.Equal(BankAccount.InterestRate, account.ApplicableRate);
        }

        [Fact]
        public void RateChangeOnOneObjectChangesForAllObjects()
        {   
            var account2 = new BankAccount(2, "Someone else", password, amount);
            var newRate = rate + 1;

            BankAccount.InterestRate = newRate;

            Assert.Equal(newRate, account.ApplicableRate);
            Assert.Equal(newRate, account2.ApplicableRate);

        }
    }
}

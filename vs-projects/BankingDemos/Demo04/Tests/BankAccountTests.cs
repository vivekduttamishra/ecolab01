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
            account = new BankAccount(1, "Vivek", password, amount, rate);
        }

        [Fact]
        public void LatestInterestRateAppliesToAllAccounts()
        {
            var newRate = rate + 1;
            var account2 = new BankAccount(2, "Someone else", password, amount, newRate);

            Assert.Equal(newRate, account.InterestRate);
        }
    }
}

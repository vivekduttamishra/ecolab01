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
        BankAccount account1,account2;
        int amount = 10000;
        double rate = 12;
        string password = "p@ss";

        public BankAccountTests()
        {
           // BankAccount.lastId = 0;
            account1 = new BankAccount( "Vivek", password, amount);
            account2 = new BankAccount("Account 2", password, amount);
        }

       [Fact]
       public void BankAccountGetsTheDefaultInterestRateSetInInitialization()
        {
            Assert.Equal(BankAccount.InterestRate, account1.ApplicableRate);
        }

        [Fact]
        public void RateChangeOnOneObjectChangesForAllObjects()
        {   
            //ARRANGE
            var account2 = new BankAccount( "Someone else", password, amount);
            var newRate = rate + 1;
            
            //ACT
            BankAccount.InterestRate = newRate;

            //ASSERT
            Assert.Equal(newRate, account1.ApplicableRate);
            Assert.Equal(newRate, account2.ApplicableRate);

        }

        [Fact]
        public void FirstAccountShouldBeAccountNumber1()
        {
            Assert.Equal(1, account1.AccountNumber);
        }

        [Fact]
        public void EachAccountShouldGetANewAccountNumber()
        {
            int lastId = BankAccount.LastId;

            var account2 = new BankAccount( "New Name", "New Password", amount);

            Assert.Equal(lastId+1, account2.AccountNumber);
        }


        [Fact()]
        public void TransferToCanTransferFundsFromOneAccountToAnotherInHappyPath()
        {
            //Act
            bool result = account1.TransferTo(account2, 1, password);

            Assert.True(result);
            Assert.Equal(amount - 1, account1.Balance);
            Assert.Equal(amount + 1, account2.Balance);



        }

        [Fact()]
        public void TransferToFailsIfSourceAccountDoesntHaveSufficientBalance()
        {
            ////Act
            //bool result = BankAccount.Transfer(account1, amount + 1, password, account2);

            bool result =account1.TransferTo(account2, amount+1, password);

            Assert.False(result);

            ////Assert
            Assert.False(result);
            Assert.Equal(amount, account1.Balance);
            Assert.Equal(amount, account2.Balance);

        }


        [Fact()]
        public void TransferToFailsIfSourceAccountPasswordIsInCorrect()
        {
            var result = account1.TransferTo(account2, 1, "wrong-password");

            Assert.False(result);
            Assert.Equal(amount, account1.Balance);
            Assert.Equal(amount, account2.Balance);
        }


        [Fact()]
        public void TransferToFailsIfInvalidAmountIsEntered()
        {
            var result = account1.TransferTo(account2, -1, password);

            Assert.False(result);
            Assert.Equal(amount, account1.Balance);
            Assert.Equal(amount, account2.Balance);
        }


        
        [Fact()]
        public void TransferCanTransferFundsFromOneAccountToAnotherInHappyPath()
        {
            //Act
            bool result = BankAccount.Transfer(account1, 1, password,account2);

            Assert.True(result);
            Assert.Equal(amount - 1, account1.Balance);
            Assert.Equal(amount + 1, account2.Balance);



        }

        [Fact()]
        public void TransferFailsIfSourceAccountDoesntHaveSufficientBalance()
        {
            ////Act
            //bool result = BankAccount.Transfer(account1, amount + 1, password, account2);

            bool result = BankAccount.Transfer(account1, amount+1, password, account2);

            Assert.False(result);

            ////Assert
            Assert.False(result);
            Assert.Equal(amount, account1.Balance);
            Assert.Equal(amount, account2.Balance);

        }


        [Fact()]
        public void TransferFailsIfSourceAccountPasswordIsInCorrect()
        {
            bool result = BankAccount.Transfer(account1, amount , "wrong-password", account2);


            Assert.False(result);
            Assert.Equal(amount, account1.Balance);
            Assert.Equal(amount, account2.Balance);
        }


        [Fact()]
        public void TransferFailsIfInvalidAmountIsEntered()
        {
            bool result = BankAccount.Transfer(account1, -1, password, account2);



            Assert.False(result);
            Assert.Equal(amount, account1.Balance);
            Assert.Equal(amount, account2.Balance);
        }

        




    }
}

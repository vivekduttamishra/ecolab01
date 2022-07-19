using ConceptArchitect.Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demo03Test
{
    public class BankAccountTests
    {
        string password = "p@ss";
        int amount = 20000;
        double rate = 12;

        BankAccount account;
        public BankAccountTests()
        {
            account= new BankAccount(1, "Vivek", password, amount, rate);
        }


        [Fact]
        public void DepositShouldSucceedForPositiveAmount()
        {
           
            var result = account.Deposit(1000);

            Assert.True(result);

        }

        [Fact]
        public void DepositShouldFailForNegaiveAmount()
        {
            Assert.False(account.Deposit(-1));
        }

       

        [Fact]
        public void WithdrawShouldFailForNegativeAmount()
        {
            var result = account.Withdraw(-1, password);
            Assert.False(result);
        }

        [Fact]
        public void WithdrawShouldFailForInvalidPassword()
        {
            var result = account.Withdraw(1, "wrong-password");
            Assert.False(result);
        }

        [Fact]
        public void WithdrawShouldFailForInsufficientBalance()
        {
            var result = account.Withdraw(amount + 1, password);
            //Assert.False(result);

            AssertTransactionResultAndStatus(amount, false, result);

        }

        [Fact]
        public void WithdrawShouldWorkForRightAmountAndPassword()
        {
            AssertTransactionResultAndStatus(amount - 1, true, account.Withdraw(1, password));
        }

        private void AssertTransactionResultAndStatus(double expectedBalance, bool expectedResult,bool result)
        {
            Assert.Equal(expectedBalance, account.Balance);

            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void LastInterestRateShouldApplyToAllAccount()
        {
            var account2 = new BankAccount(2, "some other name", "p@ss", 1000, rate + 1);

            Assert.Equal(account2.InterestRate, account.InterestRate);

        }

        [Fact]
        public void CreditInterestShouldCreditOneMonthInterest()
        {
            account.CreditInterest();
            
            var expectedNewBalance = amount + amount * rate / 1200;

            Assert.Equal(expectedNewBalance, account.Balance);
        }
    }
}








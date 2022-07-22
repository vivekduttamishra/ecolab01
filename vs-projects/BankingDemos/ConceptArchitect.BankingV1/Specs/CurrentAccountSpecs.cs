using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConceptArchitect.Banking.Specs
{
    public class CurrentAccountSpecs
    {
        string password = "p@ss";
        double amount = 20000;
        CurrentAccount account;
        public CurrentAccountSpecs()
        {
            //Arrange
            account=new CurrentAccount(1, "Vivek", password, amount);
        }

        [Fact]
        public void CurrentAccountIsATypeOfBankAccount()
        {
            

            Assert.True(account is CurrentAccount);

            Assert.True(account is BankAccount);

            Assert.IsType<CurrentAccount>(account);

            
        }

        [Fact]
        public void CreditInterestShouldNotCreditInterest()
        {
           

            //Act
            account.CreditInterest(12);

            //Assert
            Assert.Equal(amount, account.Balance);
        }

        [Fact]
        public void WithdrawCanWithdrawUptoTheBalance()
        {
            var result= account.Withdraw(amount, password);

            Assert.True(result);
            Assert.Equal(0, account.Balance);

        }

        [Fact]
        public void WithdrawCantOverWithdraw()
        {
            var result = account.Withdraw(amount+1, password);

            Assert.False(result);
            Assert.Equal(amount, account.Balance);

        }
    }
}



using ConceptArchitect.Banking;
using ConceptArchitect.Utils;

var amount = 20000;
var password = "p@ss";
var account = new BankAccount(1, "Vivek", password, amount, 12);


var tester = new BankAccountTester(account);

tester.TestDeposit  ("Deposite should work for positive Amount",1000,true);
tester.TestDeposit(  "Deposit should fail for negative amount",-1,false);
tester.TestDeposit(  "Deposit should fail for 0 amount",0,false);

tester.TestWithdraw("Withdraw should fail for excess withdrawal", amount + 1, password, false);

tester.TestWithdraw("Withdraw should fail for negative withdrawal", -1, password, false);

tester.TestWithdraw("Withdraw shuould fail for wrong password", 1, "wrong-password", false);

tester.TestWithdraw("Withdraw should work with right values", 1, password, true);



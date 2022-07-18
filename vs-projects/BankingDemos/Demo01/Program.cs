

using ConceptArchitect.Banking;

var account = new BankAccount(1, "Vivek", "p@ss", 20000, 12);

account.Show();

account.Deposit();

account.Withdraw();

account.Show();

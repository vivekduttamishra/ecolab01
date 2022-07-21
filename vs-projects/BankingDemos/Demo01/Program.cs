

using ConceptArchitect.Banking;

BankAccount account = new BankAccount(1, "Vivek", "p@ss", 20000, 12);

var account2 = new BankAccount(2, "Sanjay", "p@ss", 20000, 12);

dynamic account3 = new BankAccount(3, "Sanjay", "p@ss", 20000, 12);


account3.Deposit();

account3.Show();

account3 = 20;

Console.WriteLine(account3);

account.Show();

account.Deposit();

account.Withdraw();

account.Show();

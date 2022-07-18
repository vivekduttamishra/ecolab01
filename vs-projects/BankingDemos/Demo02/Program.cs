

using ConceptArchitect.Banking;
using ConceptArchitect.Utils;

var account = new BankAccount(1, "Vivek", "p@ss", 20000, 12);

account.Show();

var input = new Input();

var amount = input.ReadInt("Amount?");

var success=account.Deposit(amount);

if(success)
    Console.WriteLine("Amount is deposited");

if(account.Withdraw(input.ReadInt("Amount?"), input.ReadString("password")))
    Console.WriteLine("Please collect your cash"); 
else
    Console.WriteLine("Withdraw failed") ;

account.Show();
Console.WriteLine($"Your password is {account.Password}");
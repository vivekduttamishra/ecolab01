using ConceptArchitect.Banking;

internal class BankAccountTester
{
    private BankAccount account;

    public BankAccountTester(BankAccount account)
    {
        this.account = account;
    }

    public  void TestDeposit(string testDescription, int amount, bool expectedResult)
    {
        var result = account.Deposit(amount);

        if(result==expectedResult)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Passed:\t{testDescription}");
        }
        else
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine($"Failed:\t{testDescription}");
            Console.WriteLine($"\tExpected:{expectedResult}\tActual:{result}");
        }
        Console.ResetColor();
    }

    public void TestWithdraw(  string testDescription,int amount,string password, bool expectedResult)
    {
        var result = account.Withdraw(amount,password);

        if (result == expectedResult)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Passed:\t{testDescription}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Failed:\t{testDescription}");
            Console.WriteLine($"\tExpected:{expectedResult}\tActual:{result}");
        }
        Console.ResetColor();
    }
}
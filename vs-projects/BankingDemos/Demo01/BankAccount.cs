
using ConceptArchitect.Utils;

namespace ConceptArchitect.Banking
{

    public class BankAccount
    {
        private int accountNumber;
        private string name;
        private string password;
        Input input = new Input();



        private double balance;
        private int interestRate;

        public BankAccount(int accountNumber, string name, string password, int initialAmount, int interestRate)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            this.password = password;
            this.balance = initialAmount;
            this.interestRate = interestRate;
        }

        public void Deposit()
        {
            
            double amount = input.ReadDouble("Amount?");
            if (amount <= 0)
                Console.WriteLine("Deposit Failed. Invalid Amount");
            else
            {

                balance += amount;
                Console.WriteLine($"Deposit Successful. New Balance: {balance}");
            }
        }

        public void Withdraw()
        {
           
            var amount = input.ReadDouble("Amount to Withdraw?");
            var password = input.ReadString("Password?");

            if(amount<0)
                Console.WriteLine("Invalid Amount");
            else if(amount>balance)
                Console.WriteLine("Insufficient Funds");
            else if(password!=this.password)
                Console.WriteLine("Invalid password");
            else
            {
                balance -= amount;
                Console.WriteLine("Please collect your cash!!!");
            }

        }

        public void Show()
        {
            Console.WriteLine($"Account Number:{accountNumber}" +
                $"\nName:{name}" +
                $"\nBalance:{balance}" +
                $"\nRate:{interestRate}");
        }
    }
}

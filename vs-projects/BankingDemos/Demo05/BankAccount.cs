
using ConceptArchitect.Utils;

namespace ConceptArchitect.Banking
{

    public class BankAccount
    {
        //private int accountNumber;

        public int AccountNumber { get;  }

       // private string password;


        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }   
        //}

        public string Name { get; set; }



        public  double Balance { get; private set; }

        static BankAccount()
        {
            interestRate = 12;
        }

        private static double interestRate;

        
        public static  double InterestRate
        {
            get { return interestRate; }
            set {

                var delta = interestRate / 10;
                var min = interestRate - delta;
                var max = interestRate + delta;
                if(interestRate==0 || value>=min && value<=max)
                    interestRate = value; 
            }
        }

        public double ApplicableRate
        {
            get { return interestRate; }

            //set{} //we don't want value to be modified from here.
        }

        


        public BankAccount(int accountNumber, string name, string password, 
                                int initialAmount)
        {
            this.AccountNumber = accountNumber;
            this.Name = name;
            this.Password = password;
            this.Balance = initialAmount;
            //BankAccount.interestRate = interestRate;
        }

        public bool Deposit(int amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            else
                return false;
            
        }

        public bool Withdraw(int amount,string password)
        {
            if (amount <= 0)
                return false;
            if (amount > Balance)
                return false;
            else if (!Authenticate(password))
                return false;
            else
            {
                Balance -= amount;
                return true;
            }

        }

        public void Show()
        {
            Console.WriteLine($"Account Number:{AccountNumber}" +
                $"\nName:{Name}" +
                $"\nBalance:{Balance}" +
                $"\nRate:{interestRate}");
        }


        private string password;

        public string Password
        {
            get { return password; }
            set { password = Encrypt(value); }
        }

        public bool Authenticate(string password)
        {
            return this.password.Equals(Encrypt(password));
        }

        public void CreditInterest()
        {
            Balance += (Balance * interestRate / 1200);
        }

        public void ChangePassword(string oldPassword, string newPassword)
        {
            if (Authenticate(oldPassword))
                Password = newPassword;
        }


        private string Encrypt(string value)
        {
            string result = "";
            foreach(char ch in value)
            {
                result += ((int)ch).ToString();
            }
            return result;
        }
    }
}

using System.Collections.Generic;

namespace ConceptArchitect.Banking
{
    public class Bank
    {
        public string Name { get; set; }
        public  double InterestRate { get; set; }
        public int AccountCount { get; private set; }

        public Bank(string name, double interestRate)
        {
            this.Name = name;
            this.InterestRate = interestRate;
        }
    }
}
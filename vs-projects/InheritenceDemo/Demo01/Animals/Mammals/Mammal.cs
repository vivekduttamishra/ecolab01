using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.AnimalKindom
{
    public abstract class Mammal : Animal
    {
        public override string Breed()
        {
            return $"{this} is child bearing";
        }
        public override string Move()
        {
            return $"{this} moves on land";
        }
    }
}

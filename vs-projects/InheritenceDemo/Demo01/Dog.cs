using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.AnimalKindom
{
    public class Dog : Animal
    {
        public override string Eat()
        {
            return $"{this} is flesh eater";
        }

        public override string Breed()
        {
            return $"{this} is child bearning";
        }

        public string Move()
        {
            return $"{this} moves on land";
        }
    }
}

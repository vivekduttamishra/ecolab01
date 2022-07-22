using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.AnimalKindom
{
    public class Leopard : Animal
    {
        public override string Eat()
        {
            return $"{this} is flesh eater";
        }

        public override  string Breed()
        {
            return $"{this} is child bearning";
        }

        public override string Move()
        {
            return $"{this} moves on land";
        }
    }
}

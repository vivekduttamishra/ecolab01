using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.AnimalKindom
{
    public class Crocodile : Animal
    {
        public override string Eat()
        {
            return $"{this} is flesh eater";
        }

        public override string Breed()
        {
            return $"{this} is egg laying";
        }

        public override string Move()
        {
            return $"{this} sweems in water, crawler";
        }
    }
}

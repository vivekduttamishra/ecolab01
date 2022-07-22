using ConceptArchitect.AnimalKindom.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.AnimalKindom
{
    public abstract class Reptile: Animal,IHunter
    {
        public override string Breed()
        {
            return $"{this} is egg laying";
        }

        public override string Eat()
        {
            return $"{this} is flesh eater";
        }

        public virtual string Hunt()
        {
            return $"{this} is Hunter";
        }



    }
}

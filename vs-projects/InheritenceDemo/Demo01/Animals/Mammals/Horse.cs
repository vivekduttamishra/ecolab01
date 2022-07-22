using ConceptArchitect.AnimalKindom.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.AnimalKindom
{
    public class Horse : Mammal,IRideable,IDomestic
    {
        public override string Eat()
        {
            return $"{this} is grass eater";
        }

        public string Ride()
        {
            return $"{this} is an ancient Ride";
        }
      
    }
}

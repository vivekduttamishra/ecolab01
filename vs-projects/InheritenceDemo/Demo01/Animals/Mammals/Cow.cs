using ConceptArchitect.AnimalKindom.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.AnimalKindom
{
    public class Cow : Mammal,IDomestic
    {
        public override string Eat()
        {
            return $"{this} is grass eater";
        }

       

      
    }
}

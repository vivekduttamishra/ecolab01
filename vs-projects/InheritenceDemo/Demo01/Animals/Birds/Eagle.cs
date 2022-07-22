using ConceptArchitect.AnimalKindom.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.AnimalKindom
{
    public class Eagle: Bird, IHunter
    {
        public override string Eat()
        {
            return $"{this} is a flesh eater";
        }

        public string Hunt()
        {
            return $"{this} is a flying hunter";
        }
    }
}

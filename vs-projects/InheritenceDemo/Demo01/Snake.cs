using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.AnimalKindom
{
    public class Snake : Animal
    {
        public string Eat()
        {
            return $"{this} is flesh eater";
        }

        public string Breed()
        {
            return $"{this} is egg laying";
        }

        public string Move()
        {
            return $"{this}  crawler";
        }
    }
}

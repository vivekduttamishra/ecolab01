using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.AnimalKindom
{
    public class Crocodile : Reptile
    {
    
        public override string Move()
        {
            return $"{this} sweems in water";
        }

        public override string Hunt()
        {
            return $"{this} is a great underwater hunter";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.AnimalKindom
{
    public class Snake : Reptile
    {
        public override string Hunt()
        {
            return $"{this} is a poisonous hunter";
        }

        public override string Move()
        {
            return $"{this}  crawler";
        }
    }
}

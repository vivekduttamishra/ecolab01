using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.AnimalKindom
{
    public abstract class Bird:Animal
    {
        public override string Breed()
        {
            return $"{this} is egg laying";
        }

        public override string Move()
        {
            return Fly();
        }
        public virtual string Fly()
        {
            return $"{this} flies";
        }
    }
}

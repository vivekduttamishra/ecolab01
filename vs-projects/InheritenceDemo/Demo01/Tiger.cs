using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.AnimalKindom
{
    public class Tiger : Animal
    {

        public override string Eat()
        {
            return $"{this} eats flesh";
        }
        public override string Breed()
        {
            return $"{this} is child bearing";
        }

        public override string Move()
        {
            return $"{this} is Moves on land";
        }



        public string Hunt()
        {
            return $"{this} is a wild hunter";
        }
    }
}

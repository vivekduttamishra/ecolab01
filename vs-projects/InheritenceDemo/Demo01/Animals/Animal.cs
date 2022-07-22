using ConceptArchitect.AnimalKindom.Animals;

namespace ConceptArchitect.AnimalKindom
{
    public abstract class Animal
    {
        public abstract string Eat();

        public abstract string Breed();


        public abstract string Move();

        public bool IsDomestic
        {
            get { return this is IDomestic; }
        }
        
    }
}
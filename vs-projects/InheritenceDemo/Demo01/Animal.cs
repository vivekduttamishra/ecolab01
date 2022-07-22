namespace ConceptArchitect.AnimalKindom
{
    public class Animal
    {
        public virtual string Eat()
        {
            return $"{this} eats something";
        }

        public virtual string Breed()
        {
            return $"{this} breeds somehow";
        }

        public virtual string Move()
        {
            return $"{this} moves somewhere";
        }
    }
}
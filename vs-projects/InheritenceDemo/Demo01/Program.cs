

using ConceptArchitect.AnimalKindom;

Animal[] animals =
{
    new Tiger(),
    new Cow(),
    new Crocodile(),
    new Snake(),
    new Dog(),
};

foreach(var animal in animals)
{
    Console.WriteLine(animal.Eat());
    Console.WriteLine(animal.Breed());
    Console.WriteLine(animal.Move());
    Console.WriteLine();
}



using ConceptArchitect.AnimalKindom;
using ConceptArchitect.AnimalKindom.Animals;

Animal[] animals =
{
    new Tiger(),
    new Cow(),
   // new Animal(),
    new Crocodile(),
   // new Bird(),
    new Eagle(),
    //new Cat(),
    new Snake(),
  //  new Mammal(),
 //   new Reptile(),
    new Parrot(),
    new Dog(),
    new Horse(),
    new Leopard(),
    new Camel(),
};

foreach(var animal in animals)
{

    if(animal.IsDomestic)
        Console.WriteLine("******");
    Console.WriteLine(animal.Eat());
    Console.WriteLine(animal.Breed());
    Console.WriteLine(animal.Move());

    //HuntIfYourAreATiger(animal);
    HuntIfYouAreAHunter(animal);

    RideARideable(animal);

    Console.WriteLine();
}

void HuntIfYouAreAHunter(Animal animal)
{
    var hunter = animal as IHunter;
    if(hunter != null)
        Console.WriteLine(hunter.Hunt());
}

void RideARideable(Animal animal)
{
    var rideable = animal as IRideable;
    if (rideable != null)
        Console.WriteLine(rideable.Ride());
}

void HuntIfYourAreATiger(Animal animal)
{
    if (animal is Tiger)
    {
        Tiger t = (Tiger)animal;
        Console.WriteLine(t.Hunt());
    }
}
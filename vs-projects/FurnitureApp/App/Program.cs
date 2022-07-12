using ConceptArchitect.Data;
using ConceptArchitect.Furnitures;
using Table = ConceptArchitect.Furnitures.Table;

class App
{
    static void Main()
    {
        Chair chair = new Chair();

        Console.WriteLine(chair);

        Table table = new Table();

        Printer printer = new Printer();

        printer.Print("Hello World");

        Console.WriteLine("{0} as price {1}", table,table.Price());

        LinkedList list = new LinkedList();

        Console.WriteLine(list);
    }
}


using System;
using ConceptArchitectIn.Furnitures;
using ConceptArchitectIn.Data;

using Table=ConceptArchitectIn.Furnitures.Table; //Alias Name

using DataTable=ConceptArchitectIn.Data.Table;

//using EchoLabsTable=EchoLabs.Data.Table;

using ELD = EchoLabs.Data;


class App
{
	static void Main()
	{
		Chair chair=new Chair();
		Console.WriteLine(chair+ " has price "+chair.Price());

		Table table=new Table();
		Console.WriteLine( table+" has price "+table.Price());

		List list=new List();
		Console.WriteLine(list);

		DataTable t2=new DataTable();
		Console.WriteLine(t2);


		ELD.Table t3=new ELD.Table();
		Console.WriteLine(t3);
		

	}
}
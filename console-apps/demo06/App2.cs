
using Furnitures;
using Data;
using Table=Data.Table;
using FTable=Furnitures.Table;
using System;

class App
{
    static void Main()
    {
        Chair chair=new Chair();
        List list=new List();
        Table table=new Table();
        FTable table2=new FTable();
       Console.WriteLine(chair);
       Console.WriteLine(list);
       Console.WriteLine(table);
       Console.WriteLine(table2);
    }
}
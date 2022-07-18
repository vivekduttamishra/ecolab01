// See https://aka.ms/new-console-template for more information

namespace ConceptArchitect.Geometry
{
    class Program
    { 
        static void Main()
        {
            var t1 = new Triangle();
            t1.s1 = 3;
            t1.s2 = 4;
            t1.s3 = 15;

            Console.WriteLine(t1.Perimeter());

            Console.WriteLine(t1.Area());
        }
    }

}

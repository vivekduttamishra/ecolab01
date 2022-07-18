// See https://aka.ms/new-console-template for more information

namespace ConceptArchitect.Geometry
{
    class TriangleTester
    { 
        static void Main()
        {
            
            var tester=new TriangleTester();

            tester.TestTriangle(new Triangle(3, 4, 5));

            tester.TestTriangle(new Triangle(5,12));
            tester.TestTriangle(new Triangle(5));
            tester.TestTriangle(new Triangle());
            tester.TestTriangle(new Triangle(-2));


        }

        private  void TestTriangle(Triangle t)
        {
            
            t.Draw();
            Console.WriteLine($"Area is {t.Area()}");
            Console.WriteLine($"Perimeter is {t.Perimeter()}");
            Console.WriteLine("\n\n");
        }
    }

}

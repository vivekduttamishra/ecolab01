// See https://aka.ms/new-console-template for more information

namespace ConceptArchitect.Geometry
{
    class TriangleTester
    { 
        static void Main()
        {
            
            var tester=new TriangleTester();

            tester.TestTriangle(3, 4, 5);

            tester.TestTriangle(4, 5, 16);

        }

        private  void TestTriangle(int x, int y, int z)
        {
            Console.WriteLine($"Testing Triangle with sides {x},{y},{z}");

            var t1 = new Triangle();
            
            t1.SetSides(x, y, z);
            
            
            t1.Draw();
            Console.WriteLine($"Area is {t1.Area()}");
            Console.WriteLine($"Perimeter is {t1.Perimeter()}");
            Console.WriteLine("\n\n");
        }
    }

}

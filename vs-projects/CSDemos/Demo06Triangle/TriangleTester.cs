// See https://aka.ms/new-console-template for more information

namespace ConceptArchitect.Geometry
{
    class TriangleTester
    { 
        static void Main()
        {
            
            

            var tester=new TriangleTester();

            tester.TestTriangle(new Triangle(3, 4, 5), 6);

            tester.TestTriangle(new Triangle(3, 4, 5), 16);

            Triangle t = new Triangle(3, 4, 5);

            t.Draw();

            //t.SetS1(50);

            t.S1 = 50;

            t.Draw();






        }

        private  void TestTriangle(Triangle t,int deltaS1)
        {

            Console.WriteLine($"Testing Triangle with sides {t.S1},{t.S2},{t.S3} ");
            
            t.Draw();
            Console.WriteLine($"Area is {t.Area}");
            Console.WriteLine($"Perimeter is {t.Perimeter}");
            Console.WriteLine($"changing s1 to {deltaS1}");

            t.S1 = deltaS1;

            t.Draw();
            Console.WriteLine($"Area is {t.Area}");
            Console.WriteLine($"Perimeter is {t.Perimeter}");
            Console.WriteLine("\n\n");
        }
    }

}

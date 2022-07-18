// See https://aka.ms/new-console-template for more information

namespace ConceptArchitect.Geometry
{
    public  class Triangle
    {
        internal double s1;
        internal double s2;
        internal double s3;

        internal double Perimeter()
        {
            return s1 + s2 + s3;
        }

        internal double Area()
        {
            var s = Perimeter() / 2;
            return Math.Sqrt(s*(s-s1)*(s-s2)*(s-s3));
        }
    }
}
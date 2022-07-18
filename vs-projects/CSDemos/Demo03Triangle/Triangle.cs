// See https://aka.ms/new-console-template for more information

namespace ConceptArchitect.Geometry
{
    public  class Triangle
    {
        internal double s1;
        internal double s2;
        internal double s3;

        public void SetSides(double s1,double s2,double s3)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            

        }

        public bool IsValid()
        {
            return (s1 > 0 && s2 > 0 && s3 > 0 && s1 + s2 > s3 && s2 + s3 > s1 && s1 + s3 > s2);
        }


        internal double Perimeter()
        {
            if (IsValid())
                return s1 + s2 + s3;
            else
                return double.NaN;
        }

        internal double Area()
        {
            if(!IsValid())
                return double.NaN;

            var s = Perimeter() / 2;
            return Math.Sqrt(s*(s-s1)*(s-s2)*(s-s3));
        }

        public void Draw()
        {
            if (IsValid())
            {
                Console.WriteLine($"Triangle<{s1},{s2},{s3}>");
            }
            else
            {
                Console.WriteLine("<Invalid Triangle>");
            }
        }
    }
}
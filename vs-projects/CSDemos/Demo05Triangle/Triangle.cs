﻿// See https://aka.ms/new-console-template for more information

namespace ConceptArchitect.Geometry
{
    public  class Triangle
    {
        private double s1;

        public double GetS1()
        {
            return s1;
        }

        public void SetS1(double value)
        {
            this.s1 = value;
            Validate();
        }



        private double s2;
        private double s3;
        private bool isValid;

        public Triangle(double s1, double s2, double s3)
        {
            SetSides(s1, s2, s3);
        }

        public Triangle(double side)
        {
            SetSides(side, side, side);
        }

        public Triangle(double b, double h)
        {
            s1 = b;
            s2 = h;
            s3 = Math.Sqrt(s1 * s1 + s2 * s2);

        }
        public Triangle()
        {
            SetSides(1, 1, 1);
        }

        
        public void SetSides(double s1,double s2,double s3)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            Validate();
        }

      

        public double GetS2()
        {
            return s2;
        }
        public void SetS2(double value)
        {
            s2 = value;
            Validate();
        }

        public double GetS3()
        {
            return s3;
        }
        public void SetS3(double value)
        {
            s3 = value;
            Validate();
        }

        private void Validate()
        {
            isValid= (s1 > 0 && s2 > 0 && s3 > 0 && s1 + s2 > s3 && s2 + s3 > s1 && s1 + s3 > s2); 
        }

        public bool IsValid()
        {
            return isValid;
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
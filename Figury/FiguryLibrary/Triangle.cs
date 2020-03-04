using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    /// <summary>
    /// Trojkat w wersji immutable
    /// </summary>
    public class Triangle : Figure
    {
        public double A { get; private set; } // A jest read-only
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a = 1, double b = 1, double c = 1) : base("red")
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("boki powinny byc dodatnie");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("nie spelniony warunek trojkata");

            A = a;
            B = b;
            C = c;

        }
        public override string ToString()
        {
            return $"triangle({A}, {B}, {C})";
        }

        public double Perimeter => A + B + C;

        public Triangle Scale( double factor )
        {
            if (factor < 0)
                throw new ArgumentOutOfRangeException("wsp. skalowanie musi byc dodatni");

            return new Triangle(A * factor, B * factor, C * factor);

        }

        public override void Draw()
        {
            Console.WriteLine("rysowanie trojkata");
        }
    }
}

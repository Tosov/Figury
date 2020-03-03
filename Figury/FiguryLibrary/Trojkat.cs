using System;

namespace FiguryLibrary
{
    public class Trojkat
    {
        // dane obiektu - pole obiektu (fields)
        private double a; // this.a
        public double A
        {
            get { return a; }
            set 
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartosc A musi byc dodatna");
                else if (isSpelnionyWarunekTrojkata(value, b, c))
                    a = value;
                else //nie jest spelniony warunek trojkata
                    throw new ArgumentException("nie jest spelniony warunek trojkata przy probie zmiany A");
            }
        }

        private double b; // this.b
        public double B
        {
            get => b;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartosc B musi byc dodatna");
                else if (isSpelnionyWarunekTrojkata(a, value, c))
                    b = value;
                else 
                    throw new ArgumentException("nie jest spelniony warunek trojkata przy probie zmiany B");
            }
                
        }

        private double c; // this.c
        public double C
        {
            get => c;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("wartosc C musi byc dodatna");
                else if (isSpelnionyWarunekTrojkata(a, b, value))
                    c = value;
                else 
                    throw new ArgumentException("nie jest spelniony warunek trojkata przy probie zmiany C");
            }
        }

        private bool isSpelnionyWarunekTrojkata(double a, double b, double c)
        {
            if(a + b <= c || a + c <= b || b + c <= a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
         

        // konstruktory

        public Trojkat() // kostruktor domyslny
        {
            a = b = c = 1.0;

        }
        public Trojkat(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("boki musza byc dodatnie");

            if (!isSpelnionyWarunekTrojkata(a, b, c))
                throw new ArgumentException("nie spelniny warunek trojkata");

            this.a = a;
            this.b = b;
            this.c = c;
        }

        // tekstowa reprezentacja obiektu
        public override string ToString()
        {
            return $"Trojkat(a: {a}, b: {b}, c: {c})";
        }

        // wlasciwosci i metody

        public double GetObwod() //metoda zwracajaca obwod tego trojkata, Java style
        {
            return a + b + c;

        }

        //propetry zwracajaca obwod tego trojkata
        public double Obwod => a + b + c;

        public double GetPole() // Java style
        {
            var p = 0.5 * GetObwod();
            var s = Math.Sqrt( p * (p-a) * (p-b) * (p-c) );
            return s;
        }

        public double Pole
        {
            get
            {
                var p = 0.5 * Obwod;
                var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;

            }

            



        }
    }
}

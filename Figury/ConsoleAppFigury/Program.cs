using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguryLibrary;

namespace ConsoleAppFigury
{
    class Program
    {
        static void Main()
        {
            var t = new Triangle();
            Console.WriteLine(t);
            Console.WriteLine(t.Color);
            t.Print();

            var s = new Sphere(10);
            Console.WriteLine(s);
            Console.WriteLine( s.Surface );
            //Console.WriteLine( s.Perimeter );

            var c = new Circle(1);
            var t1 = new Triangle(3, 4, 5);
            var s1 = new Sphere(2);

            List<Figure> lista;
            lista = new List<Figure>(1000);
            lista.Add(t);
            lista.Add(s);
            lista.Add(c);
            lista.Add(t1);
            lista.Add(s1);
            lista.Add(new Circle(4));

            foreach( var f in lista )
            {
                Console.WriteLine(f);

            }

            Console.WriteLine("--------------------------");
            var total = 0.0;
            foreach(var f  in lista)
            {
                if(f is IMeasurable2D)
                {
                    total += ((IMeasurable2D)f).Surface;
                    Console.WriteLine(f);
                }
                
            }
            Console.WriteLine($"sumaryczne pole = {total}");
        }
        static void Main2()
        {
            Triangle t = new Triangle();
            Console.WriteLine(t);

            var t1 = new Triangle(1.5, 1, 1);
            Console.WriteLine(t1);

            //var t2 = new Triangle(3); // pozostale boki == 1
            //Console.WriteLine(t2);

            var t3 = t1.Scale(2);
            Console.WriteLine(t3);
        }

        static void Main1(string[] args)
        {
            Trojkat t1; //deklaracja zmiennej typu Trojkat
            t1 = new Trojkat();

            Trojkat t2 = new Trojkat(1, 2, 3);
            var t3 = new Trojkat(c: 1, b: 2, a: 2);

            Console.WriteLine(t1);
            Console.WriteLine(t1.GetObwod());
            Console.WriteLine(t1.Obwod);
            Console.WriteLine($"pole = {t1.GetPole()}");
            Console.WriteLine($"pole = {t1.Pole}");
            try
            {
                t1.A = -1;
                t1.B = -2;
                t1.C = -3;
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("nie wolno bokom przypisac wartosci ujemnych");
            }
            Console.WriteLine(t1);
            Console.WriteLine(t1.Pole);

            Console.WriteLine("========================");
            _ = new Trojkat(3, 4, 5);
            Console.WriteLine(t2);
            Console.WriteLine(t2.A);
            t2.B = 100;
            Console.WriteLine(t2);


        }
    }
}

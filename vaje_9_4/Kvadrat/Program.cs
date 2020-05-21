using System;

namespace Kvadrat
{
    class Kvadrat
    {
        private double _x;
        private double _y;
        private double _dolzina;

        public double X
        {
            get
            {
                return _x;
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }
        }

        public double D
        {
            get
            {
                return _dolzina;
            }
        }
        public double Ploscina
        {
            get
            {
                return Math.Pow(D, 2);
            }
        }

        public double Obseg
        {
            get
            {
                return 4 * D;
            }
        }
        //Izračuna ploščino, ki jo pokrijejo pravokotniki v dani tabeli
        public double Pokritost(Kvadrat[] tab)
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

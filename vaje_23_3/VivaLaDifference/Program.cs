using System;

namespace VivaLaDifference
{
    class Program
    {
        public static double JeStevilo(string niz)
        {
            Console.Write(niz + ": ");
            try
            {
                double x = double.Parse(Console.ReadLine());
                return x;
            }
            catch
            {
                Console.WriteLine(niz + " mora biti nenegativno število!");
                return JeStevilo(niz);
            }
        }
        public static double Odstevanje(double a, double b)
        {

            if (b > a) throw new Exception("Odštevanec mora biti manjši od zmanjševanca!");
            return a - b;
        }
        static void Main(string[] args)
        {
            
            double a = JeStevilo("Zmanjševanec");
            if (a < 0) throw new Exception("Zmanjševanec mora biti nenegativno število!");
            double b = JeStevilo("Odštevanec");
            if (b < 0) throw new Exception("Odštevanec mora biti nenegativno število!");
            Console.WriteLine(Odstevanje(a, b));
        }
    }
}

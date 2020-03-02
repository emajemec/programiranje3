using System;

namespace V_gore
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Visina : " + globina() + " m.");
        }

        public static double globina()
        {
            double g = 9.8;
            Console.Write("Vnesi cas padanja kamna z mostu do tal (v sekundah): ");
            double t = Double.Parse(Console.ReadLine());
            //izracunamo visino 
            double h = g * Math.Pow(t,2) / 2;
            //zaokrozimo na dve decimalki 
            h = Math.Round(h, 2);
            return h;
        }
    }
}


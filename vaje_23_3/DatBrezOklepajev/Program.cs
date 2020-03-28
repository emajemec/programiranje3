using System;
using System.IO;

namespace DatBrezOklepajev
{
    class Program
    {
        public static void BrezOklepajev(string imeVhod, string imeIzhod)
        {
            if (!File.Exists(imeVhod)) throw new Exception("Datoteka ne obstaja!");
            StreamWriter pisanje = File.CreateText(imeIzhod);
            StreamReader branje = File.OpenText(imeVhod);
            string vrstica = branje.ReadLine();
            while (vrstica != null)
            {
                foreach (char znak in vrstica)
                {
                    if(znak.Equals("("))
                    {
                        //izbriši vse do znaka ")"
                    }
                }
                vrstica = branje.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

using System;
using System.IO;

namespace CSV_datoteke
{
    class Program
    {
        public static void Datoteke(string vhodna, string izhodna)
        {
            if (!File.Exists(vhodna)) throw new Exception("Datoteka ne obstaja!");
            StreamWriter pisanje = File.CreateText(izhodna);
            StreamReader branje = File.OpenText(vhodna);
            string vrstica = branje.ReadLine();
            string[] tab = vrstica.Split(", ");
            string ime = tab[0];
            string starost = tab[1];
            string teza = tab[2];
            while (vrstica != null)
            {
                vrstica = branje.ReadLine();
                string[] podatki = vrstica.Split(", ");
                var parIme = (ime, podatki[0]);
                var parStarost = (starost, podatki[1]);
                var parTeza = (teza, podatki[2]);
                (string, string)[] tabela = {parIme, parStarost, parTeza };
                pisanje.WriteLine(tabela);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("");
        }
    }
}

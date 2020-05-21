using System;
using System.IO;

namespace Naloga_4
{
    class Program
    {
        public static void Datoteke(string vhodna, string izhodna)
        {
            if (!File.Exists (vhodna)) throw new Exception ("Ta datoteka ne obstaja!"); //ce datoteka ne obstaja, vrnemo napako

            StreamWriter pisanje = File.CreateText (izhodna); //odpremo datoteko za pisanje
            StreamReader branje = File.OpenText (vhodna); //odpremo datoteko za branje
            string vrstica = branje.ReadLine ();
            string[] tab = vrstica.Split (", "); //ustvarmo tabelo
            string ime = tab[0]; //ime je prvi podatek v vrstici
            string starost = tab[1]; //starost je drugi podatek
            string teza = tab[2]; //teza je tretji podatek
            while (vrstica != null)
            {
                vrstica = branje.ReadLine ();
                string[] podatki = vrstica.Split (", ");
                var parIme = (ime, podatki[0]);
                var parStarost = (starost, podatki[1]);
                var parTeza = (teza, podatki[2]);
                (string, string)[] tabela = { parIme, parStarost, parTeza };
                pisanje.WriteLine (tabela);
            }
        }
        public static void Main(string[] args)
        {
             Console.Write("Ime datoteke: ");
             string ime = Console.ReadLine ();
             if (File.Exists(ime)) 
            {
                Console.WriteLine("Datoteka " + ime + " že obstaja!");
            } 
            else
            {
                 File.CreateText(ime);
                 Console.WriteLine("Datoteko " + ime + " smo naredili!");
            }
            Console.ReadLine();
         }

    }
}

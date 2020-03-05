using System;
using System.IO;


namespace Moja_datoteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi ime datoteke: ");
            string naslov = Console.ReadLine();
            string f = @"u:\3.letnik\programiranje3\vaje_2_3\" + naslov + ".txt";
            if (!File.Exists(f))
            {
                StreamWriter pisanje = File.CreateText(f);
                pisanje.WriteLine("To je moja datoteka!");
                pisanje.Close();
            }
            StreamWriter pisi = File.CreateText(f);
            pisi.WriteLine("To je moja datoteka!");
            Console.WriteLine("Vnesi svoje ime: ");
            string ime = Console.ReadLine();
            pisi.WriteLine(ime);
            pisi.Close();
            
            StreamReader branje = File.OpenText(f);
            string vrstica = branje.ReadLine();
            while (vrstica != null) // null : datoteke je konec!
            {
                Console.WriteLine(vrstica);
                vrstica = branje.ReadLine();
            }

            branje.Close();
            StreamReader novobranje = File.OpenText(f);
            int i = 1;
            while ((vrstica = novobranje.ReadLine()) != null)
            {
                Console.WriteLine(i + ": " + vrstica);
                i++;
            }
            novobranje.Close();
        }
    }
}

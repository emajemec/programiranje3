using System;

namespace Presledki_in_besede
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Vnesi niz: ");
            string niz = Console.ReadLine();
            
            int prestej_presledke = 0;
            string[] besede = niz.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (char znak in niz)
            {
                if (Char.IsWhiteSpace(znak))
                {
                    prestej_presledke++;
                }
            }
            Console.WriteLine("Število presledkov v nizu: " + prestej_presledke + ".");
            Console.WriteLine("Število besed v nizu: " + besede.Length + ".");
            string brez_presledkov = "";
            string s_presledki = "";
            string brez_spredaj = "";
            int i = 1;
            int najdaljša = 0, najkrajša = 100;
            string najdaljša_b = "", najkrajša_b = "";
            Console.WriteLine("Niz, izpisan po besedah: ");
            foreach (string beseda in besede)
            {
                brez_presledkov += beseda;
                s_presledki += " " + beseda;
                brez_spredaj += beseda + " ";
                Console.WriteLine(i + ". beseda: " + beseda);
                i++;
                if (beseda.Length > najdaljša)
                {
                    najdaljša = beseda.Length;
                    najdaljša_b = beseda;
                }
                if (beseda.Length < najkrajša)
                {
                    najkrajša = beseda.Length;
                    najkrajša_b = beseda;
                }

            }
            Console.WriteLine("Niz brez presledkov: " + brez_presledkov);
            Console.WriteLine("Niz brez zaporednih presledkov: " + s_presledki + " ");
            
            brez_spredaj = "Niz brez začetnih, končnih in zaporednih presledkov: " + brez_spredaj;
            brez_spredaj = brez_spredaj.Remove(brez_spredaj.Length - 1, 1) + "";
            Console.WriteLine(brez_spredaj);
            Console.WriteLine("Najdaljša beseda: " + najdaljša_b);
            Console.WriteLine("Št. črk: " + najdaljša);
            Console.WriteLine("Najkrajša beseda: " + najkrajša_b);
            Console.WriteLine("Št. črk: " + najkrajša);
        }

    }
}

using System;

namespace VrniNtiElement
{
    class Program
    {

        public static T VrniNti<T>(T[] tab, int n)
        {
            if ((n > tab.Length) || (n < -tab.Length) || (n == 0)) throw new Exception("Tega elementa ni v tabeli!");
            if (n < 0)
            {
                return tab[tab.Length + n];
            }
            else
            {
                return tab[n - 1];
            }
        }
        static void Main(string[] args)
        {
            string[] blebetanje = { "bla", "blo", "bli" }; 
            int[] tja = { 10, 20, 30 };
            
            string niz1 = VrniNti(blebetanje, 2); // dobimo "blo" 
            Console.WriteLine(niz1);
            string niz2 = VrniNti(blebetanje, -3); // dobimo "bla" 
            Console.WriteLine(niz2);
            try
            {
                string niz3 = VrniNti(blebetanje, -4); // sproži se izjema
            }
            catch
            {
                Console.WriteLine("NAPAKA!");
            } 
            int tam = VrniNti(tja, 1); // dobimo 10 
            Console.WriteLine(tam);
            try
            {
                int tu = VrniNti(tja, 0); // sproži se izjema 
            }
            catch
            {
                Console.WriteLine("NAPAKA!");
            }
            try
            {
                int tuk = VrniNti(tja, 4); // sproži se izjema
            }
            catch
            {
                Console.WriteLine("NAPAKA!");
            }
        }
    }
}

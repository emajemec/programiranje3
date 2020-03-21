using System;
using System.Linq;


namespace Bisekcija
{
    class Program
    {
        
        //Za kakrsno koli urejeno tabelo z bisekcijo poisce podatek in vrne True, če ga tabela vsebuje
        public static bool Bisekcija<T>(T[] tab, T podatek) where T : IComparable<T>
        {
            int pol = tab.Length / 2;
            if (tab.Length == 0)
            {
                return false;
            }
            if (podatek.CompareTo(tab[pol]) == 0)
            {
                return true;
            }
            else if (podatek.CompareTo(tab[pol]) > 0)
            {
                T[] drugepol = tab.Skip(pol + 1).ToArray();
                return Bisekcija(drugepol, podatek);
            }
            else if (podatek.CompareTo(tab[pol]) < 0)
            {
                T[] prvepol = tab.Take(pol).ToArray();
                return Bisekcija(prvepol, podatek);
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] tab1 = new int[] { 2, 7, 9, 16, 54, 63, 72, 91};
            string[] tab2 = new string[] {"ana", "anže", "maja", "miha", "mojca", "peter", "petra", "žana", "žan"};
            Console.WriteLine(Bisekcija(tab1, 17));
            Console.WriteLine(Bisekcija(tab2, "maja"));
        }
    }
}

using System;

namespace Naloga1
{
    class Program
    {
        public static int[] SpremeniTabelo(int[] tab)
        {
            //Izračunamo dolžino nove tabele
            int dolzina = 0;
            for (int i = 1; i <= tab.Length; i++)
            {
                dolzina += i;
            }
            int k = 0;
            int[] novaTab = new int[dolzina];
            for (int i = 1; i <= tab.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    novaTab[i + j - 1 + k] = tab[i - 1];
                }
                k = k + i - 1;
            }
            return novaTab;
        }
        public static T[] Spremeni<T>(T[] tab)
        {
            int dolzina = 0;
            for (int i = 1; i <= tab.Length; i++)
            {
                dolzina += i;
            }
            int k = 0;
            T[] novaTab = new T[dolzina];
            for (int i = 1; i <= tab.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    novaTab[i + j - 1 + k] = tab[i - 1];
                }
                k = k + i - 1;
            }
            return novaTab;
        }
        public static void IzpisiTab<T>(T[] tab)
        {
            foreach (T el in tab)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] tab = {5, -1, 3, 2 };
            IzpisiTab(tab);
            int [] novaTab = SpremeniTabelo(tab);
            IzpisiTab(novaTab);
            string[] tabImen = { "Ana", "Mojca", "Eva", "Anže", "Jan" };
            IzpisiTab(tabImen);
            string[] novaIme = Spremeni(tabImen);
            IzpisiTab(novaIme);
            int[] tabSt = { 11, 5, -6, 3, 0 };
            IzpisiTab(tabSt);
            int[] novaSt = Spremeni(tabSt);
            IzpisiTab(novaSt);
        }
    }
}

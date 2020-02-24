using System;

namespace Tabela
{
    class Program
    {
        public static int[] GenTab(int vel, int odkje, int doKam)
        {
            Random gen = new Random();
            int[] tab = new int[vel];
            for (int i = 0; i < vel; i++)
            {
                tab[i] = gen.Next(odkje, doKam + 1);
            }
            return tab;
        }

        public static int[] PreurediTab(int[] tabela)
        {
            int[] novaT = new int[tabela.Length];
            int pol = tabela.Length / 2;
            for (int i = 0; i < pol; i++)
            {
                novaT[i] = tabela[2 * i];
                novaT[pol + i] = tabela[2 * i + 1];
            }
            return novaT;
        }

        public static void IzpisTab(int[] tabela)
        {
            int koliko = 0;
            foreach (int el in tabela)
            {
                Console.Write(el + " ");
                koliko++;
                if (koliko % 10 == 0)  //Izpisujemo po 10 v vrsto
                {
                    koliko = 0;
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int odKje = 1;
            int doKam = 100;
            Console.WriteLine("velikost tabele: ");
            int vel = int.Parse(Console.ReadLine());
            //Generiraj naključno tabelo
            int[] tabela = GenTab(vel, odKje, doKam);
            //Preuredi tabelo
            int[] preurejenaTab = PreurediTab(tabela);
            Console.WriteLine("Prvotna tabela");
            IzpisTab(tabela);
            Console.WriteLine("Preurejena tabela");
            IzpisTab(preurejenaTab);

        }
    }
}

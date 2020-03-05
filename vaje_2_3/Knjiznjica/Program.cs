using System;


namespace Knjiznjica
{
    class Program
    {
        public static int[] NakljucnaTabela(int d, int m)
        {
            int[] tab = new int[d];
            Random rand = new Random();
            for (int i = 0; i < d; i++)
            {
 
                tab[i] = rand.Next(1, m); 
            }
            return tab;
        }
        static void Izpisi(string ime, int[] t)
        {
            Console.Write(ime + " ");
            foreach (int el in t)
            {
                Console.Write(el + " ");
            }

        }

        public static string TabelaKotNiz(int[] t)
        {
            string niz = "";
            foreach (int el in t)
            {
                niz += el + " ";
            }
            return niz;
            
        }

        public static int[] NizKotTabela(string s)
        {
            string[] besede = s.Split(' ');
            int[] stevila = new int[besede.Length];
            int i = 0;
            foreach (string el in besede)
            {
                int st = int.Parse(el);
                stevila[i] = st;
                i++;
            }
            return stevila;
        }
        static void Main(string[] args)
        {
            int[] tab = NakljucnaTabela(10, 100);
            Izpisi("Naključna tabela", tab);
            Console.WriteLine("");
            Console.Write("Niz, ki ga dobimo iz tabele: ");
            Console.WriteLine(TabelaKotNiz(tab));
            string niz = "1 2 10 12 3 45 78";
            int[] tab2 = NizKotTabela(niz);
            Izpisi("Tabela, ki jo dobimo iz niza: ", tab2);
        }
    }
}

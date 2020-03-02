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
        static void Main(string[] args)
        {
            int[] tab = NakljucnaTabela(5, 8);
            Izpisi("Naključna tabela", tab);
            Console.WriteLine("");
            Console.WriteLine(TabelaKotNiz(tab));
        }
    }
}

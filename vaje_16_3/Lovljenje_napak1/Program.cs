using System;

namespace Lovljenje_napak1
{
    class Program
    {
        public static void IzpisTabele(int[] tab)
        {

            foreach (int el in tab)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
        public static int F(int i)
        {
            return 100 / (i % 3);
        }
        public static int[] Tabeliraj(int vel)
        {
            int[] mojaT = new int[vel];
            for (int i = 0; i < vel; i++)
            {
                try
                {
                    mojaT[i] = F(i);
                }
                catch
                {
                    mojaT[i] = 0;
                }
            }
            return mojaT;
        }
        static void Main(string[] args)
        {
            int[] tab = Tabeliraj(10);
            IzpisTabele(tab);
        }
    }
}

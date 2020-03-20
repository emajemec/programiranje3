using System;

namespace IzpisiTab
{
    class Program
    {
        public static void IzpisTabele<T>(T[] tab, int n, string vmes)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(tab[i] + vmes);
                    i++;
                }
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
            int[] tab = { 12, 5, 6, 78, 3, 5, 6, 21, 434, 56, 42, 7 };
            int n = 5;
            string vmes = " : ";
            IzpisTabele(tab, n, vmes);
        }
    }
}

using System;

namespace IzpisiTab
{
    class Program
    {
        public static void IzpisTabele<T>(T[] tab, int n, string vmes)
        {
            int i = 0;
            
            while (i < tab.Length)
            {
                string niz = "";
                int j = 0;
                while (j < n)
                {
                    
                    if (i == tab.Length)
                    {
                        break;
                    }
                    else
                    {
                        niz += tab[i] + vmes;
                        j++;
                        i++;
                    }
                    
                }
                niz = niz.Remove(niz.Length - 2, 2) + "";
                Console.WriteLine(niz);
            }
            
        }
        static void Main(string[] args)
        {
            int[] tab = { 12, 5, 6, 78, 3, 5, 6, 21, 434, 56, 42, 7};
            int n = 5;
            string vmes = " : ";
            IzpisTabele(tab, n, vmes);
        }
    }
}

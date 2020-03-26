using System;
using System.Linq;

namespace BrezTrojk
{
    class Program
    {
        public static void IzpisTabele<Karkoli>(Karkoli[] tab)
        {
            foreach (Karkoli el in tab)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }

        public static void Krajsaj(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                string niz = t[i] + "";
                niz = niz.Replace("3", "");
                if (niz == "")
                {
                    t[i] = 0;
                }
                else
                {
                    t[i] = int.Parse(niz);
                }
            }
           
        }
        static void Main(string[] args)
        {
            int[] tab1 = { 13, 23, 333, 112, 3 };
            IzpisTabele(tab1);
            Krajsaj(tab1);
            IzpisTabele(tab1);

        }
    }
}

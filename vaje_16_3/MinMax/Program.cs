using System;

namespace MinMax
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
        public static T[] MinMax<T>(T[] tab) where T : IComparable<T>
        {
            T max = tab[0];
            T min = tab[0];
            foreach (T el in tab)
            {
                if (el.CompareTo(max) > 0)
                {
                    max = el;
                }
                if (el.CompareTo(min) < 0)
                {
                    min = el;
                }
            }
            T[] novatab = new T[] {min, max};
            return novatab;
        }

        public static string[] MinMax(string[] tab)
        {
            string maxEl = tab[0];
            string minEl = tab[0];
            foreach (string el in tab)
            {
                if (el.Length > maxEl.Length)
                {
                    maxEl = el;
                }
                if (el.Length < minEl.Length)
                {
                    minEl = el;
                }
            }
            string[] novatab = new string[] {minEl, maxEl};
            return novatab;
        }
        static void Main(string[] args)
        {
            int[] tab1 = { 12, 5, 6, 78, 3, 5, 6, 21, 434, 56, 42, 7 };
            string[] tab2 = {"ana", "anže", "maja", "miha", "mateja", "peter", "petra"};
            IzpisTabele(MinMax(tab1));
            IzpisTabele(MinMax(tab2));
        }
    }
}

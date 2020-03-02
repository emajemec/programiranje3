using System;

namespace Zamenjava_elementov
{
    class Program
    {
        static int[] Kopija(int[] t)
        {
          
            int[] s = new int[t.Length];
            int i = 0;
            foreach (int el in t)
            {
                s[i] = el;
                i++;
            }
            return s;
        }

        static void Izpisi(string ime, int[] t)
        {
            Console.Write(ime + " ");
            foreach (int el in t)
            {
                Console.Write(el + " ");
            }
            
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            int[] b = Kopija(a);
            Console.WriteLine("Prej: ");
            Izpisi("a", a);
            Izpisi("b", b);
            a[1] = b[2];
            a[2] = b[1];
            Console.WriteLine(" ");
            Console.WriteLine("Potem: ");
            Izpisi("a", a);
            Izpisi("b", b);
        }
    }
}

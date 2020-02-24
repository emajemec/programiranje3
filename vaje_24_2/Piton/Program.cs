using System;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vpiši niz: ");
            string niz = Console.ReadLine();
            Console.WriteLine("Katere črke bomo prešteli: ");
            string crke = Console.ReadLine();
            int[] prestej = new int[crke.Length];
            string max_crke = "";
            for (int i = 0; i < crke.Length; i++)
            {
                int koliko = niz.Count(f => f == crke[i]);
                prestej[i] = koliko;
            }
            int naj = prestej.Max();
            for (int i = 0; i < crke.Length; i++)
            {

                if (prestej[i] == naj)
                {
                    max_crke += crke[i];
                }
            }
            Console.WriteLine(max_crke);
        }
    }
}

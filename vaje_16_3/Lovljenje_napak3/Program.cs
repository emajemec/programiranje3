using System;

namespace Lovljenje_napak3
{
    class Program
    {
        public static int preberiInt(string niz)
        {
            Console.Write(niz);
            try
            {
                int st = int.Parse(Console.ReadLine());
                return st;
            }
            catch
            {
                Console.WriteLine("NAPAKA: To ni celo število, poskusi znova.");
                return preberiInt(niz);
            }
            

        }
        public static int preberiIntMeje(string niz, int a, int b)
        {
            
            int st = preberiInt(niz + a + " in " + b + ": ");
            if (st < a)
            {
                Console.WriteLine("NAPAKA: To ni celo število med " + a + " in " + b + ".");
                return preberiIntMeje(niz, a, b);
            }
            if (st > b)
            {
                Console.WriteLine("NAPAKA: To ni celo število med " + a + " in " + b + ".");
                return preberiIntMeje(niz, a, b);
            }
            return st;
        }
        static void Main(string[] args)
        {
            string niz = "Vnesi celo število med ";
            preberiIntMeje(niz, 1, 5);
        }
    }
}

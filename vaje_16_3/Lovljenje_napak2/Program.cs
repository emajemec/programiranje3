using System;

namespace Lovljenje_napak2
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
                Console.WriteLine("To ni celo število, poskusi znova.");
                return preberiInt(niz);
            }
        }
        static void Main(string[] args)
        {
            string niz = "Vnesi celo število: ";
            preberiInt(niz);

        }
    }
}

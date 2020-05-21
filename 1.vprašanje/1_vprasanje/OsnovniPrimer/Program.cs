using System;
using System.Linq;

namespace OsnovniPrimer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabela = { 6, 15, 3, 23, 26, 45, 35, 29, 74, 52, 14, 8, 33 };
            var stevila = from stevilo in tabela 
                          select stevilo;

            foreach (int stevilo in stevila)
            {
                Console.Write(stevilo + " ");
            }
        }
    }
}

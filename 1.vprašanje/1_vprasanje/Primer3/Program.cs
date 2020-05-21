using System;
using System.Linq;

namespace Primer3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabela = { 6, 15, 3, 23, 26, 45, 35, 29, 74, 52, 14, 8, 33 };

            //Razvrsti cela števila podana v tabeli v skupine glede na ostanke pri deljenju s številom 3

            var modul3 = from stevilo in tabela
                         orderby stevilo
                         group stevilo 
                         by stevilo % 3;

            //Izpišemo po skupinah ostanke in števila, ki jim pripadajo
            foreach (var podtab in modul3)
            {
                Console.Write(podtab.Key + ": ");
                foreach (int stevilo in podtab)
                {
                    Console.Write(stevilo + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

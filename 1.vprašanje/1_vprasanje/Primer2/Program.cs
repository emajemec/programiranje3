using System;
using System.Linq;

namespace Primer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabela = { 6, 15, 3, 23, 26, 45, 35, 29, 74, 52, 14, 8, 33 };

            //Vsa števila v tabeli celih števil pomnožimo z 2 in uredimo v naraščajočem vrstnem redu
            var podvoji = from stevilo in tabela
                          orderby stevilo
                          ascending
                          select stevilo * 2;

            //Izpišemo urejeno tabelo podvojenih števil
            foreach (int stevilo in podvoji)
            {
                Console.Write(stevilo + " ");
            }
        }
    }
}

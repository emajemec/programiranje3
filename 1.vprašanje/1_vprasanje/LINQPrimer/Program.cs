using System;
using System.Linq;

namespace LINQPrimer
{
    class Program
    {
        static void Main(string[] args)
        {
            //V tabeli celih števil izbriši vsa liha števila in tabelo uredi v padajočem vrstnem redu.

            int[] tabela = { 6, 15, 3, 23, 26, 45, 35, 29, 74, 52, 14, 8, 33 };
            var sodaTabela = from stevilo in tabela 
                             where stevilo % 2 == 0 
                             orderby stevilo 
                             descending
                             select stevilo;

            //Izpišemo urejeno tabelo sodih števil
            foreach (int stevilo in sodaTabela)
            {
                Console.Write(stevilo + " ");
            }
        }
    }
}

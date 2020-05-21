using System;

namespace Primer
{
    class Program
    {
        static void Main(string[] args)
        {
            //V tabeli celih števil izbriši vsa liha števila in tabelo uredi v padajočem vrstnem redu.
            int[] tabela = { 6, 15, 3, 23, 26, 45, 35, 29, 74, 52, 14, 8, 33 };

            //sprehodimo se čez tabelo in preštejemo vsa soda števila
            int stevec = 0;
            foreach (int stevilo in tabela)
            {
                if (stevilo % 2 == 0)
                {
                    stevec++;
                }
            }

            //Ustvarimo novo tabelo, ki ima toliko elementov, kot smo prešteli sodih števil
            int[] sodaTabela = new int[stevec];

            //Sprehodimo se čez začetno tabelo in v novo tabelo dodamo vsa soda števila
            int indeks = 0;
            foreach (int stevilo in tabela)
            {
                if (stevilo % 2 == 0)
                {
                    sodaTabela[indeks] = stevilo;
                    indeks++;
                }
            }

            //Uredimo tabelo v padajočem vrstnem redu
            Array.Sort(sodaTabela);
            Array.Reverse(sodaTabela);

            //Izpišemo urejeno tabelo sodih števil
            foreach (int stevilo in sodaTabela)
            {
                Console.Write(stevilo + " ");
            }
        }
    }
}

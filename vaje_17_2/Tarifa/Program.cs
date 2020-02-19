using System;

namespace Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            int megab, meseci, na_mesec, skupno, poraba = 0;
            megab = int.Parse(Console.ReadLine());
            meseci = int.Parse(Console.ReadLine());
            skupno = megab * (meseci + 1);
            for (int i = 0; i < meseci; i++)
            {
                na_mesec = int.Parse(Console.ReadLine());
                poraba += na_mesec;
            }
            Console.WriteLine(skupno-poraba);
        }
    }
}

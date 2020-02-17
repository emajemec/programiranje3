using System;

namespace Goljufivi_pek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi predpisano težo hlebca: ");
            double tezaPredpis = double.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi število hlebcev v pekarni: ");
            int steviloHlebcev = int.Parse(Console.ReadLine());
            int stevecNapacnih = 0;
            double minTeza = tezaPredpis * 0.8;
            double maxTeza = tezaPredpis * 1.2;
            for (int i = 1; i < steviloHlebcev; i++)
            {
                Console.WriteLine("Vnesi težo: " + i + ". hlebca");
                double dejanskaTeza = double.Parse(Console.ReadLine());
                //Če je teža hlebca 20% manjša od predpisa, ga štej med napačne hlebce
                if ((dejanskaTeza < minTeza) | (dejanskaTeza > maxTeza))
                    stevecNapacnih++;
            }
            //računamo ali bo pek pil vodo
            if (stevecNapacnih > steviloHlebcev * 0.15)
                Console.WriteLine("Peka v vodo takoj!!!!");
            else
                Console.WriteLine("Pek ima dobro mero");
            Console.ReadKey();
        }
    }
}

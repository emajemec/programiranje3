using System;

namespace Pek
{
    class Program
    {
        static void Main(string[] args)
        {
            double tezaPredpis;
            int steviloHlebcev;
            Branje(out tezaPredpis, out steviloHlebcev);
            int stevecNapacnih = 0;
            double minTeza = tezaPredpis * 0.8;
            double maxTeza = tezaPredpis * 1.2;

            stevecNapacnih = Prestej(steviloHlebcev, stevecNapacnih, minTeza, maxTeza);
            //računamo ali bo pek pil vodo
            Sodba(steviloHlebcev, stevecNapacnih);
        }

        private static void Branje(out double tezaPredpis, out int steviloHlebcev)
        {
            Console.Write("Vnesi predpisano tezo hlebca: ");
            tezaPredpis = double.Parse(Console.ReadLine());
            Console.Write("Vnesi stevilo hlebcev v pekarni: ");
            steviloHlebcev = int.Parse(Console.ReadLine());
        }

        private static void Sodba(int steviloHlebcev, int stevecNapacnih)
        {
            if (stevecNapacnih > steviloHlebcev * 0.15)
                Console.WriteLine("Peka v vodo takoj!!!!");
            else Console.WriteLine("Pek ima dobro mero");
        }

        private static int Prestej(int steviloHlebcev, int stevecNapacnih, double minTeza, double maxTeza)
        {
            for (int i = 1; i <= steviloHlebcev; i++)
            {
                Console.Write("Vnesi tezo: " + i + ". hlebca ");
                double dejanskaTeza = double.Parse(Console.ReadLine());
                //Če je teža hlebca 20% manjša od predpisa, ga štej med napačne hlebce
                if ((dejanskaTeza < minTeza) || (dejanskaTeza > maxTeza)) stevecNapacnih++;
            }

            return stevecNapacnih;
        }
    }
}

using System;

namespace Caramo_s_celimi_stevili
{
    class Program
    {
        static void Main(string[] args)
        {
            int stevec, imenovalec, decimalk, k = 0, ostanek, celi_del;
            string rezultat;
            Console.Write("stevec:");
            stevec = int.Parse(Console.ReadLine());
            Console.Write("imenovalec:");
            imenovalec = int.Parse(Console.ReadLine());
            Console.Write("decimalk:");
            decimalk = int.Parse(Console.ReadLine());
            ostanek = stevec % imenovalec;
            rezultat = stevec / imenovalec + ".";
            while (k <= decimalk-1)
            {
                ostanek *= 10;
                celi_del = ostanek / imenovalec;
                rezultat = rezultat + celi_del;
                k++;
                ostanek = ostanek % imenovalec;
            }
            Console.WriteLine(stevec + "/" + imenovalec + " = " + rezultat);

        }
    }
}

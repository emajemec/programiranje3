using System;

namespace Deljiva_stevila
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi spodnjo mejo: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Vnesi zgornjo mejo: ");
            int b = int.Parse(Console.ReadLine());
            string stevila = "Med " + a + " in " + b + " so z vsoto svojih števk deljiva naslednja števila:";
            for (int st = a; st < b; st++)
            {
                int org = st;
                int vsota = 0;
                while (org > 0)
                {
                    int ostanek = org % 10;
                    vsota += ostanek;
                    org = org / 10;
                }
                if (st % vsota == 0)
                {
                    stevila += st + ", ";
                }
            }
            stevila = stevila.Remove(stevila.Length - 2, 2) + ".";
            Console.WriteLine(stevila);
        }
    }
}

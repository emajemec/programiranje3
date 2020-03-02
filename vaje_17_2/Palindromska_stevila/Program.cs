using System;

namespace Palindromska_stevila
{
    class Program
    {
        static void Main(string[] args)
        {
            int stevec = 0;
            Console.Write("Vnesi spodnjo mejo: ");
            int zacetek = int.Parse(Console.ReadLine());
            Console.Write("Vnesi zgornjo mejo: ");
            int konec = int.Parse(Console.ReadLine());
            string stevila = "Med " + zacetek + " in " + konec + " imamo naslednja palindromska števila: ";
            
            for (int st = zacetek; st <= konec; st++)
            {
                int obrat = 0;
                int org = st;
                while (org > 0)
                {
                    int ostanek = org % 10;
                    obrat = (obrat * 10) + ostanek;
                    org = org / 10;
                    
                }
                
                if (st == obrat)
                {
                    stevec++;
                    stevila += st + ", ";
                }
            }
            if (stevec == 0)
            {
                
                Console.WriteLine("Med " + zacetek + " in " + konec + " ni palindromskih števil.");
            }
            else
            {
                stevila = stevila.Remove(stevila.Length - 2, 2) + ".";
                Console.WriteLine(stevila);
            }
            
        }
    }
}

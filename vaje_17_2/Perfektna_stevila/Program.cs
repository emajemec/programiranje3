using System;

namespace Perfektna_stevila
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi spodnjo mejo: ");
            int zacetek = int.Parse(Console.ReadLine());
            Console.Write("Vnesi zgornjo mejo: ");
            int konec = int.Parse(Console.ReadLine());
            string stevila = "Perfektna stevila: ";
            for (int i = zacetek; i <= konec; i++)
            {
                int vsota = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        vsota += j;
                    }
                }
                if (vsota == i)
                {
                    stevila += i + " ";
                }
            }
            Console.Write(stevila);
        }
    }
}

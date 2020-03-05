using System;
using System.IO;

namespace Nakljucna_stevila
{
    class Program
    {
        public static void Branje(string ime)
        {
            string f = @"u:\3.letnik\programiranje3\vaje_2_3\" + ime + ".txt";
            StreamReader branje = File.OpenText(f);
            string vrstica = branje.ReadLine();
            while (vrstica != null) // null : datoteke je konec!
            {
                Console.WriteLine(vrstica);
                vrstica = branje.ReadLine();
            }
        }
        public static void Ustvari(string ime, int maxvrstic, int maxstevil, int maxvrednost)
        {
            string f = @"u:\3.letnik\programiranje3\vaje_2_3\" + ime + ".txt";
            if (!File.Exists(f))
            {
                using (StreamWriter pisi = File.CreateText(f))
                {
                    Random gen = new Random();
                    int vrstice = gen.Next(1, maxvrstic + 1);
                    for (int i = 0; i < vrstice; i++)
                    {
                        int stevil = gen.Next(1, maxstevil + 1);
                        for (int j = 0; j < stevil; j++)
                        {
                            int st = gen.Next(1, maxvrednost + 1);
                            pisi.Write(st + " ");
                        }
                        pisi.WriteLine(" ");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vpiši ime datoteke: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Maksimalno število vrstic: ");
            int maxvrstic = int.Parse(Console.ReadLine());
            Console.WriteLine("Maksimalno število naključnih števil v vrstici: : ");
            int maxstevil = int.Parse(Console.ReadLine());
            Console.WriteLine("Maksimalno naključno število: ");
            int maxvrednost = int.Parse(Console.ReadLine());
            Ustvari(ime, maxvrstic, maxstevil, maxvrednost);
            Branje(ime);
        }
    }
}

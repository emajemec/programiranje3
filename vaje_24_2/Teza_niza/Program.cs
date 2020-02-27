using System;

namespace Teza_niza
{
    class Program
    {
        public static int Sloteža(char znak)
        {
            string mala_abeceda = "abcčdefghijklmnoprsštuvzž";
            string velika_abc = mala_abeceda.ToUpper();
            if (mala_abeceda.IndexOf(znak) >= 0)
            {
                return mala_abeceda.IndexOf(znak) + 1;
            }
            if (velika_abc.IndexOf(znak) >= 0)
            {
                return velika_abc.IndexOf(znak) + 51;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi niz: ");
            string niz = Console.ReadLine();
            Console.WriteLine("Tehtnica: ");
            string jezik = Console.ReadLine();
            int vsota = 0;
            string racun = "Racun: ";
            if (jezik == "angleska")
            {
                foreach (char znak in niz)
                {
                    vsota += znak + 0;
                    racun += znak + " + ";
                }
            }
            if (jezik == "slovenska")
            {
                foreach (char znak in niz)
                {

                    vsota += Sloteža(znak);
                    racun += Sloteža(znak) + " + ";
                }
            }
            Console.WriteLine("Teza niza: " + vsota);
            racun = racun.Remove(racun.Length - 2, 2) + "";
            Console.WriteLine(racun);
        }
    }
        
}

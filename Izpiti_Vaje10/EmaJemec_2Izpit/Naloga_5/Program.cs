using System;

namespace Naloga_5
{
    public class Polonica
    {
        private int _starost;
        private int _steviloPik;

        public int Starost
        {
            get
            {
                return _starost;
            }
            set
            {
                if (value < 0) throw new Exception("Leta ne morajo biti negativna!");
                if (value > 208) throw new Exception("Pikapolonica ne mora biti starejša od 4 let.");
                _starost = value;
            }
        }
        public int SteviloPik
        {
            get
            {
                return _steviloPik;
            }
            set
            {
                if (value < 0) throw new Exception("Pikapolonica ne mora imeti negativno število pik!");
                if (value > 7) throw new Exception("Pikapolonica ne mora imeti več kot 7 pik!");
                _steviloPik = value;
            }
        }
        public void NastaviSteviloPik(int steviloPik)
        {
            this.SteviloPik = steviloPik;
        }

        public Polonica(int starost, int stPik)
        {
            this.Starost = starost;
            this.SteviloPik = stPik;
        }

        public override string ToString()
        {
            return "Jaz sem PikaPoka, stara " + Starost + " tednov in imam " + SteviloPik + " pik.";

        }
        public static Polonica[] operator *(Polonica P, int i)
        {
            Polonica[] tab = new Polonica[i];
            for (int  j = 0;  j < i;  j++)
            {
                tab[j] = P;
            }
            return tab;
        }
        public static Polonica[] operator *(int i, Polonica P)
        {
            Polonica[] tab = new Polonica[i];
            for (int j = 0; j < i; j++)
            {
                tab[j] = P;
            }
            return tab;
        }

        public static int stejPike(Polonica[] pikapolonice)
        {
            int skupnoPik = 0;
            foreach (Polonica pika in pikapolonice)
            {
                if (pika.Starost > 52)
                {
                    skupnoPik += pika.SteviloPik;
                }
            }
            return skupnoPik;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Polonica[] tab = new Polonica[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Polonica p = new Polonica(rand.Next(208), rand.Next(8));
                tab[i] = p;
                Console.WriteLine(p);
            }
            Console.WriteLine("Število vseh pik pikapolonic, ki so starejše od 1 leta: " + Polonica.stejPike(tab));
            Polonica pika = new Polonica(100, 7);
            Console.WriteLine(pika);
            Polonica[] tabPik = pika * 5;
            foreach (Polonica p in tabPik)
            {
                Console.WriteLine(p);
            }
        }
    }
}

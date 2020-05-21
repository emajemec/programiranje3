using System;
using System.Linq;
using System.IO;

namespace Kolo
{
    class Kolo
    {
        private int _prestave;
        private string _barva;
        private string _tip;
        private int _leto;
        private int _stLjudi;

        private static string[] barve = { "rdeča", "rumena", "zelena", "modra", "bela", "črna", "roza", "vijolična", "rjava", "oranžna", "siva" };
        private static string[] tipi = { "gorsko", "cestno", "treking", };

        public int Prestave
        {
            get
            {
                return _prestave;
            }
            set
            {
                if (value < 0 || value > 40) throw new Exception("Nesmiselno število prestav!");
            }
        }

        public string Barve
        {
            get
            {
                return _barva;
            }
            set
            {
                if (!Kolo.barve.Contains(value)) throw new Exception("Neustrezna barva!");
            }
        }

        public string Tip
        {
            get
            {
                return _tip;
            }
        }
        public int Leto
        {
            get
            {
                return _leto;
            }
        }
        public int StLjudi
        {
            get
            {
                return _stLjudi;
            }
        }

        public Kolo(string tip, int prestave, string barve, int leto, int stLjudi)
        {
            Prestave = prestave;
            Barve = barve;
            //ustrezen tip kolesa
            if (!tipi.Contains(tip)) throw new Exception("Neustrezen tip kolesa!");
            _tip = tip;
            //pogoj za leto
            if (leto > DateTime.Now.Year) throw new Exception("Neveljaven datum!");
            _leto = leto;
            //pogoj za število ljudi
            if (stLjudi < 0 || stLjudi > 6) throw new Exception("Nesmiselno število ljudi.");
            _stLjudi = stLjudi;
        }
        public override string ToString()
        {
            return _tip + ", " + Prestave + ", " + Barve + ", " + _leto + ", " + _stLjudi;
        }

        /// <summary>
        /// Generira naključno tabelo 100 koles
        /// </summary>
        /// <returns></returns>
        public Kolo[] GenerirajTabelo()
        {
            string[] b = { "rdeča", "rumena", "zelena", "modra", "bela", "črna", "roza", "vijolična", "rjava", "oranžna", "siva" };
            Kolo[] tabKoles = new Kolo[100];

            Random genTip = new Random();
            Random genPrestave = new Random();
            Random genBarve = new Random();
            Random genLeto = new Random();
            Random genStLjudi = new Random();

            for (int i = 0; i < tabKoles.Length; i++)
            {
                int tip = genTip.Next(0, 3);
                int prestave = genPrestave.Next(0, 10);
                int barva = genBarve.Next(0, 11);
                int leto = genLeto.Next(1999, 2020);
                int stLjudi = genStLjudi.Next(0, 6);

                tabKoles[i] = new Kolo(tipi[tip], prestave, b[barva], leto, stLjudi);
            }
            return tabKoles;
        }

        /// <summary>
        /// Podatke o kolesu zapiše na datoteko.
        /// </summary>
        public static void ZapišiNaDat(StreamWriter piši, Kolo k)
        {
                piši.WriteLine(k.ToString());
        }
        /// <summary>
        /// Iz datoteke prebere dano vrstico in vrne Kolo.
        /// </summary>
        /// <param name="dat"></param>
        /// <param name="vrstica"></param>
        /// <returns>Kolo</returns>
        public static Kolo UstvariIzDat(StreamReader beri)
        {
            string vr = beri.ReadLine();
            if (vr == null) { throw new Exception("To število koles ne obstaja!"); }
            string[] podatek = vr.Split(',');
            Kolo kolo = new Kolo(podatek[0], int.Parse(podatek[1]), podatek[2], int.Parse(podatek[3]), int.Parse(podatek[4]));
            return kolo;
        }
        /// <summary>
        /// Iz datoteke prebere podatke in ustvari tabelo koles.
        /// </summary>
        /// <returns>Tabela koles</returns>
        public Kolo[] UstvariTabelo(string dat)
        {
            if (!File.Exists(dat)) throw new Exception("Datoteka ne obstaja!");
            int vrstice = File.ReadLines(dat).Count();
            Kolo[] tabKoles = new Kolo[vrstice];
            using (StreamReader beri = new StreamReader(dat))
                for (int i = 1; i <= vrstice; i++)
                {
                    tabKoles[i - 1] = UstvariIzDat(beri);
                }

            return tabKoles;
        }
        /// <summary>
        /// Metoda vrne tabelo stevil, vsako število v tabeli predstavlja število koles posamezne barve.
        /// </summary>
        /// <param name="tab">tabela koles</param>
        /// <param name="barva"></param>
        /// <returns></returns>
        public int prestejBarve(Kolo[] tab, string barva)
        {
            int st = 0;
            foreach (Kolo k in tab)
            {
                if (k._barva.Equals(barva))
                {
                    st++;
                }
            }
            return st;
        }

        /// <summary>
        /// Metoda, ki prebarva vsa rumena kolesa v rdeča.
        /// </summary>
        /// <param name="tab">tabela koles</param>
        public void prebarvaj(Kolo[] tab)
        {
            foreach (Kolo k in tab)
            {
                if (k._barva.Equals("rumena"))
                {
                    k._barva = "rdeča";
                }
            }
        }

        /// <summary>
        /// Metoda, ki vrne stevilo ljudi, ki se lahko hkrati peljejo s cestnimi kolesi
        /// </summary>
        /// <param name="tab"></param>
        /// <returns></returns>
        public int KolikoCestnih(Kolo[] tab)
        {
            int st = 0;
            foreach (Kolo k in tab)
            {
                if (k._tip.Equals("cestno"))
                {
                    st += k._stLjudi;
                }
            }
            return st;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kolo k = new Kolo("cestno", 4, "rumena", 2009, 1);
            Kolo[] tab = k.GenerirajTabelo();
            foreach (Kolo ko in tab)
            {
                Console.WriteLine(ko);
            }
            Console.WriteLine("Stevilo modrih koles je: " + k.prestejBarve(tab, "modra"));
            Console.WriteLine("Stevilo rumenih koles je: " + k.prestejBarve(tab, "rumena"));
            Console.WriteLine("Stevilo rdečih koles je: " + k.prestejBarve(tab, "rdeča"));
            k.prebarvaj(tab);
            Console.WriteLine("Prebarvaj!");
            Console.WriteLine("Stevilo rumenih koles je: " + k.prestejBarve(tab, "rumena"));
            Console.WriteLine("Stevilo rdečih koles je: " + k.prestejBarve(tab, "rdeča"));
            Console.WriteLine("Hkrati se s cestnimi kolesi lahko vozi " + k.KolikoCestnih(tab) + "ljudi");

        }
    }
}
    


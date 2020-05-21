using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Bager
{
    class Bager : IComparable<Bager>
    {
        private int _teza;
        private string _ime;
        private int _leto;
        private double _cena;
      
        public double Cena
        {
            get
            {
                return _cena;
            }
            set
            {
                if (value > 20000)
                {
                    _cena = value * 0.9;
                }
                if (value < 0) throw new Exception("Cena mora biti pozitivno celo število!");
            }
        }


        public int Leto
        {
            get
            {
                return _leto;
            }
        }

        public int Teza
        {
            get
            {
                return _teza;
            }
        }
        public Bager(int teza, string ime, int leto, int cena)
        {
            if (teza <= 0) throw new Exception("Teža mora biti pozitivno celo število!");
            this._teza = teza;
            this._ime = ime;
            if ((leto > DateTime.Now.Year)||(leto < 1990)) throw new Exception("Neveljaven datum!");
            this._leto = leto;
            this.Cena = cena;
        }

        public Bager()
        {
            this._teza = 300;
            this._ime = "Drejc";
            this._leto = 2001;
            this.Cena = 50000;
        }

        public Bager(string niz)
        {
            string[] tab = niz.Split(" ");
            this._ime = tab[1];
            int teza = int.Parse(tab[3]);
            if (teza <= 0) throw new Exception("Teža mora biti pozitivno celo število!");
            this._teza = teza;
            this.Cena = double.Parse(tab[5]);
            //Ker nimamo podanih let, bomo privzeli da so vsi bagri iz trenutnega leta
            this._leto = DateTime.Now.Year;
        }
        public override string ToString()
        {
            return "Bager " + _ime + " težak " + _teza + " stane " + _cena + " EUR." ;
        }

        //Objekt zapiše na odprto tekstovno datoteko
        public void DodajNaDatoteko(string dat)
        {
            StreamWriter piši;
            if (!File.Exists(dat))
            {
                piši = File.CreateText(dat);
            }
            else
            {
                piši = File.AppendText(dat);
            }
            piši.WriteLine(this.ToString());
            piši.Close();
        }
        //Vrne tabelo objektov, zapisanih na datoteki
        public Bager[] PreberiZDatoteke(string dat)
        {
            if (!File.Exists(dat)) throw new Exception("Datoteka ne obstaja!");
            string[] pomoznaTab = File.ReadAllLines(dat);
            Bager[] tab = new Bager[pomoznaTab.Length];
            int i = 0;
            foreach (string niz in pomoznaTab)
            {
                Bager bg = new Bager(niz);
                tab[i] = bg;
                i++;
            }
            return tab;
        }

        //izpiše predstavitev objektov na datoteki
        public void IzpisiDatoteko(string dat)
        {
            if (!File.Exists(dat)) throw new Exception("Datoteka ne obstaja!");
            StreamReader beri = File.OpenText(dat);
            string vrstica = beri.ReadLine();
            Console.WriteLine(vrstica);
            while (vrstica != null)
            {
                vrstica = beri.ReadLine();
                Console.WriteLine(vrstica);
            }
        }

        //tvori st  objektov, ki jih zapise na datoteko dat
        public void TvoriDatoteke(string dat, int st)
        {
            Bager[] tab = GenerirajTab(st);
            foreach (Bager bg in tab)
            {
                bg.DodajNaDatoteko(dat);
            }
        }

        //generira tabelo naključnih bagrov
        public Bager[] GenerirajTab(int stBagrov)
        {
            string[] tabImen = { "Drejc", "Tone", "Miha", "Malči", "Miško", "Mici", "Maksi", "Vojc", "Kopač", "Valjar" };
            Random rand = new Random();
            Bager[] tabBagrov = new Bager[stBagrov];
            for (int i = 0; i < stBagrov; i++)
            {
                int teza = rand.Next(1, 10000);
                int indIme = rand.Next(0, tabImen.Length);
                int leto = rand.Next(1990, DateTime.Now.Year + 1);
                int cena = rand.Next(100, 100000);
                tabBagrov[i] = new Bager(teza, tabImen[indIme], leto, cena);
            }
            return tabBagrov;
        }
        //Izpiše najtežji bager v tabeli bagrov
        public Bager Najtezji(Bager[] tab)
        {
            int najTeza = 0;
            Bager najBager = tab[0];
            foreach (Bager bg in tab)
            {
                if (bg._teza > najTeza)
                {
                    najTeza = bg._teza;
                    najBager = bg;
                }
            }
            return najBager;
        }
        public int CompareTo(Bager other)
        {
            if (this.Leto < other.Leto)
            {
                return -1;
            }
            if (this.Leto > other.Leto)
            {
                return 1;
            }
            //če je this.Leto == other.Leto
            if (this.Teza < other.Teza)
            {
                return -1;
            }
            return 1;
        }
        //Odstranimo vse bagre, ki so starejši od 12 let
        public Bager[] Odstrani(Bager[] tab)
        {
            int MinLeto = DateTime.Now.Year - 12;
            int stevec = 0;
            foreach (Bager bg in tab)
            {
                if (bg._leto >= MinLeto)
                {
                    stevec++;
                }
            }
            Bager[] novaTab = new Bager[stevec];
            int i = 0;
            foreach (Bager bg in tab)
            {
                if(bg._leto >= MinLeto)
                {
                    novaTab[i] = bg;
                    i++;
                }
            }
            tab = novaTab;
            return tab;
        }

        //Preberite datoteko bagrov  in podatke zapišite na več datotek, ločenih po letu izdelave bagrov.
        public void ZapišiPoLetih(string dat)
        {
            if (!File.Exists(dat)) throw new Exception("Datoteka ne obstaja!");
            Bager[] tab = PreberiZDatoteke(dat);
            foreach (Bager bg in tab)
            {
                bg.DodajNaDatoteko(bg.Leto + ".txt");
            }
        }

     
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bager Drejc = new Bager();
            Console.WriteLine(Drejc);
            Console.WriteLine();
            Bager[] tab = Drejc.GenerirajTab(20);
            foreach (Bager bg in tab)
            {
                Console.Write(bg);
                Console.WriteLine("Leto: " + bg.Leto);
            }
            Array.Sort(tab);
            Console.WriteLine();
            Console.WriteLine("Tabela urejena po letih: ");
            foreach (Bager bg in tab)
            {
                Console.Write(bg);
                Console.WriteLine(" Leto: " + bg.Leto);
            }
            Console.WriteLine();
            Console.WriteLine("Najtezji bager: " + Drejc.Najtezji(tab));
            Bager[] novatab = Drejc.Odstrani(tab);
            Console.WriteLine();
            Console.WriteLine("Odstranimo vse bagre starejše od 12 let: ");
            foreach (Bager bg in novatab)
            {
                Console.WriteLine(bg);
            }
            Console.WriteLine();
            Console.WriteLine("Na datoteko zapišemo 12 bagrov");
            //Bager Tone = new Bager(1000, "Tone", 2009, 12000);
            //Bager[] tabBG = Tone.GenerirajTab(12);
            Drejc.TvoriDatoteke(@"Bagri.txt", 12);
            Bager[] tabDat = Drejc.PreberiZDatoteke(@"Bagri.txt");
            Console.WriteLine("Preberemo datoteko: ");
            foreach (Bager bg in tabDat)
            {
                Console.WriteLine(bg);
            }
        }
    }
}

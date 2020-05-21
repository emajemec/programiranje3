using System;
using System.Linq;
using System.IO;

namespace Majica
{
    class Majica
    {
        private int _velikost;
        private string _barva;
        private bool _rokavi; //true - kratki rokavi, false - dolgi rokavi

        private string[] _barveTab = { "rdeča", "rumena", "zelena", "modra", "bela", "črna", "roza", "vijolična", "rjava", "oranžna", "siva" };
        

        public int Velikost
        {
            get 
            {
                return _velikost;
            }
            set
            {
                if ((value < 1) || (value > 5)) throw new Exception("Neveljavna številka majice!");
            }
        }

        public string Barva
        {
            get
            {
                return _barva;
            }
            set
            {
                if (!_barveTab.Contains(value)) throw new Exception("Majica teke barve ne obstaja!");
            }
        }

        public bool Rokavi
        {
            get
            {
                return _rokavi;
            }
            set
            {
                _rokavi = value;
            }
        }
        //konstruktor
        public Majica(int st, string br, bool rok)
        {
            this._velikost = st;
            this._barva = br;
            this._rokavi = rok;
        }

        public string[] Barve
        {
            get
            {
                return _barveTab;
            }
        }

      

        public override string ToString()
        {
            string dolzina = "";
            if (this.Rokavi.Equals(true))
            {
                dolzina = "kratek";
            }
            else
            {
                dolzina = "dolg";
            }
            return "(" + this.Velikost + ", " + this.Barva + ", " + dolzina + ")";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Majica moja = new Majica(2, "rdeča", true);
            Console.WriteLine(moja);
        }
    }
}

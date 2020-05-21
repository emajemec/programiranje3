using System;
using System.Linq;

namespace Registracija
{
    class Registracija
    {
        private string[] _kraji = new string[] { "LJ", "KR", "KK", "MB", "MS", "KP", "GO", "CE", "SG", "NM", "PO" };
        private string _registrska;
        private string _obmocje;

        public string Registrska
        {
            get
            {
                return _registrska;
            }
            set
            {
                if (value.Length != 5) throw new Exception("Registracija mora biti sestavljena iz pet znakov.");
            }
        }

        public string Obmocje
        {
            get
            {
                return _obmocje;
            }
            set
            {
                if (!_obmocje.Contains(value)) throw new Exception("To obmocje je neveljavno!");
            }
        }

        public string[] TabKrajev
        {
            get
            {
                return _kraji;
            }
        }

        public Registracija(string obmocje, string registrska)
        {
            _obmocje = obmocje;
            _registrska = registrska;
        }

        public override string ToString()
        {
            return _obmocje + " " + _registrska;
        }

        public void Dodamo(string kr)
        {
            if (!_kraji.Contains(kr))
            {
                string[] tab = new string[_kraji.Length + 1];
                for (int i = 0; i < _kraji.Length; i++)
                {
                    tab[i] = _kraji[i];
                }
                tab[_kraji.Length] = kr;
                _kraji = tab;
            }
        }


        public void Odstrani(string kr)
        {
            if (!_kraji.Contains(kr)) throw new Exception("Tega kraja ni v tabeli. ");

            if (_kraji.Contains(kr))
            {
                string[] tab = new string[_kraji.Length - 1];
                int st = 0;
                foreach (string niz in _kraji)
                {
                    if (niz != kr)
                    {
                        tab[st] = _kraji[st];
                        st++;
                    }
                }
                _kraji = tab;
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}

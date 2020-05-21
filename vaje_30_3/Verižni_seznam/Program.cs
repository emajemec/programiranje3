using System;


namespace Verižni_seznam
{
    class Vozel<T>
    {
        private T _podatek;
        private Vozel<T> _naslednji;

        //lastnosti za podatek
        public T Podatek
        {
            get
            {
                return _podatek;
            }
            set
            {
                _podatek = value;
            }
        }

        //lastnosti za vozel

        public Vozel<T> Naslednji
        {
            get
            {
                return _naslednji;
            }
            set
            {
                _naslednji = value;
            }
        }

        public Vozel(T vrednost)
        {
            _podatek = vrednost;
            _naslednji = null;
        }

    }
    class Verizni_seznam<T> 
    {

        private Vozel<T> prvi; 
        private Vozel<T> zadnji;

        private int _dolzina;

        public int Dolzina
        {
            get 
            { 
                return _dolzina; 
            }
            set 
            { 
                _dolzina = value; 
            }
        }
        
        public Verizni_seznam()
        {
            prvi = null;
            zadnji = null;
        }

        /// <summary>
        /// Doda vozel na zacetek veriznega seznama
        /// </summary>
        /// <param name="podatek"></param>
        public void DodajZacetek(T podatek)
        {
            Vozel<T> nov = new Vozel<T>(podatek); //ustvarimo nov vozel
            nov.Naslednji = prvi;
            prvi = nov;
            _dolzina++;
        }

        /// <summary>
        /// Odstrani vozel z zacetka veriznega seznama.
        /// </summary>
        /// <returns></returns>
        public T OdstraniZacetek()
        {
            if (prvi == null)
            {
                return default(T);
            }
            if (prvi.Naslednji == null)
            {
                zadnji = null;
            }
            T PrviPodatek = prvi.Podatek;
            prvi = prvi.Naslednji;
            _dolzina--;
            return PrviPodatek;

        }

        /// <summary>
        /// Dodamo na konec
        /// </summary>
        /// <param name="podatek"></param>
        public void DodajKonec(T podatek)
        {
            Vozel<T> nov = new Vozel<T>(podatek);
            if (zadnji == null)
            {
                prvi = zadnji;
                zadnji = nov;
                prvi = nov;
            }
            else
            {
                zadnji.Naslednji = nov;
                zadnji = nov;
            }
            _dolzina++;
        }

        /// <summary>
        /// Odstrani vozel s konca verižnega seznama
        /// </summary>
        /// <returns></returns>
        public T OdstraniKonec() 
        {
            Vozel<T> trenutni = prvi;
            Vozel<T> prejsnji = null;

            if (trenutni == null)
            {
                throw new Exception();
            }
            if (trenutni.Naslednji == null)
            {
                prvi = null;
                zadnji = null;
                return default(T);
            }
            while (true)
            {
                if (trenutni.Naslednji == null)
                {
                    prejsnji.Naslednji = null;
                    _dolzina--;
                    return trenutni.Podatek;
                }
                prejsnji = trenutni;
                trenutni = trenutni.Naslednji;
            }

        }

        public override string ToString()
        {
            string niz = "";
            Vozel<T> trenutni = prvi;
            while (trenutni.Naslednji != null)
            {
                niz += trenutni.Podatek.ToString();
                if (trenutni.Naslednji != null)
                {
                    niz += ", ";
                }
                trenutni = trenutni.Naslednji;
            }
            return niz + "]";
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

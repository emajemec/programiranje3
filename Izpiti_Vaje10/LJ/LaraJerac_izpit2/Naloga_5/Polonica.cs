using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_5
{
    public class Polonica
    {
        private int _Starost; //življenska dobo okoli treh let, mi bomo dopuščali 4 (208 tednov)
        private int _SteviloPik; //vse 7 (z leti lahko zbledijo)

        public int Starost 
        { 
            get { return _Starost; }
            set
            { 
                if (value >= 208 || value < 0) { throw new Exception("Nesmiselna starost."); }
                _Starost = value;
            }
        }
        public int SteviloPik 
        {
            get { return _SteviloPik; }
            set
            {
                if ((value > 7  || value < 0) || (Starost == 0 && value != 7)) { throw new Exception("Nesmiselno število pik."); }
                _SteviloPik = value;
            }
        }

        public Polonica(int starost, int steviloVidnihpik)
        {
            Starost = starost;
            SteviloPik = steviloVidnihpik;
        }

        public void NastaviSteviloPik(int steviloPik)
        {
            this._SteviloPik = steviloPik;
        }
        public override string ToString()
        {
            return "Jaz sem PikaPoka, stara " + Starost + " tednov in imam " + SteviloPik + " pik.";
        }
        public static Polonica[] operator *(int n, Polonica p)
        {
            if (n < 0) { throw new Exception(); }
            Polonica[] tab = new Polonica[n];
            for (int i = 0; i < n; i++)
            {
                tab[i] = p;
            }
            return tab;
        }
        public static Polonica[] operator *(Polonica p, int n)
        {
            if (n < 0) { throw new Exception(); }
            Polonica[] tab = new Polonica[n];
            for (int i = 0; i < n; i++)
            {
                tab[i] = p;
            }
            return tab;
        }
        /// <summary>
        /// Št pik polonic starejših od enega leta.
        /// </summary>
        /// <param name="pikapolonice"></param>
        /// <returns></returns>
        public static int steviloPik(Polonica[] pikapolonice)
        {
            int vsota = 0;
            foreach (Polonica p in pikapolonice)
            {
                if (p.Starost > 52) { vsota += p.SteviloPik; }
            }
            return vsota;
        }
    }
}

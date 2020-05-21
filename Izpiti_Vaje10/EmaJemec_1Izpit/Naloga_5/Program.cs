using System;

namespace Naloga_5
{
    class KompleksnoStevilo
    {
        private double _re;
        private double _im;

        public double Re
        {
            get
            {
                return _re;
            }
            set
            {
                _re = value;
            }
        }
        public double Im
        {
            get
            {
                return _im;
            }
            set
            {
                _im = value;
            }
        }

        public KompleksnoStevilo(double re, double im)
        {
            this.Re = re;
            this.Im = im;
        }
        public double R
        {
            get
            {
                return Math.Sqrt(Math.Pow(Re, 2) + Math.Pow(Im, 2));
            }
            set
            {

            }
        }
        public double Arg
        {
            get
            {
                return Math.Atan2(Re, Im);
            }
            set
            {

            }
        }
        public override string ToString()
        {
            string ReŠt = this._re + "";
            string ImŠt = this._im + "i";
            if (this._im == 1)
            {
                ImŠt = "i";
            }
            if (this._im == -1)
            {
                ImŠt = "-i";
            }
            if (this._re == 0)
            {
                return ImŠt;
            }
            if (this._im == 0)
            {
                return ReŠt;
            }
            if (this._im > 0)
            {
                return ReŠt + "+" + ImŠt;
            }
            else
            {
                return ReŠt + "" + ImŠt;
            }
        }
        public static KompleksnoStevilo operator +(KompleksnoStevilo z, KompleksnoStevilo u)
        {
            return new KompleksnoStevilo(z._re + u._re, z._im + u._im);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KompleksnoStevilo z = new KompleksnoStevilo(4, 0);
            Console.WriteLine(z);
            KompleksnoStevilo u = new KompleksnoStevilo(0, 4);
            Console.WriteLine(u);
            KompleksnoStevilo w = new KompleksnoStevilo(-3, 0.5);
            Console.WriteLine(w);
            KompleksnoStevilo v = new KompleksnoStevilo(-2, 1);
            Console.WriteLine(v);
            Console.WriteLine("Vsota kompleksnih števil {0} in {1} je {2}.", u, z, u + z);
            Console.WriteLine("Absolutna vrednost kompleksnega števila {0} je {1}.", w, w.R);
            Console.WriteLine("Argument kompleksnega Števila {0} je {1}.", v, v.Arg);
        }
  
    }
}

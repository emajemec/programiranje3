using System;

namespace KompleksnoSt
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

        public KompleksnoStevilo()
        {
            this._re = 1;
            this._im = 1;
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

        public KompleksnoStevilo[] GenerirajTab(int st)
        {
            Random rand = new Random();
            KompleksnoStevilo[] tab = new KompleksnoStevilo[st];
            for (int i = 0; i < st; i++)
            {
                double re = rand.Next(-100, 100);
                double im = rand.Next(-100, 100);
                tab[i] = new KompleksnoStevilo(re, im);
            }
            return tab;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KompleksnoStevilo z = new KompleksnoStevilo();
            Console.WriteLine(z);
            KompleksnoStevilo u = new KompleksnoStevilo(0, 4);
            Console.WriteLine(u);
            KompleksnoStevilo w = new KompleksnoStevilo(-3, 0);
            Console.WriteLine(w);
            KompleksnoStevilo[] tab = z.GenerirajTab(5);
            foreach (KompleksnoStevilo k in tab)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Vsota kompleksnih števil {0} in {1} je {2}.", tab[0], tab[1], tab[0] + tab[1]);
            Console.WriteLine("Absolutna vrednost kompleksnega števila {0} je {1}.", tab[2], tab[2].R);
            Console.WriteLine("Argument kompleksnega Števila {0} je {1}.", tab[3], tab[3].Arg);        
        }
    }
}

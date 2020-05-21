using System;
using System.Collections.Generic;
using System.Text;

namespace Naloga_5
{
    public class KompleksnoStevilo
    {
        private double realno;
        private double imaginarno;

        public double Re 
        {
            get { return this.realno; }
            set { this.realno = value; }
        }

        public double Im
        {
            get { return this.imaginarno; }
            set { this.imaginarno = value; }
        }

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="real"></param>
        /// <param name="imag"></param>
        public KompleksnoStevilo(double real, double imag)
        {
            this.realno = real;
            this.imaginarno = imag;
        }

        /// <summary>
        /// lastnost za izracun absolutne vrednosti kompleksnega stevila
        /// </summary>
        public double R
        {
            get { return Math.Pow ((Math.Pow (this.realno, 2) + Math.Pow (this.imaginarno, 2)), 0.5); }
            //set
        }

        /// <summary>
        /// metoda za izracun argumenta v radianih
        /// </summary>
        public double Arg
        {
            get { return Math.Atan2 (this.imaginarno, this.realno); }
            set
            {
                if (value == 0) throw new Exception ("Z nič se ne da deliti!");
            }
        }

        public override string ToString()
        {
            string niz = this.realno.ToString() + " + " + this.imaginarno.ToString() + "i";
            if (imaginarno < 0) niz = this.realno.ToString () + " " + this.imaginarno.ToString () + "i";
            if (realno == 0) niz = this.imaginarno.ToString () + "i";
            if (imaginarno == 0) niz = this.realno.ToString ();

            if (realno == 0 && imaginarno == 1) niz = "i";
            if (realno != 0 && imaginarno == 1) niz = this.realno.ToString () + "i";
            if (realno == 0 && imaginarno == -1) niz = "-1";
            if (realno != 0 && imaginarno == -1) niz = this.realno.ToString () + "-i";

            return niz;
        }

        /// <summary>
        /// metoda za sestevanje dveh kompleksnih stevil
        /// </summary>
        /// <param name="z"></param>
        /// <param name="u"></param>
        /// <returns></returns>
        public static KompleksnoStevilo operator +(KompleksnoStevilo z, KompleksnoStevilo u)
        {
            double real = z.realno + u.realno;
            double imag = z.imaginarno + u.imaginarno;
            return new KompleksnoStevilo (real, imag);
        }

    }
}

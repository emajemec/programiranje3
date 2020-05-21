using System;

namespace Vozilo
{
    public class Vozilo
    {
        private double gorivo;
        private double kapaciteta;
        private double poraba;

     
        public double Kapaciteta
        {
            get { return this.kapaciteta; }
            set
            {
                if (value < 0) throw new Exception("Število mora biti pozitivno!");
                this.kapaciteta = value;
            }
        }

        public double Poraba
        {
            get { return this.poraba; }
            set
            {
                if (value < 0) throw new Exception("Število mora biti pozitivno!");
                this.poraba = value;
            }
        }

        public Vozilo(double kapac, double por)
        {
            this.Kapaciteta = kapac;
            this.Poraba = por;
            this.gorivo = kapac;
        }

        public double Preostalikilometri()
        {
            return (this.gorivo / this.poraba) * 100;
        }

        public void Crpalka()
        {
            this.gorivo = kapaciteta;
        }

        public bool Prevozimo(double[] tab)  //[200, 0, 10, 0, 0]
        {
            int stNicel = 0;
            double trenutnoGorivo = this.gorivo;
            // v tej zanki spreminjam trenutnoGorivo (sploh ne vplivam na objekt!)   
            foreach (double el in tab)
            {
                if (el < 0) throw new Exception("Število mora biti pozitivno!");
                if (el == 0)
                {
                    stNicel++;
                    trenutnoGorivo = this.kapaciteta;
                }
                if (el > 0)
                {
                    trenutnoGorivo -= el;
                }
                if (trenutnoGorivo < 0)
                {
                    return false;
                }
                if (stNicel > (tab.Length + 1) / 2) throw new Exception("Dve zaporedni ničli v tabeli!");
            }
            // vse je bilo OK, zato popravimo stanje objekta
            this.gorivo = trenutnoGorivo;
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo vozilo11 = new Vozilo(60, 5.8);
            Console.WriteLine("Kapaciteta rezervoarja je " + vozilo11.Kapaciteta);
            Console.WriteLine("Poraba goriva je " + vozilo11.Poraba);
            
            Console.WriteLine("S polnim rezervoarjem lahko prevozimo " + Preostalikilometri() + "kilometrov");
           

        }

    }
}


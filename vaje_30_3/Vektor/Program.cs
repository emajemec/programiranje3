using System;

namespace Vektor
{
    class Vektor : IComparable<Vektor>
    {
        private int _x;
        private int _y;
        private int _stevec;

        private static int kolikoOb = 0;

        // konstruktor:
        public Vektor(int x, int y)
        {
            this._x = x;
            this._y = y;
            Vektor.kolikoOb += 1;
            this._stevec = Vektor.kolikoOb;
        }
        // X komponenta vektorja
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        // Y komponeta vektorja
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        // dolžina vektorja
        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            }
        }
        public override string ToString()
        {
            return ("("+ this.X + " , " + this.Y + ")"); 
        }
        //matematični operatorji
        //seštevanje dveh vektorjev
        public static Vektor operator +(Vektor v1, Vektor v2)
        {
            return new Vektor(v1.X + v2.X, v1.Y + v2.Y);
        }
        //odštevanje dveh vektorjev
        public static Vektor operator -(Vektor v1, Vektor v2)
        {
            return new Vektor(v1.X - v2.X, v1.Y - v2.Y);
        }
        //množenje vektorja s celim številom
        public static Vektor operator *(Vektor v, int skalar)
        {
            return new Vektor(v.X * skalar, v.Y * skalar);
        }
        public static Vektor operator *(int skalar, Vektor v)
        {
            return new Vektor(v.X * skalar, v.Y * skalar);
        }
        //skalarni produkt dveh vektorjev
        public static int operator *(Vektor v1, Vektor v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }
        //povečanje koordinat za 1
        public static Vektor operator ++(Vektor v)
        {
            v.X++;
            v.Y++;
            return new Vektor(v.X, v.Y);
        }
        //pomanšanje koordinat za 1
        public static Vektor operator --(Vektor v)
        {
            v.X--;
            v.Y--;
            return new Vektor(v.X, v.Y);
        }
        //nasprotno usmerjen vektor
        public static Vektor operator -(Vektor v)
        {
            return new Vektor(-v.X, -v.Y);
        }
        //primerjalni operatorji
        public static bool operator ==(Vektor v1, Vektor v2)
        {
            return (v1.X == v2.X && v1.Y == v2.Y);
        }
        public static bool operator !=(Vektor v1, Vektor v2)
        {
            //return (v1.X != v2.X || v1.Y != v2.Y);
            return !(v1 == v2);
        }
        public static bool operator >(Vektor v1, Vektor v2)
        {
            return (v1.Length > v2.Length);
        }

        public static bool operator <(Vektor v1, Vektor v2)
        {
            return (v1.Length < v2.Length);
        }

        public static bool operator >=(Vektor v1, Vektor v2)
        {
            return (v1.Length >= v2.Length);
        }

        public static bool operator <=(Vektor v1, Vektor v2)
        {
            return (v1.Length <= v2.Length);
        }
        //logični opertorji
        public static bool operator &(Vektor v1, Vektor v2)
        {
            bool prvi = !((v1.X == 0) && (v1.Y == 0));
            bool drugi = !((v2.X == 0) && (v2.Y == 0));

            return prvi & drugi;
        }
        public static bool operator |(Vektor v1, Vektor v2)
        {
            bool prvi = !((v1.X == 0) && (v1.Y == 0));
            bool drugi = !((v2.X == 0) && (v2.Y == 0));

            return prvi | drugi;
        }
        public static bool operator ^(Vektor v1, Vektor v2)
        {
            bool prvi = !((v1.X == 0) && (v1.Y == 0));
            bool drugi = !((v2.X == 0) && (v2.Y == 0));

            return prvi ^ drugi;
        }
        //pretvorba
        public static implicit operator double(Vektor v)
        {
            return v.Length;
        }
        public static explicit operator float(Vektor v)
        {
            return (float)v.Length;
        }
        //nadgradnja:
        //generiramo tabelo naključnih vektorjev
        //tabela je dolžine st_elementov + 3
        //vektorjev generiramo toliko kot je st_elementov
        //zadnja tri mesta v tebeli so rezervirana za dvojnike 3., 5. in 3. elementa
        public Vektor[] GenerirajTabelo(int st_elementov)
        {
            Vektor[] tab_vektorjev = new Vektor[st_elementov + 3];
            if (st_elementov < 5) throw new Exception("Tabela mora imeti vsaj 5 elementov");
            Random rand = new Random();
            for (int i = 0; i < st_elementov; i++)
            {
                int rand_x = rand.Next(-100, 100);
                int rand_y = rand.Next(-100, 100);
                tab_vektorjev[i] = new Vektor(rand_x, rand_y);
            }
            return tab_vektorjev;
        }

        public void Izpiši(Vektor[] tab)
        {
            for (int i = 0; i < tab.Length - 3; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
        //V tabelo vektorjev na konec tabele vstavimo kopijo 3., 5. in 3. vektorja
        public void VstaviKopije(Vektor[] tab)
        {
            int dolzina_tab = tab.Length;
            Vektor kopija_tretji1 = new Vektor(tab[2].X, tab[2].Y);
            Vektor kopija_tretji2 = new Vektor (tab[2].X, tab[2].Y);
            Vektor kopija_peti = new Vektor (tab[4].X, tab[4].Y);
            tab[dolzina_tab - 3] = kopija_tretji1;
            tab[dolzina_tab - 2] = kopija_tretji2;
            tab[dolzina_tab - 1] = kopija_peti;
        }
        public int CompareTo(Vektor other)
        {
            if (this.X < other.X)
            {
                return -1;
            }
            if (this.X > other.X)
            {
                return 1;
            }
            // this.X == other.X
            if (this.Y < other.Y)
            {
                return -1;
            }
            if (this.Y > other.Y)
            {
                return 1;
            }
            // this == other (po vsebini)
            if (this._stevec > other._stevec)
            {
                return 1;
            }
            return -1;
            // primerjamo "čas" nastzanka, torej vrednost _stevec!
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Vektor v1 = new Vektor(-4, 11);
            Vektor v2 = new Vektor(3, -5);
            //seštej v1 in v2
            Vektor v3 = v1 + v2;
            Console.WriteLine("Seštevanje: ({0},{1}) + ({2},{3}) = ({4}, {5})", v1.X, v1.Y, v2.X, v2.Y, v3.X, v3.Y);
            v1++;
            v2--;
            //odštej v1 in v2
            Vektor v4 = v1 - v2;
            Console.WriteLine("Odštevanje: ({0},{1}) - ({2},{3}) = ({4}, {5})", v1.X, v1.Y, v2.X, v2.Y, v4.X, v4.Y);
            v1++;
            //nasprotni vektor
            Vektor v5 = -v1;
            Console.WriteLine("Nasprotni vektor vektorja ({0},{1}) je vektor ({2}, {3})", v1.X, v1.Y, v5.X, v5.Y);
            v2--;
            //množenje s skalarjem
            int skalar = 5;
            Vektor v6 = skalar * v2;
            Console.WriteLine("Množenje s skalarjem: {0} * ({1}, {2}) = ({3}, {4})", skalar, v2.X, v2.Y, v6.X, v6.Y);
            v1++;
            v2--;
            //skalarni produkt
            int produkt = v1 * v2;
            Console.WriteLine("Skalarni produkt: ({0}, {1}) * ({2}, {3}) = {4}", v1.X, v1.Y, v2.X, v2.Y, produkt);
            v1++;
            v2--;
            //primerjava vektorjev
            Console.WriteLine("({0}, {1}) = ({2}, {3}) -> {4}", v1.X, v1.Y, v2.X, v2.Y, v2.Equals(v1));
            Console.WriteLine("({0}, {1}) < ({2}, {3}) -> {4}", v4.X, v4.Y, v2.X, v2.Y, v4 < v2);
            Console.WriteLine("({0}, {1}) <= ({2}, {3}) -> {4}", v3.X, v3.Y, v5.X, v5.Y, v3 <= v5);
            Console.WriteLine("({0}, {1}) >= ({2}, {3}) -> {4}", v1.X, v1.Y, v3.X, v3.Y, v1 >= v3);
            Console.WriteLine("({0}, {1}) > ({2}, {3}) -> {4}", v1.X, v1.Y, v6.X, v6.Y, v1 > v6);
            Console.WriteLine("({0}, {1}) != ({2}, {3}) -> {4}", v1.X, v1.Y, v5.X, v5.Y, v1 != v5);
            v1++;
            v2--;
            //pretvori vektorje v dolžino
            double d = v1;
            Console.WriteLine(d);
            float f = (float)v2;
            Console.WriteLine(f);
        }
    }
}

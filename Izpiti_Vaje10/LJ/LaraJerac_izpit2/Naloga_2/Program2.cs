using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Delitelji(10, 20, 6));
            Console.WriteLine(Delitelji(20, 40, 5));
        }
        public static string Delitelji(int a, int b, int k)
        {
            if (a > b) { throw new Exception("Nesmiselen interval."); }
            bool deli = true;
            string delitelji = "";
            for (int i = a; i <= b; i++) //interval [a,b]
            {
                string st = i.ToString();
                foreach (char stevka in st)//preverimo vsako števko v številu
                {
                    if (stevka != '0')
                    {
                        int stevka_int = int.Parse(stevka+"");
                        if (k % stevka_int != 0) { deli = false; break; }
                    }
                }
                if (deli) { delitelji += st + ", "; }
            }
            if (delitelji == "") { return "V intervalu [" + a + ", " + b + "] ni celih števil, v katerih vsaka neničelna števka deli " + k + "."; }
            return "Cela števila iz intervala [" + a + ", " + b + "], v katerih vsaka neničelna števka deli " + k + ", so: " + delitelji.Substring(0, delitelji.Length-2) + ".";


        }
    }
}

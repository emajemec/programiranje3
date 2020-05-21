using System;

namespace Naloga_2
{
    class Program
    {
        public static string PreštejŠtevila (int a, int n)
        {
            string nizSt = a + "0";
            if (a < 0) throw new Exception("Neustrezno število!");
            if (n <= 0) throw new Exception("Neustrezno število korakov!");
            int i = 0;
            string novoSt = "";
            while (i < n)
            {
                i++;
                int stevec = 0;
                int prejsnji = (int)Char.GetNumericValue(nizSt[0]);
                novoSt = "";
                foreach (char el in nizSt)
                {
                    int st = (int)Char.GetNumericValue(el);
                    if (st == prejsnji)
                    {
                        stevec++;
                    }
                    
                    else
                    {
                        if (stevec == 0)
                        {
                            novoSt += "1" + prejsnji;
                        }
                        else
                        {
                            string stev = "" + stevec;
                            novoSt += stev + prejsnji;
                            stevec = 0;
                        }
                    }
                    prejsnji = st;
                }
                nizSt = novoSt;
                Console.WriteLine( novoSt );
            }
            return novoSt;

        }
        static void Main(string[] args)
        {
            PreštejŠtevila(1117, 4);
        }
    }
}

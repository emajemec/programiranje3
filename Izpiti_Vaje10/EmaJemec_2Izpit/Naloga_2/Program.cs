using System;

namespace Naloga_2
{
    class Program
    {
        public static string PoisciCela(int a, int b, int k)
        {

            int m = 0;
            string rez = "Cela števila iz intervala [" + a + ", " + b + "], v katerih vsaka neničelna števka deli " + k + ", so: ";
            for (int i = a; i <= b; i++)
            {
                string stevilo = i + "";
                int n = 0;
                foreach (char znak in stevilo)
                {
                    int j = int.Parse(znak.ToString());
                    if (j == 0)
                    {
                        n++;
                        continue;
                    }
                    else if (k % j == 0)
                    {
                        n++;
                    }
                }
                if (stevilo.Length == n)
                {
                    rez += stevilo + ", ";
                    m++;
                }
            }
            if (m > 0)
            {
                rez = rez.Remove(rez.Length - 2, 2) + ".";
                return rez;
            }
            else
            {
                return ("V intervalu [" + a + ", " + b + "] ni celih števil, v katerih vsaka neničelna števka deli " + k + ".");
            }



        }
        static void Main(string[] args)
        {
            Console.Write("Vnesi spodnjo mejo intervala: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Vnesi zgornjo mejo intervala: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Vnesi celo stevilo: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(PoisciCela(a, b, k));
        }
        
    }
}

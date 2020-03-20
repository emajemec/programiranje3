using System;

namespace Prozenje_napak1
{
    class Program
    {
        public static int preberiInt(string niz)
        {
            Console.Write(niz);
            try
            {
                int st = int.Parse(Console.ReadLine());
                return st;
            }
            catch
            {
                Console.WriteLine("To ni celo število, poskusi znova.");
                return preberiInt(niz);
            }
        }
        public static int Operacije(int a, int b, string op)
        {
            string[] operatorji = { "+", "-", "*" };
            if (op == operatorji[0])
            {
                return a + b;
            }
            if (op == operatorji[1])
            {
                return a - b;
            }
            else
            {
                return a * b;
            }
                      
        }
        public static string Racunanje(int k)
        {
            string[] operatorji = { "+", "-", "*"}; // Skoraj nikoli ne bo množenja, ker je zelo majhna verjetnost da bosta izbrani dve števili manjši od 10
            for (int i = 0; i < k; i++)
            {
                Random rand = new Random();
                int a = rand.Next(101);
                int b = rand.Next(101);
                int j = rand.Next(operatorji.Length);
                string op = operatorji[j];
                if (Operacije(a, b, op) > 100)
                {
                    return Racunanje(k - i);
                }
                // to bi upoštevali, če bi želeli le realna števila
                //if (Operacije(a, b, op) < 0) 
                //{
                //    return Racunanje(k - i);
                //}
                int re = Operacije(a, b, op);
                
                int x = preberiInt(a + " " + op + " " + b + " = ");
                while (x != re) 
                {
                    Console.WriteLine("Rezultat je napačen, poskusi znova.");
                    x = preberiInt(a + " " + op + " " + b + " = ");
                }
            }
            return "Bravo!";
        }
        static void Main(string[] args)
        {
            Racunanje(10);
        }
    }
}

using System;

namespace Pi_in_Monte_Carlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Število naključnih točk: ");
            int n = int.Parse(Console.ReadLine());
            int zadetki = 0;
            
            for (int i = 0; i < n; i++)
            {
                Random rand = new Random();
                double x = rand.NextDouble();
                double y = rand.NextDouble();
                if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1)
                {
                    zadetki++;
                }
            }
            Console.WriteLine(4*(double)zadetki/n);
        }
    }
}

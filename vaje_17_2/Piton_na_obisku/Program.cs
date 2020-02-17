using System;

namespace Piton_na_obisku
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, i = 0;
            int vsota = 0;
            Console.Write("Vpiši število:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Vpiši število:");
            k = int.Parse(Console.ReadLine());
            while (i < n+1)
            {
                vsota += (int)Math.Pow(i, k);
                i++;
            }
            Console.WriteLine(vsota);
        }
    }
}

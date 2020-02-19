using System;

namespace Oddities
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int st = int.Parse(Console.ReadLine());
                if (st % 2 == 0)
                {
                    Console.WriteLine(st + " is even");
                }
                else
                {
                    Console.WriteLine(st + " is odd");
                }
            }
        }
    }
}

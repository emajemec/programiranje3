using System;

namespace P3
{
    class Program
    {
        /// <summary>
        /// Vrne večjega od obeh parametrov.
        /// </summary>
        /// <param name="a"> int poljubna vrednost </param>
        /// <param name="b"> int poljubna vrednost </param>
        /// <returns></returns>
        public static int Max(int a, int b)
        {
            if (a > b) return a;
            return b;
        }
        static void Main(string[] args)
        {
            int x = 2;
            int y = 6;
            Console.WriteLine(Max(x, y));
        }
    }
}

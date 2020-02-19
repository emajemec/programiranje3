using System;

namespace Quadrant_selection
{
    class Program
    {
        static void Main(string[] args)
        {
            int x , y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (x > 0 & y > 0)
            {
                Console.WriteLine(1);
            }
            if (x < 0 & y > 0)
            {
                Console.WriteLine(2);
            }
            if (x < 0 & y < 0)
            {
                Console.WriteLine(3);
            }
            if (x > 0 & y < 0)
            {
                Console.WriteLine(4);
            }
        }
    }
}


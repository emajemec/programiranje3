using System;

namespace Stuck_in_a_time_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int st_vrstic = int.Parse(Console.ReadLine());
            for (int i = 1; i <= st_vrstic; i++)
            {
                Console.WriteLine(i + " Abracadabra");
            }
        }
    }
}

using System;

namespace Bum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Od kod naj štejem? ");
            int zacni = int.Parse(Console.ReadLine());
            Console.Write("Do kod naj štejem? ");
            int koncaj = int.Parse(Console.ReadLine());
            for (int i = zacni; i <= koncaj; i++)
            {
                string str = "" + i;
                if (i % 3 == 0 | str.Contains("3"))
                {
                    Console.Write("Bum! ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

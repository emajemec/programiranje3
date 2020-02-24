using System;

namespace Kocka
{
    class Program
    {
        static void Main(string[] args)
        {
            int stMetov;
            Random gen = new Random();
            int[] koliko = new int[6]; // Koliko[0]...kolikokrat smo vrgli 1 piko...
            Console.Write("Koliko metov naj izvedem: ");
            stMetov = int.Parse(Console.ReadLine());
            //izvedi mete
            for (int met = 0; met < stMetov; met++)
            {
                int vrzemo = gen.Next(1, 7);
                //povečamo ustrezen števec
                koliko[vrzemo - 1]++;
            }
            //izpis
            int pike = 1;
            foreach (int el in koliko)
            {
                Console.WriteLine(pike + "smo vrgli" + el + ".krat : " + (double)el / stMetov);
                pike++;
            }
        }
    }
}

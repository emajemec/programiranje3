using System;

namespace Piece_of_cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int stranica, dolžina, širina, volumen;
            string line;
            line = Console.ReadLine();

            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            stranica = int.Parse(split[0]);
            dolžina = int.Parse(split[1]);
            širina = int.Parse(split[2]);
            if (stranica - dolžina > dolžina)
            {
                dolžina = stranica - dolžina;
            }
            if (stranica - širina > širina)
            {
                širina = stranica - širina;
            }
            Console.WriteLine(dolžina*širina*4);
        }
    }
}

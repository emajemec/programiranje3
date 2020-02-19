using System;

namespace Cold_puter_science
{
    class Program
    {
        static void Main(string[] args)
        {
            int st_dni, koliko = 0, x;
            string line;
            st_dni = int.Parse(Console.ReadLine());
            line = Console.ReadLine();
            string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            for (int i = 0; i < st_dni; i++)
            {
                x = int.Parse(split[i]);
                if (x < 0)
                {
                    koliko += 1;
                }
            }
            Console.WriteLine(koliko);
        }
    }
}

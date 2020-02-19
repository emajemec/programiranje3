using System;

namespace Pozri_nicle
{
    class Program
    {
        static void Main(string[] args)
        {
            string stevilo = Console.ReadLine();
            string brez_nic = stevilo.Replace("0", "");
            Console.WriteLine(brez_nic);
        }
    }
}

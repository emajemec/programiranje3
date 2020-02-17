using System;

namespace Boris
{
    class Program
    {
        static void Main(string[] args)
        {
            double masaA, masaB, staraA;
            int korak = 0;
            Console.Write("Masa v regiji A:");
            masaA = double.Parse(Console.ReadLine());
            Console.Write("Masa v regiji B:");
            masaB = double.Parse(Console.ReadLine());
            while (masaA + masaB > 0.001)
            {
                Console.WriteLine(korak + ", " + masaA + ", " + masaB);
                staraA = masaA;
                masaA = masaA * 0.12 + masaB * 0.22;
                masaB = masaB * 0.12 + staraA * 0.22;
                korak++;
                
            }
            
        }
    }
}

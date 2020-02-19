using System;

namespace Obrni_stevilo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi stevilo: ");
            string st = Console.ReadLine();
            char[] charArray = st.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
        }
    }
}

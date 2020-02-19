using System;

namespace Palindromska_stevila
{
    class Program
    {
        static void Main(string[] args)
        {
            int stevec = 0;
            Console.Write("Vnesi spodnjo mejo: ");
            int zacetek = int.Parse(Console.ReadLine());
            Console.Write("Vnesi zgornjo mejo: ");
            int konec = int.Parse(Console.ReadLine());
            string stevila = "Med " + zacetek + " in " + konec + " imamo naslednja palindromska števila: ";
            for (int i = zacetek; i <= konec; i++)
            {
                string st = i+"";
                char[] stevilo = st.ToCharArray();
                Array.Reverse(stevilo);
                if (String.Equals(st, stevilo))
                {
                    stevec++;
                    stevila += st + ", ";
                }
            }
            if (stevec == 0)
            {
                Console.WriteLine("Med " + zacetek + " in " + konec + " ni palindromskih števil.");
            }
            else
            {
                Console.WriteLine(stevila);
            }
        }
    }
}

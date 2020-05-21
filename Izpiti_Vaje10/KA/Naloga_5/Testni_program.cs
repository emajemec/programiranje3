using System;

namespace Naloga_5
{
    class Testni_program
    {
        static void Main(string[] args)
        {
            KompleksnoStevilo z1 = new KompleksnoStevilo (3, -1);
            KompleksnoStevilo z2 = new KompleksnoStevilo (2, 6);
            KompleksnoStevilo z3 = new KompleksnoStevilo (5, 4);
            KompleksnoStevilo z4 = new KompleksnoStevilo (0, 1);

            Console.WriteLine (z1 + z2);
            Console.WriteLine (z3.R);
            Console.WriteLine (z1.Arg);
            Console.WriteLine (z4);
        }
    }
}

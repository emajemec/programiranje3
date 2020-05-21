using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_5
{
    class Program5
    {
        static void Main(string[] args)
        {
            Polonica p1 = new Polonica(100, 5);
            Polonica p2 = new Polonica(15, 7);
            Polonica p3 = new Polonica(200, 2);
            Polonica[] tabp = new Polonica[] { p1, p2, p3 };
            Console.WriteLine(p1.ToString());
            Console.WriteLine(Polonica.steviloPik(tabp));
            Polonica[] tab_zm = p3 * 5;
            foreach (Polonica p in tab_zm)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}

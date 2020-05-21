using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga_1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int[] t1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] t2 = new string[] { "a", "b", "c" };
            Console.WriteLine(VrniNtiElement(t1, -3));
            Console.WriteLine(VrniNtiElement(t1, 2));
            Console.WriteLine(VrniNtiElement(t2, 2));
            Console.WriteLine(VrniNtiElement(t2, 7));

        }
        public static T VrniNtiElement<T>(T[] tabela, int n)
        {
            int n_abs = Math.Abs(n);
            if (n_abs > tabela.Length) { throw new Exception("Neveljaven element"); }
            else if (n >= 0) { return tabela[n - 1]; }
            return tabela[tabela.Length - n_abs];
        }
    }
}

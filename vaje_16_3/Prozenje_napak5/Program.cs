using System;
using System.Linq;

namespace Prozenje_napak5
{
    class Program
    {
        public static int preberiInt(string niz)
        {
            Console.Write(niz);
            try
            {
                int st = int.Parse(Console.ReadLine());
                return st;
            }
            catch 
            {
                Console.WriteLine("To ni celo število, poskusi znova.");
                return preberiInt(niz);
            }
        }

        public static string preberiOp(string niz)
        {
            Console.Write(niz);
            string[] operatorji = { "+", "-", "/", "*" };
            string op = Console.ReadLine();
            try
            {
                operatorji.Contains(op);
                return op;
            }
            catch
            {
                Console.WriteLine("To ni operator.");
                return preberiOp(niz);
            }
            
           
        }

       
        public static int Operacije(int a, int b, string op)
        {
            string[] operatorji = { "+", "-", "/", "*"};
           
            if (op == operatorji[0])
            {
                return a + b;
            }
            else if (op == operatorji[1])
            {
                return a - b; // Ne moramo odšteti negativnega števila
            }
            else if (op == operatorji[2])
            {
                if (b != 0)
                {
                    return a / b;
                } 
                throw new Exception ("Deljenje z 0!");
            }
            else if (op == operatorji[3])
            {
                return a * b;
            }
            throw new Exception("To ni operator!");
            
        }

        static void Main(string[] args)
        {
            int a = preberiInt("Vpiši prvo število: ");
            int b = preberiInt("Vpiši drugo število: ");
            string op = preberiOp("Vpiši operator: ");
            int rez = Operacije(a, b, op);

            Console.WriteLine(a + " " + op + " " + b + " = " + rez);
        }
    }
}

using System;

namespace Dopolni_program1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Program izpiše vrednost izraza (a+b)/c, za cela števila a,b,c");

            try
            {
                Console.Write("Vnesi a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Vnesi b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Vnesi c: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("(a+b)/c = " + ((a + b) / c));
            }
            catch (FormatException)
            {
                Console.WriteLine("Uporabiš lahko samo cela števila!");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Napaka! Deljenje z 0");

            }
            catch (Exception e)
            {
                Console.WriteLine("Nekaj je šlo narobe:");
                Console.WriteLine(e.ToString());

            }
        }
    }
    
}

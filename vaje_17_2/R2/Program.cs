using System;

namespace R2
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1 =0, r = 0;
            int r2;
            string line;
            line = Console.ReadLine();
          
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                r1 = int.Parse(split[0]);
                r = int.Parse(split[1]);
      
            r2 = 2 * r - r1;
            Console.WriteLine(r2);
        }
    }
}

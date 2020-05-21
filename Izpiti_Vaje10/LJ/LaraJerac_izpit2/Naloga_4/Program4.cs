using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Naloga_4
{
    class Program4
    {
        static void Main(string[] args)
        {
            BrezOklepajev("Test_izp2.txt", "Rez.txt");
        }
        public static void BrezOklepajev(string imeVhod, string imeIzhod)
        {
            if (!File.Exists(imeVhod)) { throw new Exception("Datoteka ne obstaja."); }
            StreamReader beri = File.OpenText(imeVhod);
            StreamWriter pisi = File.CreateText(imeIzhod);
            string vr = "";
            while (true)
            {
                vr = beri.ReadLine();
                if (vr == null) { break; }
                pisi.WriteLine(Brezoklepajev(vr));
            }
            pisi.Close();
            beri.Close();
        }
        public static string Brezoklepajev(string vrstica)
        {
            bool oklepaj = false;
            string rez = "";
            for (int i = 0; i < vrstica.Length; i++)
            {
                if (vrstica[i] == ')' && !oklepaj) { return "NAPAKA"; }
                else if (vrstica[i] == '(')
                {
                    oklepaj = true;
                    while (vrstica[i] != ')')
                    {
                        i++;
                        if (i >= vrstica.Length) { return "NAPAKA"; }
                        else if (vrstica[i] == ')') { i++; break; }
                    }
                }
                if (i >= vrstica.Length) { break; }
                rez += vrstica[i];
            }
            return rez;
        }
    }
}

       
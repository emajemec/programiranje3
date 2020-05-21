using System;

namespace Naloga_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[] {3, 2, 5};
            IzpisTabele (tab);
            PovecanaTabela (ref tab);
            IzpisTabele (tab);
        }

        /// <summary>
        /// Metoda vrne novo tabelo števil,
        /// v kateri se i-ti element vhodne tabele pojavi i-krat
        /// </summary>
        /// <param name="tab">vhodna tabela</param>
        public static void PovecanaTabela(ref int[] tab)
        {
            string povecanNiz = ""; //ustvarim prazen niz, ki se bo spreminjal
            for (int i = 1; i < tab.Length; i++)
            {
                int element = tab[i];
                string niz = tab[i].ToString (); //niz spremenim v string
                niz = niz.Replace ("tab[i]", "tab[i]*i"); //niz spremenim
                if (niz != "")
                {
                    povecanNiz += niz + " ";
                }
            }
            string[] tabNizov = povecanNiz.Split (" ");
            int[] tabSt = new int[tabNizov.Length - 1];
            for(int i = 0; i < tabNizov.Length - 1; i++)
            {
                tabSt[i] = int.Parse (tabNizov[i]);
            }

            tab = tabSt;
                
        }

      
        public static void IzpisTabele<T>(T[] tab)
        {
            string izpis = "";
            foreach (T el in tab)
            {
                izpis += el + ", ";
            }
            izpis = izpis.Remove (izpis.Length - 2);
            System.Console.WriteLine (izpis);
        }
    }
}

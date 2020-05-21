using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Nobel_lepse
{
    class Nobel_lepse
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> prevod = new Dictionary<string, string>()
            {
                {"Chemistry", "kemija"},
                {"Peace", "mir"},
                {"Medicine", "medicina"}
            };
            String povezovalniNiz = "Server= baza.fmf.uni-lj.si; User Id= student11; Password= student; Database= nobel2012;";
            NpgsqlConnection povezava = new NpgsqlConnection(povezovalniNiz);
            String sqlUkaz = "Select * FROM Nobel";
            NpgsqlCommand ukaz = new NpgsqlCommand(sqlUkaz, povezava);

            povezava.Open();
            NpgsqlDataReader izvedba = ukaz.ExecuteReader();
            int koliko = 1;
            while (izvedba.Read())
            {
                string področje = izvedba["subject"].ToString();
                int leto = izvedba.GetInt32(0);
                string dobitnik = izvedba.GetString(2);
                string podr = področje;
                if (prevod.ContainsKey(področje)) podr = prevod[področje];
                Console.WriteLine(String.Format("Leta {0} je nagrado za področje {1} dobil {2}.", leto, podr, dobitnik));
                koliko = koliko % 10 + 1;
                if (koliko == 1) Console.ReadKey();
            }
        }
    }
}

using System;
using Npgsql;
using System.Data;

namespace Baze_osnove_Nobel_PG
{
    class Nobel_osnova
    {
        static void Main(string[] args)
        {
            // povezovalni niz 
            string povNiz = "Server= baza.fmf.uni-lj.si; User Id= student11; Password= student; Database= nobel2012;";
            // Povezava s pomočjo Npgsql 
            NpgsqlConnection pov = new NpgsqlConnection(povNiz);
            pov.Open();
            // ustrezen ukaz v SQL
            string sql = "SELECT * FROM nobel WHERE yr >= 2007";
            NpgsqlCommand ukaz = new NpgsqlCommand();
            ukaz.Connection = pov;
            ukaz.CommandType = CommandType.Text;
            ukaz.CommandText = sql;
            NpgsqlDataReader rez = ukaz.ExecuteReader();
            while (rez.Read())
            {
                for (int i = 0; i < rez.VisibleFieldCount; i++)
                {
                    string izp = rez[i].ToString();
                    Console.Write(izp + " : ");
                }
                Console.WriteLine();
            }

            pov.Close();
            Console.ReadLine();
        }
    }
}


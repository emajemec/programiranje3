using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Vmesnik
{
    public partial class Nobel : Form
    {
        Dictionary<string, string> prevodSlo = new Dictionary<string, string>()
            {
                {"kemija", "Chemistry"},
                {"mir", "Peace"},
                {"medicina", "Medicine"},
                {"literatura", "Literature"},
                {"fizika", "Physics"},
                {"ekonomija", "Economics"},
            };
        Dictionary<string, string> prevodAng = new Dictionary<string, string>()
            {
                {"Chemistry", "kemija"},
                {"Peace", "mir"},
                {"Medicine", "medicina" },
                {"Literature", "literatura"},
                {"Physics", "fizika"},
                {"Economics", "ekonomija" },
            };
        String povezovalniNiz;
        NpgsqlConnection povezava;
        String[] podrocja;
        int[] leta;
        public Nobel()
        {
            InitializeComponent();
            povezovalniNiz = "Server= baza.fmf.uni-lj.si; User Id= student11; Password= student; Database= nobel2012;";
            povezava = new NpgsqlConnection(povezovalniNiz);
            NpgsqlCommand ukaz = new NpgsqlCommand();
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string zacetek = OdLeta.Text; //leto od
            string konec = DoLeta.Text; //leto do
            int odLeta;
            int doLeta;
            try
            {
                odLeta = Int32.Parse(zacetek);
                doLeta = Int32.Parse(konec);
            }
            catch 
            {
                MessageBox.Show("Vnesite letnice.");
                return;
            }
            if (doLeta < odLeta) throw new Exception("Neveljavno obdobje!");

            List<string> izbrani = new List<string>(); 
            foreach (object tema in checkedListBox1.CheckedItems)
            { 
                izbrani.Add(prevodSlo[tema.ToString()]); 
            }
            if (izbrani.Count == 0) //ce podrocja ne obkljukamo, se izvede napaka
            {
                MessageBox.Show("Izberite vsaj eno ali več področij.");
                return;
            }
            string podrocja = string.Join("','", izbrani);
            podrocja = "'" + podrocja + "'";
            
            String sqlUkaz = string.Format("Select * FROM Nobel WHERE yr BETWEEN {1} AND {0} AND subject IN ( {2} )", konec, zacetek, podrocja); //iz baze
            NpgsqlCommand ukaz = new NpgsqlCommand(sqlUkaz, povezava);
            povezava.Open();
            NpgsqlDataReader izvedba = ukaz.ExecuteReader();
            listBox1.Items.Clear();
            while (izvedba.Read())
            {
                string področje = izvedba["subject"].ToString(); //dolocimo podrocje
                int leto = izvedba.GetInt32(0); //dolocimo leto
                string dobitnik = izvedba.GetString(2); //dolocimo nagrajenca
                listBox1.Items.Add(String.Format("Leta {0} je nagrado za področje {1} dobil {2}.", leto, prevodAng[področje], dobitnik));
            }
            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add(String.Format("Med letoma {0} in {1} ni podatkov za izbrana področja.", zacetek, konec));
            }
            povezava.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Nobel_Load(object sender, EventArgs e)
        {

        }
    }
    
}

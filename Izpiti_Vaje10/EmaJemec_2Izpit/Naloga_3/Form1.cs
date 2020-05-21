using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naloga_3
{
    public partial class Form1 : Form
    {
       
        private short ure, minute, sekunde;
        private void Čas()
        {
            Ura.Text = ure.ToString("00");
            Minuta.Text = minute.ToString("00");
            Sekunda.Text = sekunde.ToString("00");
        }
        private void IzSekund()
        {
            if(sekunde == 59)
            {
                sekunde = 0;
                IzMinut();
            }
            else
            {
                sekunde++;
            }
        }
        private void IzMinut()
        {
            if (minute == 59)
            {
                minute = 0;
                IzUr();
            }
            else
            {
                minute++;
            }
        }
        private void IzUr()
        {
            ure++;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Minuta_Click(object sender, EventArgs e)
        {

        }

        private void Ura_Click(object sender, EventArgs e)
        {

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            IzSekund();
            Čas();
        }

        
    }
}

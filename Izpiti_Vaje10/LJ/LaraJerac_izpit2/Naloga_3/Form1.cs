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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "USTAVI") 
            {
                button1.Text = "ZAŽENI";
                timer1.Stop();
            }
            else 
            { 
                button1.Text = "USTAVI";
                timer1.Start();
            }
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = timer1.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

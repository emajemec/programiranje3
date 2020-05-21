using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semafor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Gumb1(object sender, EventArgs e)
        {
            this.barve.BackColor = Color.Red;
        }

        private void Gumb2(object sender, EventArgs e)
        {
            this.barve.BackColor = Color.Yellow;
        }

        private void Gumb3(object sender, EventArgs e)
        {
            this.barve.BackColor = Color.Green;
        }

        private void barve_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

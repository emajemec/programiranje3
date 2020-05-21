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
        public bool klikgumb1 = false;
        public int stej = 0;
        public int pravilni = 0;
        private void Gumb1_Click(object sender, EventArgs e)
        {
            klikgumb1 = true;          
        }
        private void Gumb2_Click(object sender, EventArgs e)
        {
            klikgumb1 = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            stej++;
            string[] b = { "rdeča", "modra", "zelena" };
            Color[] B = { Color.Red, Color.Blue, Color.Green };
            Random rand = new Random();
            int i = rand.Next(b.Length);
            int j = rand.Next(B.Length);
            this.label2.ForeColor = B[j];
            this.label2.Text = b[i];
            if (i != j)
            {
                if (klikgumb1)
                {
                    pravilni++;
                }
                this.stevec.Text = (pravilni * 100) / stej + "%";
            }
            else if (i == j)
            {
                if (!klikgumb1)
                {
                    pravilni++;
                }
                this.stevec.Text = (pravilni * 100) / stej + "%";
            }
         }
    }
}

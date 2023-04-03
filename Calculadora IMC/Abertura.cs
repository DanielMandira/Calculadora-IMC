using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_IMC
{
    public partial class Abertura : Form
    {
        public Abertura()
        {
            InitializeComponent();
        }
        int cont;
        private void timer1_Tick(object sender, EventArgs e)
        {
            cont++;
            if (cont < 2000)
            {
                timer1.Enabled = false;
                this.Hide();
                calcIMC abr = new calcIMC();
                abr.Show();
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

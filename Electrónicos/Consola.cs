using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrónicos
{
    public partial class Consola : Form
    {
        public Consola()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtMostrarDatos.Text = Abis.variableConsola;
        }

        private void Consola_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Electrónicos
{
    public partial class Consola : Form
    {
        public Consola()
        {
            InitializeComponent();
        }

        public Abis frm = new Abis();
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtMostrarDatos.Text = Abis.variableConsola;
        }

        private void Consola_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void txtEnviarDatos_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEnviarDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            var frm = new Abis();
           // frm.EsconderPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abis frm = new Abis();
            //var frm = new Abis();
            frm.Show();
            //frm.button1_Click(this,null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Abis frm = new Abis(this);
            Presentacion.fh.Show();
            frm.button1_Click(this, null);
        }
    }
}

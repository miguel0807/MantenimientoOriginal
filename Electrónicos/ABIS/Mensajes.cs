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
    public partial class Mensajes : Form
    {
        private string mensaje;
        public Mensajes(string mensaje)
        {
            this.mensaje = mensaje;            
            InitializeComponent();
        }

        

        private void btnConsola_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mensajes_Load(object sender, EventArgs e)
        {
            label1.Text = mensaje;
            //label1.Text = Abis.variableMensaje;
            //gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_SLIDE;
            gunaAnimateWindow1.Start();
            
        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Electrónicos
{
    public partial class Presion_1 : Form
    {
        private string serie;

        public Presion_1(string serie)
        {
            this.serie = serie;
            InitializeComponent();
            
        }
        
        Conexion cn = new Conexion();

        Conexion cn2 = new Conexion(2);

        private void Presion_1_Load(object sender, EventArgs e)
        {
            Usuarios();
        }

        private void Usuarios()
        {
            cn2.abrir();

            SqlCommand cmd = new SqlCommand("select  CONCAT_WS(' ' ,FirstName,LastName) as [Nombre Completo]  from Users where CONVERT(char,Position) = 'Electro-Mechanical Assembler' ", cn2.conectarBD);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            
            cboUsuario.DataSource = dt;
            cboUsuario.ValueMember = dt.Columns[0].ToString();
            cboUsuario.SelectedIndex = -1;
            cn2.cerrar();
        }


        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            txtHoraIngreso.Text = DateTime.Now.ToString("HH:mm:ss");
           
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            txtHoraFinal.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            txtTemperaturaHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

       
    }
}

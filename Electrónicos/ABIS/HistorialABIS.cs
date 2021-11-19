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
    public partial class HistorialABIS : Form
    {
        public HistorialABIS()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();

        private void HistorialABIS_Load(object sender, EventArgs e)
        {
            cn.abrir();
           
            SqlCommand cmd = new SqlCommand("select top " + txtMostrar.Text + " * from CSM  ", cn.conectarBD);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].Visible = false;
            txtMostrar.Visible = true;
            label3.Visible = true;
            dataGridView1.Visible = true;
            lblResgistros.Visible = true;

            lblResgistros.Text = "Cantidad de registros: " + dataGridView1.Rows.Count.ToString();
            cn.cerrar();

            if (dataGridView1.Rows.Count == 0)
            {
               
            }
        }
    }
}

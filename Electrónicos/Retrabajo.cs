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
using System.IO.Ports;

namespace Electrónicos
{
    public partial class Retrabajo : Form
    {
        public Retrabajo()
        {
            InitializeComponent();
        }
        Conexion cn = new Conexion();
        private void Retrabajo_Load(object sender, EventArgs e)
        {
            cn.abrir();
            //SqlCommand cmd = new SqlCommand("select top " + txtMostrar.Text + " * from CSM where [Error Humano] = 0 and [Hora ingreso 2] is null and [Fecha Final 2] is null", cn.conectarBD);
            SqlCommand cmd = new SqlCommand("select top " + txtMostrar.Text + " * from CSM ", cn.conectarBD);
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
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("agregar").Name = "AGREGAR";
                menu.Items.Add("eliminar").Name = "Eliminar";
                menu.Items.Add("detalles").Name = "DETALLES";


                //Obtienes las coordenadas de la celda seleccionada. 
                Rectangle coordenada = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                int anchoCelda = coordenada.Location.X; //Ancho de la localizacion de la celda
                int altoCelda = coordenada.Location.Y;  //Alto de la localizacion de la celda

                //Y para mostrar el menú lo haces de esta forma:  
                int X = anchoCelda + dataGridView1.Location.X;
                int Y = altoCelda + dataGridView1.Location.Y - 400;

                //menu.Show(dataGridView1, new Point(X, altoCelda));
                derecho.Show(dataGridView1, new Point(X, altoCelda));
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == true)
            {
                dataGridView1.Visible = false;
                txtMostrar.Visible = false;
                label3.Visible = false;
                lblResgistros.Visible = false;
            }
            else
            {
                cn.abrir();
                //SqlCommand cmd = new SqlCommand("select top " + txtMostrar.Text + " * from CSM where [Error Humano] = 0 and [Hora ingreso 2] is null and [Fecha Final 2] is null", cn.conectarBD);
                SqlCommand cmd = new SqlCommand("select top " + txtMostrar.Text + " * from CSM ", cn.conectarBD);
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
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Abis.ModoRetrabajo = true;
        }
    }
}

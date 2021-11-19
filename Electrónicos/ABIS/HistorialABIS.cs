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
        private string serie;
        private void HistorialABIS_Load(object sender, EventArgs e)
        {
            cn.abrir();
           
            SqlCommand cmd = new SqlCommand("select top " + txtMostrar.Text + " [Número de parte],[Número de serie],Descripción,[Usuario Calibración],Estado  from CSM  ", cn.conectarBD);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            //dataGridView1.Columns[0].Visible = false;
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {



                if (e.Button == MouseButtons.Right)
                {
                    //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    serie = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                   
                    ContextMenuStrip menu = new ContextMenuStrip();
                  

                    menu.Items.Add("Calibración #1", default(Image), (snd, evt) => { menuCalibracion1(); });
                    menu.Items[0].BackColor = Color.FromKnownColor(KnownColor.LightGreen);
                    
                    menu.Items.Add("Calibración #2", default(Image), (snd, evt) => { MessageBox.Show("Hice click en Nueva Venta!"); });
                    menu.Items.Add("Presión #1", default(Image), (snd, evt) => { MessageBox.Show("Hice click en Nueva Venta!"); });
                    menu.Items.Add("Presión #2", default(Image), (snd, evt) => { MessageBox.Show("Hice click en Nueva Venta!"); });

                    //Obtienes las coordenadas de la celda seleccionada. 
                    Rectangle coordenada = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                    int anchoCelda = coordenada.Location.X; //Ancho de la localizacion de la celda
                    int altoCelda = coordenada.Location.Y;  //Alto de la localizacion de la celda

                    //Y para mostrar el menú lo haces de esta forma:  
                    int X = anchoCelda + dataGridView1.Location.X;
                    int Y = altoCelda + dataGridView1.Location.Y - 40;

                    menu.Show(dataGridView1, new Point(X, Y));
                }


            }
            catch 
            { }

        }

        private void menuCalibracion1()
        {
           
            Form frm = new Calibracion1(serie);
            frm.ShowDialog();
        }


    }
}

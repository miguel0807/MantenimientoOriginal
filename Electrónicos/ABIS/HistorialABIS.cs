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
                   
                    serie = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                   
                    ContextMenuStrip menu = new ContextMenuStrip();

                    
                    menu.Items.Add("Calibración #1", default(Image), (snd, evt) => { menuCalibracion1(); });

                    if (consultar() == 0)
                    {
                       
                    }

                    else if (consultar() == 1)
                    {
                        menu.Items[0].BackColor = Color.FromKnownColor(KnownColor.LightGreen);
                    }

                    else if (consultar() == 2)
                    {
                        menu.Items[0].BackColor = Color.FromKnownColor(KnownColor.Red);

                    }
                    
                    
                    menu.Items.Add("Calibración #2", default(Image), (snd, evt) => { menuCalibracion2(); });

                    if (consultar2() == 0)
                    {

                    }

                    else if (consultar2() == 1)
                    {
                        menu.Items[1].BackColor = Color.FromKnownColor(KnownColor.LightGreen);
                    }

                    else if (consultar2() == 2)
                    {
                        menu.Items[1].BackColor = Color.FromKnownColor(KnownColor.Red);

                    }

                    if (verificarEstado() == 1)
                    {
                        menu.Items.Add("Presión #1", default(Image), (snd, evt) => { menuPresion1(); });
                        if (consultar3() == 0)
                        {

                        }
                        else if (consultar3() == 1)
                        {
                            menu.Items[2].BackColor = Color.FromKnownColor(KnownColor.Red);
                        }

                        else if (consultar3() == 2)
                        {
                            menu.Items[2].BackColor = Color.FromKnownColor(KnownColor.LightGreen);
                        }

                        menu.Items.Add("Presión #2", default(Image), (snd, evt) => { MessageBox.Show("Presión 2"); });

                    }

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
            {
                
            }

        }

        

        private void menuCalibracion1()
        {
           
            Form frm = new Calibracion1(serie);
            frm.ShowDialog();
        }

        private void menuCalibracion2()
        {

            Form frm = new Calibracion2(serie);
            frm.ShowDialog();
        }

        private void menuPresion1()
        {
            Form frm = new Presion_1(serie);
            frm.ShowDialog();
            //MessageBox.Show("Cerrado");
        }

        private int consultar()
        {
            int Estado = 0;
            cn.abrir();


            SqlCommand cmd = new SqlCommand("select [Fecha Final 1] from CSM where convert(char,[Número de serie]) = @serie", cn.conectarBD);

            cmd.Parameters.AddWithValue("@serie", serie);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (reader[0] != DBNull.Value)
                {
                    Estado = 1;
                }
                else
                {
                    Estado = 2;
                }

                cn.cerrar();
            }

            cn.cerrar();
            return Estado;
        }

        private int consultar2()
        {
            int Estado = 0;
            cn.abrir();


            SqlCommand cmd = new SqlCommand("select [Fecha Final 2] from CSM where convert(char,[Número de serie]) = @serie", cn.conectarBD);

            cmd.Parameters.AddWithValue("@serie", serie);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (reader[0] == DBNull.Value)
                {
                    Estado = 0;
                }
                else if ( reader[0].ToString() == "")
                {
                    Estado = 2;
                }

                else
                {
                    Estado = 1;
                }

                cn.cerrar();
            }

            return Estado;
        }

        private int consultar3()
        {
            int Estado = 0;
            cn.abrir();


            SqlCommand cmd = new SqlCommand("select*from [CSM Presión] where convert(char,[Número de serie]) =@serie", cn.conectarBD);

            cmd.Parameters.AddWithValue("@serie", serie);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int presion1 ,presion2, rango;
                presion1 = (int)(reader[9]);
                presion2 = (int)(reader[10]);
                rango = presion1 - presion2;

                if (rango == 0)
                {
                    Estado = 0;
                }
                else if (rango >= -100 && rango <= 100)
                {
                    Estado = 2;
                   
                }
                else if (rango > 100 || rango < -100)
                {
                    Estado = 1;
                }                                              


            }
            cn.cerrar();
            return Estado;
        }

        private int verificarEstado()
        {
            int Estado = 0;
            cn.abrir();


            SqlCommand cmd = new SqlCommand("select Estado from CSM where convert(char,[Número de serie]) =@serie", cn.conectarBD);

            cmd.Parameters.AddWithValue("@serie", serie);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
              if (reader[0].ToString() == "Pendiente Presión")
                {
                    Estado = 1;
                }

              else
                {
                    Estado = 0;
                }


            }
            cn.cerrar();
            return Estado;
            
            
        }
    }
}

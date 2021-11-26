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
using Electrónicos.ABIS;

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
            Inicio();
        }

        private void Inicio()
        {
            cn.abrir();
            //SqlCommand cmd = new SqlCommand("select top " + txtMostrar.Text + " [Número de parte],[Número de serie],Descripción,[Usuario Calibración],Estado  from CSM  ", cn.conectarBD);
            SqlCommand cmd = new SqlCommand("select top " + txtMostrar.Text + " [Número de parte],[Número de serie],Descripción,[Usuario Calibración],Estado ,id  from CSM order by id desc  ", cn.conectarBD);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Columns[5].Visible = false;
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

        private void busqueda()
        {
            cn.abrir();
            //SqlCommand cmd = new SqlCommand("select top " + txtMostrar.Text + " [Número de parte],[Número de serie],Descripción,[Usuario Calibración],Estado  from CSM  where convert(char,[Número de serie]) LIKE @serie + '%'", cn.conectarBD);
            SqlCommand cmd = new SqlCommand("select top " + txtMostrar.Text + " [Número de parte],[Número de serie],Descripción,[Usuario Calibración],Estado,id  from CSM  where convert(char,[Número de serie]) LIKE @serie + '%' order by id desc", cn.conectarBD);
            cmd.Parameters.AddWithValue("@serie", txtBuscar.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Columns[5].Visible = false;
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

                    menu.Items.Add("Mediciones de Voltaje", default(Image), (snd, evt) => { menuVoltaje(); });
                    menu.Items[0].BackColor = Color.FromKnownColor(KnownColor.LightBlue);

                    menu.Items.Add("Calibración #1", default(Image), (snd, evt) => { menuCalibracion1(); });

                    if (consultar() == 0)
                    {
                       
                    }

                    else if (consultar() == 1)
                    {
                        menu.Items[1].BackColor = Color.FromKnownColor(KnownColor.LightGreen);
                    }

                    else if (consultar() == 2)
                    {
                        menu.Items[1].BackColor = Color.FromKnownColor(KnownColor.Red);

                    }
                    
                    
                    menu.Items.Add("Calibración #2", default(Image), (snd, evt) => { menuCalibracion2(); });

                    if (consultar2() == 0)
                    {

                    }

                    else if (consultar2() == 1)
                    {
                        menu.Items[2].BackColor = Color.FromKnownColor(KnownColor.LightGreen);
                    }

                    else if (consultar2() == 2)
                    {
                        menu.Items[2].BackColor = Color.FromKnownColor(KnownColor.Red);

                    }

                    if (verificarEstado() == 1)
                    {
                        menu.Items.Add("Presión #1", default(Image), (snd, evt) => { menuPresion1(); });
                        if (consultar3() == 0)
                        {

                        }
                        else if (consultar3() == 1)
                        {
                            menu.Items[3].BackColor = Color.FromKnownColor(KnownColor.Red);
                        }

                        else if (consultar3() == 2)
                        {
                            menu.Items[3].BackColor = Color.FromKnownColor(KnownColor.LightGreen);
                        }

                        menu.Items.Add("Presión #2", default(Image), (snd, evt) => { menuPresion2(); });

                        if (consultar4() == 0)
                        {

                        }
                        else if (consultar4() == 1)
                        {
                            menu.Items[4].BackColor = Color.FromKnownColor(KnownColor.Red);
                        }

                        else if (consultar4() == 2)
                        {
                            menu.Items[4].BackColor = Color.FromKnownColor(KnownColor.LightGreen);
                        }

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


        private void menuVoltaje()
        {

            Form frm = new Voltaje(serie);
            frm.ShowDialog();
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
            Completado();
            Inicio();
            //MessageBox.Show("Cerrado");
        }

        private void menuPresion2()
        {
            Form frm = new Presion_2(serie);
            frm.ShowDialog();
            Completado();
            Inicio();
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

               
            }
            cn.cerrar();
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
                presion1 = 0;
                presion2 = 0;

                if (reader[9] != DBNull.Value)
                {
                    presion1 = (int)reader[9];
                }
                
                if (reader[10] != DBNull.Value)
                {
                    presion2 = (int)reader[10];
                    
                }

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

        private int consultar4()
        {
            int Estado = 0;
            cn.abrir();


            SqlCommand cmd = new SqlCommand("select*from [CSM Presión] where convert(char,[Número de serie]) =@serie", cn.conectarBD);

            cmd.Parameters.AddWithValue("@serie", serie);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int presion1, presion2, rango;
                presion1 = 0;
                presion2 = 0;

                if (reader[18] != DBNull.Value)
                {
                    presion1 = (int)reader[18];
                }

                if (reader[19] != DBNull.Value)
                {
                    presion2 = (int)reader[19];

                }

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

        private void Completado()
        {

           

            if (verificarEstado() == 1)
            {
                if (consultar3() == 2 || consultar4() == 2)
                {


                    //Actualizar los datos finales de la calibración del CSM
                    cn.abrir();
                    SqlCommand cmd = new SqlCommand("update CSM set Estado = @Estado   where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                    cmd.Parameters.AddWithValue("@NumeroSerie", serie);
                    
                   
                    cmd.Parameters.AddWithValue("@Estado", "Completado");

                    cmd.ExecuteNonQuery();
                    
                    cn.cerrar();


                }

                else if (consultar3() == 1 || consultar4() == 1)
                {
                    //Actualizar los datos finales de la calibración del CSM
                    cn.abrir();
                    SqlCommand cmd = new SqlCommand("update CSM set Estado = @Estado   where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                    cmd.Parameters.AddWithValue("@NumeroSerie", serie);



                    cmd.Parameters.AddWithValue("@Estado", "Pendiente Presión");
                    cmd.ExecuteNonQuery();

                    cn.cerrar();
                }
            }
                
        }

        //Solo si el estado es "pendiente presion" procede a crear las opciones de presion 1 y presion 2
        private int verificarEstado()
        {
            int Estado = 0;
            cn.abrir();


            SqlCommand cmd = new SqlCommand("select Estado from CSM where convert(char,[Número de serie]) =@serie", cn.conectarBD);

            cmd.Parameters.AddWithValue("@serie", serie);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
              if (reader[0].ToString() == "Pendiente Presión" || reader[0].ToString() == "Completado")
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

      

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            busqueda();
        }
    }
}

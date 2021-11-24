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
            CargarInformacion();
           
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
            txtHoraInicial.Text = DateTime.Now.ToString("HH:mm:ss");
        }

       private void CargarInformacion()
        {
            cn.abrir();
            SqlCommand cmd = new SqlCommand("select*from [CSM Presión] where convert(char,[Número de serie]) = @serie", cn.conectarBD);

            cmd.Parameters.AddWithValue("@serie", serie);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {/*
                if (reader[0] != DBNull.Value)
                {
                    txtFechaIngreso.Text = Convert.ToString(Convert.ToDateTime(reader[0]).ToString("yyyy/MM/d"));
                }
                else
                {
                    txtFechaIngreso.Text = Convert.ToString(reader[4]);
                }*/
                
                
                cboUsuario.Text = Convert.ToString(reader[20]);
                if (reader[2] != DBNull.Value)
                {
                    txtFechaIngreso.Value = (DateTime)reader[2];

                }

                if (reader[3] != DBNull.Value)
                {
                    txtHoraIngreso.Text = Convert.ToString(reader[3]);
                }
                    

                if (reader[7] != DBNull.Value)
                {
                    txtTemperaturaInicial.Value = Convert.ToInt32(reader[7]);
                }

                if (reader[5] != DBNull.Value)
                {
                    txtHoraInicial.Text = Convert.ToString(reader[5]);
                }
                

                if (reader[9] != DBNull.Value)
                {
                    txtPresion25.Value = Convert.ToInt32(reader[9]);
                }

                if (reader[10] != DBNull.Value)
                {
                    txtPresion1.Value = Convert.ToInt32(reader[10]);
                }

                if (reader[4] != DBNull.Value)
                {
                    txtFechaFinal.Value = (DateTime)reader[4];
                }

                if (reader[6] != DBNull.Value) 
                {
                    txtHoraFinal.Text = Convert.ToString(reader[6]);
                }
                    


                cn.cerrar();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CargarInformacion();
        }

       
    }
}

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

namespace Electrónicos.ABIS
{
    public partial class Presion_2 : Form
    {
        private string serie;
        public Presion_2(string serie)
        {
            this.serie = serie;
            InitializeComponent();
        }

        Conexion cn = new Conexion();

        Conexion cn2 = new Conexion(2);

        private void Presion_2_Load(object sender, EventArgs e)
        {
            Usuarios();
            CargarInformacion();
            calcularRango();
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


                cboUsuario.Text = Convert.ToString(reader[21]);
                if (reader[11] != DBNull.Value)
                {
                    txtFechaIngreso.Value = (DateTime)reader[11];

                }

                if (reader[12] != DBNull.Value)
                {
                    txtHoraIngreso.Text = Convert.ToString(reader[12]);
                }


                if (reader[16] != DBNull.Value)
                {
                    txtTemperaturaInicial.Value = Convert.ToDecimal(reader[16]);
                }

                if (reader[17] != DBNull.Value)
                {
                    txtTemperaturaFinal.Value = Convert.ToDecimal(reader[17]);
                }

                if (reader[13] != DBNull.Value)
                {
                    txtHoraInicial.Text = Convert.ToString(reader[13]);
                }



                if (reader[18] != DBNull.Value)
                {
                    txtPresion25.Value = Convert.ToInt32(reader[18]);
                }

                if (reader[19] != DBNull.Value)
                {
                    txtPresion1.Value = Convert.ToInt32(reader[19]);
                }

                if (reader[14] != DBNull.Value)
                {
                    txtFechaFinal.Value = (DateTime)reader[14];
                }

                if (reader[15] != DBNull.Value)
                {
                    txtHoraFinal.Text = Convert.ToString(reader[15]);
                }



                cn.cerrar();
            }
        }

        

        private void txtPresion25_ValueChanged(object sender, EventArgs e)
        {
            calcularRango();
        }

        private void txtPresion1_ValueChanged(object sender, EventArgs e)
        {
            calcularRango();
        }

        private void calcularRango()
        {
            int rango;
            rango = (int)(txtPresion25.Value - txtPresion1.Value);

            if (rango > 100 || rango < -100)
            {
                lblRango.BackColor = Color.Red;
            }
            else if (rango >= -100 && rango <= 100)
            {
                lblRango.BackColor = Color.Green;
            }
            lblRango.Text = rango.ToString();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //Actualizar los datos finales de la calibración del CSM
            cn.abrir();
            SqlCommand cmd = new SqlCommand("update [CSM Presión] set [Fecha Ingreso 2] = @fechaIngreso , [Hora ingreso 2] = @horaIngreso , [Temperatura Inicial 2] = @temInicial ,[Temperatura Final 2] = @temFinal,[Hora Inicial 2]= @horaInicial, [Presión 25 min #2]=@presion25 , [Presión 1 hora #2]=@presion1, [Fecha Final 2] = @fechaFinal, [Hora final 2] = @horaFinal, [Usuario Presión #2] = @usuario  where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
            cmd.Parameters.AddWithValue("@NumeroSerie", serie);
            cmd.Parameters.AddWithValue("@fechaIngreso", txtFechaIngreso.Value);



            cmd.Parameters.AddWithValue("@horaIngreso", txtHoraIngreso.Value);
            cmd.Parameters.AddWithValue("@temInicial", txtTemperaturaInicial.Value);
            cmd.Parameters.AddWithValue("@temFinal", txtTemperaturaFinal.Value);
            cmd.Parameters.AddWithValue("@horaInicial", txtHoraInicial.Text);
            cmd.Parameters.AddWithValue("@presion25", txtPresion25.Text);
            cmd.Parameters.AddWithValue("@presion1", txtPresion1.Text);
            cmd.Parameters.AddWithValue("@fechaFinal", txtFechaFinal.Value);
            cmd.Parameters.AddWithValue("@horaFinal", txtHoraFinal.Text);
            cmd.Parameters.AddWithValue("@usuario", cboUsuario.Text);


            cmd.ExecuteNonQuery();
            cn.cerrar();

            this.Close();
        }
    }


}

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
    public partial class Calibracion1 : Form
    {
        private string serie;

        public Calibracion1(string serie)
        {
           
            this.serie = serie ;
            InitializeComponent();

        }
      
        Conexion cn = new Conexion();
        private void Calibracion1_Load(object sender, EventArgs e)
        {
            cn.abrir();
          
            
            SqlCommand cmd = new SqlCommand("select [Fecha Ingreso 1],[Hora ingreso 1],[Fecha Final 1],[Hora Final 1],[Calibración 1],[Bracket 1] from CSM where convert(char,[Número de serie]) = @serie", cn.conectarBD);
           
            cmd.Parameters.AddWithValue("@serie", serie);
              
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (reader[0] != DBNull.Value)
                {
                    txtFechaIngreso.Text = Convert.ToString(Convert.ToDateTime(reader[0]).ToString("yyyy/MM/d"));
                }
                else
                {
                    txtFechaIngreso.Text = "N/A";
                }

                if (reader[1] != DBNull.Value) 
                {
                    txtHoraIngreso.Text = Convert.ToString(reader[1]);
                }
                else
                {
                    txtHoraIngreso.Text = "N/A";
                }

                if (reader[2] != DBNull.Value)
                {
                    
                    txtFechaFinal.Text = Convert.ToString(Convert.ToDateTime(reader[2]).ToString("yyyy/MM/d"));
                }
                else
                {
                    txtFechaFinal.Text = "N/A";
                }

                if (reader[3] != DBNull.Value)
                {
                    txtHoraFinal.Text = Convert.ToString(reader[3]);
                }
                else
                {
                    txtHoraFinal.Text = "N/A";
                }

                if (reader[4] != DBNull.Value)
                {
                    txtCalibracion.Text = Convert.ToString(reader[4]);
                }
                else
                {
                    txtCalibracion.Text = "N/A";
                }

                if (reader[5] != DBNull.Value)
                {
                    txtBracket.Text = Convert.ToString(reader[5]);
                }
                else
                {
                    txtBracket.Text = "N/A";
                }
                cn.cerrar();
            }


        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
           // txtFechaIngreso.Text = DateTime.Now.ToString("d/MM/yyyy");
            txtFechaIngreso.Text = DateTime.Now.ToString("yyyy/MM/d");
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            txtFechaFinal.Text = DateTime.Now.ToString("yyyy/MM/d");
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            txtHoraIngreso.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            txtHoraFinal.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (txtFechaFinal.Text != "N/A" || txtCalibracion.Text != "N/A" || txtHoraFinal.Text != "N/A" || txtBracket.Text != "N/A")
                {



                    //Actualizar los datos finales de la calibración del CSM
                    cn.abrir();
                    SqlCommand cmd = new SqlCommand("update CSM set [Fecha Ingreso 1] = @fechaIngreso , [Hora ingreso 1] = @horaIngreso, [Fecha Final 1] = @fechaFinal, [Hora Final 1] = @horaFinal,[Calibración 1] = @Calibracion, [Bracket 1]= @Desviacion   where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                    cmd.Parameters.AddWithValue("@NumeroSerie", serie);
                    cmd.Parameters.AddWithValue("@fechaIngreso", txtFechaIngreso.Text);
                    cmd.Parameters.AddWithValue("@horaIngreso", txtHoraIngreso.Text);
                    cmd.Parameters.AddWithValue("@fechaFinal", txtFechaFinal.Text);
                    cmd.Parameters.AddWithValue("@horaFinal", txtHoraFinal.Text);
                    cmd.Parameters.AddWithValue("@Calibracion", txtCalibracion.Text);
                    cmd.Parameters.AddWithValue("@Desviacion", txtBracket.Text);


                    cmd.ExecuteNonQuery();
                    cn.cerrar();
                    MensajeError("Guardado con exito.");
                    this.Close();
                }

                else
                {
                    MensajeError("No esta autorizado para guardar esta información.");
                    this.Close();
                }
            }
            catch
            {
                MensajeError("Error al guardar la información, cierre la pantalla y vuelva a intentarlo.");
                // MessageBox.Show("Error al guardar la información, cierre la pantalla y vuelva a intentarlo.");
            }


        }

        private void MensajeError(string mensaje)
        {
            Abis.variableMensaje = mensaje;

            Form frm = new Mensajes(Abis.variableMensaje);

            frm.ShowDialog();
        }
    }
}

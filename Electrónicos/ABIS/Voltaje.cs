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
    public partial class Voltaje : Form
    {
        private string serie;
        public Voltaje(string serie)
        {
            this.serie = serie;
            InitializeComponent();
        }
        Conexion cn = new Conexion();

        Conexion cn2 = new Conexion(2);

        private void Voltaje_Load(object sender, EventArgs e)
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


        private void CargarInformacion()
        {
            
            cn.abrir();
            SqlCommand cmd = new SqlCommand("select*from [CSM Voltaje] where convert(char,[Número de serie]) = @serie", cn.conectarBD);

            cmd.Parameters.AddWithValue("@serie", serie);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {


                cboUsuario.Text = Convert.ToString(reader[4]);
                


                if (reader[2] != DBNull.Value)
                {
                    txtVoltaje1.Value = Convert.ToDecimal(reader[2]);
                }

                if (reader[3] != DBNull.Value)
                {
                    txtVoltaje2.Value = Convert.ToDecimal(reader[3]);
                }


                reader.Close();
               
            }
            cn.cerrar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Actualizar los datos finales de la calibración del CSM
            cn.abrir();
            SqlCommand cmd3 = new SqlCommand("update [CSM Voltaje] set [Voltaje 1] = @voltaje1 ,[Voltaje 2] = @voltaje2, [Usuario Voltaje] = @usuario  where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
            cmd3.Parameters.AddWithValue("@NumeroSerie", serie);                    
            cmd3.Parameters.AddWithValue("@voltaje1", txtVoltaje1.Value);
            cmd3.Parameters.AddWithValue("@voltaje2", txtVoltaje2.Value);
            cmd3.Parameters.AddWithValue("@usuario", cboUsuario.Text);


            cmd3.ExecuteNonQuery();
            cn.cerrar();

            this.Close();
        }
    }
}

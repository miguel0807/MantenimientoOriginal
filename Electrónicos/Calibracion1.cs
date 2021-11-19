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
                
                txtFechaIngreso.Text = Convert.ToString(Convert.ToDateTime(reader[0]).ToString("d/MM/yyyy"));
                txtHoraIngreso.Text = Convert.ToString(reader[1]);
                txtFechaFinal.Text = Convert.ToString(Convert.ToDateTime(reader[2]).ToString("d/MM/yyyy"));
                txtHoraFinal.Text = Convert.ToString(reader[3]);
                txtCalibracion.Text = Convert.ToString(reader[4]);
                txtBracket.Text = Convert.ToString(reader[5]);
            }


        }
    }
}

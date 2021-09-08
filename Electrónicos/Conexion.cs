using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Electrónicos
{
    class Conexion
    {
        string cadena = "Data Source=tcp:COS-F37HWK2\\SQLEXPRESS,49500;Initial Catalog=CR7; User Id=simpro; Password=Trpo25MgL452"; //Nuevo servidor
        public SqlConnection conectarBD = new SqlConnection();
        


        public Conexion()
        {
            conectarBD.ConnectionString = cadena;

        }

        public void abrir()
        {
            try
            {
                conectarBD.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la Base de datos + " + ex.Message);
            }

        }

        public void cerrar()
        {
            conectarBD.Close();
        }
    }
}

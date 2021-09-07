using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CR7
{
    class Conexion
    {
        string cadena = "Data Source=tcp:COS-F37HWK2\\SQLEXPRESS,49500;Initial Catalog=CR7a; User Id=simpro; Password=Trpo25MgL452"; //Nuevo servidor
        public SqlConnection conectar = new SqlConnection();

        public Conexion()
        {
            conectar.ConnectionString = cadena;

        }

        public void abrir()
        {
            try
            {
                conectar.Open();
                Console.WriteLine("Conexion Abierta");
               // MessageBox.Show("Conexion Abierta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la Base de datos + " + ex.Message);
            }

        }

        public void cerrar()
        {
            conectar.Close();
        }
    }

}



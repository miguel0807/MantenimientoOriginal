using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
//Programa interfaz del plc
//Autor: Miguel Alvarado

namespace Tank_Farm
{
    public partial class Niveles : Form
    {
        //Declaracion de variables
        public Plc plc = null;
        private string ip;
        private int rack, slot;

        //Direcciones de Peso        
        string direcEtyl = "MD168", direcAcetone = "MD172", direclNPropanol = "MD176", direcMEK = "MD180"; 
   


        public Niveles()
        {
            InitializeComponent();
        }

        //Carga al inicio del proyecto variables o funciones
        private void Niveles_Load(object sender, EventArgs e)
        {
          


            Conectar();

            txtnivelAcetona.Text = CargarDireccion(direcAcetone);
            txtnivelMEK.Text = CargarDireccion(direcMEK);
            txtnivelNPropanol.Text = CargarDireccion(direclNPropanol);
            txtnivelEtyl.Text = CargarDireccion(direcEtyl);

        }

        //Boton para realizar la reconexion cuando se desconecte la conexion
        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conectar();
        }

        //Realiza la conexion al PLC
        private void Conectar()
        {
            
            try {

                ip = "10.164.104.210";
                rack = 0;
                slot = 0;
                CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), "S71200");

            plc = new Plc(cpu, ip, Convert.ToInt16(rack), Convert.ToInt16(slot));
           
            plc.Open();

            if (plc.IsConnected)
            {
                Estado.Text = "Conectado";
                    btnConectar.Visible = false;
            }

            }
            catch(Exception )
            {
                
                MessageBox.Show("No se logro conectar al PLC con la ip " + ip);
                Estado.Text = "Desconectado";
                btnConectar.Visible = true;
            }
            
        }

      
        //Funcion para cargar las direcciones del PLC
        private string CargarDireccion (string direccion)
        {
            float numFlotante;
            string dato;
            //string direccion = "MD168";
            object resultado = plc.Read(direccion);
            string varString = string.Format("{0}", resultado.ToString());
            int b = Convert.ToInt32(varString);
            //Segundo convertirla a byte
            byte[] bytes = BitConverter.GetBytes(b);

            //Tercero pasarla a float
            numFlotante = BitConverter.ToSingle(bytes, 0);


            dato = numFlotante.ToString();
            return dato;

        }


        //Desconecta la conexion al PLC
        private void Desconectar()
        {
            plc.Close();
            Estado.Text = "Desconectado";
        }
    }
}


//int conteo = 0;
//direcEtyl = "MD168";
//direcEtylAcetone = "MD172";
//direcEtylNPropanol = "MD176";
//direcEtylMEK = "MD180";

//string[] direciones = new string[4];
//direciones[0] = direcEtyl;
//direciones[1] = direcEtylAcetone;
//direciones[2] = direcEtylNPropanol;
//direciones[3] = direcEtylMEK;

//float[] niveles = new float[4];
//niveles[0] = nivelEtyl;
//niveles[1] = nivelEtylAcetone;
//niveles[2] = nivelEtylNPropanol;
//niveles[3] = nivelEtylMEK;






//foreach (string direccion in direciones)
//{

//    //string direccion = "MD168";
//    object resultado = plc.Read(direccion);
//    string varString = string.Format("{0}", resultado.ToString());
//    int b = Convert.ToInt32(varString);
//    //Segundo convertirla a byte
//    byte[] bytes = BitConverter.GetBytes(b);

//    //Tercero pasarla a float
//    flotante = BitConverter.ToSingle(bytes, 0);

//    niveles[conteo] = flotante;
//    conteo = conteo + 1;


//}

//txtnivelEtyl.Text = niveles[0].ToString();
//txtnivelAcetona.Text = niveles[1].ToString();
//txtnivelNPropanol.Text = niveles[2].ToString();
//txtnivelMEK.Text = niveles[3].ToString();

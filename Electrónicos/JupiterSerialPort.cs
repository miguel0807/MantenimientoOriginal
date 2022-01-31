using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

using System.Windows.Forms;

using System.Reflection;
using System.Data;

namespace Electrónicos
{
    
    class JupiterSerialPort : Form
    {
        public JupiterSerialPort() 
        {

        }
       

        //create an Serial Port object
        SerialPort PuertoSerie = new SerialPort();

        private delegate void DelegadoAcceso(string accion);

        //Lee la información del puerto Serial y la envia hacia el delegado   
        private void PuertoSerie_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            AccesoInterrupcion(PuertoSerie.ReadExisting());
        }

        //Del delegado lo envia hacia el buffer de entrada
        private void AccesoInterrupcion(string accion)
        {
            DelegadoAcceso Var_DelegadoAcceso;
            Var_DelegadoAcceso = new DelegadoAcceso(RecoleccionDatos);
            object[] arg = { accion };
            
            
            base.Invoke(Var_DelegadoAcceso, arg);
        }

        //Recibe la información del buffer de entrada y la muestra en textbox
        private void RecoleccionDatos(string bufferSalida)
        {
         
        }

        //Configurarción y conexión al puerto serial
        public int Conectar()
        {
            int exito = 0;
            PuertoSerie.BaudRate = 115200;
            PuertoSerie.DataBits = 8;
            PuertoSerie.Parity = Parity.None;
            PuertoSerie.StopBits = StopBits.One;
            PuertoSerie.Handshake = Handshake.None;
            PuertoSerie.PortName = "COM31";

            try
            {
                PuertoSerie.Open();

                exito = 1;
            }
            catch (Exception exc)
            {
                if (exc.Message == "The port 'COM31' does not exist.") // Error cuando no encuentra el puerto serial
                {
                    MessageBox.Show ("No se encontro el puerto COM#31, verifique que el USB este correctamente conectado y configurado.");

                    exito = 0;
                }

                else
                {
                    MessageBox.Show(exc.Message.ToString());

                }

            }
            return exito;

        }

        //Desconectar la conexión al puerto serial
        public void Desconectar()
        {
            PuertoSerie.Close();
        }
    }
}

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
using System.IO.Ports;

namespace Electrónicos.Jupiter
{
    public partial class Jupiter : Form
    {
               
        private delegate void DelegadoAcceso(string accion);
        internal static string variableMensaje, variableConsola;
        private int Power = 0;
        private int Signal = 0;

        private void Jupiter_Load(object sender, EventArgs e)
        {

        }
        #region Conexión, desconexión y lectura al puerto Serial

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
            txtMensajeLeido.Text = txtMensajeLeido.Text + bufferSalida;
            variableConsola = variableConsola + bufferSalida;
            txtMostrarDatos.Text = txtMostrarDatos.Text + bufferSalida;

            //Mueve el scroll hasta el final de la linea
            txtMostrarDatos.Focus();
            txtMostrarDatos.SelectionStart = txtMostrarDatos.TextLength;
            txtMostrarDatos.ScrollToCaret();

            txtEnviarDatos.Focus();
        }

        //Configurarción y conexión al puerto serial
        private int Conectar()
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
                    MensajeError("No se encontro el puerto COM#31, verifique que el USB este correctamente conectado y configurado.");

                    exito = 0;
                }

                else
                {
                    MensajeError(exc.Message.ToString());

                }

            }
            return exito;

        }

        //Desconectar la conexión al puerto serial
        private void Desconectar()
        {
            PuertoSerie.Close();
        }

        #endregion

        public Jupiter()
        {
            InitializeComponent();
        }
        

        private void btnConectar_Click(object sender, EventArgs e)
        {
            int exito = 0;
            if (btnConectar.Text == "Conectar")
            {
                exito = Conectar();
                if (exito == 1)
                {
                    btnConectar.Text = "Desconectar";                   
                    lblEstadoConexion.Text = "Estado : Conectado";                   
                    btnConsola.Visible = true;

                }

            }

            else if (btnConectar.Text == "Desconectar")
            {
                Desconectar();
                btnConectar.Text = "Conectar";
                lblEstadoConexion.Text = "Estado : Desconectado";               
                btnConsola.Visible = false;
                txtMostrarDatos.Visible = false;
                txtEnviarDatos.Visible = false;
                txtMensajeLeido.Visible = false;
            }
        }

        private void txtEnviarDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodoBoton(sender, e);
        }
      
        //Metodo que se ejecuta cuando se presiona el boton enter o el boton escape
        public void metodoBoton(object sender, KeyPressEventArgs e)
        {
            txtMensajeLeido.Text = "";
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                try
                {     
                    PuertoSerie.Write(txtEnviarDatos.Text);
                    PuertoSerie.Write(new byte[] { 13, 10 }, 0, 2);
                    txtEnviarDatos.Text = "";
                }
                catch (Exception exc)
                {
                    MensajeError(exc.Message.ToString());                    
                }
            }

            else if ((int)e.KeyChar == (int)Keys.Escape)
            {
                PuertoSerie.Write(new byte[] { 27, 10 }, 0, 2);
                txtEnviarDatos.Text = "";
            }
        }

        private void btnConsola_Click(object sender, EventArgs e)
        {
            if (txtMostrarDatos.Visible == false)
            {
                txtMostrarDatos.Visible = true;
                txtEnviarDatos.Visible = true;
                txtMensajeLeido.Visible = true;
            }

            else {
                txtMostrarDatos.Visible = false;
                txtEnviarDatos.Visible = false;
                txtMensajeLeido.Visible = false;
            }
            
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            PuertoSerie.Write(txtEnviarDatos.Text);
            PuertoSerie.Write(new byte[] { 13, 10 }, 0, 2);
            txtEnviarDatos.Text = "";
        }

        private void btnSignal_Click(object sender, EventArgs e)
        {
            gunaCircleProgressBar1.Value = 0;
            gunaCircleProgressBar1.Visible = true;
            txtScaner.Focus();

            
            
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            Power = Convert.ToInt32(txtScaner.Text);
           
        }

        private void CargarSignalPower()
        {            
            if (Power == 0 || Signal == 0)
            {
                btnSignal.Enabled = true;
                btnPower.Enabled = true;
            }

            else
            {
                btnSignal.Enabled = false;
                btnPower.Enabled = false;
            }

           
           
        }

        private void txtScaner_TextChanged(object sender, EventArgs e)
        {
            Signal = Convert.ToInt32(txtScaner.Text);

            
        }

        //Permite mostrar un form donde tendra el mensaje enviado como parametro.
        private void MensajeError(string mensaje)
        {
            variableMensaje = mensaje;

            Form frm = new Mensajes();

            frm.ShowDialog();
        }
    }

}

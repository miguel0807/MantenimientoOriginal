using System;
using System.IO.Ports;
using System.Windows.Forms;

/*
 * Autor:  Miguel Alvarado
 * Título: Calibrador de CSM del proyecto Abis 
 * Fecha:  12/08/2021
 */

namespace CR7
{
    public partial class Abis : Form
    {
        private delegate void DelegadoAcceso(string accion);
        private string BufferEntrada;
        private string BufferSalida;


        public Abis()
        {
            InitializeComponent();
        }

        

        private void Abis_Load(object sender, EventArgs e)
        {
            BufferEntrada = "";
            BufferSalida = "";
            btnConectar.Enabled = true;
        }


        #region Eventos

        //Evento click del boton btnConectar
        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConectar.Text == "Conectar")
                {
                    Conectar();
                    btnConectar.Text = "Desconectar";
                }
                else if (btnConectar.Text == "Desconectar")
                {
                    Desconectar();
                    btnConectar.Text = "Conectar";
                    
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        //Evento cuando se presiona alguna tecla en txtDatosEnviar
        private void txtDatosAEnviar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    serialPort1.DiscardOutBuffer();

                    BufferSalida = txtEnviarDatos.Text;

                    serialPort1.Write(BufferSalida);

                    serialPort1.Write(new byte[] { 13, 10 }, 0, 2);

                    txtEnviarDatos.Text = "";

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message.ToString());
                }
            }

            else if ((int)e.KeyChar == (int)Keys.Escape)
            {
                serialPort1.Write(new byte[] { 27, 10 }, 0, 2);
                txtEnviarDatos.Text = "";
            }




        }

        #endregion

        //Lee la información del puerto Serial y la envia hacia el delegado
        private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)
        {
            AccesoInterrupcion(serialPort1.ReadExisting());             
           
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
        private void RecoleccionDatos(string accion)
        {
            BufferEntrada = accion;

            txtMostrarDatos.Text = txtMostrarDatos.Text + BufferEntrada;

            //Mueve el scroll hasta el final de la linea
            txtMostrarDatos.Focus();
            txtMostrarDatos.SelectionStart = txtMostrarDatos.TextLength;
            txtMostrarDatos.ScrollToCaret();

            txtEnviarDatos.Focus();
        }

        //Configurarción y conexión al puerto serial
        private void Conectar()
        {
            serialPort1.BaudRate = 115200;
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Handshake = Handshake.None;
            serialPort1.PortName = "COM30";

            try
            {
                serialPort1.Open();



            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
                throw;
            }

        }

        //Desconectar la conexión al puerto serial
        private void Desconectar()
        {
            serialPort1.Close();
        }

    }



}


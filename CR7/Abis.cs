using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

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
        


        public Abis()
        {
            InitializeComponent();
        }


        #region Eventos
        //Evento click del boton btnConectar
        private void btnConectar_Click(object sender, EventArgs e)
        {
            int exito = 0;
            if (btnConectar.Text == "Conectar")
            {
                exito = Conectar();
                if (exito == 1)
                {
                    btnConectar.Text = "Desconectar";
                    // btnConectar.BackColor = Color.FromArgb(0, 128, 0);
                    lblEstadoConexion.Text = "Estado : Conectado";

                }


            }

            else if (btnConectar.Text == "Desconectar")
            {
                Desconectar();
                btnConectar.Text = "Conectar";
                lblEstadoConexion.Text = "Estado : Desconectado";

            }

            EsconderPanel();

        }

        //Evento cuando se presiona alguna tecla en txtDatosEnviar
        private void txtDatosAEnviar_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text = "";
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                try
                {
                    serialPort1.DiscardOutBuffer();

                   

                    serialPort1.Write(txtEnviarDatos.Text);

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

        //Evento que esconde el panel al ser presionado
        private void btnEsconderConexion_Click(object sender, EventArgs e)
        {
            EsconderPanel();

        }

        private void EsconderPanel()
        {
            if (btnConectar.Visible == true)
            {
                btnConectar.Visible = false;
                panel1.Size = new System.Drawing.Size(244, 73);
            }

            else
            {
                btnConectar.Visible = true;
                panel1.Size = new System.Drawing.Size(244, 110);
            }


        }
        #endregion

        #region Conexión, desconexión y lectura al puerto Serial
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
        private void RecoleccionDatos(string bufferSalida)
        {
           

            textBox1.Text = textBox1.Text + bufferSalida;
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
            serialPort1.BaudRate = 115200;
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Handshake = Handshake.None;
            serialPort1.PortName = "COM7";

            try
            {
                serialPort1.Open();
                ConectarActivado();
                exito = 1;
            }
            catch (Exception exc)
            {
                if (exc.Message == "The port 'COM7' does not exist.") // Error cuando no encuentra el puerto serial
                {
                    MessageBox.Show("No se encontro el puerto COM#30, verifique que el USB este correctamente conectado y configurado.", "Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void Desconectar()
        {
            serialPort1.Close();
            DesconectarActivado();
        }

        //Acciones que se ejecutaran cuando se este conectado al puerto serial
        private void ConectarActivado()
        {
            btnCalibracion.Visible = true;
        }

        //Acciones que se ejecutaran cuando se este desconectado al puerto serial
        private void DesconectarActivado()
        {
            btnCalibracion.Visible = false;
        }

        #endregion

        //Función que simula la letra enter solo una vez
        private void BtEnter()
        {
            serialPort1.Write(new byte[] { 13, 10 }, 0, 2);

        }

        //Función que simula la letra escape 3 veces
        private void BtEscape()
        {

            serialPort1.Write(new byte[] { 27, 10 }, 0, 2);

        }


        private void Abis_Load(object sender, EventArgs e)
        {
           
            
            btnConectar.Enabled = true;
        }    




        private void btnCalibracion_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                BtEscape();

                serialPort1.DiscardOutBuffer();

                textBox1.Text = "";

                

                serialPort1.Write("calibrate");


                BtEnter();

              
                btnColocarArriba.Visible = true;
            }
            else
            {
                MessageBox.Show("El puerto se desconecto, reinicie el programa y vuelta a intentar");
            }
            

        }


   


      

        private void btnColocarArriba_Click(object sender, EventArgs e)
        {
            BtEnter();
            btnColocarAbajo.Visible = true;
            btnColocarArriba.Visible = false;
            btnColocarAbajo.Focus();
        }

        private void btnColocarAbajo_Click(object sender, EventArgs e)
        {
            BtEnter();
            btnColocarLado.Visible = true;
            btnColocarAbajo.Visible = false;
            btnColocarLado.Focus();
        }

        private void btnColocarLado_Click(object sender, EventArgs e)
        {
            BtEnter();
            btnColocarLado.Visible = false;
            MessageBox.Show("Finalizada la calibración");
           
        }

        private void btnLineas_Click(object sender, EventArgs e)
        {

            Decodificador();   
        }

        private void Decodificador()
        {
            int numeroLinea = 1;
            string Mensaje = "";

            

            foreach (string linea in textBox1.Lines)
            {


                if (linea == "Place CSM with LED side up and press Enter!")
                {
                    Mensaje = "Coloque CSM en posición hacia Arriba";
                }

                else if (linea == "Place CSM with flat side down and press Enter!")
                {
                    Mensaje = "Coloque el CSM en posición hacia abajo";
                }

                else if (linea == "Port status: [KREAD")
                {
                    Mensaje = "Estatus";
                }

                if (linea.Contains("Calibration: ["))
                {
                    MessageBox.Show(linea);
                }

                else if (linea.Contains("CALIBRATION FAILED! PRESS ENTER TO CONTINUE!"))
                {
                    MessageBox.Show("LA calibración fallo, vuelva a repetir el proceso");
                }





                numeroLinea++;
            }


            if (Mensaje != "")
            {
                MessageBox.Show(Mensaje);
            }
        }

        

       

      

       
    }



}


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
        private string BufferEntrada;
        private string BufferSalida;
        private string Codigo,texto,pruebaEscrita;
        private bool Reinicio = false;


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

        #region Conexiones al puerto Serial
        //Lee la información del puerto Serial y la envia hacia el delegado
        private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)
        {
           // Reinicio = true;
            //AccesoInterrupcion(serialPort1.ReadExisting());
            if (Reinicio == false)
            {
                AccesoInterrupcion(serialPort1.ReadExisting());
            }

            else
            {
                serialPort1.Write(new byte[] { 27, 10 }, 0, 2);
                textBox1.Text = "";
            }

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
            BufferEntrada = accion + "\n";
            
            textBox1.Text = textBox1.Text + accion;
            txtMostrarDatos.Text = txtMostrarDatos.Text + BufferEntrada;

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
                    MessageBox.Show("No se encontro el puerto COM#30, verifique que el USB este correctamente conectado y configurado.", "Alerta!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
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



        #endregion

        #region Funciónes cuando se este ejecutando la conexión o desconexión del puerto serial
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

        private void btnCalibracion_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                BtEscape();



                serialPort1.DiscardOutBuffer();

                textBox1.Text = "";

                BufferSalida = "calibrate";

                serialPort1.Write(BufferSalida);


                BtEnter();

                btnDetener.Visible = true;

                btnColocarArriba.Visible = true;
            }
            else
            {
                MessageBox.Show("El puerto se desconecto, reinicie el programa y vuelta a intentar");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process cmdProcess = null;
            cmdProcess = new Process();
            // Dump all info from ipconfig command
            cmdProcess.StartInfo.Arguments = "/renew";
            // Run command: ipconfig
            cmdProcess.StartInfo.FileName = "ipconfig";
            // Redirect stdout
            cmdProcess.StartInfo.RedirectStandardOutput = true;
            // Set to false, otherwise you can't redirect stdout
            cmdProcess.StartInfo.UseShellExecute = false;
            // Start process
            if (cmdProcess.Start())
            {
                // Read stdout and show the content in a rtf-box
                txtMostrarDatos.Text = cmdProcess.StandardOutput.ReadToEnd();
            }
            else
            {
                // Failed to execute command
            }
        }

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
       

        private void EstadoBotonesInicio()
        {
            if (Codigo == "2D-77-C4-21-9C-56-33-F8-3B-14-76-8C-C1-3A-5E-29-3F-FC-3D-A1-DE-E3-B7-F8-CE-04-D8-3F-5D-D8-79-48-1D-9E-7C-0C-A3-D7-74-3F-93-10-60-3A-A3-8E-CA-4F-DD-D5-B0-75-3F-A0-04-AA-1E-16-55-F9-C9-81-12-C3")


            {
                MessageBox.Show("Coloque el CSM hacia arriba");
            }

            else if (Codigo == "DE-42-47-1B-4E-6C-33-97-7A-E9-37-38-68-76-17-BF-99-59-2D-C8-5A-31-79-06-2F-3D-8E-33-B5-A2-A5-AF-A2-63-AA-F9-FE-A3-90-1C-B5-D4-22-0A-42-0B-99-A1-E7-7D-11-E5-89-83-AC-2E-C6-66-80-95-30-54-4B-EB")
            {
                MessageBox.Show("Coloque el CSM hacia arriba");
            }

            else if (Codigo == "DE-42-47-1B-4E-6C-33-97-7A-E9-37-38-68-76-17-BF-99-59-2D-C8-5A-31-79-06-2F-3D-8E-33-B5-A2-A5-AF-A2-63-AA-F9-FE-A3-90-1C-B5-D4-22-0A-42-0B-99-A1-E7-7D-11-E5-89-83-AC-2E-C6-66-80-95-30-54-4B-EB")
            {
                MessageBox.Show("Coloque el CSM hacia arriba");
            }


            else if(Codigo == "E6-91-15-27-69-91-E9-1F-4E-4A-66-E7-0A-02-0C-AD-1D-09-8B-B0-97-F5-0C-FD-23-A9-20-D2-4A-58-9F-DB-E6-24-B3-29-DA-F9-85-F7-C3-C0-FC-94-36-FE-26-D6-C4-D4-92-6E-05-76-64-3B-8A-AA-79-96-EC-50-E1-0A")
            {
                MessageBox.Show("Coloque el CSM hacia abajo");
            }

        }

        private void EncriptarInformacion()
        {

           
            texto = textBox1.Text;
            // Obtenemos un array de bytes a partir de dicho mensaje
            byte[] mensajeBytesArray = Encoding.Default.GetBytes(texto);

            // Instanciamos el algoritmo
            //SHA512Managed algoritmoHash = new SHA512Managed();
            MD5 algoritmoHash = new MD5Cng();

            // Se podría haber instanciado de esta otra forma.
            // Si no proporcionas un valor al método Create
            // "SHA1CryptoServiceProvider" será usado como opción por defecto.
            // HashAlgorithm algoritmoHash = HashAlgorithm.Create("SHA512");

            // Obtenemos el código hash mediante el método ComputeHash
            // ComputeHash es un método sobrecargado.
            // Existe una versión con la cual poder procesar solamente una
            // subregión del array de bytes.
            byte[] codigoHashBytesArray = algoritmoHash.ComputeHash(mensajeBytesArray);
            Console.WriteLine(BitConverter.ToString(codigoHashBytesArray, 0));
            // Guardo el código hash en hexadecimal en la variable Codigo                    
            Codigo = BitConverter.ToString(codigoHashBytesArray, 0);
            


            // Liberamos recursos.
            algoritmoHash.Clear();

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


            pruebaEscrita = "";
            foreach (string linea in textBox1.Lines)
            {


                if (linea == "Place CSM with LED side up and press Enter!")
                {
                    pruebaEscrita = "Coloque CSM en posición hacia Arriba";
                }

                else if (linea == "Place CSM with flat side down and press Enter!")
                {
                    pruebaEscrita = "Coloque el CSM en posición hacia abajo";
                }

                else if (linea == "Port status: [KREAD")
                {
                    pruebaEscrita = "Estatus";
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


            if (pruebaEscrita != "")
            {
                MessageBox.Show(pruebaEscrita);
            }
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Reinicio == false)
            {
                Reinicio = true;
            }

            else
            {
                Reinicio = false;
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            //EncriptarInformacion();
           
            //EstadoBotonesInicio();
            serialPort1.Write(new byte[] { 27, 10 }, 0, 2);           
            textBox1.Text = "";
           

        }

       
    }



}


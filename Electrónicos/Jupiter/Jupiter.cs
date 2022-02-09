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
using System.Diagnostics;

namespace Electrónicos.Jupiter
{
    public partial class Jupiter : Form
    {
               
        private delegate void DelegadoAcceso(string accion);
        
        private bool DecodificadorActivado;
        
        private int Power = 0;
        private int Signal = 0;
        private int segundos = 0;
        JupiterConexion impresora = new JupiterConexion();
        JupiterCalculos cal = new JupiterCalculos();


        private void Jupiter_Load(object sender, EventArgs e)
        {
            btnSignal.Focus();
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
            txtMostrarDatos.Text = txtMostrarDatos.Text + bufferSalida;

            if( cal.VsI == true && cal.VsO == true && cal.Corto == false)//Condicional para mostrar mensaje cuando sea el procedimiento de corto.
            {
                lblComando.Text = "";
                lblComando.Text = lblComando.Text + bufferSalida;
            }

            if (DecodificadorActivado == true)
            {
                txtDecodificador.Text = txtDecodificador.Text + bufferSalida;
            }

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
            //PuertoSerie.PortName = "COM2"; // Puerto virtual.
            PuertoSerie.PortName = "COM7"; // Puerto normal.

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
        

       
        private void conectar()
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
                desconectarGeneral();
            }
        }

        private void desconectarGeneral()
        {
            Desconectar();
            btnConectar.Text = "Conectar";
            lblEstadoConexion.Text = "Estado : Desconectado";
            btnConsola.Visible = false;
            txtMostrarDatos.Visible = false;
            txtEnviarDatos.Visible = false;
            txtMensajeLeido.Visible = false;
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
                    enter();
                    txtEnviarDatos.Text = "";
                }
                catch (Exception exc)
                {
                    MensajeError(exc.Message.ToString());                    
                }
            }

            else if ((int)e.KeyChar == (int)Keys.Escape)
            {
                escape();
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


        private void btnSignal_Click(object sender, EventArgs e)
        {           
            circularProgressBar1.Visible = true;
            txtScanerSignal.Focus();
        }
        private void btnPower_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Visible = true;
            txtScanerPower.Focus();
        }
        private void txtScanerSignal_TextChanged(object sender, EventArgs e)
        {
            if (segundos == 0)
            {
                timerSignal.Start();
            }
        }
        private void txtScaner_TextChanged(object sender, EventArgs e)
        {
            if (segundos == 0)
            {
                timerPower.Start();
            }
        }
        private void timerSignal_Tick(object sender, EventArgs e)
        {
            segundos = segundos + 1;
            verificarQR(2);
        }
        private void timerPower_Tick(object sender, EventArgs e)
        {
            segundos = segundos + 1;
            verificarQR(1);
        }


        private void txtInicio_Click(object sender, EventArgs e)
        {
            /*
            impresora.P1Signal1 = 26;
            impresora.P1Power1 = 54;
            impresora.AppVersion1 = "210913A";
            impresora.FPGAVersion1 = "20210614-11B";
            impresora.Estado1 = "Inicio";
            impresora.guardadoInicial();*/


            //Hago visible los controles
            cal.Corto = false;
            cal.VsI = false;
            cal.VsO = false;

            btnAceptar.Visible = true;
            btnRechazar.Visible = true;
            lblComando.Visible = true;
            
            lblComando.Text = "Resistencia 3.8";

        
            btnComenzarProgramacion.Visible = false;
            







        }


        private void txtScanerSignal_Leave(object sender, EventArgs e)
        {
            circularProgressBar1.Visible = false;
        }

        private void txtScanerPower_Leave(object sender, EventArgs e)
        {
            circularProgressBar1.Visible = false;
        }

        //Verifica el QR contra la base de datos
        private void verificarQR(int tipo) //Seleccionar 1 para Power, 2 para Signal
        {           
            //Declaración de variables
            string prefijo, sufijo, valorPrefijo, valorSufijo, numeroSerie;
            string codigo;
                
            //Asignación de variables                                          
            
            prefijo = "‰";            
            sufijo = "05";

            if(tipo == 1)
            {
                codigo = txtScanerPower.Text;
            }
            else
            {
                codigo = txtScanerSignal.Text;
            }

            if (segundos == 1) //Cuando los segundos son iguales a 1, procede a realizar el programa.
            {
                if (codigo.Length > 3) //El codigo tiene que tener como minimo 4 digitos para que lo acepte como codigo valido.
                {
                    valorPrefijo = codigo.Substring(0, 1);  //Extraer el valor del prefijo en el codigo.
                    valorSufijo = codigo.Substring(codigo.Length - 2); //Extraer el valor del sufijo en el codigo.
                    numeroSerie = codigo.Substring(prefijo.Length, codigo.Length - prefijo.Length - sufijo.Length);//Extrae la información del codigo escaneado.

                    if (valorPrefijo == prefijo && valorSufijo == sufijo) //Verifica que los prefijos ingresados sean los correctos.
                    {
                        if (numeroSerie.All(char.IsDigit)) //Verifica si el codigo escaneado es un número.
                        {
                            if (tipo == 1) //Selecciona la función para la serie Power.
                            {
                                impresora.P1Power1 = Int32.Parse(numeroSerie); //Asigna el valor de número de serie al objeto impresora.
                                if (impresora.VerificarPower() == impresora.P1Power1)    //Verifica que el Power no se encuentre registrado en la base de datos.
                                {
                                    serieInvalida(numeroSerie,tipo);
                                }
                                else
                                {
                                    serieValida(numeroSerie, tipo);                                        
                                }
                            }
                            else //Selecciona la función para la serie Signal
                            {
                                impresora.P1Signal1 = Int32.Parse(numeroSerie);
                                if (impresora.VerificarSignal() == impresora.P1Signal1)
                                {
                                    serieInvalida(numeroSerie,tipo);
                                }
                                else
                                {
                                    serieValida(numeroSerie, tipo);                                        
                                }
                            }                                                                                                        
                        }
                        else
                        {
                            qrInvalido(tipo);
                        }
                    }
                }
            }
            else if (segundos > 3) //Si supera el segundo invalida el QR.
            {
                qrInvalido(tipo);                    
            }         
        }

        //Acción que se realiza cuando el qr es invalido
        private void qrInvalido(int tipo) //Seleccionar 1 para Power, 2 para Signal
        {
            if (tipo == 1)
            {
                timerPower.Stop();
                txtScanerPower.Text = "";                
                segundos = 0;
                btnPower.Focus();
                MensajeError("QR Invalido.");
            }
            else
            {
                timerSignal.Stop();
                txtScanerSignal.Text = "";                
                segundos = 0;
                btnSignal.Focus();
                MensajeError("QR Invalido.");
            }
            
        }

        //Acción que se realiza cuando el QR nunca se a registrado en la base de datos.
        private void serieValida(string serie, int tipo)//Tipo 1 para Power, 2 para Signal
        {
            if (tipo == 1)
            {
                timerPower.Stop();
                txtScanerPower.Text = "";                
                segundos = 0;
                btnPower.Focus();
                Power = Int32.Parse(serie);
                lblPower.Text = serie;                             
                btnPower.Enabled = false;
                
                MensajeError("Codigo aceptado, el número de serie es " + serie + ".");
            }
            else
            {
                timerSignal.Stop();
                txtScanerSignal.Text = "";
                segundos = 0;
                btnSignal.Focus();
                Signal = Int32.Parse(serie);
                lblSignal.Text = serie;                
                btnSignal.Enabled = false;
                
                MensajeError("Codigo aceptado, el número de serie es " + serie + ".");
            }

            ActivarProgramación();

        }
        //Habilita el boton de comenzar programación cuando signal y power esten cargados correntamente.
        private void ActivarProgramación()
        {
            if (btnPower.Enabled == false && btnSignal.Enabled == false)
            {
                btnComenzarProgramacion.Visible = true;
                btnComenzarProgramacion.Focus();
            }
        }
        //Acción que se realiza cuando el QR se encuentra registrado en la base de datos.
        private void serieInvalida(string serie,int tipo)//Tipo 1 para Power, 2 para Signal
        {
            if (tipo == 1)
            {
                timerPower.Stop();
                txtScanerPower.Text = "";                
                segundos = 0;
                btnPower.Focus();
                MensajeError("La serie " + serie + " del Power ya existe, no se puede volver a programar.");                
            }
            else
            {
                timerSignal.Stop();
                txtScanerSignal.Text = "";                
                segundos = 0;
                btnSignal.Focus();
                MensajeError("La serie " + serie + " del Signal ya existe, no se puede volver a programar.");
            }
            
        }

        private void PuertoSerie_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            desconectarGeneral();
        }

        private void Jupiter_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

      


        //Permite mostrar un form donde tendra el mensaje enviado como parametro.
        private void MensajeError(string mensaje)
        {            

            Form frm = new Mensajes(mensaje);

            frm.ShowDialog();
        }

        private void cmd(string comando)
        {
            if (lblEstadoConexion.Text != "Estado : Desconectado")
            {
                PuertoSerie.Write(comando);
                enter();
            }
            else
            {
                MessageBox.Show("El puerto de comunicación se encuentra cerrado.");
            }
            
            
            
        }

      

        private void btnActivar_Click(object sender, EventArgs e)
        {
            string comando;
            comando = cal.SecuenciaComandos();                       
                       
            cmd(comando);
            lblComando.Text = comando;

            if (cal.btnEstado == true)
            {
                colorBoton(true);

            }
            else
            {
                colorBoton(false);
            }

            btnAceptar.Visible = true;
            btnRechazar.Visible = true;


        }

     

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            lblComando.Text = cal.SecuenciaPruebas();
            colorBoton(false);

            if (lblComando.Text == "Vs i 0")
            {
                conectar();
                escape();
                cmd("run");
                escape();
             
                InicioProgramación.Start();
            }
            if (cal.Voltaje60 == true) //Cuando la medición de voltaje es 60 se procede a conectar el boton.
            {
                btnActivar.Visible = true;
            }

            if (cal.VsO == true)
            {
                btnActivar.Visible = false;
            }

            if (cal.Direcciones == true)
            {
                btnAceptar.Visible = false;
                btnRechazar.Visible = false;
                btnActivar.Visible = false;
                lblComando.Visible = false;                
                btnCargarPruebas.Visible = true;
            }

         

        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {

        }

       
        private void colorBoton(bool estado)
        {
            if (estado == false)
            {
                btnActivar.BaseColor1 = Color.Gray;
                btnActivar.BaseColor2 = Color.Gray;
                btnActivar.OnHoverBaseColor1 = Color.DarkGray;
                btnActivar.OnHoverBaseColor2 = Color.DarkGray;
                btnActivar.Text = "Activar";
            }
            else
            {
                btnActivar.BaseColor1 = Color.Gold;
                btnActivar.BaseColor2 = Color.Yellow;
                btnActivar.OnHoverBaseColor1 = Color.Gold;
                btnActivar.OnHoverBaseColor2 = Color.LightGoldenrodYellow;
                btnActivar.Text = "Desactivar";
            }
        }

        private void InicioProgramación_Tick(object sender, EventArgs e)
        {
            segundos = segundos + 1;
            if (segundos == 2)
            {
                escape();
                InicioProgramación.Stop();
                
                segundos = 0;
              
            }
        }

        private void escape()
        {
            if (lblEstadoConexion.Text != "Estado : Desconectado")
            {
                PuertoSerie.Write(new byte[] { 27, 10 }, 0, 2);
            }
            else
            {
                MessageBox.Show("El puerto de comunicación se encuentra cerrado.");
            }
        }

        private void enter()
        {
            PuertoSerie.Write(new byte[] { 13, 10 }, 0, 2);
        }

        private void timerPruebas_Tick(object sender, EventArgs e)
        {
           
            segundos = segundos - 1;
            gunaCircleProgressBar1.Value = gunaCircleProgressBar1.Value + 10;
            gunaCircleProgressBar1.Text = segundos.ToString();
                        
            if (segundos == 10)
            {
                escape();
                DecodificadorActivado = true;                
            }
           
            else if (segundos == 9)
            {
                cmd("i2c c");
            }
            else if (segundos == 8)
            {
               
                DecodificadorJellingDisck("i2c status: 0", "i2c status: 1", ref pic1, ref txtRespuesta1);
                cmd("i2c w 1024 1 2 3");
                
            }

            else if (segundos == 7)
            {
                DecodificadorDirecciones("400: 01 02 03",ref pic2, ref txtRespuesta2);
                cmd("i2c w 1025 1 2 3");
            }

            else if (segundos == 6)
            {
                DecodificadorDirecciones("401: 01 02 03", ref pic3, ref txtRespuesta3);
                cmd("i2c w 1026 1 2 3");
            }


            else if (segundos == 5)
            {
                DecodificadorDirecciones("402: 01 02 03", ref pic4, ref txtRespuesta4);
                cmd("i2c w 1024 255 255 255");
            }

            else if (segundos == 4)
            {
                DecodificadorDirecciones("400: FF FF FF ", ref pic6, ref txtRespuesta6);
                cmd("i2c w 1025 255 255 255");
            }
            else if (segundos == 3)
            {
                DecodificadorDirecciones("401: FF FF FF ", ref pic7, ref txtRespuesta7);
                cmd("i2c w 1026 255 255 255");
            }

            else if (segundos == 2)
            {
                DecodificadorDirecciones("402: FF FF FF ", ref pic8, ref txtRespuesta8);
                
            }
            else if (segundos == -5)
            {
                
                
                
                
                cmd("i2c r 1024");
               
                cmd("i2c w 1026 255 255 255");


            }
            else if (segundos == 0)
            {
                timerPruebas.Stop();

                gunaCircleProgressBar1.Visible = false;
                // DecodificadorActivado = false;
            }
        }

        private void btnCargarPruebas_Click(object sender, EventArgs e)
        {
            escape();
            cmd("run");
            escape();

            gunaCircleProgressBar1.Visible = true;
            gunaPanel1.Visible = true;
            timerPruebas.Start();
            segundos = 11;
            gunaCircleProgressBar1.Value = 0;
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            cmd("info");
            cargarEtiquetas.Start();
            
        }

        private void DecodificadorEtiquetas(string cmdAprobado, TextBox txtDecodificador ,ref Guna.UI.WinForms.GunaLabel lblRespuesta, string inicio, string final,string PalabraExtra)
        {
            int numeroLinea = 1;

            foreach (string linea in txtDecodificador.Lines)
            {
                if (linea.Contains(cmdAprobado))
                {
                    string nuevo;
                    nuevo = linea + PalabraExtra;
                    lblRespuesta.Text = StringEntre(nuevo, inicio,final) ;
                    break;
                }
                
                numeroLinea++;
            }

            
        }

        public static string StringEntre(string texto, string inicio, string final)
        {
            string resultado = "";
            if (texto.Contains(inicio) && texto.Contains(final))
            {
                int StartIndex = texto.IndexOf(inicio, 0) + inicio.Length;
                int EndIndex = texto.IndexOf(final, StartIndex);
                resultado = texto.Substring(StartIndex, EndIndex - StartIndex);
                return resultado;
            }

            return resultado;
        }

            //Decodificador para las pruebas de verificación del i2 c.
            private void DecodificadorJellingDisck(string cmdAprobado, string cmdDenegar, ref PictureBox imagen, ref Guna.UI.WinForms.GunaTextBox txtRespuesta)
        {

            int numeroLinea = 1;

            foreach (string linea in txtDecodificador.Lines)
            {
                if (linea.Contains(cmdAprobado))
                {
                   imagen.Image = Properties.Resources.Aceptar;
                    txtRespuesta.Text = linea;
                    break;
                }
                else if (linea.Contains(cmdDenegar))
                {
                    imagen.Image = Properties.Resources.Denegar;
                    txtRespuesta.Text = linea;
                    break;

                }
                numeroLinea++;
            }

            txtDecodificador.Text = "";
        }

        private void DecodificadorDirecciones(string cmdAprobado, ref PictureBox imagen, ref Guna.UI.WinForms.GunaTextBox txtRespuesta)
        {

            int numeroLinea = 1;

            foreach (string linea in txtDecodificador.Lines)
            {
                if (linea.Contains(cmdAprobado))
                {
                    imagen.Image = Properties.Resources.Aceptar;
                    txtRespuesta.Text = linea;
                    break;
                }
                else 
                {
                    imagen.Image = Properties.Resources.Denegar;

                }
                numeroLinea++;
            }

            txtDecodificador.Text = "";
        }

        private void circularProgressBar2_Click(object sender, EventArgs e)
        {

        }

        

        private void btnConectar_Click(object sender, EventArgs e)
        {
            conectar();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            DecodificadorEtiquetas("Application", txtMensajeLeido, ref lblAppVersion, "\"", "\"Extra", "Extra");
        }

        private void cargarEtiquetas_Tick(object sender, EventArgs e)
        {
            DecodificadorEtiquetas("Application", txtMensajeLeido, ref lblAppVersion, "\"", "\"Extra", "Extra");
            DecodificadorEtiquetas("ver[", txtMensajeLeido, ref lblFPGAVersion, "ver[", "]Extra", "Extra");
            cargarEtiquetas.Stop();
        }
    }

}

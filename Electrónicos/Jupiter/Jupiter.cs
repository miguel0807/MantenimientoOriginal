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
        internal static string variableMensaje, variableConsola;
        private int Power = 0;
        private int Signal = 0;
        private int segundos = 0;
        JupiterConexion impresora = new JupiterConexion();

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
            impresora.P1Signal1 = 26;
            impresora.P1Power1 = 54;
            impresora.AppVersion1 = "210913A";
            impresora.FPGAVersion1 = "20210614-11B";
            impresora.Estado1 = "Inicio";
            impresora.guardadoInicial();
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
                MensajeError("Codigo aceptado, el número de serie es " + serie + ".");                
            }
            else
            {
                timerSignal.Stop();
                txtScanerSignal.Text = "";
                segundos = 0;
                btnSignal.Focus();
                MensajeError("Codigo aceptado, el número de serie es " + serie + ".");
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


       
    }

}

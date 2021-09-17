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

/*
 * Autor:  Miguel Alvarado
 * Título: Calibrador de CSM del proyecto Abis 
 * Fecha:  12/08/2021
 */

namespace Electrónicos
{
    public partial class Abis : Form
    {

        private delegate void DelegadoAcceso(string accion);
        public static bool ModoRetrabajo = false;
        bool decoCalibracion = false;
        bool decoLeerCSM = true;
        bool sinConectarCSM = false;
        int contadorCSMdesconectado = 0;
        int tipoCalibracion; // Usada para concatenar las acciones del boton en la calibración
        Conexion cn = new Conexion();

        internal static string variableMensaje,variableConsola;

        

        string NumeroSerie = "";
        string Calibracion1 = "";
        string Desviacion = "";
        int NumeroParte = 0;
        string Descripcion = "";




        public Abis()
        {
            InitializeComponent();
        }


        private void btnConectar_Click(object sender, EventArgs e)
        {

        }

        //Evento cuando se presiona alguna tecla en txtDatosEnviar
        public  void txtEnviarDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            textBox1.Text = "";
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                try
                {
                    PuertoSerie.DiscardOutBuffer();



                    PuertoSerie.Write(txtEnviarDatos.Text);

                    PuertoSerie.Write(new byte[] { 13, 10 }, 0, 2);

                    txtEnviarDatos.Text = "";



                }
                catch (Exception exc)
                {
                    MensajeError(exc.Message.ToString());
                   // MessageBox.Show(exc.Message.ToString());
                }
            }

            else if ((int)e.KeyChar == (int)Keys.Escape)
            {
                PuertoSerie.Write(new byte[] { 27, 10 }, 0, 2);
                txtEnviarDatos.Text = "";
            }
            */

            metodoClick(sender,  e);

        }

        public void metodoClick(object sender, KeyPressEventArgs e)
        {
            textBox1.Text = "";
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                try
                {
                    //PuertoSerie.DiscardOutBuffer();



                    PuertoSerie.Write(txtEnviarDatos.Text);

                    PuertoSerie.Write(new byte[] { 13, 10 }, 0, 2);

                    txtEnviarDatos.Text = "";



                }
                catch (Exception exc)
                {
                    MensajeError(exc.Message.ToString());
                    // MessageBox.Show(exc.Message.ToString());
                }
            }

            else if ((int)e.KeyChar == (int)Keys.Escape)
            {
                PuertoSerie.Write(new byte[] { 27, 10 }, 0, 2);
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

        private void btnCalibracion_Click(object sender, EventArgs e)
        {
            if (PuertoSerie.IsOpen == true)
            {


                BtEscape();

                PuertoSerie.DiscardOutBuffer();

                textBox1.Text = "";

                PuertoSerie.Write("calibrate");

                BtEnter();

                btnEnPosicion.Visible = true;

                btnCalibracion.Visible = false;

               

                decoCalibracion = true;


            }

            else
            {
                MensajeError("El puerto se desconecto, reinicie el programa y vuelta a intentar");
               
            }
        }

        private void btnColocarArriba_Click(object sender, EventArgs e)
        {

        }

        private void btnColocarAbajo_Click(object sender, EventArgs e)
        {

        }

        private void btnColocarLado_Click(object sender, EventArgs e)
        {

        }

      

        #region Conexión, desconexión y lectura al puerto Serial


        //Lee la información del puerto Serial y la envia hacia el delegado
        private void PuertoSerie_DataReceived(object sender, SerialDataReceivedEventArgs e)
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

            if (bufferSalida.Contains("Port status: [KMISSING"))
            {
                textBox1.Text = "";
                sinConectarCSM = true;

                return;
            }

            if (bufferSalida.Contains("Port status: [KREADY "))
            {

                

                return;
            }


            if (bufferSalida.Contains(" Port status: [KUPDATING"))
            {

                timerDesconectadoCSM.Start();

                return;
            }
           

            textBox1.Text = textBox1.Text + bufferSalida;
            variableConsola = variableConsola + bufferSalida;
            txtMostrarDatos.Text = txtMostrarDatos.Text + bufferSalida;

            if (sinConectarCSM == false)
            {
                
                Decodificador();
            }

            else
            {
                
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
            PuertoSerie.PortName = "COM30";

            try
            {
                PuertoSerie.Open();
                //ConectarActivado();
                exito = 1;
            }
            catch (Exception exc)
            {
                if (exc.Message == "The port 'COM30' does not exist.") // Error cuando no encuentra el puerto serial
                {
                    MensajeError("No se encontro el puerto COM#30, verifique que el USB este correctamente conectado y configurado.");
                   // MessageBox.Show("No se encontro el puerto COM#30, verifique que el USB este correctamente conectado y configurado.", "Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    exito = 0;
                }

                else
                {
                    MensajeError(exc.Message.ToString());
                    //MessageBox.Show(exc.Message.ToString());
                }





            }
            return exito;

        }

        //Desconectar la conexión al puerto serial
        private void Desconectar()
        {
            PuertoSerie.Close();
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
            PuertoSerie.Write(new byte[] { 13, 10 }, 0, 2);

        }

        //Función que simula la letra escape 
        private void BtEscape()
        {

            PuertoSerie.Write(new byte[] { 27, 10 }, 0, 2);

        }

        private void Abis_Load(object sender, EventArgs e)
        {
            

        //RegresoInicio();
        // MessageBox.Show("Hubo un error durante el proceso de la calibración, el CSM requiere que se calibre nuevamente.");



        btnConectar.Enabled = true;
        }

        //Restablece la configuración a sus valores iniciales
        private void RegresoInicio()
        {
            
            btnCalibracion.Visible = false;
           
            btnEnPosicion.Visible = false;
           
            btnCargarCSM.Visible = false;



            lblNumeroSerie.Text = "Número de serie: N/A";
            lblErrorHumano.Text = "Intentos restantes: N/A";
            lblEstado.Text = "Estado: N/A";
        }

        //Decodifica los mensajes generados en el textbox de ingles al español
        private void Decodificador()
        {
            int numeroLinea = 1;
            string Mensaje = "";
            
            if (ModoRetrabajo == true)
            {
                DecodificadorRetrabajo();
                return;
            }

            else if (decoCalibracion == true)
            {
                DecodificadorInicial();

                return;
            }

            else if (decoLeerCSM == true)
            {
                DecodificadorLeerCSM();
                return;
            }

            foreach (string linea in textBox1.Lines)
            {
                //Indica la posición del CSM
                if (linea == "Place CSM with LED side up and press Enter!")
                {
                    
                    pic1.Image = Properties.Resources.Picture2;
                    lblInstruccion.Text = "Coloque en posición hacia arriba el CSM";
                    // Mensaje = "Coloque CSM en posición hacia Arriba";
                }

                else if (linea == "Place CSM with flat side down and press Enter!")
                {
                    pic1.Image = Properties.Resources.Picture3;
                    lblInstruccion.Text = "Coloque en posición hacia abajo el CSM";
                   
                    // Mensaje = "Coloque el CSM en posición hacia abajo";
                }

                else if (linea == "Place CSM in orientation the reference bracket and press Enter!")
                {
                    pic1.Image = Properties.Resources.Picture1;
                    lblInstruccion.Text = "Coloque el CSM en el bracket";
                    //Mensaje = "Coloque el CSM de lado";
                }


                //Almacenar valores de la calibración
                if (linea.Contains("Calibration:"))
                {


                    int inicio = linea.IndexOf("[");

                    try
                    {
                        int final = linea.IndexOf("]", inicio);
                        Calibracion1 = linea.Substring(inicio, final + 1 - inicio);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("{0} Exception caught.", e);
                    }
                    

                    

                }

                //Almacenar valores de la calibración
                if (linea.Contains("Deviation: ["))
                {


                    int inicio = linea.IndexOf("[") - 1;
                    int final = linea.IndexOf("]", inicio);

                    try
                    {
                        Desviacion = linea.Substring(inicio, final + 1 - inicio);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("{0} Exception caught.", e);
                    }
                    





                }

                //En caso de fallo
                if (linea.Contains("CALIBRATION FAILED! PRESS ENTER TO CONTINUE!"))
                {
                    MensajeError("La calibración fallo, vuelva a repetir el proceso.");
                    //MessageBox.Show("La calibración fallo, vuelva a repetir el proceso");


                    //Verificar los errores humanos
                    cn.abrir();
                    SqlCommand cmd = new SqlCommand("select [Error Humano] from CSM where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                    cmd.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);

                    int conteoErrores = Convert.ToInt32(cmd.ExecuteScalar());
                    cn.cerrar();

                    //Actualiza la información del CSM
                    SqlCommand cmd1 = new SqlCommand("update CSM set [Error Humano] = @ErrorHumano , Estado = @Estado where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                    cn.abrir();
                    if (conteoErrores == 0)
                    {

                        cmd1.Parameters.AddWithValue("@Estado", "Retrabajo");
                        MensajeError("No se permiten mas intentos.");
                        //MessageBox.Show("No se permiten mas intentos");
                    }
                    else if (conteoErrores >= 1)
                    {
                        conteoErrores = conteoErrores - 1;
                       
                        
                        
                        cmd1.Parameters.AddWithValue("@Estado", "Pendiente calibración");
                        
                        MensajeError("Se resto 1 al contador de errores.");
                        //MessageBox.Show("Se resto 1 al contador de errores");

                    }
                    cmd1.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);
                    cmd1.Parameters.AddWithValue("@ErrorHumano", conteoErrores);
                    cmd1.ExecuteNonQuery();

                    cn.cerrar();




                    RestablecerControles();
                    
                    decoCalibracion = true;
                    
                }

                //En caso de que finalice sin problemas
                else if (linea.Contains("Calibration saved! Disconnect the CSM!"))
                {
                    //Actualizar los datos finales de la calibración del CSM
                    cn.abrir();
                    SqlCommand cmd = new SqlCommand("update CSM set [Fecha Final 1] = @fechaFinal, [Hora Final 1] = @horaFinal,[Calibración 1] = @Calibracion, [Bracket 1]= @Desviacion, Estado = @Estado   where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                    cmd.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);
                    cmd.Parameters.AddWithValue("@fechaFinal", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@horaFinal", DateTime.Now.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Calibracion", Calibracion1);
                    cmd.Parameters.AddWithValue("@Desviacion", Desviacion);
                    cmd.Parameters.AddWithValue("@Estado", "Completado");

                    cmd.ExecuteNonQuery();
                    cn.cerrar();


                    Mensaje = "La calibración fue un exito, desconecte el cable del CSM";
                    RestablecerControles();
                    decoCalibracion = true;
                    RegresoInicio();
                    btnCargarCSM.Visible = true;
                }


                numeroLinea++;
            }

            ActualizarDatos();  //Actualiza la información de error humano y Estado

            //Enviar mensaje a mostrar
            if (Mensaje != "")
            {
                MensajeError(Mensaje);
                //MessageBox.Show(Mensaje);
            }

        }

        private void DecodificadorLeerCSM()
        {

            int numeroLinea = 1;

            foreach (string linea in textBox1.Lines)
            {
                //Obtiene el número de serie 
                if (linea.Contains("Serial number:"))
                {
                    int inicio = linea.IndexOf(":") + 2;
                    NumeroSerie = linea.Substring(inicio, linea.Length - inicio);

                }

              
            


           numeroLinea++;
            }


        }


        //Decodifica los mensajes generados en el textbox de ingles al español al inicio de la calibración
        private void DecodificadorInicial()
        {
            int numeroLinea = 1;
            string Mensaje = "";
            bool CrearCSM = false;


            foreach (string linea in textBox1.Lines)
            {
                //Obtiene el número de serie 
                if (linea.Contains("Serial number:"))
                {
                    int inicio = linea.IndexOf(":") + 2;
                    NumeroSerie = linea.Substring(inicio, linea.Length - inicio);
                    CrearCSM = true;


                }

                if (linea == "Place CSM with LED side up and press Enter!")
                {
                    
                    pic1.Image = Properties.Resources.Picture2;
                    lblInstruccion.Text = "Coloque en posición hacia arriba el CSM";
                    //Mensaje = "Coloque CSM en posición hacia Arriba";
                    Mensaje = "Inicio del proceso de calibración.";
                }


                numeroLinea++;
            }
            cn.cerrar();
            //Verificar si se completo y detiene el seguimiento de la macro
            cn.abrir();
            SqlCommand cmd3 = new SqlCommand("select Estado from CSM where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
            cmd3.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);
           
            
            SqlDataReader leer1;
            string TipoEstado = "";
            leer1 = cmd3.ExecuteReader();

            if (leer1.Read() == true)
            {
                TipoEstado = leer1.GetString(0);

            }



            leer1.Close();
            cn.cerrar();




            if (TipoEstado == "Completado")
            {
                //RestablecerControles();
                btnCalibracion.Visible = false;
                return;
            }

            if (Mensaje != "")
            {


                if (CrearCSM == true)
                {



                    //CrearCSM = false;
                    //Busca si hay numero de serie ya creado
                    cn.abrir();
                    SqlCommand cmd1 = new SqlCommand("select COUNT(*) from CSM where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                    cmd1.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);

                    int conteo = Convert.ToInt32(cmd1.ExecuteScalar());
                    cn.cerrar();
                    //Si no esta creado se procede a crear uno nuevo con un insert
                    if (conteo == 0)
                    {


                        cn.abrir();
                        SqlCommand cmd = new SqlCommand("INSERT Into CSM ([Usuario Calibración],[Número de serie],[Número de parte],Descripción,[Fecha Ingreso 1],[Hora ingreso 1],[Error Humano],Estado) values (@Usuario,@NumeroSerie,@NumeroParte,@Descripcion,@fechaIngreso,@horaIngreso,@ErrorHumano,@Estado)", cn.conectarBD);
                        cmd.Parameters.AddWithValue("@Usuario", Common.ActiveUser.firstName + " " + Common.ActiveUser.lastName);
                        cmd.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);
                        cmd.Parameters.AddWithValue("@NumeroParte", NumeroParte);
                        cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                        cmd.Parameters.AddWithValue("@fechaIngreso", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@horaIngreso", DateTime.Now.ToString("HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@ErrorHumano", 5);
                        cmd.Parameters.AddWithValue("@Estado", "Pendiente Calibración");


                        cmd.ExecuteNonQuery();
                        cn.cerrar();
                    }

                    //Si esta creado se verifica si se completo
                    else
                    {
                        //Verificar los errores humanos
                        cn.abrir();
                        SqlCommand cmd = new SqlCommand("select [Error Humano] from CSM where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                        cmd.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);

                        int conteoErrores = Convert.ToInt32(cmd.ExecuteScalar());
                        cn.cerrar();

                        //Actualiza la información del CSM
                        SqlCommand cmd5 = new SqlCommand("update CSM set  Estado = @Estado where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                       



                        if (conteoErrores == 0 & TipoEstado!="Completado")
                        {
                            cn.abrir();
                            cmd5.Parameters.AddWithValue("@Estado", "Retrabajo");

                            cmd5.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);
                        
                            cmd5.ExecuteNonQuery();

                            cn.cerrar();

                            MensajeError("Este CSM no se puede continuar calibrando, se cometieron los 5 errores permitidos, ahora se encuentra en retrabajo.");
                            //MessageBox.Show("Este CSM no se puede continuar calibrando, se cometieron los 5 errores permitidos, ahora se encuentra en retrabajo.");

                            ActualizarDatos();
                            RestablecerControles();

                            return;
                        }




                        //Se verfica si podemos calibrar o se rechaza la solicitud
                        cn.abrir();
                        SqlCommand cmd2 = new SqlCommand("select COUNT([Fecha Final 1]) from CSM where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                        cmd2.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);

                        int conteo2 = Convert.ToInt32(cmd2.ExecuteScalar());
                        cn.cerrar();
                        //Si no esta completado, se procede a completar
                        if (conteo2 == 0)
                        {
                            MensajeError("Este CSM quedo incompleto, comenzado nuevamente la calibración.");
                            //MessageBox.Show("Este CSM quedo incompleto, comenzado nuevamente la calibración");
                        }

                        //Si se completo, se procede a rechazar la solicitud
                        else
                        {
                            MensajeError("No se puede proceder con la calibración, este producto ya fue calibrado anteriormente.");
                            //MessageBox.Show("No se puede proceder con la calibración, este producto ya fue calibrado anteriormente");
                            RestablecerControles();
                            return;
                        }


                    }


                }

                ActualizarDatos();

                MensajeError(Mensaje);

                pic1.Visible = true;
                lblInstruccion.Visible = true;
                btnEnPosicion.Visible = true;

                //MessageBox.Show(Mensaje);
            }

        }

        private void DecodificadorRetrabajo()
        {
            int numeroLinea = 1;
            string Mensaje = "";

           

                //Verificar si se completo y detiene el seguimiento de la macro
            cn.abrir();
            SqlCommand cmd3 = new SqlCommand("select Estado from CSM where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
            cmd3.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);


            SqlDataReader leer1;
            string TipoEstado = "";
            leer1 = cmd3.ExecuteReader();

            if (leer1.Read() == true)
            {
                TipoEstado = leer1.GetString(0);

            }



            leer1.Close();
            cn.cerrar();




            if (TipoEstado == "Completado")
            {
                
                btnCalibracion.Visible = true;
                pic1.Visible = false;
                btnEnPosicion.Visible = false;
                lblInstruccion.Visible = false;
                return;
            }



            foreach (string linea in textBox1.Lines)
            {
                //Indica la posición del CSM
                if (linea == "Place CSM with LED side up and press Enter!")
                {

                    pic1.Image = Properties.Resources.Picture2;
                    lblInstruccion.Text = "Coloque en posición hacia arriba el CSM";
                    // Mensaje = "Coloque CSM en posición hacia Arriba";
                }

                else if (linea == "Place CSM with flat side down and press Enter!")
                {
                    pic1.Image = Properties.Resources.Picture3;
                    lblInstruccion.Text = "Coloque en posición hacia abajo el CSM";

                    // Mensaje = "Coloque el CSM en posición hacia abajo";
                }

                else if (linea == "Place CSM in orientation the reference bracket and press Enter!")
                {
                    pic1.Image = Properties.Resources.Picture1;
                    lblInstruccion.Text = "Coloque el CSM en el bracket";
                    //Mensaje = "Coloque el CSM de lado";
                }


                //Almacenar valores de la calibración
                if (linea.Contains("Calibration:"))
                {


                    int inicio = linea.IndexOf("[");

                    try
                    {
                        int final = linea.IndexOf("]", inicio);
                        Calibracion1 = linea.Substring(inicio, final + 1 - inicio);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Exception caught.", e);
                    }




                }

                //Almacenar valores de la calibración
                if (linea.Contains("Deviation: ["))
                {


                    int inicio = linea.IndexOf("[") - 1;
                    int final = linea.IndexOf("]", inicio);

                    try
                    {
                        Desviacion = linea.Substring(inicio, final + 1 - inicio);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Exception caught.", e);
                    }






                }

             

                //En caso de fallo
                if (linea.Contains("CALIBRATION FAILED! PRESS ENTER TO CONTINUE!"))
                {
                    MensajeError("La calibración fallo, vuelva a repetir el proceso.");
                    //MessageBox.Show("La calibración fallo, vuelva a repetir el proceso");

                   

                    RestablecerControles();

                    

                }

                //En caso de que finalice sin problemas
                else if (linea.Contains("Calibration saved! Disconnect the CSM!"))
                {
                    //Actualizar los datos finales de la calibración del CSM
                    cn.abrir();
                    SqlCommand cmd = new SqlCommand("update CSM set [Fecha Final 2] = @fechaFinal, [Hora Final 2] = @horaFinal,[Calibración 2] = @Calibracion, [Bracket 2]= @Desviacion, Estado = @Estado   where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                    cmd.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);
                    cmd.Parameters.AddWithValue("@fechaFinal", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@horaFinal", DateTime.Now.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Calibracion", Calibracion1);
                    cmd.Parameters.AddWithValue("@Desviacion", Desviacion);
                    cmd.Parameters.AddWithValue("@Estado", "Completado");

                    cmd.ExecuteNonQuery();
                   // MessageBox.Show("Se actualizo" + NumeroSerie + "desviacion =" + Desviacion + " calibracion= " + Calibracion1); 
                    cn.cerrar();


                    Mensaje = "La calibración fue un exito, desconecte el cable del CSM";
                    RestablecerControles();
                   // decoCalibracion = true;
                    RegresoInicio();
                    btnCargarCSM.Visible = true;

                    ModoRetrabajo = false;
                    decoCalibracion = false;
                    decoLeerCSM = true;
                    sinConectarCSM = false;

                }


                numeroLinea++;
            }

            ActualizarDatos();  //Actualiza la información de error humano y Estado

            //Enviar mensaje a mostrar
            if (Mensaje != "")
            {
                MensajeError(Mensaje);
                //MessageBox.Show(Mensaje);
            }
        
        }

        //Restablece la configuración a sus valores iniciales al finalizar la calibración
        private void RestablecerControles()
        {
            lblInstruccion.Visible = false;
            pic1.Visible = false;
            btnEnPosicion.Visible = false;
            btnCalibracion.Visible = true;

            textBox1.Text = "";
            BtEscape();
            AccesoInterrupcion("");
            BtEscape();
            AccesoInterrupcion("");
            textBox1.Text = "";
            //NumeroSerie = "";
            Calibracion1 = "";
            btnCalibracion.Focus();
        }

        //Obtiene los valores de la calibración del CSM y los devuelve por referencia
        private void obtenerCaracteres(string cadena, ref int valor1, ref int valor2, ref int valor3)
        {
            int conteo = 1;


            char[] separador = new char[] { ' ', '[', ']' };

            string[] subs = cadena.Split(separador, StringSplitOptions.RemoveEmptyEntries);

            foreach (string sub in subs)
            {


                if (conteo == 2)
                {
                    valor1 = Int32.Parse(sub);
                    MensajeError(valor1.ToString());
                    //MessageBox.Show(valor1.ToString());
                }

                else if (conteo == 3)
                {
                    valor3 = Int32.Parse(sub);
                    MensajeError(valor2.ToString());
                    //MessageBox.Show(valor2.ToString());
                }

                else if (conteo == 4)
                {
                    valor3 = Int32.Parse(sub);
                    MensajeError(valor3.ToString());
                    //MessageBox.Show(valor3.ToString());
                }

                conteo++;
            }
        }

   

     

        







       

        //Evento click del boton btnConectar
        private void gunaGradientButton1_Click(object sender, EventArgs e)
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
                    btnRetrabajo.Visible = true;
                    btnConsola.Visible = true;
                    btnCargarCSM.Visible = true;

                    ModoRetrabajo = false;
                    decoCalibracion = false;
                    decoLeerCSM = true;
                    sinConectarCSM = false;
        



                }


            }

            else if (btnConectar.Text == "Desconectar")
            {

                Desconectar();

                btnConectar.Text = "Conectar";
                lblEstadoConexion.Text = "Estado : Desconectado";
                btnCargarCSM.Visible = false;
                btnRetrabajo.Visible = false;
                btnConsola.Visible = false;
                pic1.Visible = false;
                lblInstruccion.Visible = false;
                btnEnPosicion.Visible = false;

                RegresoInicio();

            }

            ModoRetrabajo = false; //Desactiva el modo retrabajo
            EsconderPanel();
        }

      

        private void btnCalibracion_Click_1(object sender, EventArgs e)
        {
            
            if (PuertoSerie.IsOpen == true)
            {
                NumeroParte = 71212730;
                Descripcion = "ISU, L-SERIES, ABIS CSM";

                BtEscape();

                PuertoSerie.DiscardOutBuffer();

                textBox1.Text = "";

                PuertoSerie.Write("calibrate");

                BtEnter();

                

                btnCalibracion.Visible = false;


                //Verificar si se completo y detiene el seguimiento de la macro
                cn.abrir();
                SqlCommand cmd3 = new SqlCommand("select Estado from CSM where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                cmd3.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);


                SqlDataReader leer1;
                string TipoEstado = "";
                leer1 = cmd3.ExecuteReader();

                if (leer1.Read() == true)
                {
                    TipoEstado = leer1.GetString(0);

                }



                leer1.Close();
                cn.cerrar();



                


                //Activa botones e imagenes si el modo retrabajo se encuentra activo
                if (ModoRetrabajo == true & TipoEstado != "Completado")
                {
                    pic1.Visible = true;
                    lblInstruccion.Visible = true;
                    btnEnPosicion.Visible = true;
                }

               
                decoCalibracion = true;
                tipoCalibracion = 0;


            }

            else
            {
                MensajeError("El puerto se desconecto, reinicie el programa y vuelta a intentar");
                //MessageBox.Show("El puerto se desconecto, reinicie el programa y vuelta a intentar");
            }
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            gunaCircleProgressBar1.Increment(1);

            if (gunaCircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                gunaCircleProgressBar1.Visible = false;

                //Verifica si el N/A esta habilitado

                if (NumeroSerie == "")
                {
                    MensajeError("No se encontro el dispositivo, verifique que haya algun CSM conectado");
                   // MessageBox.Show("No se encontro el dispositivo, verifique que haya algun CSM conectado");
                    
                }
                else 
                {    
                    NumeroParte = 71212730;
                    Descripcion = "ISU, L-SERIES, ABIS CSM";

                    lblNumeroSerie.Text = "Número de serie: " + NumeroSerie;

                    //Verificar los errores humanos y el estado del CSM en la base de datos
                    cn.abrir();
                    SqlCommand cmd = new SqlCommand("select [Error Humano],Estado from CSM where convert(char,[Número de serie]) = @NumeroSerie ", cn.conectarBD);
                    cmd.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);
                    SqlDataReader leer;
                    leer = cmd.ExecuteReader();
                   

                   
                    if (leer.Read() == true)
                    {   
                      

                        lblErrorHumano.Text = "Intentos restantes: " + leer.GetInt32(0);

                        lblEstado.Text = "Estado: " + leer.GetString(1); 

                       

                    }

                    else
                    {
                        lblEstado.Text = "Estado: Equipo Nuevo";
                        lblErrorHumano.Text = "Intentos restantes: 5";
                    }

                    btnCalibracion.Visible = true;
                    btnCargarCSM.Visible = false;
                    decoLeerCSM = false;

                    leer.Close();
                    cn.cerrar();

                    

                  

                }
                
            }


        }

       

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            if (PuertoSerie.IsOpen == true)
            {
                gunaCircleProgressBar1.Value = 0;
                gunaCircleProgressBar1.Visible = true;

                timer1.Start();

                BtEscape();

                PuertoSerie.DiscardOutBuffer();

                textBox1.Text = "";

                PuertoSerie.Write("sensor 0");

                BtEnter();

                sinConectarCSM = false;//Activa el modo actualizar puerto del CSM luego de haberse completado
                decoLeerCSM = true;    //Activo el modo decodificador inicial



            }

            else
            {
                MensajeError("El puerto se desconecto, reinicie el programa y vuelta a intentar");
                //MessageBox.Show("El puerto se desconecto, reinicie el programa y vuelta a intentar");
                return;
            }
        }

    

        private void gunaGradientButton2_Click_1(object sender, EventArgs e)
        {
            
            if (txtMostrarDatos.Visible == true)
            {
                txtMostrarDatos.Visible = false;
                txtEnviarDatos.Visible= false;
                textBox1.Visible = false;
                
                //panelConsola.Size = new System.Drawing.Size(246, 56); 
            }
            else
            {
                txtEnviarDatos.Visible = true;
                txtMostrarDatos.Visible = true;
                textBox1.Visible = true;
               
                //panelConsola.Size = new System.Drawing.Size(953, 484);
               

                

                //Form frm = new Consola();


                //frm.Show();
                


            }
        }

        

      

        //Actualizar los datos de la información erroresHumanos y Estado, el número de serie no se actualiza
        private void ActualizarDatos()
        {

      

            if (NumeroSerie == "")
            {
               
                

            }
            else
            {
                

                lblNumeroSerie.Text = "Número de serie: " + NumeroSerie;

                //Verificar los errores humanos y el estado del CSM en la base de datos
                cn.abrir();
                SqlCommand cmd = new SqlCommand("select [Error Humano],Estado from CSM where convert(char,[Número de serie]) = @NumeroSerie ", cn.conectarBD);
                cmd.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);
                SqlDataReader leer;
                leer = cmd.ExecuteReader();



                if (leer.Read() == true)
                {


                    lblErrorHumano.Text = "Intentos restantes: " + leer.GetInt32(0);

                    lblEstado.Text = "Estado: " + leer.GetString(1);

             

                }


                leer.Close();
                cn.cerrar();
            

            }

            //Port status: [KMISSING
            //Port status: [KUPDATING
            //Port status: [KREADY 
        }

        private void timerDesconectadoCSM_Tick(object sender, EventArgs e)
        {

            if (contadorCSMdesconectado == 5)
            {
                sinConectarCSM = false;
                timerDesconectadoCSM.Stop();
                contadorCSMdesconectado = 0;

                ActualizarDatos();

            }
            contadorCSMdesconectado ++;
        }

        private void gunaGradientButton1_Click_2(object sender, EventArgs e)
        {
            EsconderPanel();

           
            
            
            

        }
        private void MensajeError(string mensaje)
        {
            variableMensaje = mensaje;

            Form frm = new Mensajes();

            frm.ShowDialog();
        }

        private void btnRetrabajo_Click(object sender, EventArgs e)
        {
            Form frm = new Retrabajo();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.abrir();
        }

        private void btnEnPosicion_Click(object sender, EventArgs e)
        {
            if (tipoCalibracion == 0)
            {
                textBox1.Text = "";
                BtEnter();
             

                decoCalibracion = false;

            }

            else if (tipoCalibracion == 1)
            {
                textBox1.Text = "";
                BtEnter();
               

            }

            else if (tipoCalibracion == 2)
            {
                textBox1.Text = "";
                BtEnter();
                lblInstruccion.Text = "Coloque en posición hacia arriba el CSM";
                pic1.Image = Properties.Resources.Picture2;
                btnEnPosicion.Visible = false;
                pic1.Visible = false;
                lblInstruccion.Visible = false;
            }
            tipoCalibracion++;
        }

       

     

       
    }
}

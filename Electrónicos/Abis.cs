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
        bool decoCalibracion = false;
        bool decoLeerCSM = true;
        Conexion cn = new Conexion();

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
        private void txtEnviarDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                    MessageBox.Show(exc.Message.ToString());
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

                btnColocarArriba.Visible = true;

                btnCalibracion.Visible = false;

                btnColocarArriba.Focus();

                decoCalibracion = true;


            }

            else
            {
                MessageBox.Show("El puerto se desconecto, reinicie el programa y vuelta a intentar");
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

        private void btnLineas_Click(object sender, EventArgs e)
        {
            int v1, v2, v3;
            v1 = 0;
            v2 = 0;
            v3 = 0;
            string cadena = "Calibration: [-1245 -43 230]";
            obtenerCaracteres(cadena, ref v1, ref v2, ref v3);

            MessageBox.Show("Valores: " + v1 + " " + v2 + " " + v3);
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
                return;
            }

            textBox1.Text = textBox1.Text + bufferSalida;
            txtMostrarDatos.Text = txtMostrarDatos.Text + bufferSalida;

            Decodificador();

            /*
            //Mueve el scroll hasta el final de la linea
            txtMostrarDatos.Focus();
            txtMostrarDatos.SelectionStart = txtMostrarDatos.TextLength;
            txtMostrarDatos.ScrollToCaret();

            txtEnviarDatos.Focus();
            */



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
            PuertoSerie.Close();
            DesconectarActivado();
        }

        //Acciones que se ejecutaran cuando se este conectado al puerto serial
        private void ConectarActivado()
        {
            btnCalibracion.Visible = true;
            btnRetrabajo.Visible = true;
        }

        //Acciones que se ejecutaran cuando se este desconectado al puerto serial
        private void DesconectarActivado()
        {
            btnCalibracion.Visible = false;
            btnRetrabajo.Visible = false;
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
            lblResgistros.Visible = false;
            dataGridView1.Visible = false;
            txtMostrar.Visible = false;
            label3.Visible = false;
            btnCalibracion.Visible = false;
            btnRetrabajo.Visible = false;
            btnColocarAbajo.Visible = false;
            btnColocarArriba.Visible = false;
            btnColocarLado.Visible = false;
            btnCargarCSM.Visible = false;

       

            lblNumeroSerie.Text = "Número de serie: N/A";
            lblErrorHumano.Text = "Intentos restantes: N/A";
        }

        //Decodifica los mensajes generados en el textbox de ingles al español
        private void Decodificador()
        {
            int numeroLinea = 1;
            string Mensaje = "";

            if (decoCalibracion == true)
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
                    // Mensaje = "Coloque CSM en posición hacia Arriba";
                }

                else if (linea == "Place CSM with flat side down and press Enter!")
                {
                    // Mensaje = "Coloque el CSM en posición hacia abajo";
                }

                else if (linea == "Place CSM in orientation the reference bracket and press Enter!")
                {
                    //Mensaje = "Coloque el CSM de lado";
                }


                //Almacenar valores de la calibración
                if (linea.Contains("Calibration:"))
                {


                    int inicio = linea.IndexOf("[");
                    int final = linea.IndexOf("]", inicio);

                    Calibracion1 = linea.Substring(inicio, final + 1 - inicio);

                }

                //Almacenar valores de la calibración
                if (linea.Contains("Deviation: ["))
                {


                    int inicio = linea.IndexOf("[") - 1;
                    int final = linea.IndexOf("]", inicio);

                    Desviacion = linea.Substring(inicio, final + 1 - inicio);

                  



                }

                //En caso de fallo
                if (linea.Contains("CALIBRATION FAILED! PRESS ENTER TO CONTINUE!"))
                {
                    MessageBox.Show("La calibración fallo, vuelva a repetir el proceso");


                    //Verificar los errores humanos
                    cn.abrir();
                    SqlCommand cmd = new SqlCommand("select [Error Humano] from CSM where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                    cmd.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);

                    int conteoErrores = Convert.ToInt32(cmd.ExecuteScalar());
                    cn.cerrar();

                    if (conteoErrores == 0)
                    {
                        MessageBox.Show("No se permiten mas intentos");
                    }
                    else if (conteoErrores >= 1)
                    {
                        conteoErrores = conteoErrores - 1;
                        cn.abrir();
                        SqlCommand cmd1 = new SqlCommand("update CSM set [Error Humano] = @ErrorHumano where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                        cmd1.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);
                        cmd1.Parameters.AddWithValue("@ErrorHumano", conteoErrores);
                        cmd1.ExecuteNonQuery();
                        cn.cerrar();
                        MessageBox.Show("Se resto 1 al contador de errores");

                    }






                    RestablecerControles();
                }

                //En caso de que finalice sin problemas
                else if (linea.Contains("Calibration saved! Disconnect the CSM!"))
                {
                    //Actualizar los datos finales de la calibración del CSM
                    cn.abrir();
                    SqlCommand cmd = new SqlCommand("update CSM set [Fecha Final 1] = @fechaFinal, [Hora Final 1] = @horaFinal,[Calibración 1] = @Calibracion, [Bracket 1]= @Desviacion   where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                    cmd.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);
                    cmd.Parameters.AddWithValue("@fechaFinal", DateTime.Now.ToString("dd/MM/yyyy"));
                    cmd.Parameters.AddWithValue("@horaFinal", DateTime.Now.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Calibracion", Calibracion1);
                    cmd.Parameters.AddWithValue("@Desviacion", Desviacion);

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

            //Enviar mensaje a mostrar
            if (Mensaje != "")
            {
                MessageBox.Show(Mensaje);
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
                    //Mensaje = "Coloque CSM en posición hacia Arriba";
                    Mensaje = "Inicio del proceso de calibración";
                }


                numeroLinea++;
            }


            if (Mensaje != "")
            {
               

                if (CrearCSM == true)
                {



                    CrearCSM = false;
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
                        SqlCommand cmd = new SqlCommand("INSERT Into CSM ([Usuario Calibración],[Número de serie],[Número de parte],Descripción,[Fecha Ingreso 1],[Hora ingreso 1],[Error Humano]) values (@Usuario,@NumeroSerie,@NumeroParte,@Descripcion,@fechaIngreso,@horaIngreso,@ErrorHumano)", cn.conectarBD);
                        cmd.Parameters.AddWithValue("@Usuario", "Miguel Alvarado");
                        cmd.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);
                        cmd.Parameters.AddWithValue("@NumeroParte", NumeroParte);
                        cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                        cmd.Parameters.AddWithValue("@fechaIngreso", DateTime.Now.ToString("dd/MM/yyyy"));
                        cmd.Parameters.AddWithValue("@horaIngreso", DateTime.Now.ToString("HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@ErrorHumano", 5);

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

                        if (conteoErrores == 0)
                        {
                            MessageBox.Show("Este CSM no se puede continuar calibrando, se cometieron los 5 errores permitidos, ahora se encuentra en retrabajo.");
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
                            MessageBox.Show("Este CSM quedo incompleto, comenzado nuevamente la calibración");
                        }

                        //Si se completo, se procede a rechazar la solicitud
                        else
                        {
                            MessageBox.Show("No se puede proceder con la calibración, este producto ya fue calibrado anteriormente");
                            RestablecerControles();
                            return;
                        }
        

                    }
           

                }

                MessageBox.Show(Mensaje);
            }

        }

        //Restablece la configuración a sus valores iniciales al finalizar la calibración
        private void RestablecerControles()
        {
            btnColocarArriba.Visible = false;
            btnColocarAbajo.Visible = false;
            btnColocarLado.Visible = false;
            btnCalibracion.Visible = true;

            textBox1.Text = "";
            BtEscape();
            AccesoInterrupcion("");
            BtEscape();
            AccesoInterrupcion("");
            textBox1.Text = "";
            NumeroSerie = "";
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
                    MessageBox.Show(valor1.ToString());
                }

                else if (conteo == 3)
                {
                    valor3 = Int32.Parse(sub);
                    MessageBox.Show(valor2.ToString());
                }

                else if (conteo == 4)
                {
                    valor3 = Int32.Parse(sub);
                    MessageBox.Show(valor3.ToString());
                }

                conteo++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.abrir();

            SqlCommand cmd = new SqlCommand("INSERT Into CSM ([Número de parte],[Usuario Calibración],[Número de serie]) values (71212775,'Miguel Alvarado','03599');", cn.conectarBD);
            cmd.ExecuteNonQuery();
            cn.cerrar();
            MessageBox.Show("Completado con exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.abrir();
            SqlCommand cmd = new SqlCommand("update CSM set [Número de serie] = @NumeroSerie where id = 1;", cn.conectarBD);
            cmd.Parameters.AddWithValue("@NumeroSerie", "12345");
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            cn.cerrar();
            MessageBox.Show("Actualizado con exito");
        }

        public void button3_Click(object sender, EventArgs e)
        {
            /*
            cn.abrir();
            SqlCommand cmd1 = new SqlCommand("select Error from CSM where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
            cmd1.Parameters.AddWithValue("@NumeroSerie", "03598");

            int conteo = Convert.ToInt32(cmd1.ExecuteScalar());

            if (conteo == 0)
            {
                MessageBox.Show("NO existe");
            }
            else
            {
                MessageBox.Show("existe");

            }



            cn.cerrar();
            */

            //Actualizar el contador de errores humanos
            cn.abrir();
            SqlCommand cmd = new SqlCommand("select [Error Humano] from CSM where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
            cmd.Parameters.AddWithValue("@NumeroSerie", "03407");


            int conteo = Convert.ToInt32(cmd.ExecuteScalar());

            if (conteo == 0)
            {
                MessageBox.Show("No se permiten mas intentos");
            }
            else if (conteo >= 1)
            {
                MessageBox.Show("Aun puede continuar intentando");

            }
           
            cn.cerrar();


        }

       

      

       

        private void gunaGradientCircleButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            BtEnter();
            btnColocarAbajo.Visible = true;
            btnColocarArriba.Visible = false;
            btnColocarAbajo.Focus();

            decoCalibracion = false;
        }

        private void gunaGradientCircleButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            BtEnter();
            btnColocarLado.Visible = true;
            btnColocarAbajo.Visible = false;
            btnColocarLado.Focus();
        }

        private void gunaGradientCircleButton3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            BtEnter();
            btnColocarLado.Visible = false;
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
                    btnCargarCSM.Visible = true;

                }


            }

            else if (btnConectar.Text == "Desconectar")
            {

                Desconectar();

                btnConectar.Text = "Conectar";
                lblEstadoConexion.Text = "Estado : Desconectado";
                btnCargarCSM.Visible = false;
                RegresoInicio();

            }

            EsconderPanel();
        }

        private void gunaGradientCircleButton1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

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

                btnColocarArriba.Visible = true;

                btnCalibracion.Visible = false;
                btnRetrabajo.Visible = false;

                btnColocarArriba.Focus();

                decoCalibracion = true;


            }

            else
            {
                MessageBox.Show("El puerto se desconecto, reinicie el programa y vuelta a intentar");
            }
        }

        private void txtEnviarDatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gunaCircleProgressBar1.Increment(1);

            if (gunaCircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                NumeroParte = 71212730;
                Descripcion = "ISU, L-SERIES, ABIS CSM";
                
                lblNumeroSerie.Text = "Número de serie: " + NumeroSerie;

                //Verificar los errores humanos
                cn.abrir();
                SqlCommand cmd = new SqlCommand("select [Error Humano] from CSM where convert(char,[Número de serie]) = @NumeroSerie", cn.conectarBD);
                cmd.Parameters.AddWithValue("@NumeroSerie", NumeroSerie);

                int conteoErrores = Convert.ToInt32(cmd.ExecuteScalar());
                cn.cerrar();

                lblErrorHumano.Text = "Intentos restantes: " + conteoErrores;

                gunaCircleProgressBar1.Visible = false;
                btnCalibracion.Visible = true;
                btnRetrabajo.Visible = true;
                btnCargarCSM.Visible = false;
                decoLeerCSM = false;

            }
            
            
        }

        private void gunaGradientButton1_Click_1(object sender, EventArgs e)
        {
            if (panelInformacion.Visible == true)
            {
                panelInformacion.Visible = false;
            }

            else
            {
                panelInformacion.Visible = true;
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


                decoLeerCSM = true;    //Activo el modo decodificador inicial



            }

            else
            {
                MessageBox.Show("El puerto se desconecto, reinicie el programa y vuelta a intentar");
                return;
            }
        }

        private void btnRetrabajo_Click(object sender, EventArgs e)
        {
            cn.abrir();
            SqlCommand cmd = new SqlCommand("select top " + txtMostrar.Text +" * from CSM", cn.conectarBD);                     
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].Visible = false;
            txtMostrar.Visible = true;
            label3.Visible = true;
            dataGridView1.Visible = true;
            lblResgistros.Visible = true;

            lblResgistros.Text = "Cantidad de registros: " + dataGridView1.Rows.Count.ToString();
            cn.cerrar();

          
            
            
            
            
        }

       
    }
}

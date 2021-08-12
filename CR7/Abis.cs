using System;
using System.IO.Ports;
using System.Windows.Forms;

/*
 * Autor:  Miguel Alvarado
 * Título: Programador de CSM del proyecto Abis 
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

        //Recibe la información del buffer y la muestra en textbox
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

        private void AccesoInterrupcion(string accion)
        {
            DelegadoAcceso Var_DelegadoAcceso;
            Var_DelegadoAcceso = new DelegadoAcceso(RecoleccionDatos);
            object[] arg = { accion };
            base.Invoke(Var_DelegadoAcceso, arg);


        }
        

        private void Abis_Load(object sender, EventArgs e)
        {
            BufferEntrada = "";
            BufferSalida = "";
            btnConectar.Enabled = false;
            

        }

      

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConectar.Text == "Conectar")
                {
                    serialPort1.BaudRate = 115200;
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.PortName = cboPuertos.Text;

                    try
                    {
                        serialPort1.Open();
                        btnConectar.Text = "Desconectar";
                        

                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.Message.ToString());
                        throw;
                    }

                
                }
                else if (btnConectar.Text == "Desconectar")
                {
                    serialPort1.Close();
                    btnConectar.Text = "Conectar";
                    
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }


        private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)
        {
            AccesoInterrupcion(serialPort1.ReadExisting());           
      
           
        }

       

        

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

       private void BuscarPuertos()
        {
            string[] PuertosDisponibles = SerialPort.GetPortNames();

            cboPuertos.Items.Clear();

            foreach (string puerto_simple in PuertosDisponibles)
            {
                cboPuertos.Items.Add(puerto_simple);
            }

            if (cboPuertos.Items.Count > 0)
            {
                cboPuertos.SelectedIndex = 0;
                //MessageBox.Show("Seleccionar puerto de trabajo");
                btnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ningun puerto detectado");
                cboPuertos.Items.Clear();
                cboPuertos.Text = "                   ";
                BufferEntrada = "";
                BufferSalida = "";
                btnConectar.Enabled = false;



            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;


namespace CR7
{
    public partial class Abis : Form
    {
        private delegate void DelegadoAcceso(string accion);
        private string strBufferIn;
        private string strbufferOut;


        public Abis()
        {
            InitializeComponent();
        }

        private void AccesoForm(string accion)
        {
            strBufferIn = accion;



            txtDatosRecibidos.Text = strBufferIn;

        }

        private void AccesoInterrupcion(string accion)
        {
            DelegadoAcceso Var_DelegadoAcceso;
            Var_DelegadoAcceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { accion };
            base.Invoke(Var_DelegadoAcceso, arg);


        }
        

        private void Abis_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strbufferOut = "";
            btnConectar.Enabled = false;
            btnEnviarDatos.Enabled = false;

        }

        private void btnBuscaPuerto_Click(object sender, EventArgs e)
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
                strBufferIn = "";
                strbufferOut = "";
                btnConectar.Enabled = false;
                btnEnviarDatos.Enabled = false;


            }

            cboPuertos.SelectedIndex = 1;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConectar.Text == "Conectar")
                {
                    serialPort1.BaudRate = Int32.Parse(cboBaudRate.Text);
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.PortName = cboPuertos.Text;

                    try
                    {
                        serialPort1.Open();
                        btnConectar.Text = "Desconectar";
                        btnEnviarDatos.Enabled = true;

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
                    btnEnviarDatos.Enabled = true;
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void btnEnviarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.DiscardOutBuffer();
                strbufferOut = txtDatosAEnviar.Text;
                serialPort1.Write(strbufferOut);
                serialPort1.Write(new byte[] { 13, 10 }, 0, 2);
                // serialPort1.Write("\r\n");

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

        private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)
        {
            AccesoInterrupcion(serialPort1.ReadExisting());
            
            /*string Data_in = serialPort1.ReadExisting();
            MessageBox.Show(Data_in);
            txtDatosRecibidos.Text = Data_in;*/
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write(new byte[] { 27, 10 }, 0, 2);
            serialPort1.Write(new byte[] { 13, 10 }, 0, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write(new byte[] { 27, 10 }, 0, 2);
        }
    }
}

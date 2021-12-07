﻿using System;
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

            textBox1.Text = textBox1.Text + bufferSalida;
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
                textBox1.Visible = false;


            }
        }

        private void txtEnviarDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodoClick(sender, e);
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
                textBox1.Visible = true;
            }

            else {
                txtMostrarDatos.Visible = false;
                txtEnviarDatos.Visible = false;
                textBox1.Visible = false;
            }
            
        }

        private void Jupiter_Load(object sender, EventArgs e)
        {

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
//Programa interfaz del plc
//Autor: Miguel Alvarado

namespace Tank_Farm
{

    public partial class Niveles : Form
    {
       

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void TXTALTURA_TextChanged(object sender, EventArgs e)
        {

        }
        private void TXTY_TextChanged(object sender, EventArgs e)
        {

        }
        private void picEtyl_Click(object sender, EventArgs e)
        {

        }

        //Declaracion de variables
        public Plc plc = null;
        private string ip;
        private int rack, slot;
        private int segundos = 20;
        public int alturatotal, ancho, ancho2, x1, x2, x3, x4, y1, y2, y3, y4,h1,h2,h3,h4,PosicionY, AlturaH;

        //Masa de tanques
        float masaAcetona = 39235.07019f;
        float masaMEK = 39830.44303f;
        float masaNPropanol = 39770.90575f;
        float masaEtyl = 44593.42576f;



        //Direcciones de Peso        
        string direcEtyl = "MD168", direcAcetone = "MD172", direclNPropanol = "MD176", direcMEK = "MD180";

        private void porcentajeAcetona_TextChanged(object sender, EventArgs e)
        {
            //y2 = ActualizarGraficoPosicion(float.Parse(porcentajeAcetona.Text), h2, y2);
            //h2 = ActualizarGrafico(float.Parse(porcentajeAcetona.Text), h2, y2);

            //this.Refresh();
        }

        private void porcentajeNPropanol_TextChanged(object sender, EventArgs e)
        {
            //y3 = ActualizarGraficoPosicion(float.Parse(porcentajeNPropanol.Text), h3, y3);
            //h3 = ActualizarGrafico(float.Parse(porcentajeNPropanol.Text), h3, y3);

            //this.Refresh();
        }

        private void porcentajeMEK_TextChanged(object sender, EventArgs e)
        {
            //y3 = ActualizarGraficoPosicion(float.Parse(porcentajeMEK.Text), h4, y4);
            //h4 = ActualizarGrafico(float.Parse(porcentajeMEK.Text), h4, y4);

            //this.Refresh();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            y1 = 30;
            h1 = 216;
            AlturaH = ActualizarGrafico(float.Parse(porcentajeAcetato.Text), h1, y1);
            PosicionY = ActualizarGraficoPosicion(float.Parse(porcentajeAcetato.Text), h1, y1);
            h1 = AlturaH;
            y1 = PosicionY;

            y2 = 30;
            h2 = 216;
            AlturaH = ActualizarGrafico(float.Parse(porcentajeAcetona.Text), h2, y2);
            PosicionY = ActualizarGraficoPosicion(float.Parse(porcentajeAcetona.Text), h2, y2);
            h2 = AlturaH;
            y2 = PosicionY;

            y3 = 30;
            h3 = 216;
            AlturaH = ActualizarGrafico(float.Parse(porcentajeNPropanol.Text), h3, y3);
            PosicionY = ActualizarGraficoPosicion(float.Parse(porcentajeNPropanol.Text), h3, y3);
            h3 = AlturaH;
            y3 = PosicionY;

            y4 = 30;
            h4 = 216;
            AlturaH = ActualizarGrafico(float.Parse(porcentajeMEK.Text), h4, y4);
            PosicionY = ActualizarGraficoPosicion(float.Parse(porcentajeMEK.Text), h4, y4);
            h4 = AlturaH;
            y4 = PosicionY;



            this.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         

        }

        //Acetato de etilo cambia
        private void porcentajeAcetato_TextChanged(object sender, EventArgs e)
        {
       

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           

        }



        public Niveles()
        {
            InitializeComponent();
        }

        //Carga al inicio del proyecto variables o funciones
        private void Niveles_Load(object sender, EventArgs e)
        {
           

            
            alturatotal = 216;
            ancho = 160;
            ancho2 = 200;




            Conectar();

           
            timer1.Enabled = true;
            timer1.Start();

            x1 = 20;
            x2 = 220;
            x3 = 420;
            x4 = 620;
           
            y1 = 30;
            h1 = 216;

            y2 = 30;
            h2 = 216;

            y3 = 30;
            h3 = 216;

            y4 = 30;
            h4 = 216;
            ActualizarInterfaz();
        }

        //Pinta en el panel los tanques
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;







            g.FillRectangle(Brushes.WhiteSmoke, new Rectangle(20, 30, ancho, 216));
            g.FillRectangle(Brushes.WhiteSmoke, new Rectangle(220, 30, ancho, 216));
            g.FillRectangle(Brushes.WhiteSmoke, new Rectangle(420, 30, ancho, 216));
            g.FillRectangle(Brushes.WhiteSmoke, new Rectangle(620, 30, ancho, 216));

            g.FillRectangle(Brushes.DarkOliveGreen, new Rectangle(x1, y1, ancho, h1));
            g.FillRectangle(Brushes.DarkOliveGreen, new Rectangle(x2, y2, ancho, h2));
            g.FillRectangle(Brushes.DarkOliveGreen, new Rectangle(x3, y3, ancho, h3));
            g.FillRectangle(Brushes.DarkOliveGreen, new Rectangle(x4, y4, ancho, h4));




            g.DrawRectangle(Pens.Black, new Rectangle(20, 30, ancho, 216));
            g.DrawRectangle(Pens.Black, new Rectangle(220, 30, ancho, 216));
            g.DrawRectangle(Pens.Black, new Rectangle(420, 30, ancho, 216));
            g.DrawRectangle(Pens.Black, new Rectangle(620, 30, ancho, 216));
        }



        //Boton para realizar la reconexion cuando se desconecte la conexion
        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conectar();
        }

        //Boton actualizar niveles
        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarInterfaz();



        }

        //Realiza la conexion al PLC
        private void Conectar()
        {

            try
            {

                ip = "10.164.104.210";
                rack = 0;
                slot = 0;
                CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), "S71200");

                plc = new Plc(cpu, ip, Convert.ToInt16(rack), Convert.ToInt16(slot));

                plc.Open();

                if (plc.IsConnected)
                {
                    Estado.Text = "Conectado";
                    btnConectar.Visible = false;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No se logro conectar al PLC con la ip " + ip);
                Estado.Text = "Desconectado";
                btnConectar.Visible = true;
            }

        }

        //Timer para actualizar información
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (segundos == 0)
            {
                ActualizarInterfaz();
                segundos = 20;

            }
            label8.Text = "El sistema se \nactualizara en: " + segundos.ToString();
            segundos = segundos - 1;

        }


        //Funcion para cargar las direcciones del PLC
        private float CargarDireccion(string direccion)
        {

            float dato;
            //string direccion = "MD168";
            object resultado = plc.Read(direccion);
            string varString = string.Format("{0}", resultado.ToString());
            int b = Convert.ToInt32(varString);
            //Segundo convertirla a byte
            byte[] bytes = BitConverter.GetBytes(b);

            //Tercero pasarla a float
            dato = BitConverter.ToSingle(bytes, 0);



            return dato;

        }

        //Funcion para cerrar aplicacion cuando se cierra el form
        private void Niveles_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }


    







        //Desconecta la conexion al PLC
        private void Desconectar()
        {
            plc.Close();
            Estado.Text = "Desconectado";
        }

        //Cargar imagenes
        private void CargaImagen(float Peso, float maxMasa, string Solvente)
        {
            PictureBox imagen;
            if (Solvente == "Acetona") { imagen = picAcetone; }
            else if (Solvente == "Etyl") { imagen = picEtyl; }
            else if (Solvente == "MEK") { imagen = picMEK; }
            else if (Solvente == "N-Propanol") { imagen = picNPropanol; }
            else { imagen = picAcetone; }
            float porce;
            porce = Peso * 100 / maxMasa;
            if (porce <= 0)
            {
                imagen.Image = Tank_Farm.Properties.Resources.Vacio;
            }

            else if (porce >= 0.00001 && porce <= 10) { imagen.Image = Tank_Farm.Properties.Resources._10; }

            else if (porce >= 10.00001 && porce <= 20) { imagen.Image = Tank_Farm.Properties.Resources._20; }

            else if (porce >= 20.00001 && porce <= 30) { imagen.Image = Tank_Farm.Properties.Resources._30; }

            else if (porce >= 30.00001 && porce <= 40) { imagen.Image = Tank_Farm.Properties.Resources._40; }

            else if (porce >= 40.00001 && porce <= 50) { imagen.Image = Tank_Farm.Properties.Resources._50; }

            else if (porce >= 50.00001 && porce <= 60) { imagen.Image = Tank_Farm.Properties.Resources._60; }

            else if (porce >= 60.00001 && porce <= 70) { imagen.Image = Tank_Farm.Properties.Resources._70; }

            else if (porce >= 70.00001 && porce <= 80) { imagen.Image = Tank_Farm.Properties.Resources._80; }

            else if (porce >= 80.00001 && porce <= 90) { imagen.Image = Tank_Farm.Properties.Resources._90; }

            else if (porce >= 90.00001) { imagen.Image = Tank_Farm.Properties.Resources._100_1; }




        }

        //Calcula porcentaje de cilindro
        private void CalculaPorcentaje(TextBox txtPeso, float maxMasa, TextBox txtbox)
        {
            float porcentaje = 0;


            porcentaje = float.Parse(txtPeso.Text) * 100 / maxMasa;

            txtbox.Text = porcentaje.ToString("#.##") ;
        }

        //Actualiza los datos para ser mostrados
        void ActualizarInterfaz()
        {

            txtnivelAcetona.Text = CargarDireccion(direcAcetone).ToString();
            txtnivelMEK.Text = CargarDireccion(direcMEK).ToString();
            txtnivelNPropanol.Text = CargarDireccion(direclNPropanol).ToString();
            txtnivelEtyl.Text = CargarDireccion(direcEtyl).ToString();

            //CargaImagen(float.Parse(txtnivelAcetona.Text), masaAcetona, "Acetona");
            //CargaImagen(float.Parse(txtnivelEtyl.Text), masaEtyl, "Etyl");
            //CargaImagen(float.Parse(txtnivelMEK.Text), masaMEK, "MEK");
            //CargaImagen(float.Parse(txtnivelNPropanol.Text), masaNPropanol, "N-Propanol");
            CalculaPorcentaje(txtnivelAcetona, masaAcetona, porcentajeAcetona);
            CalculaPorcentaje(txtnivelEtyl, masaEtyl, porcentajeAcetato);
            CalculaPorcentaje(txtnivelMEK, masaMEK, porcentajeMEK);
            CalculaPorcentaje(txtnivelNPropanol, masaNPropanol, porcentajeNPropanol);

            segundos = 20;

            y1 = 30;
            h1 = 216;
            AlturaH = ActualizarGrafico(float.Parse(porcentajeAcetato.Text), h1, y1);
            PosicionY = ActualizarGraficoPosicion(float.Parse(porcentajeAcetato.Text), h1, y1);
            h1 = AlturaH;
            y1 = PosicionY;

            y2 = 30;
            h2 = 216;
            AlturaH = ActualizarGrafico(float.Parse(porcentajeAcetona.Text), h2, y2);
            PosicionY = ActualizarGraficoPosicion(float.Parse(porcentajeAcetona.Text), h2, y2);
            h2 = AlturaH;
            y2 = PosicionY;

            y3 = 30;
            h3 = 216;
            AlturaH = ActualizarGrafico(float.Parse(porcentajeNPropanol.Text), h3, y3);
            PosicionY = ActualizarGraficoPosicion(float.Parse(porcentajeNPropanol.Text), h3, y3);
            h3 = AlturaH;
            y3 = PosicionY;

            y4 = 30;
            h4 = 216;
            AlturaH = ActualizarGrafico(float.Parse(porcentajeMEK.Text), h4, y4);
            PosicionY = ActualizarGraficoPosicion(float.Parse(porcentajeMEK.Text), h4, y4);
            h4 = AlturaH;
            y4 = PosicionY;



            this.Refresh();
        }

        //Conseguir altura
       int ActualizarGrafico(float porcentajeAltura,int valorAltura, int valorPosicion)
        {
            float alturap;
            alturap = (porcentajeAltura * alturatotal) / 100;
            Math.Round(alturap);
            double numeroDouble = alturap;

            int numeroEntero = Convert.ToInt32(Math.Floor(numeroDouble));
            

            while (valorAltura != numeroEntero)
            {
                if (valorAltura < numeroEntero)
                {
                    
                    valorPosicion = valorPosicion - 1;
                    valorAltura = valorAltura + 1;

                   
                  
                    
                }

                else if (valorAltura > numeroEntero)
                {
                    valorPosicion = valorPosicion + 1;
                    valorAltura = valorAltura - 1;
                 
                  
                    
                }
                
            }
            return (valorAltura);
        }

        //Conseguir posicion
        int ActualizarGraficoPosicion(float porcentajeAltura, int valorAltura, int valorPosicion)
        {
            float alturap;
            alturap = (porcentajeAltura * alturatotal) / 100;
            Math.Round(alturap);
            double numeroDouble = alturap;

            int numeroEntero = Convert.ToInt32(Math.Floor(numeroDouble));


            while (valorAltura != numeroEntero)
            {
                if (valorAltura < numeroEntero)
                {

                    valorPosicion = valorPosicion - 1;
                    valorAltura = valorAltura + 1;


                  

                }

                else if (valorAltura > numeroEntero)
                {
                    valorPosicion = valorPosicion + 1;
                    valorAltura = valorAltura - 1;

                  

                }

            }
            return (valorPosicion);
        }
    }

}



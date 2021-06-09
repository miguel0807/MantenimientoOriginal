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
        //Declaracion de variables
        public Plc plc = null;
        private string ip;
        private int rack, slot;

        //Masa de tanques
        float masaAcetona = 39235.07019f;
        float masaMEK = 39830.44303f;
        float masaNPropanol = 39770.90575f;
        float masaEtyl = 44593.42576f;



        //Direcciones de Peso        
        string direcEtyl = "MD168", direcAcetone = "MD172", direclNPropanol = "MD176", direcMEK = "MD180";

       

        public Niveles()
        {
            InitializeComponent();
        }

        //Carga al inicio del proyecto variables o funciones
        private void Niveles_Load(object sender, EventArgs e)
        {



            Conectar();

            txtnivelAcetona.Text = CargarDireccion(direcAcetone).ToString();
            txtnivelMEK.Text = CargarDireccion(direcMEK).ToString();
            txtnivelNPropanol.Text = CargarDireccion(direclNPropanol).ToString();
            txtnivelEtyl.Text = CargarDireccion(direcEtyl).ToString();

            CargaImagen(float.Parse(txtnivelAcetona.Text), masaAcetona, "Acetona");
            CargaImagen(float.Parse(txtnivelEtyl.Text), masaEtyl, "Etyl");
            CargaImagen(float.Parse(txtnivelMEK.Text), masaMEK, "MEK");
            CargaImagen(float.Parse(txtnivelNPropanol.Text), masaNPropanol, "N-Propanol");
            CalculaPorcentaje(txtnivelAcetona, masaAcetona, porcentajeAcetona);
            CalculaPorcentaje(txtnivelEtyl, masaEtyl, porcentajeAcetato);
            CalculaPorcentaje(txtnivelMEK, masaMEK, porcentajeMEK);
            CalculaPorcentaje(txtnivelNPropanol, masaNPropanol, porcentajeNPropanol);

        }

        //Boton para realizar la reconexion cuando se desconecte la conexion
        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conectar();
        }

        //Boton para cargar pruebas
        private void button1_Click(object sender, EventArgs e)
        {
            txtnivelAcetona.Text = CargarDireccion(direcAcetone).ToString();
            txtnivelMEK.Text = CargarDireccion(direcMEK).ToString();
            txtnivelNPropanol.Text = CargarDireccion(direclNPropanol).ToString();
            txtnivelEtyl.Text = CargarDireccion(direcEtyl).ToString();

            CargaImagen(float.Parse(txtnivelAcetona.Text), masaAcetona, "Acetona");
            CargaImagen(float.Parse(txtnivelEtyl.Text), masaEtyl, "Etyl");
            CargaImagen(float.Parse(txtnivelMEK.Text), masaMEK, "MEK");
            CargaImagen(float.Parse(txtnivelNPropanol.Text), masaNPropanol, "N-Propanol");
            CalculaPorcentaje(txtnivelAcetona,masaAcetona,porcentajeAcetona);
            CalculaPorcentaje(txtnivelEtyl, masaEtyl, porcentajeAcetato);
            CalculaPorcentaje(txtnivelMEK, masaMEK, porcentajeMEK);
            CalculaPorcentaje(txtnivelNPropanol, masaNPropanol, porcentajeNPropanol);


        }

        //Realiza la conexion al PLC
        private void Conectar()
        {

            try {

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


        //Desconecta la conexion al PLC
        private void Desconectar()
        {
            plc.Close();
            Estado.Text = "Desconectado";
        }

        //Cargar imagenes
        private void CargaImagen (float Peso, float maxMasa, string Solvente){
            PictureBox imagen;
            if (Solvente == "Acetona") { imagen = picAcetone; }
            else if (Solvente == "Etyl") { imagen = picEtyl; }
            else if (Solvente == "MEK") { imagen = picMEK; }
            else if (Solvente == "N-Propanol") { imagen = picNPropanol; }
            else { imagen = picAcetone; }
           
            if (Peso <= 0 && Solvente == "Acetona") {
                picAcetone.Image = Tank_Farm.Properties.Resources.Vacio;
            }

            else if (Peso*100/maxMasa>= 1 && Peso * 100 / maxMasa <= 10) { imagen.Image = Tank_Farm.Properties.Resources._10; }

            else if (Peso * 100 / maxMasa >= 11 && Peso * 100 / maxMasa <= 20) { imagen.Image = Tank_Farm.Properties.Resources._20; }

            else if (Peso * 100 / maxMasa >= 21 && Peso * 100 / maxMasa <= 30) { imagen.Image = Tank_Farm.Properties.Resources._30; }

            else if (Peso * 100 / maxMasa >= 31 && Peso * 100 / maxMasa <= 40) { imagen.Image = Tank_Farm.Properties.Resources._40; }

            else if (Peso * 100 / maxMasa >= 41 && Peso * 100 / maxMasa <= 50) { imagen.Image = Tank_Farm.Properties.Resources._50; }

            else if (Peso * 100 / maxMasa >= 51 && Peso * 100 / maxMasa <= 60) { imagen.Image = Tank_Farm.Properties.Resources._60; }

            else if (Peso * 100 / maxMasa >= 61 && Peso * 100 / maxMasa <= 70) { imagen.Image = Tank_Farm.Properties.Resources._70; }

            else if (Peso * 100 / maxMasa >= 71 && Peso * 100 / maxMasa <= 80) { imagen.Image = Tank_Farm.Properties.Resources._80; }

            else if (Peso * 100 / maxMasa >= 81 && Peso * 100 / maxMasa <= 90) { imagen.Image = Tank_Farm.Properties.Resources._90; }

            else if (Peso * 100 / maxMasa >= 91) { imagen.Image = Tank_Farm.Properties.Resources._100_1; }




        }
    
        //Calcula porcentaje de cilindro
        private void CalculaPorcentaje (TextBox txtPeso, float maxMasa, TextBox txtbox)
        { float porcentaje=0;

           
            porcentaje = float.Parse(txtPeso.Text) * 100 / maxMasa ;

            txtbox.Text =  porcentaje.ToString("#.##")+"%";
        }


    }

}


//int conteo = 0;
//direcEtyl = "MD168";
//direcEtylAcetone = "MD172";
//direcEtylNPropanol = "MD176";
//direcEtylMEK = "MD180";

//string[] direciones = new string[4];
//direciones[0] = direcEtyl;
//direciones[1] = direcEtylAcetone;
//direciones[2] = direcEtylNPropanol;
//direciones[3] = direcEtylMEK;

//float[] niveles = new float[4];
//niveles[0] = nivelEtyl;
//niveles[1] = nivelEtylAcetone;
//niveles[2] = nivelEtylNPropanol;
//niveles[3] = nivelEtylMEK;






//foreach (string direccion in direciones)
//{

//    //string direccion = "MD168";
//    object resultado = plc.Read(direccion);
//    string varString = string.Format("{0}", resultado.ToString());
//    int b = Convert.ToInt32(varString);
//    //Segundo convertirla a byte
//    byte[] bytes = BitConverter.GetBytes(b);

//    //Tercero pasarla a float
//    flotante = BitConverter.ToSingle(bytes, 0);

//    niveles[conteo] = flotante;
//    conteo = conteo + 1;


//}

//txtnivelEtyl.Text = niveles[0].ToString();
//txtnivelAcetona.Text = niveles[1].ToString();
//txtnivelNPropanol.Text = niveles[2].ToString();
//txtnivelMEK.Text = niveles[3].ToString();

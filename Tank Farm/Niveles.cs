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

namespace Tank_Farm
{
    public partial class Niveles : Form
    {
        private Plc plc = null;
        private string ip;
        private int rack, slot;
      
        public Niveles()
        {
            InitializeComponent();
        }

        private void Niveles_Load(object sender, EventArgs e)
        {
            
            Conectar();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conectar();
        }

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
            catch(Exception ex)
            {
                
                MessageBox.Show("No se logro conectar al PLC con la ip " + ip);
                Estado.Text = "Desconectado";
                btnConectar.Visible = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string direcEtyl, direcEtylAcetone, direcEtylNPropanol, direcEtylMEK;
            int conteo = 0;
            float nivelEtyl=0, nivelEtylAcetone=0, nivelEtylNPropanol=0, nivelEtylMEK=0, flotante = 0;
            direcEtyl = "MD168";
            direcEtylAcetone = "MD172";
            direcEtylNPropanol = "MD176";
            direcEtylMEK = "MD180";

            string[] direciones = new string[4];
            direciones[0] = direcEtyl;
            direciones[1] = direcEtylAcetone;
            direciones[2] = direcEtylNPropanol;
            direciones[3] = direcEtylMEK;

            float[] niveles = new float[4];
            niveles[0] = nivelEtyl;
            niveles[1] = nivelEtylAcetone;
            niveles[2] = nivelEtylNPropanol;
            niveles[3] = nivelEtylMEK;


        



            foreach (string direccion in direciones)
            {
               
                //string direccion = "MD168";
                object resultado = plc.Read(direccion);
                string varString = string.Format("{0}", resultado.ToString());
                int b = Convert.ToInt32(varString);
                //Segundo convertirla a byte
                byte[] bytes = BitConverter.GetBytes(b);

                //Tercero pasarla a float
                flotante = BitConverter.ToSingle(bytes, 0);

                niveles[conteo] = flotante;
                conteo = conteo + 1;
               

            }

            txtnivelEtyl.Text = niveles[0].ToString();
            txtnivelAcetona.Text = niveles[1].ToString();
            txtnivelNPropanol.Text = niveles[2].ToString();
            txtnivelMEK.Text = niveles[3].ToString();

           
        }

        private void Desconectar()
        {
            plc.Close();
            Estado.Text = "Desconectado";
        }
    }
}

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
            string address = "MD168";
            object result = plc.Read(address);
            string varSting = string.Format("{0}", result.ToString());
            int b = Convert.ToInt32(varSting);
            //Segundo convertirla a byte
            byte[] bytes = BitConverter.GetBytes(b);

            //Tercero pasarla a float
            float flotante = BitConverter.ToSingle(bytes, 0);



            nivelEtyl.Text = flotante.ToString();
        }

        private void Desconectar()
        {
            plc.Close();
            Estado.Text = "Desconectado";
        }
    }
}

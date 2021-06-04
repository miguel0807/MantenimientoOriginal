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
    public partial class Nivel_de_solventes : Form
    {
        private Plc plc = null;
        public Nivel_de_solventes()
        {
            InitializeComponent();
        }

        private void Nivel_de_solventes_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetNames(typeof(CpuType));
            comboBox1.Text = "S71200";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), comboBox1.SelectedValue.ToString());



            plc = new Plc(cpu, textBox1.Text, Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox3.Text));
            plc.Open();

            if (plc.IsConnected)
            {
                textBox6.Text = "Conectado";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plc.Close();
            textBox6.Text = "Desconectado";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string address = textBox7.Text;
            object result = plc.Read(address);
            string varSting = string.Format("{0}", result.ToString());
            int b = Convert.ToInt32(varSting);
            //Segundo convertirla a byte
            byte[] bytes = BitConverter.GetBytes(b);

            //Tercero pasarla a float
            float flotante = BitConverter.ToSingle(bytes, 0);



            textBox4.Text = flotante.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string address = textBox7.Text;
            object result = plc.Read(address);
            plc.Write(address, textBox5.Text);
            textBox4.Text = string.Format("{0}", result.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Primero declarar variable como int
            int n = 1101004800;

            string a = 1101004800.ToString();
            int b = Convert.ToInt32(a);


            //Segundo convertirla a byte
            byte[] bytes = BitConverter.GetBytes(b);

            //Tercero pasarla a float
            float flotante = BitConverter.ToSingle(bytes, 0);

            //Cuarto mostrarla en pantalla
            MessageBox.Show(flotante.ToString());
        }
    }
}

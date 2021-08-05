using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CR7
{
    public partial class BusquedaOrden : Form
    {
        public BusquedaOrden()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtruta.Text = fbd.SelectedPath;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (txtruta.Text != "")
            {
                listBox1.Items.Clear();
                string ruta = @"" + txtruta.Text; //Escribir ruta
                string texto = txtfiltro.Text; //Escribir texto a buscar

                string[] files = Directory.GetFiles(ruta, "*", SearchOption.AllDirectories);
                //List<string> encontrados = new List<string>();
                foreach (string item in files)
                {
                    string contenido = File.ReadAllText(item);

                    if (contenido.Contains(texto))
                        //MessageBox.Show(item);
                        listBox1.Items.Add(item);

                }
            }
        
        }
    }
}

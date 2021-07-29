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

using System.IO;

namespace CR7
{
    public partial class SN_Evolution : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=tcp:COS-F4Z1XQ2\\SQLEXPRESS,49500;Initial Catalog=CR7; User Id=malvarado; Password=1234Admin");
        public static string[,] matriz = new string [5000, 16];
        public const string Delimiter = "\t";
        public SN_Evolution()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Serial#", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string path;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = "\\\\cor-sv-fs01\\Costa Rica Share\\Public\\Engineering\\DD Backup\\CR\\Backup\\Evolution\\Numeros de Serie Produccion\\Serial Number\\" + Path.GetFileName(openFileDialog1.FileName);
                SqlCommand cmd = new SqlCommand("bulk insert Serial# from '\\\\cor-sv-fs01\\Costa Rica Share\\Public\\Engineering\\DD Backup\\CR\\Backup\\Evolution\\Numeros de Serie Produccion\\Serial Number\\" + Path.GetFileName(openFileDialog1.FileName) + " ' with (fieldterminator = '\t',rowterminator = '\n')", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();

                for (int i = 0; i < 50; i ++)
                    {
                    SqlCommand cmd2 = new SqlCommand("with indicadores4 as (SELECT convert(char,[System Serial#]) as System,Row_Number() OVER (PARTITION BY convert(char,[System Serial#]) ORDER BY convert(char,[System Serial#]) DESC) AS RowNum FROM Serial#) delete from indicadores4 where RowNum=2", cn);
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    dataGridView1.DataSource = dt2;
                    cn.Close();

                }




                if (File.Exists(path))
                {
                    try
                    {
                        File.Delete(path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        MessageBox.Show("No se encontro el archivo");
                    }
                }

                MessageBox.Show("Se cargo correctamente");
            }





        }

        //Busca los registros en la base de datos y los imprime en el datagridview1
        public void Search()
        {
            //Declaracion de variable
            string vCbo;


            //Inicializacion de variable
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    vCbo = "[System Serial#]";
                    break;

                case 1:
                    vCbo = "[Print Head Serial#]";
                    break;

                case 2:
                    vCbo = "[Driver PCB Serial#]";
                    break;

                case 3:
                    vCbo = "[POGO Serial#]";
                    break;
                case 4:
                    vCbo = "[Controller Serial#]";
                    break;

                case 5:
                    vCbo = "[CPU Serial#]";
                    break;

                case 6:
                    vCbo = "[LCD Serial#]";
                    break;

                case 7:
                    vCbo = "[Controller Software Version]";
                    break;

                case 8:
                    vCbo = "[Print Head Firmware]";
                    break;

                case 9:
                    vCbo = "[Print Head Software Version]";
                    break;
                case 10:
                    vCbo = "Date";
                    break;

                case 11:
                    vCbo = "[User]";
                    break;


                case 12:
                    vCbo = "[System Model]";
                    break;
                case 13:
                    vCbo = "[Controller Hardware Version]";
                    break;

                case 14:
                    vCbo = "[Driver Hardware Version]";
                    break;

                default:
                    vCbo = "[POGO Hardware Version]";
                    break;
            }

            SqlCommand cmd = new SqlCommand("select   * from Serial# where CONVERT(char," + vCbo + ")  like '%" + txtSearch.Text + "%'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();


          

            lblRegistros.Visible = true;
            lblRegistros.Text = "Cantidad de registros: " + dataGridView1.Rows.Count.ToString();



        }

       

        private void button10_Click(object sender, EventArgs e)
        {
            string path;
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path= fbd.SelectedPath;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            int counter = 0;
            string line,path;

            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = "\\\\cor-sv-fs01\\Costa Rica Share\\Public\\Engineering\\DD Backup\\CR\\Backup\\Evolution\\Numeros de Serie Produccion\\Serial Number\\Originales\\" + Path.GetFileName(openFileDialog2.FileName);
                Path.GetFileName(openFileDialog2.FileName);
                // Read the file and display it line by line.  
                StreamReader file = new System.IO.StreamReader(@"\\cor-sv-fs01\Costa Rica Share\Public\Engineering\DD Backup\CR\Backup\Evolution\Numeros de Serie Produccion\Serial Number\Originales\" + Path.GetFileName(openFileDialog2.FileName)); 

                while ((line = file.ReadLine()) != null)
                {     
         
                    SystemSerial(line, counter);
                    PrintHeadSerial(line, counter);
                    DriverPcbSerial(line, counter);
                    PogoSerial(line, counter);
                    ControllerSerial(line, counter);
                    CpuSerial(line, counter);
                    LcdSerial(line, counter);
                    ControllerSoftwareVersion(line, counter);
                    PrintHeadFirmware(line, counter);
                    PrintHeadSoftwareVersion(line, counter);
                    Date(line, counter);
                    User(line, counter);
                    SystemModel(line, counter);
                    ControllerHardwareVersion(line, counter);
                    DriverHardwareVersion(line, counter);
                    PogoHardwareVersion(line, counter);

                    counter++;


                }
            
                RowWrite();        
            
                file.Close();


                if (File.Exists(path))
                {
                    try
                    {
                        File.Delete(path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        MessageBox.Show("No se encontro el archivo");
                    }
                }

                MessageBox.Show("Finalizado","Status");
            }

           


          
        }

        private void SystemSerial(string line,int counter)
        {   
                for (int i = 0; i < 1; i++)
                {

                    matriz[counter, 0] = (line.Substring(i, 6)) + Delimiter;         

                }

        }

        private void PrintHeadSerial(string line, int counter)
        {
            for (int i = 7; i < 8; i++)
            {
                matriz[counter, 1] = (line.Substring(i, 6)) + Delimiter;
               
            }

        }

        private void DriverPcbSerial(string line, int counter)
        {
            for (int i = 14; i < 15; i++)
            {
                matriz[counter, 2] = (line.Substring(i, 6)) + Delimiter;
               
            }

        }

        private void PogoSerial(string line, int counter)
        {
            for (int i = 21; i < 22; i++)
            {
                matriz[counter, 3] = (line.Substring(i, 6)) + Delimiter;

            }
        }

        private void ControllerSerial(string line, int counter)
        {
            for (int i = 28; i < 29; i++)
            {
                matriz[counter, 4] = (line.Substring(i, 6)) + Delimiter;

            }
        }

        private void CpuSerial(string line, int counter)
        {
            for (int i = 35; i < 36; i++)
            {
                matriz[counter, 5] = (line.Substring(i, 6)) + Delimiter;

            }
        }

        private void LcdSerial(string line, int counter)
        {
            for (int i = 42; i < 43; i++)
            {
                matriz[counter, 6] = (line.Substring(i, 6)) + Delimiter;

            }
        }

        private void ControllerSoftwareVersion(string line, int counter)
        {
            for (int i = 64; i < 65; i++)
            {
                matriz[counter, 7] = (line.Substring(i, 10)) + Delimiter;

            }
        }

        private void PrintHeadFirmware(string line, int counter)
        {
            for (int i = 87; i < 88; i++)
            {
                matriz[counter, 8] = (line.Substring(i, 1)) + Delimiter;

            }

           
        }

        private void PrintHeadSoftwareVersion(string line, int counter)
        {
            for (int i = 94; i < 95; i++)
            {
                matriz[counter, 9] = (line.Substring(i, 10)) + Delimiter;

            }

        }

        private void Date(string line, int counter)
        {
            for (int i = 125; i < 126; i++)
            {
                matriz[counter, 10] = (line.Substring(i, 10)) + Delimiter;

            }

        }

        private void User(string line, int counter)
        {
            for (int i = 135; i < 136; i++)
            {
                matriz[counter, 11] = (line.Substring(i, 10)) + Delimiter;

            }

        }

        private void SystemModel(string line, int counter)
        {
            for (int i = 145; i < 146; i++)
            {
                matriz[counter, 12] = (line.Substring(i, 13)) + Delimiter;

            }

        }

        private void ControllerHardwareVersion(string line, int counter)
        {
            for (int i = 160; i < 161; i++)
            {
                matriz[counter, 13] = (line.Substring(i, 1)) + Delimiter;

            }

        }

        private void DriverHardwareVersion(string line, int counter)
        {
            for (int i = 161; i < 162; i++)
            {
                matriz[counter, 14] = (line.Substring(i, 1)) + Delimiter;

            }

        }

        private void PogoHardwareVersion(string line, int counter)
        {
            for (int i = 162; i < 163; i++)
            {
                matriz[counter, 15] = (line.Substring(i, 1)) + Delimiter;

            }

        }

        void RowWrite()
        {
            string path = "\\\\cor-sv-fs01\\Costa Rica Share\\Public\\Engineering\\DD Backup\\CR\\Backup\\Evolution\\Numeros de Serie Produccion\\Serial Number\\file.txt";
            StreamWriter add = File.AppendText(path);
            
            
            for (int i = 0; i < 4999; i++)
            {
                add.WriteLine((matriz[i, 0] + matriz[i, 1] + matriz[i, 2] + matriz[i, 3] + matriz[i, 4] + matriz[i, 5] + matriz[i, 6] + matriz[i, 7] + matriz[i, 8] + matriz[i, 9] + matriz[i, 10] + matriz[i, 11] + matriz[i, 12] + matriz[i, 13] + matriz[i, 14] + matriz[i, 15]));
            }
          
            add.Close();
        }

    }
    
}

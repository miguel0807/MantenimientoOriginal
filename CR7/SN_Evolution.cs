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
        SqlConnection cn = new SqlConnection("Data Source=tcp:COS-F37HWK2\\SQLEXPRESS,49500;Initial Catalog=CR7; User Id=simpro; Password=Trpo25MgL452");
        public static string[,] matrix = new string[15000, 16];
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
            string path,ConvertedFile;
            ConvertedFile = "file.txt";
           
            path = "\\\\cor-sv-fs01\\Costa Rica Share\\Public\\Engineering\\DD Backup\\CR\\Backup\\Evolution\\Numeros de Serie Produccion\\Serial Number\\" + ConvertedFile;
                SqlCommand cmd = new SqlCommand("bulk insert Serial# from '\\\\cor-sv-fs01\\Costa Rica Share\\Public\\Engineering\\DD Backup\\CR\\Backup\\Evolution\\Numeros de Serie Produccion\\Serial Number\\" + ConvertedFile + " ' with (fieldterminator = '\t',rowterminator = ',')", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);       
                DataTable dt = new DataTable();
          
             


            if (File.Exists(path))
            {
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("No se encontro el archivo");
                }
            }
            else { MessageBox.Show("No se encontro el archivo"); }




       
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
                    MessageBox.Show("Se cargo correctamente");


                }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        MessageBox.Show("No se encontro el archivo");
                    }

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
            SqlCommand cmd = new SqlCommand("select  top " + txtShow.Text +  "* from Serial# where CONVERT(char," + vCbo + ")  like '%" + txtSearch.Text + "%'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //DataView dataView2 = new DataView(dt);
            //dataGridView1.DataSource = dataView2;
            dataGridView1.DataSource = dt;
            cn.Close();





            lblRegistros.Visible = true;
            lblRegistros.Text = "Cantidad de registros: " + dataGridView1.Rows.Count.ToString();



        }

       

        private void button10_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Serial#", cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Eliminado con exito"  );
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
                try
                {
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
                 }
                        catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                RowWrite(path);        
            
                file.Close();
                /*

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
                */
                MessageBox.Show("Finalizado","Status");
            }

           


          
        }

        private void SystemSerial(string line,int counter)
        {   
                for (int i = 0; i < 1; i++)
                {

                    matrix[counter, 0] = (line.Substring(i, 6)) + Delimiter;         

                }

        }

        private void PrintHeadSerial(string line, int counter)
        {
            for (int i = 7; i < 8; i++)
            {
                matrix[counter, 1] = (line.Substring(i, 6)) + Delimiter;
               
            }

        }

        private void DriverPcbSerial(string line, int counter)
        {
            for (int i = 14; i < 15; i++)
            {
                matrix[counter, 2] = (line.Substring(i, 6)) + Delimiter;
               
            }

        }

        private void PogoSerial(string line, int counter)
        {
            for (int i = 21; i < 22; i++)
            {
                matrix[counter, 3] = (line.Substring(i, 6)) + Delimiter;

            }
        }

        private void ControllerSerial(string line, int counter)
        {
            for (int i = 28; i < 29; i++)
            {
                matrix[counter, 4] = (line.Substring(i, 6)) + Delimiter;

            }
        }

        private void CpuSerial(string line, int counter)
        {
            for (int i = 35; i < 36; i++)
            {
                matrix[counter, 5] = (line.Substring(i, 6)) + Delimiter;

            }
        }

        private void LcdSerial(string line, int counter)
        {
            for (int i = 42; i < 43; i++)
            {
                matrix[counter, 6] = (line.Substring(i, 6)) + Delimiter;

            }
        }

        private void ControllerSoftwareVersion(string line, int counter)
        {
            for (int i = 64; i < 65; i++)
            {
                matrix[counter, 7] = (line.Substring(i, 10)) + Delimiter;

            }
        }

        private void PrintHeadFirmware(string line, int counter)
        {
            for (int i = 87; i < 88; i++)
            {
                matrix[counter, 8] = (line.Substring(i, 6)) + Delimiter;

            }

           
        }

        private void PrintHeadSoftwareVersion(string line, int counter)
        {
            for (int i = 94; i < 95; i++)
            {
                matrix[counter, 9] = (line.Substring(i, 10)) + Delimiter;

            }

        }

        private void Date(string line, int counter)
        {
            for (int i = 125; i < 126; i++)
            {
                matrix[counter, 10] = (line.Substring(i, 10)) + Delimiter;

            }

        }

        private void User(string line, int counter)
        {
            for (int i = 135; i < 136; i++)
            {
                matrix[counter, 11] = (line.Substring(i, 10)) + Delimiter;

            }

        }

        private void SystemModel(string line, int counter)
        {
            for (int i = 145; i < 146; i++)
            {
                matrix[counter, 12] = (line.Substring(i, 13)) + Delimiter;

            }

        }

        private void ControllerHardwareVersion(string line, int counter)
        {
            for (int i = 160; i < 161; i++)
            {
                matrix[counter, 13] = (line.Substring(i, 1)) + Delimiter;

            }

        }

        private void DriverHardwareVersion(string line, int counter)
        {
            for (int i = 161; i < 162; i++)
            {
                matrix[counter, 14] = (line.Substring(i, 1)) + Delimiter;

            }

        }

        private void PogoHardwareVersion(string line, int counter)
        {
            for (int i = 162; i < 163; i++)
            {
                matrix[counter, 15] = (line.Substring(i, 1)) + ",";

            }

        }

        void RowWrite(string pathOrigin)
        {
            string path = "\\\\cor-sv-fs01\\Costa Rica Share\\Public\\Engineering\\DD Backup\\CR\\Backup\\Evolution\\Numeros de Serie Produccion\\Serial Number\\file.txt";
            int TotalRow = CountRowsPath(pathOrigin);
            
            StreamWriter add = File.AppendText(path);
            
           

            for (int i = 0; i < TotalRow; i++)
            {
                add.WriteLine((matrix[i, 0] + matrix[i, 1] + matrix[i, 2] + matrix[i, 3] + matrix[i, 4] + matrix[i, 5] + matrix[i, 6] + matrix[i, 7] + matrix[i, 8] + matrix[i, 9] + matrix[i, 10] + matrix[i, 11] + matrix[i, 12] + matrix[i, 13] + matrix[i, 14] + matrix[i, 15]));
            }
          
            add.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           

            SqlCommand cmd = new SqlCommand("select COUNT(*) from Serial#", cn);
            cn.Open();
            int contar = (int)cmd.ExecuteScalar();
            cn.Close();
            MessageBox.Show(contar.ToString());
            
        }

        int CountRowsPath(string path)
        {
            StreamReader sr = new StreamReader(path);
            int Count = 1;

            while (sr.Peek() != -1)
            {
                sr.ReadLine();
                Count ++;

            }

            sr.Close();
            return Count;
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
           
            string ruta = @"" + txtruta.Text; //Escribir ruta
            string texto = txtfiltro.Text; //Escribir texto a buscar

            string[] files = Directory.GetFiles(ruta, "*", SearchOption.AllDirectories);
            //List<string> encontrados = new List<string>();
            foreach (string item in files)
            {
                string contenido = File.ReadAllText(item);

                if (contenido.Contains(texto))
                    MessageBox.Show(item);
                   
            }
        }

    }
    
}

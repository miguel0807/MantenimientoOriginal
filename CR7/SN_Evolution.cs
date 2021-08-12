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
        public  bool Duplicates = false;
        public string Address = "";

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
            if (comboBox1.Text == "To Explore")
            {
                if (Address != "")
                {
                    if (txtSearch.Text != "")
                    {
                        SearchFile();

                        

                    }

                    else
                    {
                        MessageBox.Show("First type the keyword.", "Status");
                    }
                }

                    else
                    {
                        MessageBox.Show("A folder was not assigned.", "Status");
                    }
               
                
            }

                else 
                {
                    Duplicates = false;
                    Search();
                }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "To Explore")
            {
                dataGridView1.Visible = false;
                listView1.Visible = true;
                button4.Visible = true;
                button3.Visible = false;
            }

                else 
                {
                    dataGridView1.Visible = true;
                    listView1.Visible = false;
                    button4.Visible = false;
                    button3.Visible = true;
                }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string path;
          
            openFileDialog2.InitialDirectory = "\\\\cor-sv-fs01\\Costa Rica Share\\Public\\Engineering\\DD Backup\\CR\\Backup\\Evolution\\Numeros de Serie Produccion\\Serial Number\\";

            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = openFileDialog2.FileName;             
             
                SqlCommand cmd = new SqlCommand("bulk insert Serial# from '" + path +  "' with (fieldterminator = '\\t',rowterminator = ',')", cn);  
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
                        return;
                    }
                }
                    else 
                    { 
                        MessageBox.Show("No se encontro el archivo"); 
                    }


                cn.Close();

                /* Adicional             

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

                }*/
                MessageBox.Show("Data upload finished", "Status");
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

            

            dataGridView1.DataSource = dt;
            cn.Close();



            dataGridView1.Columns[0].Visible = false;

            lblRegistros.Visible = true;
            lblRegistros.Text = "Record count: " + dataGridView1.Rows.Count.ToString();

           

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
            openFileDialog2.InitialDirectory = "\\\\cor-sv-fs01\\Costa Rica Share\\Public\\Engineering\\DD Backup\\CR\\Backup\\Evolution\\Numeros de Serie Produccion\\Serial Number\\";
           
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = openFileDialog2.FileName ;
               

                
             
               

                try
                {
                    // Read the file and display it line by line.  
                    StreamReader file = new System.IO.StreamReader(path);
               
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

                    file.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                
                    return;

                }
                RowWrite(path);        
            
                
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
                MessageBox.Show("File conversion completed successfully", "Status");
            }

           


          
        }

        private void SystemSerial(string line,int counter)
        {            
            matrix[counter, 0] = 1 + "\t" + (line.Substring(0, 6)) + Delimiter;        

        }

        private void PrintHeadSerial(string line, int counter)
        {
             matrix[counter, 1] = (line.Substring(7, 6)) + Delimiter;

        }

        private void DriverPcbSerial(string line, int counter)
        {
            matrix[counter, 2] = (line.Substring(14, 6)) + Delimiter;
        }

        private void PogoSerial(string line, int counter)
        {
            matrix[counter, 3] = (line.Substring(21, 6)) + Delimiter;
        }

        private void ControllerSerial(string line, int counter)
        {
            matrix[counter, 4] = (line.Substring(28, 6)) + Delimiter;
        }

        private void CpuSerial(string line, int counter)
        {
            matrix[counter, 5] = (line.Substring(35, 6)) + Delimiter;
        }

        private void LcdSerial(string line, int counter)
        {
            matrix[counter, 6] = (line.Substring(42, 6)) + Delimiter;
        }

        private void ControllerSoftwareVersion(string line, int counter)
        {
            matrix[counter, 7] = (line.Substring(64, 10)) + Delimiter;
        }

        private void PrintHeadFirmware(string line, int counter)
        {
            matrix[counter, 8] = (line.Substring(87, 6)) + Delimiter;
        }

        private void PrintHeadSoftwareVersion(string line, int counter)
        {
            matrix[counter, 9] = (line.Substring(94, 10)) + Delimiter;
        }

        private void Date(string line, int counter)
        {
            matrix[counter, 10] = (line.Substring(125, 10)) + Delimiter;
        }

        private void User(string line, int counter)
        {
            matrix[counter, 11] = (line.Substring(135, 10)) + Delimiter;
        }

        private void SystemModel(string line, int counter)
        {
            matrix[counter, 12] = (line.Substring(145, 13)) + Delimiter;
        }

        private void ControllerHardwareVersion(string line, int counter)
        {
            matrix[counter, 13] = (line.Substring(160, 1)) + Delimiter;
        }

        private void DriverHardwareVersion(string line, int counter)
        {
            matrix[counter, 14] = (line.Substring(161, 1)) + Delimiter;
        }

        private void PogoHardwareVersion(string line, int counter)
        {
            matrix[counter, 15] = (line.Substring(162, 1)) + ",";
        }

        void RowWrite(string pathOrigin)
        {
            
            //string path = "\\\\cor-sv-fs01\\Costa Rica Share\\Public\\Engineering\\DD Backup\\CR\\Backup\\Evolution\\Numeros de Serie Produccion\\Serial Number\\Converted files\\file.txt";
            string path = "\\\\cor-sv-fs01\\Costa Rica Share\\Public\\Engineering\\DD Backup\\CR\\Backup\\Evolution\\Numeros de Serie Produccion\\Serial Number\\Converted files\\" + Path.GetFileNameWithoutExtension(openFileDialog2.FileName) + "(converted).txt";
            int TotalRow = CountRowsPath(pathOrigin) - 1;
            
            StreamWriter add = File.AppendText(path);
            
           

            for (int i = 0; i < TotalRow ; i++)
            {
                

                //The last row is added without a line break
                if (i == TotalRow - 1)
                {
                    add.Write((matrix[i, 0] + matrix[i, 1] + matrix[i, 2] + matrix[i, 3] + matrix[i, 4] + matrix[i, 5] + matrix[i, 6] + matrix[i, 7] + matrix[i, 8] + matrix[i, 9] + matrix[i, 10] + matrix[i, 11] + matrix[i, 12] + matrix[i, 13] + matrix[i, 14] + matrix[i, 15]));
                }

                    else
                    {
                        add.WriteLine((matrix[i, 0] + matrix[i, 1] + matrix[i, 2] + matrix[i, 3] + matrix[i, 4] + matrix[i, 5] + matrix[i, 6] + matrix[i, 7] + matrix[i, 8] + matrix[i, 9] + matrix[i, 10] + matrix[i, 11] + matrix[i, 12] + matrix[i, 13] + matrix[i, 14] + matrix[i, 15]));
                    }
                
            }
            


            add.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           

            SqlCommand cmd = new SqlCommand("select COUNT(*) from Serial#", cn);
            cn.Open();
            int contar = (int)cmd.ExecuteScalar();
            cn.Close();
            MessageBox.Show("Total number of records " + contar.ToString() , "Report");
            
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

        


        private void button6_Click(object sender, EventArgs e)
        {
            Duplicates = true;
            SearchDuplicates();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (Duplicates == true)
            { 

                

                string id;
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value).ToString();

                DialogResult dr = MessageBox.Show("Are you sure to delete the row ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    SqlCommand cmdDelete = new SqlCommand("delete from Serial# where id = " + id, cn);
                    cn.Open();
                    cmdDelete.ExecuteNonQuery();
                    cn.Close();
                    //MessageBox.Show(cmdDelete.CommandText);
                    SearchDuplicates();
                }


               

            }
        }

        private void SearchDuplicates()
        {
           
            SqlCommand cmd = new SqlCommand("select top " + txtShow.Text + " *from Serial# where CONVERT(char,[System Serial#]) in (select CONVERT(char,[System Serial#]) from Serial# group by CONVERT(char,[System Serial#]) having COUNT (CONVERT(char,[System Serial#])) >=2 ) order by CONVERT(char,[System Serial#])", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            cn.Close();

            dataGridView1.Columns[0].Visible = false;

            lblRegistros.Visible = true;

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No duplicate records found.", "Status");
            }
                else
                {
                lblRegistros.Text = "Record count: " + dataGridView1.Rows.Count.ToString();
                }
            

            

        }

        private void SearchFile()
        {
            string ruta = @"" + Address; //Escribir ruta
            string texto = txtSearch.Text; //Escribir texto a buscar
            int count = 0;
            string[] files = Directory.GetFiles(ruta, "*", SearchOption.AllDirectories);
            listView1.Items.Clear();






            foreach (string item in files)
            {
                string contenido = File.ReadAllText(item);

             
                if (contenido.Contains(texto))
                {


                    listView1.Items.Add(item);
                

                    count++;
                }
                

            }

            if (count == 0)
            {
                MessageBox.Show("No file was found", "Status");
            }
                else
                {
                MessageBox.Show("Finished search", "Status");
                }
        }

        private void LocationFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Address = fbd.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LocationFolder();
        }
    }
    
}

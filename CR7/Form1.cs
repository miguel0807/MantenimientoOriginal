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


namespace CR7
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=tcp:COS-F4Z1XQ2\\SQLEXPRESS,49500;Initial Catalog=CR7; User Id=malvarado; Password=1234Admin");
        
        public Form1()
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
         






            SqlCommand cmd = new SqlCommand("select * from Serial# where CONVERT(char,"+ vCbo + ")  like '%"+ txtSearch.Text +"%'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();


            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[14].Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}

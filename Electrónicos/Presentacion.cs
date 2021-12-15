using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;



namespace Electrónicos
{ 
    
    public partial class Presentacion : Form
    {
        internal static string variableMensaje;


        // internal static string CompartidoNombre;
        //internal static string CompartidoPosicion;

        public Presentacion()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (panelAbis.Visible == true)
            {
                panelAbis.Visible = false;
            }

            else
            {
                panelAbis.Visible = true;
            }
           
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de cerrar el programa?", "Alerta" , MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                this.Close();
               // Application.Exit();
            }
            
        }

        private void Presentacion_Load(object sender, EventArgs e)
        {
            
           
           
            lblNombre.Text = Common.ActiveUser.firstName.ToString() + " " + Common.ActiveUser.lastName.ToString();
            lblPuesto.Text = Common.ActiveUser.position.ToString();
            lblCorreo.Text = Common.ActiveUser.email.ToString();


        }
        
        public Form fh;
        private void AbrirFormHijo(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
             fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;                 
            fh.Show();
            
            
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private const int tamañogrid = 10;
        private const int areamouse = 132;
        private const int botonizquierdo = 17;
        private Rectangle rectangulogrid;

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));
            rectangulogrid = new Rectangle(ClientRectangle.Width - tamañogrid, ClientRectangle.Height - tamañogrid, tamañogrid, tamañogrid);
            region.Exclude(rectangulogrid);
            PanelTotal.Region = region;
            Invalidate();

        }

        protected override void WndProc(ref Message sms)
        {
            switch (sms.Msg)
            {
                case areamouse:
                    base.WndProc(ref sms);

                    var RefPoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));

                    if (!rectangulogrid.Contains(RefPoint))
                    {
                        break;
                    }

                    sms.Result = new IntPtr(botonizquierdo);
                    break;

                default:
                    base.WndProc(ref sms);
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(55, 61, 69));

            e.Graphics.FillRectangle(solidBrush, rectangulogrid);
            
            base.OnPaint(e);

            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, rectangulogrid);

        }
        int lx, ly;

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);

            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;


        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (fh != null)
            {
                fh.Close();
            }


            AbrirFormHijo(new Abis());
        }

        private void panelBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

          
            if (fh != null)
            {
                fh.Close();
            }

            AbrirFormHijo(new Electrónicos.Jupiter.Jupiter());
            //Abis.variableMensaje= "Prueba de animaciónes";

            //   Form frm = new Mensajes();


            // frm.ShowDialog();

        }

        private void panelContenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (fh != null)
            {
                fh.Close();
            }

            AbrirFormHijo(new HistorialABIS());
        }

        int sw, sh;

        private void MensajeError(string mensaje)
        {
            

            Form frm = new Mensajes(mensaje);

            frm.ShowDialog();
        }

    }


}

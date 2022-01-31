
namespace Electrónicos.Jupiter
{
    partial class Jupiter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jupiter));
            this.panel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnConectar = new Guna.UI.WinForms.GunaGradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstadoConexion = new System.Windows.Forms.Label();
            this.PuertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.txtEnviarDatos = new System.Windows.Forms.TextBox();
            this.txtMostrarDatos = new System.Windows.Forms.TextBox();
            this.btnConsola = new Guna.UI.WinForms.GunaGradientButton();
            this.txtMensajeLeido = new System.Windows.Forms.TextBox();
            this.btnSignal = new Guna.UI.WinForms.GunaGradientButton();
            this.btnPower = new Guna.UI.WinForms.GunaGradientButton();
            this.timerPower = new System.Windows.Forms.Timer(this.components);
            this.txtScanerPower = new System.Windows.Forms.TextBox();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.txtScanerSignal = new System.Windows.Forms.TextBox();
            this.timerSignal = new System.Windows.Forms.Timer(this.components);
            this.txtInicio = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnAceptar = new Guna.UI.WinForms.GunaGradientButton();
            this.btnRechazar = new Guna.UI.WinForms.GunaGradientButton();
            this.btnActivar = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton4 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblSignal = new Guna.UI.WinForms.GunaLabel();
            this.lblPower = new Guna.UI.WinForms.GunaLabel();
            this.btnSignalPrueba = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPowerPrueba = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtSignalPrueba = new Guna.UI.WinForms.GunaTextBox();
            this.txtPowerPrueba = new Guna.UI.WinForms.GunaTextBox();
            this.lblComando = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.gunaGradientButton1);
            this.panel1.Controls.Add(this.btnConectar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblEstadoConexion);
            this.panel1.GradientColor1 = System.Drawing.SystemColors.Highlight;
            this.panel1.GradientColor2 = System.Drawing.Color.DarkGray;
            this.panel1.GradientColor3 = System.Drawing.Color.DarkSalmon;
            this.panel1.GradientColor4 = System.Drawing.Color.RosyBrown;
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(350, 209);
            this.panel1.MinimumSize = new System.Drawing.Size(325, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 135);
            this.panel1.TabIndex = 47;
            this.panel1.Text = "gunaGradientPanel1";
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.Animated = true;
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.Gray;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Snow;
            this.gunaGradientButton1.BorderSize = 1;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = null;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(27, 43);
            this.gunaGradientButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGradientButton1.MinimumSize = new System.Drawing.Size(23, 18);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 5;
            this.gunaGradientButton1.Size = new System.Drawing.Size(23, 18);
            this.gunaGradientButton1.TabIndex = 64;
            // 
            // btnConectar
            // 
            this.btnConectar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConectar.Animated = true;
            this.btnConectar.AnimationHoverSpeed = 0.07F;
            this.btnConectar.AnimationSpeed = 0.03F;
            this.btnConectar.BackColor = System.Drawing.Color.Transparent;
            this.btnConectar.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnConectar.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnConectar.BorderColor = System.Drawing.Color.Black;
            this.btnConectar.BorderSize = 1;
            this.btnConectar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConectar.FocusedColor = System.Drawing.Color.Empty;
            this.btnConectar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnConectar.Image = null;
            this.btnConectar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConectar.Location = new System.Drawing.Point(73, 74);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConectar.MaximumSize = new System.Drawing.Size(306, 110);
            this.btnConectar.MinimumSize = new System.Drawing.Size(184, 50);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnConectar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConectar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConectar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConectar.OnHoverImage = null;
            this.btnConectar.OnPressedColor = System.Drawing.Color.Black;
            this.btnConectar.Radius = 20;
            this.btnConectar.Size = new System.Drawing.Size(184, 50);
            this.btnConectar.TabIndex = 48;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 125);
            this.panel2.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(320, 5);
            this.panel5.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 130);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 5);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(320, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 135);
            this.panel3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 15);
            this.label1.MinimumSize = new System.Drawing.Size(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "PCB";
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoConexion.AutoSize = true;
            this.lblEstadoConexion.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoConexion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstadoConexion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoConexion.ForeColor = System.Drawing.Color.White;
            this.lblEstadoConexion.Location = new System.Drawing.Point(56, 38);
            this.lblEstadoConexion.MinimumSize = new System.Drawing.Size(237, 23);
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(239, 25);
            this.lblEstadoConexion.TabIndex = 10;
            this.lblEstadoConexion.Text = "Estado : Desconectado";
            this.lblEstadoConexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PuertoSerie
            // 
            this.PuertoSerie.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.PuertoSerie_ErrorReceived);
            this.PuertoSerie.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerie_DataReceived_1);
            // 
            // txtEnviarDatos
            // 
            this.txtEnviarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnviarDatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEnviarDatos.Location = new System.Drawing.Point(884, 73);
            this.txtEnviarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnviarDatos.Name = "txtEnviarDatos";
            this.txtEnviarDatos.Size = new System.Drawing.Size(343, 22);
            this.txtEnviarDatos.TabIndex = 48;
            this.txtEnviarDatos.Visible = false;
            this.txtEnviarDatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnviarDatos_KeyPress);
            // 
            // txtMostrarDatos
            // 
            this.txtMostrarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMostrarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.txtMostrarDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMostrarDatos.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtMostrarDatos.Location = new System.Drawing.Point(884, 95);
            this.txtMostrarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMostrarDatos.Multiline = true;
            this.txtMostrarDatos.Name = "txtMostrarDatos";
            this.txtMostrarDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMostrarDatos.Size = new System.Drawing.Size(343, 673);
            this.txtMostrarDatos.TabIndex = 49;
            this.txtMostrarDatos.Visible = false;
            // 
            // btnConsola
            // 
            this.btnConsola.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsola.Animated = true;
            this.btnConsola.AnimationHoverSpeed = 0.07F;
            this.btnConsola.AnimationSpeed = 0.03F;
            this.btnConsola.BackColor = System.Drawing.Color.Transparent;
            this.btnConsola.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnConsola.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnConsola.BorderColor = System.Drawing.Color.Black;
            this.btnConsola.BorderSize = 1;
            this.btnConsola.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConsola.FocusedColor = System.Drawing.Color.Empty;
            this.btnConsola.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsola.ForeColor = System.Drawing.Color.White;
            this.btnConsola.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnConsola.Image = null;
            this.btnConsola.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConsola.Location = new System.Drawing.Point(872, 16);
            this.btnConsola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsola.MaximumSize = new System.Drawing.Size(144, 46);
            this.btnConsola.Name = "btnConsola";
            this.btnConsola.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnConsola.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConsola.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConsola.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConsola.OnHoverImage = null;
            this.btnConsola.OnPressedColor = System.Drawing.Color.Black;
            this.btnConsola.Radius = 20;
            this.btnConsola.Size = new System.Drawing.Size(144, 46);
            this.btnConsola.TabIndex = 63;
            this.btnConsola.Text = "Consola";
            this.btnConsola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConsola.Click += new System.EventHandler(this.btnConsola_Click);
            // 
            // txtMensajeLeido
            // 
            this.txtMensajeLeido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensajeLeido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.txtMensajeLeido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMensajeLeido.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtMensajeLeido.Location = new System.Drawing.Point(1022, 11);
            this.txtMensajeLeido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMensajeLeido.Multiline = true;
            this.txtMensajeLeido.Name = "txtMensajeLeido";
            this.txtMensajeLeido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensajeLeido.Size = new System.Drawing.Size(205, 56);
            this.txtMensajeLeido.TabIndex = 64;
            this.txtMensajeLeido.Visible = false;
            // 
            // btnSignal
            // 
            this.btnSignal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignal.Animated = true;
            this.btnSignal.AnimationHoverSpeed = 0.07F;
            this.btnSignal.AnimationSpeed = 0.03F;
            this.btnSignal.BackColor = System.Drawing.Color.Transparent;
            this.btnSignal.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnSignal.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnSignal.BorderColor = System.Drawing.Color.Black;
            this.btnSignal.BorderSize = 1;
            this.btnSignal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignal.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignal.ForeColor = System.Drawing.Color.White;
            this.btnSignal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSignal.Image = null;
            this.btnSignal.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignal.Location = new System.Drawing.Point(29, 160);
            this.btnSignal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignal.MaximumSize = new System.Drawing.Size(152, 77);
            this.btnSignal.MinimumSize = new System.Drawing.Size(120, 77);
            this.btnSignal.Name = "btnSignal";
            this.btnSignal.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnSignal.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSignal.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignal.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignal.OnHoverImage = null;
            this.btnSignal.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignal.Size = new System.Drawing.Size(120, 77);
            this.btnSignal.TabIndex = 65;
            this.btnSignal.Text = "Signal Board";
            this.btnSignal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignal.Click += new System.EventHandler(this.btnSignal_Click);
            // 
            // btnPower
            // 
            this.btnPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPower.Animated = true;
            this.btnPower.AnimationHoverSpeed = 0.07F;
            this.btnPower.AnimationSpeed = 0.03F;
            this.btnPower.BackColor = System.Drawing.Color.Transparent;
            this.btnPower.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnPower.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnPower.BorderColor = System.Drawing.Color.Black;
            this.btnPower.BorderSize = 1;
            this.btnPower.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPower.FocusedColor = System.Drawing.Color.Empty;
            this.btnPower.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPower.ForeColor = System.Drawing.Color.White;
            this.btnPower.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnPower.Image = null;
            this.btnPower.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPower.Location = new System.Drawing.Point(180, 160);
            this.btnPower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPower.MaximumSize = new System.Drawing.Size(152, 77);
            this.btnPower.MinimumSize = new System.Drawing.Size(112, 77);
            this.btnPower.Name = "btnPower";
            this.btnPower.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnPower.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPower.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPower.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPower.OnHoverImage = null;
            this.btnPower.OnPressedColor = System.Drawing.Color.Black;
            this.btnPower.Size = new System.Drawing.Size(112, 77);
            this.btnPower.TabIndex = 66;
            this.btnPower.Text = "Power Board";
            this.btnPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // timerPower
            // 
            this.timerPower.Interval = 1;
            this.timerPower.Tick += new System.EventHandler(this.timerPower_Tick);
            // 
            // txtScanerPower
            // 
            this.txtScanerPower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScanerPower.Location = new System.Drawing.Point(180, 242);
            this.txtScanerPower.MaximumSize = new System.Drawing.Size(142, 50);
            this.txtScanerPower.Multiline = true;
            this.txtScanerPower.Name = "txtScanerPower";
            this.txtScanerPower.Size = new System.Drawing.Size(142, 50);
            this.txtScanerPower.TabIndex = 69;
            this.txtScanerPower.TextChanged += new System.EventHandler(this.txtScaner_TextChanged);
            this.txtScanerPower.Leave += new System.EventHandler(this.txtScanerPower_Leave);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 200;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(596, 122);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Plum;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(253, 214);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 70;
            this.circularProgressBar1.Text = "Buscando";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 4, 8, 0);
            this.circularProgressBar1.Value = 68;
            this.circularProgressBar1.Visible = false;
            // 
            // txtScanerSignal
            // 
            this.txtScanerSignal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScanerSignal.Location = new System.Drawing.Point(12, 242);
            this.txtScanerSignal.MaximumSize = new System.Drawing.Size(142, 50);
            this.txtScanerSignal.Multiline = true;
            this.txtScanerSignal.Name = "txtScanerSignal";
            this.txtScanerSignal.Size = new System.Drawing.Size(142, 50);
            this.txtScanerSignal.TabIndex = 71;
            this.txtScanerSignal.TextChanged += new System.EventHandler(this.txtScanerSignal_TextChanged);
            this.txtScanerSignal.Leave += new System.EventHandler(this.txtScanerSignal_Leave);
            // 
            // timerSignal
            // 
            this.timerSignal.Interval = 1;
            this.timerSignal.Tick += new System.EventHandler(this.timerSignal_Tick);
            // 
            // txtInicio
            // 
            this.txtInicio.Animated = true;
            this.txtInicio.AnimationHoverSpeed = 0.07F;
            this.txtInicio.AnimationSpeed = 0.03F;
            this.txtInicio.BackColor = System.Drawing.Color.Transparent;
            this.txtInicio.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.txtInicio.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.txtInicio.BorderColor = System.Drawing.Color.Black;
            this.txtInicio.BorderSize = 1;
            this.txtInicio.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtInicio.FocusedColor = System.Drawing.Color.Empty;
            this.txtInicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicio.ForeColor = System.Drawing.Color.White;
            this.txtInicio.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.txtInicio.Image = null;
            this.txtInicio.ImageSize = new System.Drawing.Size(20, 20);
            this.txtInicio.Location = new System.Drawing.Point(57, 342);
            this.txtInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.txtInicio.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtInicio.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txtInicio.OnHoverForeColor = System.Drawing.Color.White;
            this.txtInicio.OnHoverImage = null;
            this.txtInicio.OnPressedColor = System.Drawing.Color.Black;
            this.txtInicio.Size = new System.Drawing.Size(212, 73);
            this.txtInicio.TabIndex = 72;
            this.txtInicio.Text = "Comenzar programación";
            this.txtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInicio.Click += new System.EventHandler(this.txtInicio_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaPictureBox1.BackColor = System.Drawing.Color.White;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.BurlyWood;
            this.gunaPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPictureBox1.Location = new System.Drawing.Point(580, 485);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(298, 123);
            this.gunaPictureBox1.TabIndex = 74;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceptar.Animated = true;
            this.btnAceptar.AnimationHoverSpeed = 0.07F;
            this.btnAceptar.AnimationSpeed = 0.03F;
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BaseColor1 = System.Drawing.Color.ForestGreen;
            this.btnAceptar.BaseColor2 = System.Drawing.Color.Khaki;
            this.btnAceptar.BorderColor = System.Drawing.Color.Black;
            this.btnAceptar.BorderSize = 1;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAceptar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAceptar.Image = null;
            this.btnAceptar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAceptar.Location = new System.Drawing.Point(12, 715);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnAceptar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAceptar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAceptar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAceptar.OnHoverImage = null;
            this.btnAceptar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAceptar.Size = new System.Drawing.Size(137, 77);
            this.btnAceptar.TabIndex = 77;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRechazar.Animated = true;
            this.btnRechazar.AnimationHoverSpeed = 0.07F;
            this.btnRechazar.AnimationSpeed = 0.03F;
            this.btnRechazar.BackColor = System.Drawing.Color.Transparent;
            this.btnRechazar.BaseColor1 = System.Drawing.Color.Red;
            this.btnRechazar.BaseColor2 = System.Drawing.SystemColors.MenuBar;
            this.btnRechazar.BorderColor = System.Drawing.Color.Black;
            this.btnRechazar.BorderSize = 1;
            this.btnRechazar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRechazar.FocusedColor = System.Drawing.Color.Empty;
            this.btnRechazar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazar.ForeColor = System.Drawing.Color.Black;
            this.btnRechazar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRechazar.Image = null;
            this.btnRechazar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRechazar.Location = new System.Drawing.Point(164, 715);
            this.btnRechazar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnRechazar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRechazar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRechazar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRechazar.OnHoverImage = null;
            this.btnRechazar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRechazar.Size = new System.Drawing.Size(146, 77);
            this.btnRechazar.TabIndex = 78;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRechazar.Visible = false;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActivar.Animated = true;
            this.btnActivar.AnimationHoverSpeed = 0.07F;
            this.btnActivar.AnimationSpeed = 0.03F;
            this.btnActivar.BackColor = System.Drawing.Color.Transparent;
            this.btnActivar.BaseColor1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnActivar.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnActivar.BorderColor = System.Drawing.Color.Black;
            this.btnActivar.BorderSize = 1;
            this.btnActivar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnActivar.FocusedColor = System.Drawing.Color.Empty;
            this.btnActivar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.ForeColor = System.Drawing.Color.White;
            this.btnActivar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnActivar.Image = null;
            this.btnActivar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnActivar.Location = new System.Drawing.Point(85, 536);
            this.btnActivar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnActivar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnActivar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnActivar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnActivar.OnHoverImage = null;
            this.btnActivar.OnPressedColor = System.Drawing.Color.Black;
            this.btnActivar.Radius = 20;
            this.btnActivar.Size = new System.Drawing.Size(119, 83);
            this.btnActivar.TabIndex = 79;
            this.btnActivar.Text = "Activar";
            this.btnActivar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnActivar.Visible = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // gunaGradientButton4
            // 
            this.gunaGradientButton4.Animated = true;
            this.gunaGradientButton4.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton4.AnimationSpeed = 0.03F;
            this.gunaGradientButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton4.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton4.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.gunaGradientButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.BorderSize = 1;
            this.gunaGradientButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton4.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaGradientButton4.Image = null;
            this.gunaGradientButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton4.Location = new System.Drawing.Point(547, 381);
            this.gunaGradientButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGradientButton4.Name = "gunaGradientButton4";
            this.gunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.gunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.OnHoverImage = null;
            this.gunaGradientButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.Size = new System.Drawing.Size(212, 73);
            this.gunaGradientButton4.TabIndex = 81;
            this.gunaGradientButton4.Text = "Leer";
            this.gunaGradientButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(359, 113);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(81, 28);
            this.gunaLabel1.TabIndex = 82;
            this.gunaLabel1.Text = "Signal :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(359, 164);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(81, 28);
            this.gunaLabel2.TabIndex = 83;
            this.gunaLabel2.Text = "Power :";
            // 
            // lblSignal
            // 
            this.lblSignal.AutoSize = true;
            this.lblSignal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignal.ForeColor = System.Drawing.Color.White;
            this.lblSignal.Location = new System.Drawing.Point(465, 113);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Size = new System.Drawing.Size(51, 28);
            this.lblSignal.TabIndex = 84;
            this.lblSignal.Text = "N/A";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.ForeColor = System.Drawing.Color.White;
            this.lblPower.Location = new System.Drawing.Point(465, 164);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(51, 28);
            this.lblPower.TabIndex = 85;
            this.lblPower.Text = "N/A";
            // 
            // btnSignalPrueba
            // 
            this.btnSignalPrueba.AnimationHoverSpeed = 0.07F;
            this.btnSignalPrueba.AnimationSpeed = 0.03F;
            this.btnSignalPrueba.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSignalPrueba.BorderColor = System.Drawing.Color.Black;
            this.btnSignalPrueba.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSignalPrueba.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSignalPrueba.CheckedForeColor = System.Drawing.Color.White;
            this.btnSignalPrueba.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSignalPrueba.CheckedImage")));
            this.btnSignalPrueba.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSignalPrueba.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignalPrueba.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignalPrueba.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignalPrueba.ForeColor = System.Drawing.Color.White;
            this.btnSignalPrueba.Image = ((System.Drawing.Image)(resources.GetObject("btnSignalPrueba.Image")));
            this.btnSignalPrueba.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignalPrueba.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSignalPrueba.Location = new System.Drawing.Point(523, 26);
            this.btnSignalPrueba.Name = "btnSignalPrueba";
            this.btnSignalPrueba.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSignalPrueba.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignalPrueba.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignalPrueba.OnHoverImage = null;
            this.btnSignalPrueba.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSignalPrueba.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignalPrueba.Size = new System.Drawing.Size(180, 42);
            this.btnSignalPrueba.TabIndex = 86;
            this.btnSignalPrueba.Text = "Signal";
            this.btnSignalPrueba.Click += new System.EventHandler(this.btnSignalPrueba_Click);
            // 
            // btnPowerPrueba
            // 
            this.btnPowerPrueba.AnimationHoverSpeed = 0.07F;
            this.btnPowerPrueba.AnimationSpeed = 0.03F;
            this.btnPowerPrueba.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPowerPrueba.BorderColor = System.Drawing.Color.Black;
            this.btnPowerPrueba.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPowerPrueba.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPowerPrueba.CheckedForeColor = System.Drawing.Color.White;
            this.btnPowerPrueba.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPowerPrueba.CheckedImage")));
            this.btnPowerPrueba.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPowerPrueba.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPowerPrueba.FocusedColor = System.Drawing.Color.Empty;
            this.btnPowerPrueba.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPowerPrueba.ForeColor = System.Drawing.Color.White;
            this.btnPowerPrueba.Image = ((System.Drawing.Image)(resources.GetObject("btnPowerPrueba.Image")));
            this.btnPowerPrueba.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPowerPrueba.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPowerPrueba.Location = new System.Drawing.Point(523, 74);
            this.btnPowerPrueba.Name = "btnPowerPrueba";
            this.btnPowerPrueba.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPowerPrueba.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPowerPrueba.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPowerPrueba.OnHoverImage = null;
            this.btnPowerPrueba.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPowerPrueba.OnPressedColor = System.Drawing.Color.Black;
            this.btnPowerPrueba.Size = new System.Drawing.Size(180, 42);
            this.btnPowerPrueba.TabIndex = 87;
            this.btnPowerPrueba.Text = "Power";
            this.btnPowerPrueba.Click += new System.EventHandler(this.btnPowerPrueba_Click);
            // 
            // txtSignalPrueba
            // 
            this.txtSignalPrueba.BaseColor = System.Drawing.Color.White;
            this.txtSignalPrueba.BorderColor = System.Drawing.Color.Silver;
            this.txtSignalPrueba.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSignalPrueba.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSignalPrueba.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSignalPrueba.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSignalPrueba.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSignalPrueba.Location = new System.Drawing.Point(343, 26);
            this.txtSignalPrueba.Name = "txtSignalPrueba";
            this.txtSignalPrueba.PasswordChar = '\0';
            this.txtSignalPrueba.Size = new System.Drawing.Size(160, 32);
            this.txtSignalPrueba.TabIndex = 88;
            // 
            // txtPowerPrueba
            // 
            this.txtPowerPrueba.BaseColor = System.Drawing.Color.White;
            this.txtPowerPrueba.BorderColor = System.Drawing.Color.Silver;
            this.txtPowerPrueba.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPowerPrueba.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPowerPrueba.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPowerPrueba.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPowerPrueba.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPowerPrueba.Location = new System.Drawing.Point(343, 73);
            this.txtPowerPrueba.Name = "txtPowerPrueba";
            this.txtPowerPrueba.PasswordChar = '\0';
            this.txtPowerPrueba.Size = new System.Drawing.Size(160, 32);
            this.txtPowerPrueba.TabIndex = 89;
            // 
            // lblComando
            // 
            this.lblComando.AutoSize = true;
            this.lblComando.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComando.ForeColor = System.Drawing.Color.White;
            this.lblComando.Location = new System.Drawing.Point(123, 652);
            this.lblComando.Name = "lblComando";
            this.lblComando.Size = new System.Drawing.Size(51, 28);
            this.lblComando.TabIndex = 90;
            this.lblComando.Text = "N/A";
            this.lblComando.Visible = false;
            // 
            // Jupiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1239, 797);
            this.Controls.Add(this.lblComando);
            this.Controls.Add(this.txtPowerPrueba);
            this.Controls.Add(this.txtSignalPrueba);
            this.Controls.Add(this.btnPowerPrueba);
            this.Controls.Add(this.btnSignalPrueba);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.lblSignal);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaGradientButton4);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.txtScanerSignal);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.txtScanerPower);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnSignal);
            this.Controls.Add(this.txtMensajeLeido);
            this.Controls.Add(this.btnConsola);
            this.Controls.Add(this.txtEnviarDatos);
            this.Controls.Add(this.txtMostrarDatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Jupiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jupiter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jupiter_FormClosing);
            this.Load += new System.EventHandler(this.Jupiter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel panel1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaGradientButton btnConectar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstadoConexion;
        private System.IO.Ports.SerialPort PuertoSerie;
        private System.Windows.Forms.TextBox txtEnviarDatos;
        private System.Windows.Forms.TextBox txtMostrarDatos;
        private Guna.UI.WinForms.GunaGradientButton btnConsola;
        private System.Windows.Forms.TextBox txtMensajeLeido;
        private Guna.UI.WinForms.GunaGradientButton btnSignal;
        private Guna.UI.WinForms.GunaGradientButton btnPower;
        private System.Windows.Forms.Timer timerPower;
        private System.Windows.Forms.TextBox txtScanerPower;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.TextBox txtScanerSignal;
        private System.Windows.Forms.Timer timerSignal;
        private Guna.UI.WinForms.GunaGradientButton txtInicio;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaGradientButton btnAceptar;
        private Guna.UI.WinForms.GunaGradientButton btnRechazar;
        private Guna.UI.WinForms.GunaGradientButton btnActivar;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton4;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblSignal;
        private Guna.UI.WinForms.GunaLabel lblPower;
        private Guna.UI.WinForms.GunaAdvenceButton btnSignalPrueba;
        private Guna.UI.WinForms.GunaAdvenceButton btnPowerPrueba;
        private Guna.UI.WinForms.GunaTextBox txtSignalPrueba;
        private Guna.UI.WinForms.GunaTextBox txtPowerPrueba;
        private Guna.UI.WinForms.GunaLabel lblComando;
    }
}
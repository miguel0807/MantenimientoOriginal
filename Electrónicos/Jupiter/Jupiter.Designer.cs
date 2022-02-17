
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
            this.PuertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.txtEnviarDatos = new System.Windows.Forms.TextBox();
            this.txtMostrarDatos = new System.Windows.Forms.TextBox();
            this.btnConsola = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSignal = new Guna.UI.WinForms.GunaGradientButton();
            this.btnPower = new Guna.UI.WinForms.GunaGradientButton();
            this.timerPower = new System.Windows.Forms.Timer(this.components);
            this.txtScanerPower = new System.Windows.Forms.TextBox();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.txtScanerSignal = new System.Windows.Forms.TextBox();
            this.timerSignal = new System.Windows.Forms.Timer(this.components);
            this.btnComenzarProgramacion = new Guna.UI.WinForms.GunaGradientButton();
            this.btnAceptar = new Guna.UI.WinForms.GunaGradientButton();
            this.btnRechazar = new Guna.UI.WinForms.GunaGradientButton();
            this.btnActivar = new Guna.UI.WinForms.GunaGradientButton();
            this.InicioProgramación = new System.Windows.Forms.Timer(this.components);
            this.btnCargarPruebas = new Guna.UI.WinForms.GunaGradientButton();
            this.timerPruebas = new System.Windows.Forms.Timer(this.components);
            this.txtRespuesta1 = new Guna.UI.WinForms.GunaTextBox();
            this.txtRespuesta2 = new Guna.UI.WinForms.GunaTextBox();
            this.txtRespuesta4 = new Guna.UI.WinForms.GunaTextBox();
            this.txtRespuesta3 = new Guna.UI.WinForms.GunaTextBox();
            this.txtRespuesta7 = new Guna.UI.WinForms.GunaTextBox();
            this.txtRespuesta6 = new Guna.UI.WinForms.GunaTextBox();
            this.txtRespuesta5 = new Guna.UI.WinForms.GunaTextBox();
            this.lblPrueba1 = new Guna.UI.WinForms.GunaLabel();
            this.lblPrueba2 = new Guna.UI.WinForms.GunaLabel();
            this.lblPrueba3 = new Guna.UI.WinForms.GunaLabel();
            this.lblPrueba4 = new Guna.UI.WinForms.GunaLabel();
            this.lblPrueba5 = new Guna.UI.WinForms.GunaLabel();
            this.lblPrueba6 = new Guna.UI.WinForms.GunaLabel();
            this.lblPrueba7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtRespuesta8 = new Guna.UI.WinForms.GunaTextBox();
            this.panelPruebas = new Guna.UI.WinForms.GunaPanel();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.gunaCircleProgressBar1 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.txtDecodificador = new System.Windows.Forms.TextBox();
            this.lblEstadoConexion = new System.Windows.Forms.Label();
            this.btnConectar = new Guna.UI.WinForms.GunaGradientButton();
            this.btnFinalizar = new Guna.UI.WinForms.GunaGradientButton();
            this.cargarEtiquetas = new System.Windows.Forms.Timer(this.components);
            this.txtMensajeLeido = new System.Windows.Forms.TextBox();
            this.lblComando = new System.Windows.Forms.TextBox();
            this.btnGrafico = new Guna.UI.WinForms.GunaGradientButton();
            this.btnRechazarPruebas = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.panel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.lblAppVersion = new Guna.UI.WinForms.GunaLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFPGAVersion = new Guna.UI.WinForms.GunaLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblSignal = new Guna.UI.WinForms.GunaLabel();
            this.lblPower = new Guna.UI.WinForms.GunaLabel();
            this.panelConexiones = new Guna.UI.WinForms.GunaPanel();
            this.panelPruebas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelConexiones.SuspendLayout();
            this.SuspendLayout();
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
            this.txtEnviarDatos.Location = new System.Drawing.Point(884, 89);
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
            this.txtMostrarDatos.Location = new System.Drawing.Point(884, 110);
            this.txtMostrarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMostrarDatos.Multiline = true;
            this.txtMostrarDatos.Name = "txtMostrarDatos";
            this.txtMostrarDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMostrarDatos.Size = new System.Drawing.Size(343, 758);
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
            this.btnConsola.Location = new System.Drawing.Point(1083, 38);
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
            // btnSignal
            // 
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
            this.btnSignal.Location = new System.Drawing.Point(12, 16);
            this.btnSignal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignal.MaximumSize = new System.Drawing.Size(152, 78);
            this.btnSignal.MinimumSize = new System.Drawing.Size(120, 78);
            this.btnSignal.Name = "btnSignal";
            this.btnSignal.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnSignal.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSignal.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignal.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignal.OnHoverImage = null;
            this.btnSignal.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignal.Size = new System.Drawing.Size(120, 78);
            this.btnSignal.TabIndex = 0;
            this.btnSignal.Text = "Signal Board";
            this.btnSignal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignal.Click += new System.EventHandler(this.btnSignal_Click);
            // 
            // btnPower
            // 
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
            this.btnPower.Location = new System.Drawing.Point(139, 16);
            this.btnPower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPower.MaximumSize = new System.Drawing.Size(152, 78);
            this.btnPower.MinimumSize = new System.Drawing.Size(112, 78);
            this.btnPower.Name = "btnPower";
            this.btnPower.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnPower.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPower.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPower.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPower.OnHoverImage = null;
            this.btnPower.OnPressedColor = System.Drawing.Color.Black;
            this.btnPower.Size = new System.Drawing.Size(112, 78);
            this.btnPower.TabIndex = 1;
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
            this.txtScanerPower.Location = new System.Drawing.Point(161, 41);
            this.txtScanerPower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScanerPower.MaximumSize = new System.Drawing.Size(143, 50);
            this.txtScanerPower.Multiline = true;
            this.txtScanerPower.Name = "txtScanerPower";
            this.txtScanerPower.Size = new System.Drawing.Size(68, 26);
            this.txtScanerPower.TabIndex = 69;
            this.txtScanerPower.TabStop = false;
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
            this.circularProgressBar1.Location = new System.Drawing.Point(301, 9);
            this.circularProgressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Plum;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(153, 128);
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
            this.txtScanerSignal.Location = new System.Drawing.Point(51, 42);
            this.txtScanerSignal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScanerSignal.MaximumSize = new System.Drawing.Size(143, 50);
            this.txtScanerSignal.Multiline = true;
            this.txtScanerSignal.Name = "txtScanerSignal";
            this.txtScanerSignal.Size = new System.Drawing.Size(60, 25);
            this.txtScanerSignal.TabIndex = 71;
            this.txtScanerSignal.TabStop = false;
            this.txtScanerSignal.TextChanged += new System.EventHandler(this.txtScanerSignal_TextChanged);
            this.txtScanerSignal.Leave += new System.EventHandler(this.txtScanerSignal_Leave);
            // 
            // timerSignal
            // 
            this.timerSignal.Interval = 1;
            this.timerSignal.Tick += new System.EventHandler(this.timerSignal_Tick);
            // 
            // btnComenzarProgramacion
            // 
            this.btnComenzarProgramacion.Animated = true;
            this.btnComenzarProgramacion.AnimationHoverSpeed = 0.07F;
            this.btnComenzarProgramacion.AnimationSpeed = 0.03F;
            this.btnComenzarProgramacion.BackColor = System.Drawing.Color.Transparent;
            this.btnComenzarProgramacion.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnComenzarProgramacion.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnComenzarProgramacion.BorderColor = System.Drawing.Color.Black;
            this.btnComenzarProgramacion.BorderSize = 1;
            this.btnComenzarProgramacion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnComenzarProgramacion.FocusedColor = System.Drawing.Color.Empty;
            this.btnComenzarProgramacion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzarProgramacion.ForeColor = System.Drawing.Color.White;
            this.btnComenzarProgramacion.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnComenzarProgramacion.Image = null;
            this.btnComenzarProgramacion.ImageSize = new System.Drawing.Size(20, 20);
            this.btnComenzarProgramacion.Location = new System.Drawing.Point(23, 137);
            this.btnComenzarProgramacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComenzarProgramacion.Name = "btnComenzarProgramacion";
            this.btnComenzarProgramacion.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnComenzarProgramacion.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnComenzarProgramacion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnComenzarProgramacion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnComenzarProgramacion.OnHoverImage = null;
            this.btnComenzarProgramacion.OnPressedColor = System.Drawing.Color.Black;
            this.btnComenzarProgramacion.Size = new System.Drawing.Size(212, 73);
            this.btnComenzarProgramacion.TabIndex = 72;
            this.btnComenzarProgramacion.Text = "Comenzar programación";
            this.btnComenzarProgramacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnComenzarProgramacion.Visible = false;
            this.btnComenzarProgramacion.Click += new System.EventHandler(this.txtInicio_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Animated = true;
            this.btnAceptar.AnimationHoverSpeed = 0.07F;
            this.btnAceptar.AnimationSpeed = 0.03F;
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BaseColor1 = System.Drawing.Color.ForestGreen;
            this.btnAceptar.BaseColor2 = System.Drawing.Color.FloralWhite;
            this.btnAceptar.BorderColor = System.Drawing.Color.Black;
            this.btnAceptar.BorderSize = 1;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAceptar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAceptar.Image = null;
            this.btnAceptar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAceptar.Location = new System.Drawing.Point(37, 340);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.OnHoverBaseColor1 = System.Drawing.Color.ForestGreen;
            this.btnAceptar.OnHoverBaseColor2 = System.Drawing.Color.YellowGreen;
            this.btnAceptar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAceptar.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAceptar.OnHoverImage = null;
            this.btnAceptar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAceptar.Size = new System.Drawing.Size(137, 78);
            this.btnAceptar.TabIndex = 77;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnRechazar
            // 
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
            this.btnRechazar.Location = new System.Drawing.Point(301, 340);
            this.btnRechazar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.OnHoverBaseColor1 = System.Drawing.Color.Red;
            this.btnRechazar.OnHoverBaseColor2 = System.Drawing.Color.Firebrick;
            this.btnRechazar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRechazar.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnRechazar.OnHoverImage = null;
            this.btnRechazar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRechazar.Size = new System.Drawing.Size(147, 78);
            this.btnRechazar.TabIndex = 78;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRechazar.Visible = false;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Animated = true;
            this.btnActivar.AnimationHoverSpeed = 0.07F;
            this.btnActivar.AnimationSpeed = 0.03F;
            this.btnActivar.BackColor = System.Drawing.Color.Transparent;
            this.btnActivar.BaseColor1 = System.Drawing.Color.Gray;
            this.btnActivar.BaseColor2 = System.Drawing.Color.Gray;
            this.btnActivar.BorderColor = System.Drawing.Color.Black;
            this.btnActivar.BorderSize = 1;
            this.btnActivar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnActivar.FocusedColor = System.Drawing.Color.Empty;
            this.btnActivar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.ForeColor = System.Drawing.Color.Black;
            this.btnActivar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnActivar.Image = null;
            this.btnActivar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnActivar.Location = new System.Drawing.Point(180, 336);
            this.btnActivar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnActivar.OnHoverBaseColor2 = System.Drawing.Color.Gray;
            this.btnActivar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnActivar.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnActivar.OnHoverImage = null;
            this.btnActivar.OnPressedColor = System.Drawing.Color.Black;
            this.btnActivar.Radius = 20;
            this.btnActivar.Size = new System.Drawing.Size(119, 82);
            this.btnActivar.TabIndex = 79;
            this.btnActivar.Text = "Activar";
            this.btnActivar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnActivar.Visible = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // InicioProgramación
            // 
            this.InicioProgramación.Interval = 1000;
            this.InicioProgramación.Tick += new System.EventHandler(this.InicioProgramación_Tick);
            // 
            // btnCargarPruebas
            // 
            this.btnCargarPruebas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCargarPruebas.Animated = true;
            this.btnCargarPruebas.AnimationHoverSpeed = 0.07F;
            this.btnCargarPruebas.AnimationSpeed = 0.03F;
            this.btnCargarPruebas.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarPruebas.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnCargarPruebas.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnCargarPruebas.BorderColor = System.Drawing.Color.Black;
            this.btnCargarPruebas.BorderSize = 1;
            this.btnCargarPruebas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCargarPruebas.FocusedColor = System.Drawing.Color.Empty;
            this.btnCargarPruebas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPruebas.ForeColor = System.Drawing.Color.White;
            this.btnCargarPruebas.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCargarPruebas.Image = null;
            this.btnCargarPruebas.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCargarPruebas.Location = new System.Drawing.Point(12, 439);
            this.btnCargarPruebas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarPruebas.Name = "btnCargarPruebas";
            this.btnCargarPruebas.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnCargarPruebas.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCargarPruebas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCargarPruebas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCargarPruebas.OnHoverImage = null;
            this.btnCargarPruebas.OnPressedColor = System.Drawing.Color.Black;
            this.btnCargarPruebas.Size = new System.Drawing.Size(212, 73);
            this.btnCargarPruebas.TabIndex = 91;
            this.btnCargarPruebas.Text = "Cargar Pruebas";
            this.btnCargarPruebas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCargarPruebas.Visible = false;
            this.btnCargarPruebas.Click += new System.EventHandler(this.btnCargarPruebas_Click);
            // 
            // timerPruebas
            // 
            this.timerPruebas.Interval = 800;
            this.timerPruebas.Tick += new System.EventHandler(this.timerPruebas_Tick);
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.BaseColor = System.Drawing.Color.DarkGray;
            this.txtRespuesta1.BorderColor = System.Drawing.Color.Silver;
            this.txtRespuesta1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRespuesta1.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRespuesta1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRespuesta1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRespuesta1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRespuesta1.Location = new System.Drawing.Point(249, 9);
            this.txtRespuesta1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRespuesta1.MaximumSize = new System.Drawing.Size(161, 36);
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.PasswordChar = '\0';
            this.txtRespuesta1.Size = new System.Drawing.Size(161, 36);
            this.txtRespuesta1.TabIndex = 94;
            // 
            // txtRespuesta2
            // 
            this.txtRespuesta2.BaseColor = System.Drawing.Color.DarkGray;
            this.txtRespuesta2.BorderColor = System.Drawing.Color.Silver;
            this.txtRespuesta2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRespuesta2.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRespuesta2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRespuesta2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRespuesta2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRespuesta2.Location = new System.Drawing.Point(249, 48);
            this.txtRespuesta2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRespuesta2.Name = "txtRespuesta2";
            this.txtRespuesta2.PasswordChar = '\0';
            this.txtRespuesta2.Size = new System.Drawing.Size(161, 37);
            this.txtRespuesta2.TabIndex = 96;
            // 
            // txtRespuesta4
            // 
            this.txtRespuesta4.BaseColor = System.Drawing.Color.DarkGray;
            this.txtRespuesta4.BorderColor = System.Drawing.Color.Silver;
            this.txtRespuesta4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRespuesta4.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRespuesta4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRespuesta4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRespuesta4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRespuesta4.Location = new System.Drawing.Point(249, 126);
            this.txtRespuesta4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRespuesta4.Name = "txtRespuesta4";
            this.txtRespuesta4.PasswordChar = '\0';
            this.txtRespuesta4.Size = new System.Drawing.Size(161, 37);
            this.txtRespuesta4.TabIndex = 100;
            // 
            // txtRespuesta3
            // 
            this.txtRespuesta3.BaseColor = System.Drawing.Color.DarkGray;
            this.txtRespuesta3.BorderColor = System.Drawing.Color.Silver;
            this.txtRespuesta3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRespuesta3.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRespuesta3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRespuesta3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRespuesta3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRespuesta3.Location = new System.Drawing.Point(249, 86);
            this.txtRespuesta3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRespuesta3.Name = "txtRespuesta3";
            this.txtRespuesta3.PasswordChar = '\0';
            this.txtRespuesta3.Size = new System.Drawing.Size(161, 37);
            this.txtRespuesta3.TabIndex = 98;
            // 
            // txtRespuesta7
            // 
            this.txtRespuesta7.BaseColor = System.Drawing.Color.DarkGray;
            this.txtRespuesta7.BorderColor = System.Drawing.Color.Silver;
            this.txtRespuesta7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRespuesta7.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRespuesta7.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRespuesta7.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRespuesta7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRespuesta7.Location = new System.Drawing.Point(249, 240);
            this.txtRespuesta7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRespuesta7.Name = "txtRespuesta7";
            this.txtRespuesta7.PasswordChar = '\0';
            this.txtRespuesta7.Size = new System.Drawing.Size(161, 37);
            this.txtRespuesta7.TabIndex = 106;
            // 
            // txtRespuesta6
            // 
            this.txtRespuesta6.BaseColor = System.Drawing.Color.DarkGray;
            this.txtRespuesta6.BorderColor = System.Drawing.Color.Silver;
            this.txtRespuesta6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRespuesta6.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRespuesta6.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRespuesta6.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRespuesta6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRespuesta6.Location = new System.Drawing.Point(249, 202);
            this.txtRespuesta6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRespuesta6.Name = "txtRespuesta6";
            this.txtRespuesta6.PasswordChar = '\0';
            this.txtRespuesta6.Size = new System.Drawing.Size(161, 37);
            this.txtRespuesta6.TabIndex = 104;
            // 
            // txtRespuesta5
            // 
            this.txtRespuesta5.BaseColor = System.Drawing.Color.DarkGray;
            this.txtRespuesta5.BorderColor = System.Drawing.Color.Silver;
            this.txtRespuesta5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRespuesta5.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRespuesta5.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRespuesta5.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRespuesta5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRespuesta5.Location = new System.Drawing.Point(249, 162);
            this.txtRespuesta5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRespuesta5.Name = "txtRespuesta5";
            this.txtRespuesta5.PasswordChar = '\0';
            this.txtRespuesta5.Size = new System.Drawing.Size(161, 37);
            this.txtRespuesta5.TabIndex = 102;
            // 
            // lblPrueba1
            // 
            this.lblPrueba1.AutoSize = true;
            this.lblPrueba1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba1.ForeColor = System.Drawing.Color.White;
            this.lblPrueba1.Location = new System.Drawing.Point(1, 9);
            this.lblPrueba1.Name = "lblPrueba1";
            this.lblPrueba1.Size = new System.Drawing.Size(56, 28);
            this.lblPrueba1.TabIndex = 109;
            this.lblPrueba1.Text = "i2c c";
            // 
            // lblPrueba2
            // 
            this.lblPrueba2.AutoSize = true;
            this.lblPrueba2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba2.ForeColor = System.Drawing.Color.White;
            this.lblPrueba2.Location = new System.Drawing.Point(1, 48);
            this.lblPrueba2.Name = "lblPrueba2";
            this.lblPrueba2.Size = new System.Drawing.Size(170, 28);
            this.lblPrueba2.TabIndex = 110;
            this.lblPrueba2.Text = "i2c w 1024 1 2 3";
            // 
            // lblPrueba3
            // 
            this.lblPrueba3.AutoSize = true;
            this.lblPrueba3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba3.ForeColor = System.Drawing.Color.White;
            this.lblPrueba3.Location = new System.Drawing.Point(1, 90);
            this.lblPrueba3.Name = "lblPrueba3";
            this.lblPrueba3.Size = new System.Drawing.Size(170, 28);
            this.lblPrueba3.TabIndex = 111;
            this.lblPrueba3.Text = "i2c w 1025 1 2 3";
            // 
            // lblPrueba4
            // 
            this.lblPrueba4.AutoSize = true;
            this.lblPrueba4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba4.ForeColor = System.Drawing.Color.White;
            this.lblPrueba4.Location = new System.Drawing.Point(1, 129);
            this.lblPrueba4.Name = "lblPrueba4";
            this.lblPrueba4.Size = new System.Drawing.Size(170, 28);
            this.lblPrueba4.TabIndex = 112;
            this.lblPrueba4.Text = "i2c w 1026 1 2 3";
            // 
            // lblPrueba5
            // 
            this.lblPrueba5.AutoSize = true;
            this.lblPrueba5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba5.ForeColor = System.Drawing.Color.White;
            this.lblPrueba5.Location = new System.Drawing.Point(1, 167);
            this.lblPrueba5.Name = "lblPrueba5";
            this.lblPrueba5.Size = new System.Drawing.Size(108, 28);
            this.lblPrueba5.TabIndex = 113;
            this.lblPrueba5.Text = "i2c r 1024";
            // 
            // lblPrueba6
            // 
            this.lblPrueba6.AutoSize = true;
            this.lblPrueba6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba6.ForeColor = System.Drawing.Color.White;
            this.lblPrueba6.Location = new System.Drawing.Point(1, 206);
            this.lblPrueba6.Name = "lblPrueba6";
            this.lblPrueba6.Size = new System.Drawing.Size(242, 28);
            this.lblPrueba6.TabIndex = 114;
            this.lblPrueba6.Text = "i2c w 1024 255 255 255";
            // 
            // lblPrueba7
            // 
            this.lblPrueba7.AutoSize = true;
            this.lblPrueba7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba7.ForeColor = System.Drawing.Color.White;
            this.lblPrueba7.Location = new System.Drawing.Point(1, 244);
            this.lblPrueba7.Name = "lblPrueba7";
            this.lblPrueba7.Size = new System.Drawing.Size(242, 28);
            this.lblPrueba7.TabIndex = 115;
            this.lblPrueba7.Text = "i2c w 1025 255 255 255";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(1, 283);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(242, 28);
            this.gunaLabel3.TabIndex = 117;
            this.gunaLabel3.Text = "i2c w 1026 255 255 255";
            // 
            // txtRespuesta8
            // 
            this.txtRespuesta8.BaseColor = System.Drawing.Color.DarkGray;
            this.txtRespuesta8.BorderColor = System.Drawing.Color.Silver;
            this.txtRespuesta8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRespuesta8.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRespuesta8.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRespuesta8.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRespuesta8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRespuesta8.Location = new System.Drawing.Point(249, 279);
            this.txtRespuesta8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRespuesta8.Name = "txtRespuesta8";
            this.txtRespuesta8.PasswordChar = '\0';
            this.txtRespuesta8.Size = new System.Drawing.Size(161, 37);
            this.txtRespuesta8.TabIndex = 116;
            // 
            // panelPruebas
            // 
            this.panelPruebas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelPruebas.BackColor = System.Drawing.Color.DimGray;
            this.panelPruebas.Controls.Add(this.pic8);
            this.panelPruebas.Controls.Add(this.pic7);
            this.panelPruebas.Controls.Add(this.pic6);
            this.panelPruebas.Controls.Add(this.pic5);
            this.panelPruebas.Controls.Add(this.pic4);
            this.panelPruebas.Controls.Add(this.pic3);
            this.panelPruebas.Controls.Add(this.pic2);
            this.panelPruebas.Controls.Add(this.pic1);
            this.panelPruebas.Controls.Add(this.gunaLabel3);
            this.panelPruebas.Controls.Add(this.txtRespuesta8);
            this.panelPruebas.Controls.Add(this.lblPrueba7);
            this.panelPruebas.Controls.Add(this.lblPrueba6);
            this.panelPruebas.Controls.Add(this.lblPrueba5);
            this.panelPruebas.Controls.Add(this.lblPrueba4);
            this.panelPruebas.Controls.Add(this.lblPrueba3);
            this.panelPruebas.Controls.Add(this.lblPrueba2);
            this.panelPruebas.Controls.Add(this.lblPrueba1);
            this.panelPruebas.Controls.Add(this.txtRespuesta7);
            this.panelPruebas.Controls.Add(this.txtRespuesta6);
            this.panelPruebas.Controls.Add(this.txtRespuesta5);
            this.panelPruebas.Controls.Add(this.txtRespuesta4);
            this.panelPruebas.Controls.Add(this.txtRespuesta3);
            this.panelPruebas.Controls.Add(this.txtRespuesta2);
            this.panelPruebas.Controls.Add(this.txtRespuesta1);
            this.panelPruebas.Location = new System.Drawing.Point(12, 517);
            this.panelPruebas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPruebas.Name = "panelPruebas";
            this.panelPruebas.Size = new System.Drawing.Size(480, 353);
            this.panelPruebas.TabIndex = 126;
            this.panelPruebas.Visible = false;
            // 
            // pic8
            // 
            this.pic8.Location = new System.Drawing.Point(413, 279);
            this.pic8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(53, 36);
            this.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic8.TabIndex = 131;
            this.pic8.TabStop = false;
            // 
            // pic7
            // 
            this.pic7.Location = new System.Drawing.Point(413, 240);
            this.pic7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(53, 36);
            this.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic7.TabIndex = 132;
            this.pic7.TabStop = false;
            // 
            // pic6
            // 
            this.pic6.Location = new System.Drawing.Point(413, 202);
            this.pic6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(53, 36);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic6.TabIndex = 133;
            this.pic6.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.Location = new System.Drawing.Point(413, 162);
            this.pic5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(53, 36);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic5.TabIndex = 130;
            this.pic5.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Location = new System.Drawing.Point(413, 126);
            this.pic4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(53, 36);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic4.TabIndex = 128;
            this.pic4.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(413, 86);
            this.pic3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(53, 36);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3.TabIndex = 129;
            this.pic3.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(413, 48);
            this.pic2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(53, 36);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 129;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(413, 9);
            this.pic1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(53, 36);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 127;
            this.pic1.TabStop = false;
            // 
            // gunaCircleProgressBar1
            // 
            this.gunaCircleProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaCircleProgressBar1.Animated = true;
            this.gunaCircleProgressBar1.AnimationSpeed = 0.2F;
            this.gunaCircleProgressBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.gunaCircleProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.Transition;
            this.gunaCircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleProgressBar1.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.gunaCircleProgressBar1.IdleOffset = 20;
            this.gunaCircleProgressBar1.Image = null;
            this.gunaCircleProgressBar1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleProgressBar1.Location = new System.Drawing.Point(539, 583);
            this.gunaCircleProgressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleProgressBar1.Name = "gunaCircleProgressBar1";
            this.gunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCircleProgressBar1.ProgressOffset = 20;
            this.gunaCircleProgressBar1.Size = new System.Drawing.Size(188, 167);
            this.gunaCircleProgressBar1.TabIndex = 127;
            this.gunaCircleProgressBar1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.gunaCircleProgressBar1.UseProgressPercentText = true;
            this.gunaCircleProgressBar1.Visible = false;
            // 
            // txtDecodificador
            // 
            this.txtDecodificador.Location = new System.Drawing.Point(385, 473);
            this.txtDecodificador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDecodificador.Multiline = true;
            this.txtDecodificador.Name = "txtDecodificador";
            this.txtDecodificador.Size = new System.Drawing.Size(107, 38);
            this.txtDecodificador.TabIndex = 108;
            this.txtDecodificador.Visible = false;
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
            this.lblEstadoConexion.Location = new System.Drawing.Point(944, 9);
            this.lblEstadoConexion.MinimumSize = new System.Drawing.Size(237, 23);
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(239, 25);
            this.lblEstadoConexion.TabIndex = 10;
            this.lblEstadoConexion.Text = "Estado : Desconectado";
            this.lblEstadoConexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnConectar.Location = new System.Drawing.Point(901, 38);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConectar.MaximumSize = new System.Drawing.Size(144, 46);
            this.btnConectar.MinimumSize = new System.Drawing.Size(144, 46);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnConectar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConectar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConectar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConectar.OnHoverImage = null;
            this.btnConectar.OnPressedColor = System.Drawing.Color.Black;
            this.btnConectar.Radius = 20;
            this.btnConectar.Size = new System.Drawing.Size(144, 46);
            this.btnConectar.TabIndex = 48;
            this.btnConectar.TabStop = false;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Animated = true;
            this.btnFinalizar.AnimationHoverSpeed = 0.07F;
            this.btnFinalizar.AnimationSpeed = 0.03F;
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnFinalizar.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnFinalizar.BorderColor = System.Drawing.Color.Black;
            this.btnFinalizar.BorderSize = 1;
            this.btnFinalizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFinalizar.FocusedColor = System.Drawing.Color.Empty;
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnFinalizar.Image = null;
            this.btnFinalizar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFinalizar.Location = new System.Drawing.Point(637, 517);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnFinalizar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFinalizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFinalizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFinalizar.OnHoverImage = null;
            this.btnFinalizar.OnPressedColor = System.Drawing.Color.Black;
            this.btnFinalizar.Size = new System.Drawing.Size(212, 73);
            this.btnFinalizar.TabIndex = 128;
            this.btnFinalizar.Text = "Enviar información";
            this.btnFinalizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFinalizar.Visible = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cargarEtiquetas
            // 
            this.cargarEtiquetas.Tick += new System.EventHandler(this.cargarEtiquetas_Tick);
            // 
            // txtMensajeLeido
            // 
            this.txtMensajeLeido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensajeLeido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.txtMensajeLeido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMensajeLeido.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtMensajeLeido.Location = new System.Drawing.Point(917, 341);
            this.txtMensajeLeido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMensajeLeido.Multiline = true;
            this.txtMensajeLeido.Name = "txtMensajeLeido";
            this.txtMensajeLeido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensajeLeido.Size = new System.Drawing.Size(143, 77);
            this.txtMensajeLeido.TabIndex = 135;
            this.txtMensajeLeido.Visible = false;
            // 
            // lblComando
            // 
            this.lblComando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.lblComando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComando.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblComando.Location = new System.Drawing.Point(51, 225);
            this.lblComando.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblComando.Multiline = true;
            this.lblComando.Name = "lblComando";
            this.lblComando.ReadOnly = true;
            this.lblComando.Size = new System.Drawing.Size(339, 34);
            this.lblComando.TabIndex = 136;
            this.lblComando.Visible = false;
            // 
            // btnGrafico
            // 
            this.btnGrafico.Animated = true;
            this.btnGrafico.AnimationHoverSpeed = 0.07F;
            this.btnGrafico.AnimationSpeed = 0.03F;
            this.btnGrafico.BackColor = System.Drawing.Color.Transparent;
            this.btnGrafico.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnGrafico.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnGrafico.BorderColor = System.Drawing.Color.Black;
            this.btnGrafico.BorderSize = 1;
            this.btnGrafico.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGrafico.FocusedColor = System.Drawing.Color.Empty;
            this.btnGrafico.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafico.ForeColor = System.Drawing.Color.White;
            this.btnGrafico.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnGrafico.Image = null;
            this.btnGrafico.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGrafico.Location = new System.Drawing.Point(637, 425);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnGrafico.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGrafico.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGrafico.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGrafico.OnHoverImage = null;
            this.btnGrafico.OnPressedColor = System.Drawing.Color.Black;
            this.btnGrafico.Size = new System.Drawing.Size(212, 73);
            this.btnGrafico.TabIndex = 137;
            this.btnGrafico.Text = "Cargar Grafico";
            this.btnGrafico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGrafico.Visible = false;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // btnRechazarPruebas
            // 
            this.btnRechazarPruebas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRechazarPruebas.Animated = true;
            this.btnRechazarPruebas.AnimationHoverSpeed = 0.07F;
            this.btnRechazarPruebas.AnimationSpeed = 0.03F;
            this.btnRechazarPruebas.BackColor = System.Drawing.Color.Transparent;
            this.btnRechazarPruebas.BaseColor1 = System.Drawing.Color.Red;
            this.btnRechazarPruebas.BaseColor2 = System.Drawing.SystemColors.MenuBar;
            this.btnRechazarPruebas.BorderColor = System.Drawing.Color.Black;
            this.btnRechazarPruebas.BorderSize = 1;
            this.btnRechazarPruebas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRechazarPruebas.FocusedColor = System.Drawing.Color.Empty;
            this.btnRechazarPruebas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazarPruebas.ForeColor = System.Drawing.Color.Black;
            this.btnRechazarPruebas.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRechazarPruebas.Image = null;
            this.btnRechazarPruebas.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRechazarPruebas.Location = new System.Drawing.Point(232, 439);
            this.btnRechazarPruebas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRechazarPruebas.Name = "btnRechazarPruebas";
            this.btnRechazarPruebas.OnHoverBaseColor1 = System.Drawing.Color.Red;
            this.btnRechazarPruebas.OnHoverBaseColor2 = System.Drawing.Color.Firebrick;
            this.btnRechazarPruebas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRechazarPruebas.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnRechazarPruebas.OnHoverImage = null;
            this.btnRechazarPruebas.OnPressedColor = System.Drawing.Color.Black;
            this.btnRechazarPruebas.Size = new System.Drawing.Size(147, 74);
            this.btnRechazarPruebas.TabIndex = 138;
            this.btnRechazarPruebas.Text = "Rechazar";
            this.btnRechazarPruebas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRechazarPruebas.Visible = false;
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Image = global::Electrónicos.Properties.Resources._8_corto;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(34, 45);
            this.gunaTransfarantPictureBox1.MinimumSize = new System.Drawing.Size(618, 405);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(618, 405);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaTransfarantPictureBox1.TabIndex = 139;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblAppVersion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblFPGAVersion);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.gunaLabel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.gunaLabel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.lblSignal);
            this.panel1.Controls.Add(this.lblPower);
            this.panel1.GradientColor1 = System.Drawing.SystemColors.Highlight;
            this.panel1.GradientColor2 = System.Drawing.Color.DarkGray;
            this.panel1.GradientColor3 = System.Drawing.Color.DarkSalmon;
            this.panel1.GradientColor4 = System.Drawing.Color.RosyBrown;
            this.panel1.Location = new System.Drawing.Point(505, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(349, 209);
            this.panel1.MinimumSize = new System.Drawing.Size(325, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 152);
            this.panel1.TabIndex = 47;
            this.panel1.Text = "gunaGradientPanel1";
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.AutoSize = true;
            this.lblAppVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblAppVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppVersion.ForeColor = System.Drawing.Color.White;
            this.lblAppVersion.Location = new System.Drawing.Point(172, 84);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(51, 28);
            this.lblAppVersion.TabIndex = 133;
            this.lblAppVersion.Text = "N/A";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 142);
            this.panel2.TabIndex = 13;
            // 
            // lblFPGAVersion
            // 
            this.lblFPGAVersion.AutoSize = true;
            this.lblFPGAVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblFPGAVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPGAVersion.ForeColor = System.Drawing.Color.White;
            this.lblFPGAVersion.Location = new System.Drawing.Point(172, 112);
            this.lblFPGAVersion.Name = "lblFPGAVersion";
            this.lblFPGAVersion.Size = new System.Drawing.Size(51, 28);
            this.lblFPGAVersion.TabIndex = 132;
            this.lblFPGAVersion.Text = "N/A";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(344, 5);
            this.panel5.TabIndex = 15;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(11, 107);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(143, 28);
            this.gunaLabel6.TabIndex = 130;
            this.gunaLabel6.Text = "FPGA Version:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 147);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(344, 5);
            this.panel4.TabIndex = 14;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Location = new System.Drawing.Point(11, 78);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(131, 28);
            this.gunaLabel7.TabIndex = 129;
            this.gunaLabel7.Text = "App Version:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(344, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 152);
            this.panel3.TabIndex = 14;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(11, 5);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(81, 28);
            this.gunaLabel1.TabIndex = 82;
            this.gunaLabel1.Text = "Signal :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(11, 46);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(81, 28);
            this.gunaLabel2.TabIndex = 83;
            this.gunaLabel2.Text = "Power :";
            // 
            // lblSignal
            // 
            this.lblSignal.AutoSize = true;
            this.lblSignal.BackColor = System.Drawing.Color.Transparent;
            this.lblSignal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignal.ForeColor = System.Drawing.Color.White;
            this.lblSignal.Location = new System.Drawing.Point(172, 7);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Size = new System.Drawing.Size(51, 28);
            this.lblSignal.TabIndex = 84;
            this.lblSignal.Text = "N/A";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.BackColor = System.Drawing.Color.Transparent;
            this.lblPower.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.ForeColor = System.Drawing.Color.White;
            this.lblPower.Location = new System.Drawing.Point(172, 46);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(51, 28);
            this.lblPower.TabIndex = 85;
            this.lblPower.Text = "N/A";
            // 
            // panelConexiones
            // 
            this.panelConexiones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConexiones.BackColor = System.Drawing.Color.Transparent;
            this.panelConexiones.Controls.Add(this.gunaTransfarantPictureBox1);
            this.panelConexiones.Location = new System.Drawing.Point(454, 198);
            this.panelConexiones.Name = "panelConexiones";
            this.panelConexiones.Size = new System.Drawing.Size(716, 558);
            this.panelConexiones.TabIndex = 140;
            this.panelConexiones.Visible = false;
            // 
            // Jupiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1239, 882);
            this.Controls.Add(this.lblComando);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.panelConexiones);
            this.Controls.Add(this.btnRechazarPruebas);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.panelPruebas);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnSignal);
            this.Controls.Add(this.gunaCircleProgressBar1);
            this.Controls.Add(this.btnCargarPruebas);
            this.Controls.Add(this.lblEstadoConexion);
            this.Controls.Add(this.btnComenzarProgramacion);
            this.Controls.Add(this.txtScanerSignal);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.txtScanerPower);
            this.Controls.Add(this.btnConsola);
            this.Controls.Add(this.txtEnviarDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDecodificador);
            this.Controls.Add(this.txtMostrarDatos);
            this.Controls.Add(this.txtMensajeLeido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Jupiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jupiter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jupiter_FormClosing);
            this.Load += new System.EventHandler(this.Jupiter_Load);
            this.panelPruebas.ResumeLayout(false);
            this.panelPruebas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelConexiones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort PuertoSerie;
        private System.Windows.Forms.TextBox txtEnviarDatos;
        private System.Windows.Forms.TextBox txtMostrarDatos;
        private Guna.UI.WinForms.GunaGradientButton btnConsola;
        private Guna.UI.WinForms.GunaGradientButton btnSignal;
        private Guna.UI.WinForms.GunaGradientButton btnPower;
        private System.Windows.Forms.Timer timerPower;
        private System.Windows.Forms.TextBox txtScanerPower;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.TextBox txtScanerSignal;
        private System.Windows.Forms.Timer timerSignal;
        private Guna.UI.WinForms.GunaGradientButton btnComenzarProgramacion;
        private Guna.UI.WinForms.GunaGradientButton btnAceptar;
        private Guna.UI.WinForms.GunaGradientButton btnRechazar;
        private Guna.UI.WinForms.GunaGradientButton btnActivar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblSignal;
        private Guna.UI.WinForms.GunaLabel lblPower;
        private System.Windows.Forms.Timer InicioProgramación;
        private Guna.UI.WinForms.GunaGradientButton btnCargarPruebas;
        private System.Windows.Forms.Timer timerPruebas;
        private Guna.UI.WinForms.GunaTextBox txtRespuesta1;
        private Guna.UI.WinForms.GunaTextBox txtRespuesta2;
        private Guna.UI.WinForms.GunaTextBox txtRespuesta4;
        private Guna.UI.WinForms.GunaTextBox txtRespuesta3;
        private Guna.UI.WinForms.GunaTextBox txtRespuesta7;
        private Guna.UI.WinForms.GunaTextBox txtRespuesta6;
        private Guna.UI.WinForms.GunaTextBox txtRespuesta5;
        private Guna.UI.WinForms.GunaLabel lblPrueba1;
        private Guna.UI.WinForms.GunaLabel lblPrueba2;
        private Guna.UI.WinForms.GunaLabel lblPrueba3;
        private Guna.UI.WinForms.GunaLabel lblPrueba4;
        private Guna.UI.WinForms.GunaLabel lblPrueba5;
        private Guna.UI.WinForms.GunaLabel lblPrueba6;
        private Guna.UI.WinForms.GunaLabel lblPrueba7;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtRespuesta8;
        private Guna.UI.WinForms.GunaPanel panelPruebas;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic2;
        private Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressBar1;
        private System.Windows.Forms.TextBox txtDecodificador;
        private System.Windows.Forms.Label lblEstadoConexion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaGradientButton btnConectar;
        private Guna.UI.WinForms.GunaGradientPanel panel1;
        private Guna.UI.WinForms.GunaGradientButton btnFinalizar;
        private Guna.UI.WinForms.GunaLabel lblFPGAVersion;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private System.Windows.Forms.Timer cargarEtiquetas;
        private Guna.UI.WinForms.GunaLabel lblAppVersion;
        private System.Windows.Forms.TextBox txtMensajeLeido;
        private System.Windows.Forms.TextBox lblComando;
        private Guna.UI.WinForms.GunaGradientButton btnGrafico;
        private Guna.UI.WinForms.GunaGradientButton btnRechazarPruebas;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private Guna.UI.WinForms.GunaPanel panelConexiones;
    }
}
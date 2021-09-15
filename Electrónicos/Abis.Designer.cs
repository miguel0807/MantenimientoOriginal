
namespace Electrónicos
{
    partial class Abis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abis));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLineas = new System.Windows.Forms.Button();
            this.PuertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.btnCalibracion = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btnColocarArriba = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.btnColocarAbajo = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.btnColocarLado = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaCircleProgressBar1 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.btnRetrabajo = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblResgistros = new System.Windows.Forms.Label();
            this.btnConsola = new Guna.UI.WinForms.GunaGradientButton();
            this.derecho = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.cASAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hofarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerDesconectadoCSM = new System.Windows.Forms.Timer(this.components);
            this.panelConsola = new Guna.UI.WinForms.GunaGradientPanel();
            this.txtMostrarDatos = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEnviarDatos = new System.Windows.Forms.TextBox();
            this.btnCargarCSM = new Guna.UI.WinForms.GunaGradientButton();
            this.panelInformacion = new Guna.UI.WinForms.GunaGradientPanel();
            this.lblEstado = new Guna.UI.WinForms.GunaLabel();
            this.lblErrorHumano = new Guna.UI.WinForms.GunaLabel();
            this.lblNumeroSerie = new Guna.UI.WinForms.GunaLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnConectar = new Guna.UI.WinForms.GunaGradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstadoConexion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.derecho.SuspendLayout();
            this.panelConsola.SuspendLayout();
            this.panelInformacion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(768, 253);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 32);
            this.button3.TabIndex = 39;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(768, 223);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 32);
            this.button2.TabIndex = 38;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(768, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 31;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLineas
            // 
            this.btnLineas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnLineas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLineas.ForeColor = System.Drawing.Color.Silver;
            this.btnLineas.Location = new System.Drawing.Point(768, 163);
            this.btnLineas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLineas.Name = "btnLineas";
            this.btnLineas.Size = new System.Drawing.Size(122, 32);
            this.btnLineas.TabIndex = 37;
            this.btnLineas.Text = "Lineas";
            this.btnLineas.UseVisualStyleBackColor = false;
            this.btnLineas.Visible = false;
            this.btnLineas.Click += new System.EventHandler(this.btnLineas_Click);
            // 
            // PuertoSerie
            // 
            this.PuertoSerie.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerie_DataReceived);
            // 
            // btnCalibracion
            // 
            this.btnCalibracion.Animated = true;
            this.btnCalibracion.AnimationHoverSpeed = 0.07F;
            this.btnCalibracion.AnimationSpeed = 0.03F;
            this.btnCalibracion.BackColor = System.Drawing.Color.Transparent;
            this.btnCalibracion.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnCalibracion.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnCalibracion.BorderColor = System.Drawing.Color.Black;
            this.btnCalibracion.BorderSize = 2;
            this.btnCalibracion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCalibracion.FocusedColor = System.Drawing.Color.Empty;
            this.btnCalibracion.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnCalibracion.ForeColor = System.Drawing.Color.White;
            this.btnCalibracion.Image = null;
            this.btnCalibracion.ImageSize = new System.Drawing.Size(52, 52);
            this.btnCalibracion.Location = new System.Drawing.Point(28, 210);
            this.btnCalibracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalibracion.Name = "btnCalibracion";
            this.btnCalibracion.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCalibracion.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCalibracion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCalibracion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCalibracion.OnHoverImage = null;
            this.btnCalibracion.OnPressedColor = System.Drawing.Color.Black;
            this.btnCalibracion.Radius = 20;
            this.btnCalibracion.Size = new System.Drawing.Size(217, 89);
            this.btnCalibracion.TabIndex = 1;
            this.btnCalibracion.Text = "Calibración";
            this.btnCalibracion.Visible = false;
            this.btnCalibracion.Click += new System.EventHandler(this.btnCalibracion_Click_1);
            // 
            // btnColocarArriba
            // 
            this.btnColocarArriba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColocarArriba.AnimationHoverSpeed = 0.07F;
            this.btnColocarArriba.AnimationSpeed = 0.03F;
            this.btnColocarArriba.BaseColor1 = System.Drawing.Color.Gray;
            this.btnColocarArriba.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnColocarArriba.BorderColor = System.Drawing.Color.Black;
            this.btnColocarArriba.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnColocarArriba.FocusedColor = System.Drawing.Color.Empty;
            this.btnColocarArriba.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnColocarArriba.ForeColor = System.Drawing.Color.White;
            this.btnColocarArriba.Image = null;
            this.btnColocarArriba.ImageSize = new System.Drawing.Size(52, 52);
            this.btnColocarArriba.Location = new System.Drawing.Point(328, 202);
            this.btnColocarArriba.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColocarArriba.Name = "btnColocarArriba";
            this.btnColocarArriba.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnColocarArriba.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnColocarArriba.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnColocarArriba.OnHoverForeColor = System.Drawing.Color.White;
            this.btnColocarArriba.OnHoverImage = null;
            this.btnColocarArriba.OnPressedColor = System.Drawing.Color.Black;
            this.btnColocarArriba.Size = new System.Drawing.Size(173, 75);
            this.btnColocarArriba.TabIndex = 42;
            this.btnColocarArriba.Text = "CSM colocado hacia arriba";
            this.btnColocarArriba.Visible = false;
            this.btnColocarArriba.Click += new System.EventHandler(this.gunaGradientCircleButton1_Click);
            // 
            // btnColocarAbajo
            // 
            this.btnColocarAbajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColocarAbajo.AnimationHoverSpeed = 0.07F;
            this.btnColocarAbajo.AnimationSpeed = 0.03F;
            this.btnColocarAbajo.BaseColor1 = System.Drawing.Color.Gray;
            this.btnColocarAbajo.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnColocarAbajo.BorderColor = System.Drawing.Color.Black;
            this.btnColocarAbajo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnColocarAbajo.FocusedColor = System.Drawing.Color.Empty;
            this.btnColocarAbajo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnColocarAbajo.ForeColor = System.Drawing.Color.White;
            this.btnColocarAbajo.Image = null;
            this.btnColocarAbajo.ImageSize = new System.Drawing.Size(52, 52);
            this.btnColocarAbajo.Location = new System.Drawing.Point(327, 281);
            this.btnColocarAbajo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColocarAbajo.Name = "btnColocarAbajo";
            this.btnColocarAbajo.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnColocarAbajo.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnColocarAbajo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnColocarAbajo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnColocarAbajo.OnHoverImage = null;
            this.btnColocarAbajo.OnPressedColor = System.Drawing.Color.Black;
            this.btnColocarAbajo.Size = new System.Drawing.Size(174, 75);
            this.btnColocarAbajo.TabIndex = 43;
            this.btnColocarAbajo.Text = "CSM colocado hacia abajo";
            this.btnColocarAbajo.Visible = false;
            this.btnColocarAbajo.Click += new System.EventHandler(this.gunaGradientCircleButton2_Click);
            // 
            // btnColocarLado
            // 
            this.btnColocarLado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColocarLado.AnimationHoverSpeed = 0.07F;
            this.btnColocarLado.AnimationSpeed = 0.03F;
            this.btnColocarLado.BaseColor1 = System.Drawing.Color.Gray;
            this.btnColocarLado.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnColocarLado.BorderColor = System.Drawing.Color.Black;
            this.btnColocarLado.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnColocarLado.FocusedColor = System.Drawing.Color.Empty;
            this.btnColocarLado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnColocarLado.ForeColor = System.Drawing.Color.White;
            this.btnColocarLado.Image = null;
            this.btnColocarLado.ImageSize = new System.Drawing.Size(52, 52);
            this.btnColocarLado.Location = new System.Drawing.Point(528, 253);
            this.btnColocarLado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColocarLado.Name = "btnColocarLado";
            this.btnColocarLado.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnColocarLado.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnColocarLado.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnColocarLado.OnHoverForeColor = System.Drawing.Color.White;
            this.btnColocarLado.OnHoverImage = null;
            this.btnColocarLado.OnPressedColor = System.Drawing.Color.Black;
            this.btnColocarLado.Size = new System.Drawing.Size(184, 68);
            this.btnColocarLado.TabIndex = 44;
            this.btnColocarLado.Text = "CSM colocado de lado";
            this.btnColocarLado.Visible = false;
            this.btnColocarLado.Click += new System.EventHandler(this.gunaGradientCircleButton3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaCircleProgressBar1
            // 
            this.gunaCircleProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.gunaCircleProgressBar1.Location = new System.Drawing.Point(391, 10);
            this.gunaCircleProgressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaCircleProgressBar1.Name = "gunaCircleProgressBar1";
            this.gunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCircleProgressBar1.ProgressOffset = 20;
            this.gunaCircleProgressBar1.Size = new System.Drawing.Size(164, 154);
            this.gunaCircleProgressBar1.TabIndex = 54;
            this.gunaCircleProgressBar1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.gunaCircleProgressBar1.UseProgressPercentText = true;
            this.gunaCircleProgressBar1.Visible = false;
            // 
            // btnRetrabajo
            // 
            this.btnRetrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetrabajo.Animated = true;
            this.btnRetrabajo.AnimationHoverSpeed = 0.07F;
            this.btnRetrabajo.AnimationSpeed = 0.03F;
            this.btnRetrabajo.BackColor = System.Drawing.Color.Transparent;
            this.btnRetrabajo.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnRetrabajo.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnRetrabajo.BorderColor = System.Drawing.Color.Black;
            this.btnRetrabajo.BorderSize = 1;
            this.btnRetrabajo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRetrabajo.FocusedColor = System.Drawing.Color.Empty;
            this.btnRetrabajo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrabajo.ForeColor = System.Drawing.Color.White;
            this.btnRetrabajo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRetrabajo.Image = null;
            this.btnRetrabajo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRetrabajo.Location = new System.Drawing.Point(786, 127);
            this.btnRetrabajo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRetrabajo.Name = "btnRetrabajo";
            this.btnRetrabajo.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnRetrabajo.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRetrabajo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRetrabajo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRetrabajo.OnHoverImage = null;
            this.btnRetrabajo.OnPressedColor = System.Drawing.Color.Black;
            this.btnRetrabajo.Radius = 20;
            this.btnRetrabajo.Size = new System.Drawing.Size(108, 37);
            this.btnRetrabajo.TabIndex = 49;
            this.btnRetrabajo.Text = "Retrabajo";
            this.btnRetrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRetrabajo.Visible = false;
            this.btnRetrabajo.Click += new System.EventHandler(this.gunaGradientButton1_Click_1);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(18, 184);
            this.gunaSeparator1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(876, 14);
            this.gunaSeparator1.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 60;
            this.label3.Text = "Mostrar";
            this.label3.Visible = false;
            // 
            // txtMostrar
            // 
            this.txtMostrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtMostrar.ForeColor = System.Drawing.Color.Black;
            this.txtMostrar.Location = new System.Drawing.Point(90, 325);
            this.txtMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(43, 27);
            this.txtMostrar.TabIndex = 59;
            this.txtMostrar.Text = "30";
            this.txtMostrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMostrar.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 65;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(18, 352);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(860, 226);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // lblResgistros
            // 
            this.lblResgistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResgistros.AutoSize = true;
            this.lblResgistros.BackColor = System.Drawing.Color.Transparent;
            this.lblResgistros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResgistros.ForeColor = System.Drawing.Color.White;
            this.lblResgistros.Location = new System.Drawing.Point(15, 580);
            this.lblResgistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResgistros.Name = "lblResgistros";
            this.lblResgistros.Size = new System.Drawing.Size(177, 19);
            this.lblResgistros.TabIndex = 49;
            this.lblResgistros.Text = "Cantidad de registros:";
            this.lblResgistros.Visible = false;
            // 
            // btnConsola
            // 
            this.btnConsola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnConsola.Location = new System.Drawing.Point(650, 127);
            this.btnConsola.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsola.Name = "btnConsola";
            this.btnConsola.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnConsola.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConsola.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConsola.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConsola.OnHoverImage = null;
            this.btnConsola.OnPressedColor = System.Drawing.Color.Black;
            this.btnConsola.Radius = 20;
            this.btnConsola.Size = new System.Drawing.Size(108, 37);
            this.btnConsola.TabIndex = 62;
            this.btnConsola.Text = "Consola";
            this.btnConsola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConsola.Visible = false;
            this.btnConsola.Click += new System.EventHandler(this.gunaGradientButton2_Click_1);
            // 
            // derecho
            // 
            this.derecho.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.derecho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cASAToolStripMenuItem,
            this.hofarToolStripMenuItem});
            this.derecho.Name = "derecho";
            this.derecho.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.derecho.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.derecho.RenderStyle.ColorTable = null;
            this.derecho.RenderStyle.RoundedEdges = true;
            this.derecho.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.derecho.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.derecho.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.derecho.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.derecho.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.derecho.Size = new System.Drawing.Size(105, 48);
            // 
            // cASAToolStripMenuItem
            // 
            this.cASAToolStripMenuItem.Name = "cASAToolStripMenuItem";
            this.cASAToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.cASAToolStripMenuItem.Text = "CASA";
            this.cASAToolStripMenuItem.Click += new System.EventHandler(this.cASAToolStripMenuItem_Click);
            // 
            // hofarToolStripMenuItem
            // 
            this.hofarToolStripMenuItem.Name = "hofarToolStripMenuItem";
            this.hofarToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.hofarToolStripMenuItem.Text = "hofar";
            this.hofarToolStripMenuItem.Click += new System.EventHandler(this.hofarToolStripMenuItem_Click);
            // 
            // timerDesconectadoCSM
            // 
            this.timerDesconectadoCSM.Interval = 1000;
            this.timerDesconectadoCSM.Tick += new System.EventHandler(this.timerDesconectadoCSM_Tick);
            // 
            // panelConsola
            // 
            this.panelConsola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConsola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelConsola.BackgroundImage")));
            this.panelConsola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelConsola.Controls.Add(this.txtMostrarDatos);
            this.panelConsola.Controls.Add(this.textBox1);
            this.panelConsola.Controls.Add(this.txtEnviarDatos);
            this.panelConsola.GradientColor1 = System.Drawing.Color.White;
            this.panelConsola.GradientColor2 = System.Drawing.Color.White;
            this.panelConsola.GradientColor3 = System.Drawing.Color.White;
            this.panelConsola.GradientColor4 = System.Drawing.Color.White;
            this.panelConsola.Location = new System.Drawing.Point(101, 253);
            this.panelConsola.Margin = new System.Windows.Forms.Padding(2);
            this.panelConsola.Name = "panelConsola";
            this.panelConsola.Size = new System.Drawing.Size(751, 309);
            this.panelConsola.TabIndex = 63;
            this.panelConsola.Text = "gunaGradientPanel1";
            this.panelConsola.Visible = false;
            // 
            // txtMostrarDatos
            // 
            this.txtMostrarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.txtMostrarDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMostrarDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtMostrarDatos.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtMostrarDatos.Location = new System.Drawing.Point(0, 20);
            this.txtMostrarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.txtMostrarDatos.Multiline = true;
            this.txtMostrarDatos.Name = "txtMostrarDatos";
            this.txtMostrarDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMostrarDatos.Size = new System.Drawing.Size(469, 289);
            this.txtMostrarDatos.TabIndex = 29;
            this.txtMostrarDatos.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(398, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(353, 289);
            this.textBox1.TabIndex = 36;
            this.textBox1.Visible = false;
            // 
            // txtEnviarDatos
            // 
            this.txtEnviarDatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEnviarDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEnviarDatos.Location = new System.Drawing.Point(0, 0);
            this.txtEnviarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnviarDatos.Name = "txtEnviarDatos";
            this.txtEnviarDatos.Size = new System.Drawing.Size(751, 20);
            this.txtEnviarDatos.TabIndex = 28;
            this.txtEnviarDatos.Visible = false;
            this.txtEnviarDatos.TextChanged += new System.EventHandler(this.txtEnviarDatos_TextChanged);
            this.txtEnviarDatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnviarDatos_KeyPress);
            // 
            // btnCargarCSM
            // 
            this.btnCargarCSM.Animated = true;
            this.btnCargarCSM.AnimationHoverSpeed = 0.07F;
            this.btnCargarCSM.AnimationSpeed = 0.03F;
            this.btnCargarCSM.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarCSM.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnCargarCSM.BaseColor2 = System.Drawing.Color.DimGray;
            this.btnCargarCSM.BorderColor = System.Drawing.Color.Black;
            this.btnCargarCSM.BorderSize = 1;
            this.btnCargarCSM.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCargarCSM.FocusedColor = System.Drawing.Color.Empty;
            this.btnCargarCSM.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCSM.ForeColor = System.Drawing.Color.White;
            this.btnCargarCSM.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCargarCSM.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarCSM.Image")));
            this.btnCargarCSM.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCargarCSM.Location = new System.Drawing.Point(18, 133);
            this.btnCargarCSM.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarCSM.Name = "btnCargarCSM";
            this.btnCargarCSM.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnCargarCSM.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCargarCSM.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCargarCSM.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCargarCSM.OnHoverImage = null;
            this.btnCargarCSM.OnPressedColor = System.Drawing.Color.Black;
            this.btnCargarCSM.Radius = 20;
            this.btnCargarCSM.Size = new System.Drawing.Size(154, 46);
            this.btnCargarCSM.TabIndex = 56;
            this.btnCargarCSM.Text = "Cargar CSM";
            this.btnCargarCSM.Visible = false;
            this.btnCargarCSM.Click += new System.EventHandler(this.gunaGradientButton2_Click);
            // 
            // panelInformacion
            // 
            this.panelInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInformacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelInformacion.BackgroundImage")));
            this.panelInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelInformacion.Controls.Add(this.lblEstado);
            this.panelInformacion.Controls.Add(this.lblErrorHumano);
            this.panelInformacion.Controls.Add(this.lblNumeroSerie);
            this.panelInformacion.Controls.Add(this.panel6);
            this.panelInformacion.Controls.Add(this.panel7);
            this.panelInformacion.Controls.Add(this.panel8);
            this.panelInformacion.Controls.Add(this.panel9);
            this.panelInformacion.Controls.Add(this.label2);
            this.panelInformacion.GradientColor1 = System.Drawing.SystemColors.Highlight;
            this.panelInformacion.GradientColor2 = System.Drawing.Color.DarkGray;
            this.panelInformacion.GradientColor3 = System.Drawing.Color.DarkSalmon;
            this.panelInformacion.GradientColor4 = System.Drawing.Color.RosyBrown;
            this.panelInformacion.Location = new System.Drawing.Point(650, 12);
            this.panelInformacion.Margin = new System.Windows.Forms.Padding(2);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(244, 110);
            this.panelInformacion.TabIndex = 49;
            this.panelInformacion.Text = "gunaGradientPanel1";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(8, 88);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(86, 17);
            this.lblEstado.TabIndex = 50;
            this.lblEstado.Text = "Estado: N/A";
            // 
            // lblErrorHumano
            // 
            this.lblErrorHumano.AutoSize = true;
            this.lblErrorHumano.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorHumano.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorHumano.ForeColor = System.Drawing.Color.White;
            this.lblErrorHumano.Location = new System.Drawing.Point(8, 61);
            this.lblErrorHumano.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorHumano.Name = "lblErrorHumano";
            this.lblErrorHumano.Size = new System.Drawing.Size(157, 17);
            this.lblErrorHumano.TabIndex = 49;
            this.lblErrorHumano.Text = "Intentos restantes: N/A";
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroSerie.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroSerie.ForeColor = System.Drawing.Color.White;
            this.lblNumeroSerie.Location = new System.Drawing.Point(8, 34);
            this.lblNumeroSerie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(154, 17);
            this.lblNumeroSerie.TabIndex = 48;
            this.lblNumeroSerie.Text = "Número de serie: N/A";
            this.lblNumeroSerie.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 4);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 102);
            this.panel6.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 4);
            this.panel7.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 106);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(240, 4);
            this.panel8.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(240, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(4, 110);
            this.panel9.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Información";
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 110);
            this.panel1.TabIndex = 46;
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
            this.gunaGradientButton1.Location = new System.Drawing.Point(20, 35);
            this.gunaGradientButton1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 5;
            this.gunaGradientButton1.Size = new System.Drawing.Size(17, 15);
            this.gunaGradientButton1.TabIndex = 64;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click_2);
            // 
            // btnConectar
            // 
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
            this.btnConectar.Location = new System.Drawing.Point(55, 60);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnConectar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConectar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConectar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConectar.OnHoverImage = null;
            this.btnConectar.OnPressedColor = System.Drawing.Color.Black;
            this.btnConectar.Radius = 20;
            this.btnConectar.Size = new System.Drawing.Size(138, 41);
            this.btnConectar.TabIndex = 48;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConectar.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 102);
            this.panel2.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 4);
            this.panel5.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 106);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 4);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(240, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 110);
            this.panel3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Main Unit";
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoConexion.AutoSize = true;
            this.lblEstadoConexion.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoConexion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoConexion.ForeColor = System.Drawing.Color.White;
            this.lblEstadoConexion.Location = new System.Drawing.Point(42, 31);
            this.lblEstadoConexion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(184, 19);
            this.lblEstadoConexion.TabIndex = 10;
            this.lblEstadoConexion.Text = "Estado : Desconectado";
            // 
            // Abis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(916, 604);
            this.Controls.Add(this.panelConsola);
            this.Controls.Add(this.btnColocarArriba);
            this.Controls.Add(this.btnConsola);
            this.Controls.Add(this.lblResgistros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.btnCargarCSM);
            this.Controls.Add(this.btnRetrabajo);
            this.Controls.Add(this.btnColocarAbajo);
            this.Controls.Add(this.gunaCircleProgressBar1);
            this.Controls.Add(this.panelInformacion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnColocarLado);
            this.Controls.Add(this.btnCalibracion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLineas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(916, 557);
            this.Name = "Abis";
            this.Text = "Abis";
            this.Load += new System.EventHandler(this.Abis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.derecho.ResumeLayout(false);
            this.panelConsola.ResumeLayout(false);
            this.panelConsola.PerformLayout();
            this.panelInformacion.ResumeLayout(false);
            this.panelInformacion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLineas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblEstadoConexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMostrarDatos;
        private System.Windows.Forms.TextBox txtEnviarDatos;
        private System.IO.Ports.SerialPort PuertoSerie;
        private Guna.UI.WinForms.GunaGradientTileButton btnCalibracion;
        private Guna.UI.WinForms.GunaGradientCircleButton btnColocarArriba;
        private Guna.UI.WinForms.GunaGradientCircleButton btnColocarAbajo;
        private Guna.UI.WinForms.GunaGradientCircleButton btnColocarLado;
        private Guna.UI.WinForms.GunaGradientPanel panel1;
        private Guna.UI.WinForms.GunaGradientButton btnConectar;
        private Guna.UI.WinForms.GunaLabel lblNumeroSerie;
        private Guna.UI.WinForms.GunaGradientPanel panelInformacion;
        private Guna.UI.WinForms.GunaLabel lblErrorHumano;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressBar1;
        private Guna.UI.WinForms.GunaGradientButton btnRetrabajo;
        private Guna.UI.WinForms.GunaGradientButton btnCargarCSM;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblResgistros;
        private Guna.UI.WinForms.GunaGradientButton btnConsola;
        private Guna.UI.WinForms.GunaContextMenuStrip derecho;
        private System.Windows.Forms.ToolStripMenuItem cASAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hofarToolStripMenuItem;
        private Guna.UI.WinForms.GunaLabel lblEstado;
        private System.Windows.Forms.Timer timerDesconectadoCSM;
        private Guna.UI.WinForms.GunaGradientPanel panelConsola;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abis));
            this.PuertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.btnCalibracion = new Guna.UI.WinForms.GunaGradientTileButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaCircleProgressBar1 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.txtMostrarDatos = new System.Windows.Forms.TextBox();
            this.txtEnviarDatos = new System.Windows.Forms.TextBox();
            this.btnRetrabajo = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.btnConsola = new Guna.UI.WinForms.GunaGradientButton();
            this.derecho = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.cASAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hofarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerDesconectadoCSM = new System.Windows.Forms.Timer(this.components);
            this.pic1 = new Guna.UI.WinForms.GunaPictureBox();
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
            this.btnEnPosicion = new Guna.UI.WinForms.GunaGradientButton();
            this.timerConsola = new System.Windows.Forms.Timer(this.components);
            this.derecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.panelInformacion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnCalibracion.Location = new System.Drawing.Point(281, 164);
            this.btnCalibracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalibracion.Name = "btnCalibracion";
            this.btnCalibracion.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCalibracion.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCalibracion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCalibracion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCalibracion.OnHoverImage = null;
            this.btnCalibracion.OnPressedColor = System.Drawing.Color.Black;
            this.btnCalibracion.Radius = 20;
            this.btnCalibracion.Size = new System.Drawing.Size(150, 65);
            this.btnCalibracion.TabIndex = 1;
            this.btnCalibracion.Text = "Calibración";
            this.btnCalibracion.Visible = false;
            this.btnCalibracion.Click += new System.EventHandler(this.btnCalibracion_Click_1);
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
            this.gunaCircleProgressBar1.Location = new System.Drawing.Point(479, 15);
            this.gunaCircleProgressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaCircleProgressBar1.Name = "gunaCircleProgressBar1";
            this.gunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCircleProgressBar1.ProgressOffset = 20;
            this.gunaCircleProgressBar1.Size = new System.Drawing.Size(219, 190);
            this.gunaCircleProgressBar1.TabIndex = 54;
            this.gunaCircleProgressBar1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.gunaCircleProgressBar1.UseProgressPercentText = true;
            this.gunaCircleProgressBar1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(867, 242);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(98, 12);
            this.textBox1.TabIndex = 36;
            this.textBox1.Visible = false;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.ForeColor = System.Drawing.Color.White;
            this.lblInstruccion.Location = new System.Drawing.Point(20, 271);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(413, 23);
            this.lblInstruccion.TabIndex = 51;
            this.lblInstruccion.Text = "Coloque en posición hacia arriba el CSM";
            this.lblInstruccion.Visible = false;
            // 
            // txtMostrarDatos
            // 
            this.txtMostrarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMostrarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.txtMostrarDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMostrarDatos.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtMostrarDatos.Location = new System.Drawing.Point(867, 280);
            this.txtMostrarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMostrarDatos.Multiline = true;
            this.txtMostrarDatos.Name = "txtMostrarDatos";
            this.txtMostrarDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMostrarDatos.Size = new System.Drawing.Size(342, 448);
            this.txtMostrarDatos.TabIndex = 29;
            this.txtMostrarDatos.Visible = false;
            // 
            // txtEnviarDatos
            // 
            this.txtEnviarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnviarDatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEnviarDatos.Location = new System.Drawing.Point(867, 258);
            this.txtEnviarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnviarDatos.Name = "txtEnviarDatos";
            this.txtEnviarDatos.Size = new System.Drawing.Size(342, 22);
            this.txtEnviarDatos.TabIndex = 28;
            this.txtEnviarDatos.Visible = false;
            this.txtEnviarDatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnviarDatos_KeyPress);
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
            this.btnRetrabajo.Location = new System.Drawing.Point(1048, 156);
            this.btnRetrabajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetrabajo.Name = "btnRetrabajo";
            this.btnRetrabajo.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnRetrabajo.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRetrabajo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRetrabajo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRetrabajo.OnHoverImage = null;
            this.btnRetrabajo.OnPressedColor = System.Drawing.Color.Black;
            this.btnRetrabajo.Radius = 20;
            this.btnRetrabajo.Size = new System.Drawing.Size(144, 46);
            this.btnRetrabajo.TabIndex = 49;
            this.btnRetrabajo.Text = "Retrabajo";
            this.btnRetrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRetrabajo.Visible = false;
            this.btnRetrabajo.Click += new System.EventHandler(this.btnRetrabajo_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(12, 233);
            this.gunaSeparator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(1197, 10);
            this.gunaSeparator1.TabIndex = 57;
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
            this.btnConsola.Location = new System.Drawing.Point(867, 156);
            this.btnConsola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsola.Name = "btnConsola";
            this.btnConsola.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnConsola.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConsola.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConsola.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConsola.OnHoverImage = null;
            this.btnConsola.OnPressedColor = System.Drawing.Color.Black;
            this.btnConsola.Radius = 20;
            this.btnConsola.Size = new System.Drawing.Size(144, 46);
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
            this.derecho.Size = new System.Drawing.Size(116, 52);
            // 
            // cASAToolStripMenuItem
            // 
            this.cASAToolStripMenuItem.Name = "cASAToolStripMenuItem";
            this.cASAToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.cASAToolStripMenuItem.Text = "CASA";
            // 
            // hofarToolStripMenuItem
            // 
            this.hofarToolStripMenuItem.Name = "hofarToolStripMenuItem";
            this.hofarToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.hofarToolStripMenuItem.Text = "hofar";
            // 
            // timerDesconectadoCSM
            // 
            this.timerDesconectadoCSM.Interval = 1000;
            this.timerDesconectadoCSM.Tick += new System.EventHandler(this.timerDesconectadoCSM_Tick);
            // 
            // pic1
            // 
            this.pic1.BaseColor = System.Drawing.Color.White;
            this.pic1.Location = new System.Drawing.Point(24, 309);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(605, 422);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 64;
            this.pic1.TabStop = false;
            this.pic1.Visible = false;
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
            this.btnCargarCSM.Location = new System.Drawing.Point(24, 164);
            this.btnCargarCSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarCSM.Name = "btnCargarCSM";
            this.btnCargarCSM.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnCargarCSM.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCargarCSM.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCargarCSM.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCargarCSM.OnHoverImage = null;
            this.btnCargarCSM.OnPressedColor = System.Drawing.Color.Black;
            this.btnCargarCSM.Radius = 20;
            this.btnCargarCSM.Size = new System.Drawing.Size(205, 57);
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
            this.panelInformacion.Location = new System.Drawing.Point(867, 15);
            this.panelInformacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(325, 135);
            this.panelInformacion.TabIndex = 49;
            this.panelInformacion.Text = "gunaGradientPanel1";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(11, 108);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(107, 19);
            this.lblEstado.TabIndex = 50;
            this.lblEstado.Text = "Estado: N/A";
            // 
            // lblErrorHumano
            // 
            this.lblErrorHumano.AutoSize = true;
            this.lblErrorHumano.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorHumano.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorHumano.ForeColor = System.Drawing.Color.White;
            this.lblErrorHumano.Location = new System.Drawing.Point(11, 75);
            this.lblErrorHumano.Name = "lblErrorHumano";
            this.lblErrorHumano.Size = new System.Drawing.Size(193, 19);
            this.lblErrorHumano.TabIndex = 49;
            this.lblErrorHumano.Text = "Intentos restantes: N/A";
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroSerie.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroSerie.ForeColor = System.Drawing.Color.White;
            this.lblNumeroSerie.Location = new System.Drawing.Point(11, 42);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(190, 19);
            this.lblNumeroSerie.TabIndex = 48;
            this.lblNumeroSerie.Text = "Número de serie: N/A";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 5);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 125);
            this.panel6.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(320, 5);
            this.panel7.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 130);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(320, 5);
            this.panel8.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(320, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 135);
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
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
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
            this.panel1.Location = new System.Drawing.Point(24, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 135);
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
            this.gunaGradientButton1.Location = new System.Drawing.Point(27, 43);
            this.gunaGradientButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnConectar.Location = new System.Drawing.Point(73, 74);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnConectar.Click += new System.EventHandler(this.gunaGradientButton1_Click);
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
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
            this.lblEstadoConexion.Location = new System.Drawing.Point(56, 38);
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(237, 23);
            this.lblEstadoConexion.TabIndex = 10;
            this.lblEstadoConexion.Text = "Estado : Desconectado";
            // 
            // btnEnPosicion
            // 
            this.btnEnPosicion.Animated = true;
            this.btnEnPosicion.AnimationHoverSpeed = 0.07F;
            this.btnEnPosicion.AnimationSpeed = 0.03F;
            this.btnEnPosicion.BackColor = System.Drawing.Color.Transparent;
            this.btnEnPosicion.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnEnPosicion.BaseColor2 = System.Drawing.Color.DimGray;
            this.btnEnPosicion.BorderColor = System.Drawing.Color.Black;
            this.btnEnPosicion.BorderSize = 1;
            this.btnEnPosicion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEnPosicion.FocusedColor = System.Drawing.Color.Empty;
            this.btnEnPosicion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnPosicion.ForeColor = System.Drawing.Color.White;
            this.btnEnPosicion.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEnPosicion.Image = null;
            this.btnEnPosicion.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEnPosicion.Location = new System.Drawing.Point(652, 406);
            this.btnEnPosicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnPosicion.Name = "btnEnPosicion";
            this.btnEnPosicion.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnEnPosicion.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEnPosicion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEnPosicion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEnPosicion.OnHoverImage = null;
            this.btnEnPosicion.OnPressedColor = System.Drawing.Color.Black;
            this.btnEnPosicion.Radius = 20;
            this.btnEnPosicion.Size = new System.Drawing.Size(200, 138);
            this.btnEnPosicion.TabIndex = 68;
            this.btnEnPosicion.Text = "Colocado en posición";
            this.btnEnPosicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEnPosicion.Visible = false;
            this.btnEnPosicion.Click += new System.EventHandler(this.btnEnPosicion_Click);
            // 
            // Abis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1221, 743);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalibracion);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.txtEnviarDatos);
            this.Controls.Add(this.txtMostrarDatos);
            this.Controls.Add(this.btnEnPosicion);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnConsola);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.btnCargarCSM);
            this.Controls.Add(this.btnRetrabajo);
            this.Controls.Add(this.gunaCircleProgressBar1);
            this.Controls.Add(this.panelInformacion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1221, 686);
            this.Name = "Abis";
            this.Text = "Abis";
            this.Load += new System.EventHandler(this.Abis_Load);
            this.derecho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.panelInformacion.ResumeLayout(false);
            this.panelInformacion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Guna.UI.WinForms.GunaGradientButton btnConsola;
        private Guna.UI.WinForms.GunaContextMenuStrip derecho;
        private System.Windows.Forms.ToolStripMenuItem cASAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hofarToolStripMenuItem;
        private Guna.UI.WinForms.GunaLabel lblEstado;
        private System.Windows.Forms.Timer timerDesconectadoCSM;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaPictureBox pic1;
        private Guna.UI.WinForms.GunaGradientButton btnEnPosicion;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Timer timerConsola;
    }
}
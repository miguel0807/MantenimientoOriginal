
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLineas = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnColocarArriba = new System.Windows.Forms.Button();
            this.btnColocarLado = new System.Windows.Forms.Button();
            this.btnColocarAbajo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConectar = new System.Windows.Forms.Button();
            this.lblEstadoConexion = new System.Windows.Forms.Label();
            this.btnEsconderConexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMostrarDatos = new System.Windows.Forms.TextBox();
            this.txtEnviarDatos = new System.Windows.Forms.TextBox();
            this.PuertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.btnCalibracion = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btnRetrabajo = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaGradientCircleButton1 = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.gunaGradientCircleButton2 = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.gunaGradientCircleButton3 = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(367, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 39);
            this.button3.TabIndex = 39;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(367, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 39);
            this.button2.TabIndex = 38;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(367, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 39);
            this.button1.TabIndex = 31;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLineas
            // 
            this.btnLineas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnLineas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLineas.ForeColor = System.Drawing.Color.Silver;
            this.btnLineas.Location = new System.Drawing.Point(544, 18);
            this.btnLineas.Name = "btnLineas";
            this.btnLineas.Size = new System.Drawing.Size(162, 39);
            this.btnLineas.TabIndex = 37;
            this.btnLineas.Text = "Lineas";
            this.btnLineas.UseVisualStyleBackColor = false;
            this.btnLineas.Click += new System.EventHandler(this.btnLineas_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(516, 323);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(703, 319);
            this.textBox1.TabIndex = 36;
            // 
            // btnColocarArriba
            // 
            this.btnColocarArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnColocarArriba.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocarArriba.ForeColor = System.Drawing.Color.Silver;
            this.btnColocarArriba.Location = new System.Drawing.Point(745, 49);
            this.btnColocarArriba.Name = "btnColocarArriba";
            this.btnColocarArriba.Size = new System.Drawing.Size(172, 39);
            this.btnColocarArriba.TabIndex = 35;
            this.btnColocarArriba.Text = "Colocado arriba";
            this.btnColocarArriba.UseVisualStyleBackColor = false;
            this.btnColocarArriba.Visible = false;
            this.btnColocarArriba.Click += new System.EventHandler(this.btnColocarArriba_Click);
            // 
            // btnColocarLado
            // 
            this.btnColocarLado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnColocarLado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocarLado.ForeColor = System.Drawing.Color.Silver;
            this.btnColocarLado.Location = new System.Drawing.Point(958, 49);
            this.btnColocarLado.Name = "btnColocarLado";
            this.btnColocarLado.Size = new System.Drawing.Size(198, 39);
            this.btnColocarLado.TabIndex = 34;
            this.btnColocarLado.Text = "Colocado de lado";
            this.btnColocarLado.UseVisualStyleBackColor = false;
            this.btnColocarLado.Visible = false;
            this.btnColocarLado.Click += new System.EventHandler(this.btnColocarLado_Click);
            // 
            // btnColocarAbajo
            // 
            this.btnColocarAbajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnColocarAbajo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocarAbajo.ForeColor = System.Drawing.Color.Silver;
            this.btnColocarAbajo.Location = new System.Drawing.Point(835, 4);
            this.btnColocarAbajo.Name = "btnColocarAbajo";
            this.btnColocarAbajo.Size = new System.Drawing.Size(181, 39);
            this.btnColocarAbajo.TabIndex = 33;
            this.btnColocarAbajo.Text = "Colocado abajo";
            this.btnColocarAbajo.UseVisualStyleBackColor = false;
            this.btnColocarAbajo.Visible = false;
            this.btnColocarAbajo.Click += new System.EventHandler(this.btnColocarAbajo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnConectar);
            this.panel1.Controls.Add(this.lblEstadoConexion);
            this.panel1.Controls.Add(this.btnEsconderConexion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 135);
            this.panel1.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(313, 5);
            this.panel5.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 5);
            this.panel4.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 133);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(318, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 133);
            this.panel3.TabIndex = 14;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnConectar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.Silver;
            this.btnConectar.Location = new System.Drawing.Point(72, 74);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(147, 39);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoConexion.AutoSize = true;
            this.lblEstadoConexion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoConexion.ForeColor = System.Drawing.Color.White;
            this.lblEstadoConexion.Location = new System.Drawing.Point(40, 36);
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(237, 23);
            this.lblEstadoConexion.TabIndex = 10;
            this.lblEstadoConexion.Text = "Estado : Desconectado";
            // 
            // btnEsconderConexion
            // 
            this.btnEsconderConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.btnEsconderConexion.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnEsconderConexion.Location = new System.Drawing.Point(11, 36);
            this.btnEsconderConexion.Name = "btnEsconderConexion";
            this.btnEsconderConexion.Size = new System.Drawing.Size(23, 23);
            this.btnEsconderConexion.TabIndex = 11;
            this.btnEsconderConexion.TabStop = false;
            this.btnEsconderConexion.UseVisualStyleBackColor = false;
            this.btnEsconderConexion.Click += new System.EventHandler(this.btnEsconderConexion_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Main Unit";
            // 
            // txtMostrarDatos
            // 
            this.txtMostrarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMostrarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.txtMostrarDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMostrarDatos.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.txtMostrarDatos.Location = new System.Drawing.Point(24, 323);
            this.txtMostrarDatos.Multiline = true;
            this.txtMostrarDatos.Name = "txtMostrarDatos";
            this.txtMostrarDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMostrarDatos.Size = new System.Drawing.Size(395, 319);
            this.txtMostrarDatos.TabIndex = 29;
            // 
            // txtEnviarDatos
            // 
            this.txtEnviarDatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEnviarDatos.Location = new System.Drawing.Point(24, 285);
            this.txtEnviarDatos.Name = "txtEnviarDatos";
            this.txtEnviarDatos.Size = new System.Drawing.Size(195, 22);
            this.txtEnviarDatos.TabIndex = 28;
            this.txtEnviarDatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnviarDatos_KeyPress);
            // 
            // PuertoSerie
            // 
            this.PuertoSerie.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerie_DataReceived);
            // 
            // btnCalibracion
            // 
            this.btnCalibracion.AnimationHoverSpeed = 0.07F;
            this.btnCalibracion.AnimationSpeed = 0.03F;
            this.btnCalibracion.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnCalibracion.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnCalibracion.BorderColor = System.Drawing.Color.Black;
            this.btnCalibracion.BorderSize = 2;
            this.btnCalibracion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCalibracion.FocusedColor = System.Drawing.Color.Empty;
            this.btnCalibracion.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnCalibracion.ForeColor = System.Drawing.Color.White;
            this.btnCalibracion.Image = ((System.Drawing.Image)(resources.GetObject("btnCalibracion.Image")));
            this.btnCalibracion.ImageSize = new System.Drawing.Size(52, 52);
            this.btnCalibracion.Location = new System.Drawing.Point(12, 156);
            this.btnCalibracion.Name = "btnCalibracion";
            this.btnCalibracion.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCalibracion.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCalibracion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCalibracion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCalibracion.OnHoverImage = null;
            this.btnCalibracion.OnPressedColor = System.Drawing.Color.Black;
            this.btnCalibracion.Size = new System.Drawing.Size(289, 110);
            this.btnCalibracion.TabIndex = 1;
            this.btnCalibracion.Text = "Calibración";
            this.btnCalibracion.Visible = false;
            this.btnCalibracion.Click += new System.EventHandler(this.gunaGradientTileButton1_Click);
            // 
            // btnRetrabajo
            // 
            this.btnRetrabajo.AnimationHoverSpeed = 0.07F;
            this.btnRetrabajo.AnimationSpeed = 0.03F;
            this.btnRetrabajo.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnRetrabajo.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnRetrabajo.BorderColor = System.Drawing.Color.Black;
            this.btnRetrabajo.BorderSize = 2;
            this.btnRetrabajo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRetrabajo.FocusedColor = System.Drawing.Color.Empty;
            this.btnRetrabajo.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnRetrabajo.ForeColor = System.Drawing.Color.White;
            this.btnRetrabajo.Image = ((System.Drawing.Image)(resources.GetObject("btnRetrabajo.Image")));
            this.btnRetrabajo.ImageSize = new System.Drawing.Size(52, 52);
            this.btnRetrabajo.Location = new System.Drawing.Point(331, 156);
            this.btnRetrabajo.Name = "btnRetrabajo";
            this.btnRetrabajo.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnRetrabajo.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnRetrabajo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRetrabajo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRetrabajo.OnHoverImage = null;
            this.btnRetrabajo.OnPressedColor = System.Drawing.Color.Black;
            this.btnRetrabajo.Size = new System.Drawing.Size(289, 110);
            this.btnRetrabajo.TabIndex = 2;
            this.btnRetrabajo.Text = "Retrabajo";
            this.btnRetrabajo.Visible = false;
            // 
            // gunaGradientCircleButton1
            // 
            this.gunaGradientCircleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradientCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientCircleButton1.AnimationSpeed = 0.03F;
            this.gunaGradientCircleButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.gunaGradientCircleButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.gunaGradientCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton1.Image = null;
            this.gunaGradientCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaGradientCircleButton1.Location = new System.Drawing.Point(676, 104);
            this.gunaGradientCircleButton1.Name = "gunaGradientCircleButton1";
            this.gunaGradientCircleButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientCircleButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton1.OnHoverImage = null;
            this.gunaGradientCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton1.Size = new System.Drawing.Size(208, 98);
            this.gunaGradientCircleButton1.TabIndex = 42;
            this.gunaGradientCircleButton1.Text = "CSM colocado hacia arriba";
            // 
            // gunaGradientCircleButton2
            // 
            this.gunaGradientCircleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradientCircleButton2.AnimationHoverSpeed = 0.07F;
            this.gunaGradientCircleButton2.AnimationSpeed = 0.03F;
            this.gunaGradientCircleButton2.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.gunaGradientCircleButton2.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.gunaGradientCircleButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientCircleButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientCircleButton2.ForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton2.Image = null;
            this.gunaGradientCircleButton2.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaGradientCircleButton2.Location = new System.Drawing.Point(676, 209);
            this.gunaGradientCircleButton2.Name = "gunaGradientCircleButton2";
            this.gunaGradientCircleButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientCircleButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientCircleButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton2.OnHoverImage = null;
            this.gunaGradientCircleButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton2.Size = new System.Drawing.Size(208, 98);
            this.gunaGradientCircleButton2.TabIndex = 43;
            this.gunaGradientCircleButton2.Text = "CSM colocado hacia abajo";
            // 
            // gunaGradientCircleButton3
            // 
            this.gunaGradientCircleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradientCircleButton3.AnimationHoverSpeed = 0.07F;
            this.gunaGradientCircleButton3.AnimationSpeed = 0.03F;
            this.gunaGradientCircleButton3.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.gunaGradientCircleButton3.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.gunaGradientCircleButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientCircleButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientCircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientCircleButton3.ForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton3.Image = null;
            this.gunaGradientCircleButton3.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaGradientCircleButton3.Location = new System.Drawing.Point(929, 156);
            this.gunaGradientCircleButton3.Name = "gunaGradientCircleButton3";
            this.gunaGradientCircleButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientCircleButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientCircleButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton3.OnHoverImage = null;
            this.gunaGradientCircleButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton3.Size = new System.Drawing.Size(208, 98);
            this.gunaGradientCircleButton3.TabIndex = 44;
            this.gunaGradientCircleButton3.Text = "CSM colocado de lado";
            // 
            // Abis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1221, 686);
            this.Controls.Add(this.gunaGradientCircleButton3);
            this.Controls.Add(this.gunaGradientCircleButton2);
            this.Controls.Add(this.gunaGradientCircleButton1);
            this.Controls.Add(this.btnRetrabajo);
            this.Controls.Add(this.btnCalibracion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLineas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnColocarArriba);
            this.Controls.Add(this.btnColocarLado);
            this.Controls.Add(this.btnColocarAbajo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMostrarDatos);
            this.Controls.Add(this.txtEnviarDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1221, 686);
            this.Name = "Abis";
            this.Text = "Abis";
            this.Load += new System.EventHandler(this.Abis_Load);
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
        private System.Windows.Forms.Button btnColocarArriba;
        private System.Windows.Forms.Button btnColocarLado;
        private System.Windows.Forms.Button btnColocarAbajo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label lblEstadoConexion;
        private System.Windows.Forms.Button btnEsconderConexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMostrarDatos;
        private System.Windows.Forms.TextBox txtEnviarDatos;
        private System.IO.Ports.SerialPort PuertoSerie;
        private Guna.UI.WinForms.GunaGradientTileButton btnCalibracion;
        private Guna.UI.WinForms.GunaGradientTileButton btnRetrabajo;
        private Guna.UI.WinForms.GunaGradientCircleButton gunaGradientCircleButton1;
        private Guna.UI.WinForms.GunaGradientCircleButton gunaGradientCircleButton2;
        private Guna.UI.WinForms.GunaGradientCircleButton gunaGradientCircleButton3;
    }
}
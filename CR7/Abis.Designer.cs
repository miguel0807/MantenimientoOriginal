
namespace CR7
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
            this.btnBuscaPuerto = new System.Windows.Forms.Button();
            this.btnEnviarDatos = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblDatosIngreso = new System.Windows.Forms.Label();
            this.cboPuertos = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.txtDatosAEnviar = new System.Windows.Forms.TextBox();
            this.txtDatosRecibidos = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscaPuerto
            // 
            this.btnBuscaPuerto.Location = new System.Drawing.Point(192, 91);
            this.btnBuscaPuerto.Name = "btnBuscaPuerto";
            this.btnBuscaPuerto.Size = new System.Drawing.Size(152, 82);
            this.btnBuscaPuerto.TabIndex = 0;
            this.btnBuscaPuerto.Text = "Buscar puertos";
            this.btnBuscaPuerto.UseVisualStyleBackColor = true;
            this.btnBuscaPuerto.Click += new System.EventHandler(this.btnBuscaPuerto_Click);
            // 
            // btnEnviarDatos
            // 
            this.btnEnviarDatos.Location = new System.Drawing.Point(192, 329);
            this.btnEnviarDatos.Name = "btnEnviarDatos";
            this.btnEnviarDatos.Size = new System.Drawing.Size(152, 82);
            this.btnEnviarDatos.TabIndex = 1;
            this.btnEnviarDatos.Text = "Enviar Datos";
            this.btnEnviarDatos.UseVisualStyleBackColor = true;
            this.btnEnviarDatos.Click += new System.EventHandler(this.btnEnviarDatos_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(788, 77);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(152, 82);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(216, 265);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(75, 17);
            this.lblBaudRate.TabIndex = 3;
            this.lblBaudRate.Text = "Baud Rate";
            // 
            // lblDatosIngreso
            // 
            this.lblDatosIngreso.AutoSize = true;
            this.lblDatosIngreso.Location = new System.Drawing.Point(236, 482);
            this.lblDatosIngreso.Name = "lblDatosIngreso";
            this.lblDatosIngreso.Size = new System.Drawing.Size(111, 17);
            this.lblDatosIngreso.TabIndex = 4;
            this.lblDatosIngreso.Text = "Datos Recibidos";
            // 
            // cboPuertos
            // 
            this.cboPuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuertos.FormattingEnabled = true;
            this.cboPuertos.Location = new System.Drawing.Point(450, 121);
            this.cboPuertos.Name = "cboPuertos";
            this.cboPuertos.Size = new System.Drawing.Size(192, 24);
            this.cboPuertos.TabIndex = 5;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "115200",
            ""});
            this.cboBaudRate.Location = new System.Drawing.Point(441, 262);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(252, 24);
            this.cboBaudRate.TabIndex = 6;
            this.cboBaudRate.Text = "115200";
            // 
            // txtDatosAEnviar
            // 
            this.txtDatosAEnviar.Location = new System.Drawing.Point(441, 359);
            this.txtDatosAEnviar.Name = "txtDatosAEnviar";
            this.txtDatosAEnviar.Size = new System.Drawing.Size(471, 22);
            this.txtDatosAEnviar.TabIndex = 7;
            // 
            // txtDatosRecibidos
            // 
            this.txtDatosRecibidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatosRecibidos.Location = new System.Drawing.Point(397, 407);
            this.txtDatosRecibidos.Multiline = true;
            this.txtDatosRecibidos.Name = "txtDatosRecibidos";
            this.txtDatosRecibidos.Size = new System.Drawing.Size(812, 244);
            this.txtDatosRecibidos.TabIndex = 8;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecibido);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(859, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 82);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1041, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 82);
            this.button2.TabIndex = 10;
            this.button2.Text = "Esc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Abis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 686);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDatosRecibidos);
            this.Controls.Add(this.txtDatosAEnviar);
            this.Controls.Add(this.cboBaudRate);
            this.Controls.Add(this.cboPuertos);
            this.Controls.Add(this.lblDatosIngreso);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnEnviarDatos);
            this.Controls.Add(this.btnBuscaPuerto);
            this.Name = "Abis";
            this.Text = "Abis";
            this.Load += new System.EventHandler(this.Abis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscaPuerto;
        private System.Windows.Forms.Button btnEnviarDatos;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblDatosIngreso;
        private System.Windows.Forms.ComboBox cboPuertos;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.TextBox txtDatosAEnviar;
        private System.Windows.Forms.TextBox txtDatosRecibidos;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
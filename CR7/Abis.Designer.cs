
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.cboPuertos = new System.Windows.Forms.ComboBox();
            this.txtDatosAEnviar = new System.Windows.Forms.TextBox();
            this.txtDatosRecibidos = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btnBuscaPuerto
            // 
            this.btnBuscaPuerto.Location = new System.Drawing.Point(77, 12);
            this.btnBuscaPuerto.Name = "btnBuscaPuerto";
            this.btnBuscaPuerto.Size = new System.Drawing.Size(155, 37);
            this.btnBuscaPuerto.TabIndex = 0;
            this.btnBuscaPuerto.Text = "Buscar puertos";
            this.btnBuscaPuerto.UseVisualStyleBackColor = true;
            this.btnBuscaPuerto.Click += new System.EventHandler(this.btnBuscaPuerto_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(584, 2);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(124, 41);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // cboPuertos
            // 
            this.cboPuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuertos.FormattingEnabled = true;
            this.cboPuertos.Location = new System.Drawing.Point(276, 19);
            this.cboPuertos.Name = "cboPuertos";
            this.cboPuertos.Size = new System.Drawing.Size(192, 24);
            this.cboPuertos.TabIndex = 5;
            // 
            // txtDatosAEnviar
            // 
            this.txtDatosAEnviar.Location = new System.Drawing.Point(77, 71);
            this.txtDatosAEnviar.Name = "txtDatosAEnviar";
            this.txtDatosAEnviar.Size = new System.Drawing.Size(195, 22);
            this.txtDatosAEnviar.TabIndex = 7;
            this.txtDatosAEnviar.TextChanged += new System.EventHandler(this.txtDatosAEnviar_TextChanged);
            this.txtDatosAEnviar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDatosAEnviar_KeyPress);
            // 
            // txtDatosRecibidos
            // 
            this.txtDatosRecibidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatosRecibidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatosRecibidos.Location = new System.Drawing.Point(77, 99);
            this.txtDatosRecibidos.Multiline = true;
            this.txtDatosRecibidos.Name = "txtDatosRecibidos";
            this.txtDatosRecibidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDatosRecibidos.Size = new System.Drawing.Size(1114, 544);
            this.txtDatosRecibidos.TabIndex = 8;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecibido);
            // 
            // Abis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 686);
            this.Controls.Add(this.txtDatosRecibidos);
            this.Controls.Add(this.txtDatosAEnviar);
            this.Controls.Add(this.cboPuertos);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnBuscaPuerto);
            this.Name = "Abis";
            this.Text = "Abis";
            this.Load += new System.EventHandler(this.Abis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscaPuerto;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox cboPuertos;
        private System.Windows.Forms.TextBox txtDatosAEnviar;
        private System.Windows.Forms.TextBox txtDatosRecibidos;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

namespace Electrónicos
{
    partial class Consola
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
            this.txtEnviarDatos = new System.Windows.Forms.TextBox();
            this.txtMostrarDatos = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEnviarDatos
            // 
            this.txtEnviarDatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEnviarDatos.Location = new System.Drawing.Point(33, 25);
            this.txtEnviarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnviarDatos.Name = "txtEnviarDatos";
            this.txtEnviarDatos.Size = new System.Drawing.Size(277, 22);
            this.txtEnviarDatos.TabIndex = 28;
            this.txtEnviarDatos.TextChanged += new System.EventHandler(this.txtEnviarDatos_TextChanged);
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
            this.txtMostrarDatos.Location = new System.Drawing.Point(12, 108);
            this.txtMostrarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMostrarDatos.Multiline = true;
            this.txtMostrarDatos.Name = "txtMostrarDatos";
            this.txtMostrarDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMostrarDatos.Size = new System.Drawing.Size(1124, 470);
            this.txtMostrarDatos.TabIndex = 29;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 63);
            this.button1.TabIndex = 30;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(705, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 63);
            this.button2.TabIndex = 31;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Consola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 606);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMostrarDatos);
            this.Controls.Add(this.txtEnviarDatos);
            this.Name = "Consola";
            this.Text = "Consola";
            this.Load += new System.EventHandler(this.Consola_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEnviarDatos;
        private System.Windows.Forms.TextBox txtMostrarDatos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
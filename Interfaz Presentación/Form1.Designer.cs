
namespace Interfaz_Presentación
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PictureBox9 = new System.Windows.Forms.PictureBox();
            this.Button26 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::Interfaz_Presentación.Properties.Resources.etiquetas_64;
            this.button2.Location = new System.Drawing.Point(855, 248);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(308, 136);
            this.button2.TabIndex = 16;
            this.button2.Text = "Etiquetas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Interfaz_Presentación.Properties.Resources.mantenimiento_64;
            this.button1.Location = new System.Drawing.Point(484, 248);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(308, 136);
            this.button1.TabIndex = 15;
            this.button1.Text = "Mantenimiento";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PictureBox9
            // 
            this.PictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox9.Image")));
            this.PictureBox9.Location = new System.Drawing.Point(164, 12);
            this.PictureBox9.Name = "PictureBox9";
            this.PictureBox9.Size = new System.Drawing.Size(831, 158);
            this.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox9.TabIndex = 14;
            this.PictureBox9.TabStop = false;
            // 
            // Button26
            // 
            this.Button26.BackColor = System.Drawing.Color.Silver;
            this.Button26.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button26.ForeColor = System.Drawing.Color.Black;
            this.Button26.Image = global::Interfaz_Presentación.Properties.Resources.icons8_tanque_de_almacenamiento_químico_64;
            this.Button26.Location = new System.Drawing.Point(52, 248);
            this.Button26.Name = "Button26";
            this.Button26.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Button26.Size = new System.Drawing.Size(308, 136);
            this.Button26.TabIndex = 12;
            this.Button26.Text = "Tank Farm";
            this.Button26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button26.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1192, 472);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PictureBox9);
            this.Controls.Add(this.Button26);
            this.Name = "Form1";
            this.Opacity = 0.99D;
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button26;
        internal System.Windows.Forms.PictureBox PictureBox9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


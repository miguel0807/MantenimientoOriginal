
namespace Tank_Farm
{
    partial class Niveles
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
            this.Estado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnivelEtyl = new System.Windows.Forms.TextBox();
            this.txtnivelAcetona = new System.Windows.Forms.TextBox();
            this.txtnivelNPropanol = new System.Windows.Forms.TextBox();
            this.txtnivelMEK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hMEK = new System.Windows.Forms.TextBox();
            this.hNPropanol = new System.Windows.Forms.TextBox();
            this.hAcetone = new System.Windows.Forms.TextBox();
            this.hEtyl = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Estado
            // 
            this.Estado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Estado.Location = new System.Drawing.Point(70, 557);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(154, 22);
            this.Estado.TabIndex = 0;
            this.Estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estado";
            // 
            // btnConectar
            // 
            this.btnConectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConectar.Location = new System.Drawing.Point(87, 525);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(91, 26);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Visible = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Etyl Acetate";
            // 
            // txtnivelEtyl
            // 
            this.txtnivelEtyl.Location = new System.Drawing.Point(98, 100);
            this.txtnivelEtyl.Name = "txtnivelEtyl";
            this.txtnivelEtyl.Size = new System.Drawing.Size(154, 22);
            this.txtnivelEtyl.TabIndex = 4;
            this.txtnivelEtyl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnivelAcetona
            // 
            this.txtnivelAcetona.Location = new System.Drawing.Point(365, 100);
            this.txtnivelAcetona.Name = "txtnivelAcetona";
            this.txtnivelAcetona.Size = new System.Drawing.Size(154, 22);
            this.txtnivelAcetona.TabIndex = 5;
            this.txtnivelAcetona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnivelNPropanol
            // 
            this.txtnivelNPropanol.Location = new System.Drawing.Point(615, 100);
            this.txtnivelNPropanol.Name = "txtnivelNPropanol";
            this.txtnivelNPropanol.Size = new System.Drawing.Size(154, 22);
            this.txtnivelNPropanol.TabIndex = 6;
            this.txtnivelNPropanol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnivelMEK
            // 
            this.txtnivelMEK.Location = new System.Drawing.Point(871, 100);
            this.txtnivelMEK.Name = "txtnivelMEK";
            this.txtnivelMEK.Size = new System.Drawing.Size(154, 22);
            this.txtnivelMEK.TabIndex = 7;
            this.txtnivelMEK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nivel (lb)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Acetone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "N-Propanol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(931, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "MEK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Altura(cm)";
            // 
            // hMEK
            // 
            this.hMEK.Location = new System.Drawing.Point(871, 185);
            this.hMEK.Name = "hMEK";
            this.hMEK.Size = new System.Drawing.Size(154, 22);
            this.hMEK.TabIndex = 16;
            this.hMEK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hNPropanol
            // 
            this.hNPropanol.Location = new System.Drawing.Point(615, 185);
            this.hNPropanol.Name = "hNPropanol";
            this.hNPropanol.Size = new System.Drawing.Size(154, 22);
            this.hNPropanol.TabIndex = 15;
            this.hNPropanol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hAcetone
            // 
            this.hAcetone.Location = new System.Drawing.Point(365, 185);
            this.hAcetone.Name = "hAcetone";
            this.hAcetone.Size = new System.Drawing.Size(154, 22);
            this.hAcetone.TabIndex = 14;
            this.hAcetone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hEtyl
            // 
            this.hEtyl.Location = new System.Drawing.Point(98, 185);
            this.hEtyl.Name = "hEtyl";
            this.hEtyl.Size = new System.Drawing.Size(154, 22);
            this.hEtyl.TabIndex = 13;
            this.hEtyl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 62);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Niveles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 583);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.hMEK);
            this.Controls.Add(this.hNPropanol);
            this.Controls.Add(this.hAcetone);
            this.Controls.Add(this.hEtyl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnivelMEK);
            this.Controls.Add(this.txtnivelNPropanol);
            this.Controls.Add(this.txtnivelAcetona);
            this.Controls.Add(this.txtnivelEtyl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Estado);
            this.Name = "Niveles";
            this.Text = "Niveles";
            this.Load += new System.EventHandler(this.Niveles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnivelEtyl;
        private System.Windows.Forms.TextBox txtnivelAcetona;
        private System.Windows.Forms.TextBox txtnivelNPropanol;
        private System.Windows.Forms.TextBox txtnivelMEK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox hMEK;
        private System.Windows.Forms.TextBox hNPropanol;
        private System.Windows.Forms.TextBox hAcetone;
        private System.Windows.Forms.TextBox hEtyl;
        private System.Windows.Forms.Button button2;
    }
}
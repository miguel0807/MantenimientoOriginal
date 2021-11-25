
namespace Electrónicos.ABIS
{
    partial class Voltaje
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
            this.cboUsuario = new Guna.UI.WinForms.GunaComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new Guna.UI.WinForms.GunaGradientButton();
            this.txtVoltaje1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVoltaje2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoltaje1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoltaje2)).BeginInit();
            this.SuspendLayout();
            // 
            // cboUsuario
            // 
            this.cboUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cboUsuario.BaseColor = System.Drawing.Color.White;
            this.cboUsuario.BorderColor = System.Drawing.Color.Silver;
            this.cboUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FocusedColor = System.Drawing.Color.Empty;
            this.cboUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cboUsuario.ForeColor = System.Drawing.Color.Black;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(51, 45);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboUsuario.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboUsuario.Size = new System.Drawing.Size(232, 33);
            this.cboUsuario.TabIndex = 165;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(126, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 166;
            this.label7.Text = "Usuario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Animated = true;
            this.btnGuardar.AnimationHoverSpeed = 0.07F;
            this.btnGuardar.AnimationSpeed = 0.03F;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnGuardar.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.BorderSize = 1;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnGuardar.Image = null;
            this.btnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardar.Location = new System.Drawing.Point(27, 291);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btnGuardar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Radius = 20;
            this.btnGuardar.Size = new System.Drawing.Size(256, 58);
            this.btnGuardar.TabIndex = 167;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtVoltaje1
            // 
            this.txtVoltaje1.DecimalPlaces = 2;
            this.txtVoltaje1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtVoltaje1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtVoltaje1.Location = new System.Drawing.Point(187, 118);
            this.txtVoltaje1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.txtVoltaje1.Name = "txtVoltaje1";
            this.txtVoltaje1.Size = new System.Drawing.Size(120, 32);
            this.txtVoltaje1.TabIndex = 168;
            this.txtVoltaje1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 169;
            this.label6.Text = "Voltaje #1";
            // 
            // txtVoltaje2
            // 
            this.txtVoltaje2.DecimalPlaces = 2;
            this.txtVoltaje2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtVoltaje2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtVoltaje2.Location = new System.Drawing.Point(187, 189);
            this.txtVoltaje2.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.txtVoltaje2.Name = "txtVoltaje2";
            this.txtVoltaje2.Size = new System.Drawing.Size(120, 32);
            this.txtVoltaje2.TabIndex = 170;
            this.txtVoltaje2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 171;
            this.label1.Text = "Voltaje #2";
            // 
            // Voltaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(326, 378);
            this.Controls.Add(this.txtVoltaje2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVoltaje1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Voltaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Voltaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtVoltaje1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoltaje2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox cboUsuario;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaGradientButton btnGuardar;
        private System.Windows.Forms.NumericUpDown txtVoltaje1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtVoltaje2;
        private System.Windows.Forms.Label label1;
    }
}
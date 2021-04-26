
namespace WindowsFormsApp1
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
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.btnEuroConvert = new System.Windows.Forms.Button();
            this.btnDolarConvert = new System.Windows.Forms.Button();
            this.btnPesoConvert = new System.Windows.Forms.Button();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblEuro2 = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblDolar2 = new System.Windows.Forms.Label();
            this.lblPeso2 = new System.Windows.Forms.Label();
            this.txtCotiEuro = new System.Windows.Forms.TextBox();
            this.txtCotiDolar = new System.Windows.Forms.TextBox();
            this.txtCotiPeso = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCotizacion.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacion.Location = new System.Drawing.Point(12, 12);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(147, 38);
            this.lblCotizacion.TabIndex = 0;
            this.lblCotizacion.Text = "Cotización";
            this.lblCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.Location = new System.Drawing.Point(192, 11);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(74, 38);
            this.btnLockCotizacion.TabIndex = 1;
            this.btnLockCotizacion.Text = "Locked";
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // btnEuroConvert
            // 
            this.btnEuroConvert.Location = new System.Drawing.Point(228, 132);
            this.btnEuroConvert.Name = "btnEuroConvert";
            this.btnEuroConvert.Size = new System.Drawing.Size(53, 38);
            this.btnEuroConvert.TabIndex = 2;
            this.btnEuroConvert.Text = "-->";
            this.btnEuroConvert.UseVisualStyleBackColor = true;
            this.btnEuroConvert.Click += new System.EventHandler(this.btnEuroConvert_Click);
            // 
            // btnDolarConvert
            // 
            this.btnDolarConvert.Location = new System.Drawing.Point(228, 185);
            this.btnDolarConvert.Name = "btnDolarConvert";
            this.btnDolarConvert.Size = new System.Drawing.Size(53, 38);
            this.btnDolarConvert.TabIndex = 3;
            this.btnDolarConvert.Text = "-->";
            this.btnDolarConvert.UseVisualStyleBackColor = true;
            this.btnDolarConvert.Click += new System.EventHandler(this.btnDolarConvert_Click);
            // 
            // btnPesoConvert
            // 
            this.btnPesoConvert.Location = new System.Drawing.Point(228, 239);
            this.btnPesoConvert.Name = "btnPesoConvert";
            this.btnPesoConvert.Size = new System.Drawing.Size(53, 38);
            this.btnPesoConvert.TabIndex = 4;
            this.btnPesoConvert.Text = "-->";
            this.btnPesoConvert.UseVisualStyleBackColor = true;
            this.btnPesoConvert.Click += new System.EventHandler(this.btnPesoConvert_Click);
            // 
            // lblEuro
            // 
            this.lblEuro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEuro.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(12, 132);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(94, 38);
            this.lblEuro.TabIndex = 5;
            this.lblEuro.Text = "Euro";
            this.lblEuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEuro2
            // 
            this.lblEuro2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEuro2.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro2.Location = new System.Drawing.Point(303, 78);
            this.lblEuro2.Name = "lblEuro2";
            this.lblEuro2.Size = new System.Drawing.Size(98, 38);
            this.lblEuro2.TabIndex = 6;
            this.lblEuro2.Text = "Euro";
            this.lblEuro2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDolar
            // 
            this.lblDolar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDolar.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(12, 185);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(94, 38);
            this.lblDolar.TabIndex = 7;
            this.lblDolar.Text = "Dolar";
            this.lblDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeso
            // 
            this.lblPeso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPeso.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(12, 239);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(94, 38);
            this.lblPeso.TabIndex = 8;
            this.lblPeso.Text = "Peso";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDolar2
            // 
            this.lblDolar2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDolar2.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar2.Location = new System.Drawing.Point(428, 76);
            this.lblDolar2.Name = "lblDolar2";
            this.lblDolar2.Size = new System.Drawing.Size(100, 38);
            this.lblDolar2.TabIndex = 9;
            this.lblDolar2.Text = "Dolar";
            this.lblDolar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeso2
            // 
            this.lblPeso2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPeso2.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso2.Location = new System.Drawing.Point(548, 76);
            this.lblPeso2.Name = "lblPeso2";
            this.lblPeso2.Size = new System.Drawing.Size(100, 38);
            this.lblPeso2.TabIndex = 10;
            this.lblPeso2.Text = "Peso";
            this.lblPeso2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCotiEuro
            // 
            this.txtCotiEuro.Font = new System.Drawing.Font("Corbel", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotiEuro.Location = new System.Drawing.Point(428, 11);
            this.txtCotiEuro.Name = "txtCotiEuro";
            this.txtCotiEuro.Size = new System.Drawing.Size(100, 38);
            this.txtCotiEuro.TabIndex = 11;
            this.txtCotiEuro.TextChanged += new System.EventHandler(this.txtCotiEuro_TextChanged);
            // 
            // txtCotiDolar
            // 
            this.txtCotiDolar.Font = new System.Drawing.Font("Corbel", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotiDolar.Location = new System.Drawing.Point(301, 11);
            this.txtCotiDolar.Name = "txtCotiDolar";
            this.txtCotiDolar.Size = new System.Drawing.Size(100, 38);
            this.txtCotiDolar.TabIndex = 12;
            this.txtCotiDolar.TextChanged += new System.EventHandler(this.txtCotiDolar_TextChanged);
            // 
            // txtCotiPeso
            // 
            this.txtCotiPeso.Font = new System.Drawing.Font("Corbel", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotiPeso.Location = new System.Drawing.Point(548, 12);
            this.txtCotiPeso.Name = "txtCotiPeso";
            this.txtCotiPeso.Size = new System.Drawing.Size(100, 38);
            this.txtCotiPeso.TabIndex = 13;
            this.txtCotiPeso.TextChanged += new System.EventHandler(this.txtCotiPeso_TextChanged);
            // 
            // txtEuro
            // 
            this.txtEuro.Font = new System.Drawing.Font("Corbel", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuro.Location = new System.Drawing.Point(131, 132);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(71, 38);
            this.txtEuro.TabIndex = 14;
            // 
            // txtDolar
            // 
            this.txtDolar.Font = new System.Drawing.Font("Corbel", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolar.Location = new System.Drawing.Point(131, 185);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(71, 38);
            this.txtDolar.TabIndex = 15;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Corbel", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(131, 239);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(71, 38);
            this.txtPeso.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 120);
            this.label1.TabIndex = 17;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Enabled = false;
            this.txtEuroAEuro.Font = new System.Drawing.Font("Corbel", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuroAEuro.Location = new System.Drawing.Point(301, 132);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(100, 38);
            this.txtEuroAEuro.TabIndex = 18;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Enabled = false;
            this.txtEuroADolar.Font = new System.Drawing.Font("Corbel", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuroADolar.Location = new System.Drawing.Point(428, 132);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(100, 38);
            this.txtEuroADolar.TabIndex = 19;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Enabled = false;
            this.txtEuroAPeso.Font = new System.Drawing.Font("Corbel", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuroAPeso.Location = new System.Drawing.Point(548, 132);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(100, 38);
            this.txtEuroAPeso.TabIndex = 20;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Enabled = false;
            this.txtDolarAEuro.Font = new System.Drawing.Font("Corbel", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarAEuro.Location = new System.Drawing.Point(301, 185);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(100, 38);
            this.txtDolarAEuro.TabIndex = 21;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Enabled = false;
            this.txtDolarADolar.Font = new System.Drawing.Font("Corbel", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarADolar.Location = new System.Drawing.Point(428, 185);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(100, 38);
            this.txtDolarADolar.TabIndex = 22;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Enabled = false;
            this.txtDolarAPeso.Font = new System.Drawing.Font("Corbel", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarAPeso.Location = new System.Drawing.Point(548, 185);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.Size = new System.Drawing.Size(98, 38);
            this.txtDolarAPeso.TabIndex = 23;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Enabled = false;
            this.txtPesoAEuro.Font = new System.Drawing.Font("Corbel", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoAEuro.Location = new System.Drawing.Point(301, 239);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.Size = new System.Drawing.Size(100, 38);
            this.txtPesoAEuro.TabIndex = 24;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Enabled = false;
            this.txtPesoADolar.Font = new System.Drawing.Font("Corbel", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoADolar.Location = new System.Drawing.Point(428, 239);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.Size = new System.Drawing.Size(100, 38);
            this.txtPesoADolar.TabIndex = 25;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Enabled = false;
            this.txtPesoAPeso.Font = new System.Drawing.Font("Corbel", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoAPeso.Location = new System.Drawing.Point(548, 239);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.Size = new System.Drawing.Size(98, 38);
            this.txtPesoAPeso.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(665, 12);
            this.label2.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtCotiPeso);
            this.Controls.Add(this.txtCotiDolar);
            this.Controls.Add(this.txtCotiEuro);
            this.Controls.Add(this.lblPeso2);
            this.Controls.Add(this.lblDolar2);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro2);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.btnPesoConvert);
            this.Controls.Add(this.btnDolarConvert);
            this.Controls.Add(this.btnEuroConvert);
            this.Controls.Add(this.btnLockCotizacion);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de moneda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Button btnLockCotizacion;
        private System.Windows.Forms.Button btnEuroConvert;
        private System.Windows.Forms.Button btnDolarConvert;
        private System.Windows.Forms.Button btnPesoConvert;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblEuro2;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblDolar2;
        private System.Windows.Forms.Label lblPeso2;
        private System.Windows.Forms.TextBox txtCotiEuro;
        private System.Windows.Forms.TextBox txtCotiDolar;
        private System.Windows.Forms.TextBox txtCotiPeso;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtDolarAPeso;
        private System.Windows.Forms.TextBox txtPesoAEuro;
        private System.Windows.Forms.TextBox txtPesoADolar;
        private System.Windows.Forms.TextBox txtPesoAPeso;
        private System.Windows.Forms.Label label2;
    }
}


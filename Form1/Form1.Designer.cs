namespace Form1
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
            this.Btnsuma = new System.Windows.Forms.Button();
            this.Btnresta = new System.Windows.Forms.Button();
            this.Btnprod = new System.Windows.Forms.Button();
            this.Btncoc = new System.Windows.Forms.Button();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.Lblop1 = new System.Windows.Forms.Label();
            this.Lblop2 = new System.Windows.Forms.Label();
            this.Lblrta = new System.Windows.Forms.Label();
            this.txtop2 = new System.Windows.Forms.TextBox();
            this.txtop1 = new System.Windows.Forms.TextBox();
            this.txtrta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btnsuma
            // 
            this.Btnsuma.Location = new System.Drawing.Point(202, 6);
            this.Btnsuma.Name = "Btnsuma";
            this.Btnsuma.Size = new System.Drawing.Size(75, 23);
            this.Btnsuma.TabIndex = 0;
            this.Btnsuma.Text = "Suma";
            this.Btnsuma.UseVisualStyleBackColor = true;
            this.Btnsuma.Click += new System.EventHandler(this.Btnsuma_Click);
            // 
            // Btnresta
            // 
            this.Btnresta.Location = new System.Drawing.Point(202, 35);
            this.Btnresta.Name = "Btnresta";
            this.Btnresta.Size = new System.Drawing.Size(75, 23);
            this.Btnresta.TabIndex = 1;
            this.Btnresta.Text = "Resta";
            this.Btnresta.UseVisualStyleBackColor = true;
            this.Btnresta.Click += new System.EventHandler(this.Btnresta_Click);
            // 
            // Btnprod
            // 
            this.Btnprod.Location = new System.Drawing.Point(202, 64);
            this.Btnprod.Name = "Btnprod";
            this.Btnprod.Size = new System.Drawing.Size(75, 23);
            this.Btnprod.TabIndex = 2;
            this.Btnprod.Text = "producto";
            this.Btnprod.UseVisualStyleBackColor = true;
            this.Btnprod.Click += new System.EventHandler(this.Btnprod_Click);
            // 
            // Btncoc
            // 
            this.Btncoc.Location = new System.Drawing.Point(202, 93);
            this.Btncoc.Name = "Btncoc";
            this.Btncoc.Size = new System.Drawing.Size(75, 23);
            this.Btncoc.TabIndex = 3;
            this.Btncoc.Text = "Cociente";
            this.Btncoc.UseVisualStyleBackColor = true;
            this.Btncoc.Click += new System.EventHandler(this.Btncoc_Click);
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(12, 141);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(75, 23);
            this.Btnsalir.TabIndex = 4;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            // 
            // Lblop1
            // 
            this.Lblop1.AutoSize = true;
            this.Lblop1.Location = new System.Drawing.Point(12, 12);
            this.Lblop1.Name = "Lblop1";
            this.Lblop1.Size = new System.Drawing.Size(67, 13);
            this.Lblop1.TabIndex = 5;
            this.Lblop1.Text = "1er operador";
            // 
            // Lblop2
            // 
            this.Lblop2.AutoSize = true;
            this.Lblop2.Location = new System.Drawing.Point(9, 38);
            this.Lblop2.Name = "Lblop2";
            this.Lblop2.Size = new System.Drawing.Size(70, 13);
            this.Lblop2.TabIndex = 6;
            this.Lblop2.Text = "2do operador";
            this.Lblop2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lblrta
            // 
            this.Lblrta.AutoSize = true;
            this.Lblrta.Location = new System.Drawing.Point(12, 99);
            this.Lblrta.Name = "Lblrta";
            this.Lblrta.Size = new System.Drawing.Size(61, 13);
            this.Lblrta.TabIndex = 7;
            this.Lblrta.Text = "Resaultado";
            // 
            // txtop2
            // 
            this.txtop2.Location = new System.Drawing.Point(85, 35);
            this.txtop2.Name = "txtop2";
            this.txtop2.Size = new System.Drawing.Size(100, 20);
            this.txtop2.TabIndex = 8;
            this.txtop2.TextChanged += new System.EventHandler(this.txtop2_TextChanged);
            // 
            // txtop1
            // 
            this.txtop1.Location = new System.Drawing.Point(85, 9);
            this.txtop1.Name = "txtop1";
            this.txtop1.Size = new System.Drawing.Size(100, 20);
            this.txtop1.TabIndex = 9;
            // 
            // txtrta
            // 
            this.txtrta.Location = new System.Drawing.Point(85, 96);
            this.txtrta.Name = "txtrta";
            this.txtrta.Size = new System.Drawing.Size(100, 20);
            this.txtrta.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 176);
            this.Controls.Add(this.txtrta);
            this.Controls.Add(this.txtop1);
            this.Controls.Add(this.txtop2);
            this.Controls.Add(this.Lblrta);
            this.Controls.Add(this.Lblop2);
            this.Controls.Add(this.Lblop1);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.Btncoc);
            this.Controls.Add(this.Btnprod);
            this.Controls.Add(this.Btnresta);
            this.Controls.Add(this.Btnsuma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnsuma;
        private System.Windows.Forms.Button Btnresta;
        private System.Windows.Forms.Button Btnprod;
        private System.Windows.Forms.Button Btncoc;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Label Lblop1;
        private System.Windows.Forms.Label Lblop2;
        private System.Windows.Forms.Label Lblrta;
        private System.Windows.Forms.TextBox txtop2;
        private System.Windows.Forms.TextBox txtop1;
        private System.Windows.Forms.TextBox txtrta;
    }
}


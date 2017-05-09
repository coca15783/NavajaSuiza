namespace NavajaSuiza
{
    partial class FormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.cantidadBillete = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.Potencia = new System.Windows.Forms.Button();
            this.tablaMultiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cantidadBillete
            // 
            this.cantidadBillete.Location = new System.Drawing.Point(56, 62);
            this.cantidadBillete.Name = "cantidadBillete";
            this.cantidadBillete.Size = new System.Drawing.Size(135, 65);
            this.cantidadBillete.TabIndex = 0;
            this.cantidadBillete.Text = "Cantidad Billete";
            this.cantidadBillete.UseVisualStyleBackColor = true;
            this.cantidadBillete.Click += new System.EventHandler(this.button1_Click);
            // 
            // Factorial
            // 
            this.Factorial.Location = new System.Drawing.Point(56, 235);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(135, 65);
            this.Factorial.TabIndex = 1;
            this.Factorial.Text = "Factorial";
            this.Factorial.UseVisualStyleBackColor = true;
            this.Factorial.Click += new System.EventHandler(this.button2_Click);
            // 
            // Potencia
            // 
            this.Potencia.Location = new System.Drawing.Point(434, 62);
            this.Potencia.Name = "Potencia";
            this.Potencia.Size = new System.Drawing.Size(135, 65);
            this.Potencia.TabIndex = 2;
            this.Potencia.Text = "Potencia";
            this.Potencia.UseVisualStyleBackColor = true;
            this.Potencia.Click += new System.EventHandler(this.button3_Click);
            // 
            // tablaMultiplicar
            // 
            this.tablaMultiplicar.Location = new System.Drawing.Point(434, 235);
            this.tablaMultiplicar.Name = "tablaMultiplicar";
            this.tablaMultiplicar.Size = new System.Drawing.Size(135, 65);
            this.tablaMultiplicar.TabIndex = 3;
            this.tablaMultiplicar.Text = "Tabla Multiplicar";
            this.tablaMultiplicar.UseVisualStyleBackColor = true;
            this.tablaMultiplicar.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(626, 413);
            this.Controls.Add(this.tablaMultiplicar);
            this.Controls.Add(this.Potencia);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.cantidadBillete);
            this.Name = "FormularioPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cantidadBillete;
        private System.Windows.Forms.Button Factorial;
        private System.Windows.Forms.Button Potencia;
        private System.Windows.Forms.Button tablaMultiplicar;
    }
}


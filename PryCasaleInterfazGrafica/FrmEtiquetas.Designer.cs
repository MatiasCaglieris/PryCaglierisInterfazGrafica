namespace PryCasaleInterfazGrafica
{
    partial class InterfazGrafica
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
            this.Nombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            this.Edad = new System.Windows.Forms.Label();
            this.Carrera = new System.Windows.Forms.Label();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textCarrera = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(72, 73);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(60, 19);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(165, 66);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 1;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(165, 115);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 2;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.Location = new System.Drawing.Point(72, 118);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(60, 19);
            this.Apellido.TabIndex = 3;
            this.Apellido.Text = "Apellido";
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.Location = new System.Drawing.Point(72, 162);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(41, 19);
            this.Edad.TabIndex = 4;
            this.Edad.Text = "Edad";
            // 
            // Carrera
            // 
            this.Carrera.AutoSize = true;
            this.Carrera.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carrera.Location = new System.Drawing.Point(72, 204);
            this.Carrera.Name = "Carrera";
            this.Carrera.Size = new System.Drawing.Size(56, 19);
            this.Carrera.TabIndex = 5;
            this.Carrera.Text = "Carrera";
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(165, 162);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(100, 20);
            this.textEdad.TabIndex = 6;
            // 
            // textCarrera
            // 
            this.textCarrera.Location = new System.Drawing.Point(165, 203);
            this.textCarrera.Name = "textCarrera";
            this.textCarrera.Size = new System.Drawing.Size(100, 20);
            this.textCarrera.TabIndex = 7;
            // 
            // InterfazGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textCarrera);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.Carrera);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.Nombre);
            this.Name = "InterfazGrafica";
            this.Text = "Interfaz Grafica / Etiquetas - Label";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.Label Carrera;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textCarrera;
    }
}


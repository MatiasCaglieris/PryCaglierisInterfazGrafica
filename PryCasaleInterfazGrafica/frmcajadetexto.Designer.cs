namespace PryCasaleInterfazGrafica
{
    partial class frmcajadetexto
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
            this.textCarrera = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.Carrera = new System.Windows.Forms.Label();
            this.Edad = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textCarrera
            // 
            this.textCarrera.Location = new System.Drawing.Point(151, 189);
            this.textCarrera.Name = "textCarrera";
            this.textCarrera.Size = new System.Drawing.Size(144, 20);
            this.textCarrera.TabIndex = 15;
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(151, 148);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(30, 20);
            this.textEdad.TabIndex = 14;
            // 
            // Carrera
            // 
            this.Carrera.AutoSize = true;
            this.Carrera.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carrera.Location = new System.Drawing.Point(58, 190);
            this.Carrera.Name = "Carrera";
            this.Carrera.Size = new System.Drawing.Size(56, 19);
            this.Carrera.TabIndex = 13;
            this.Carrera.Text = "Carrera";
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.Location = new System.Drawing.Point(58, 148);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(41, 19);
            this.Edad.TabIndex = 12;
            this.Edad.Text = "Edad";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.Location = new System.Drawing.Point(58, 104);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(60, 19);
            this.Apellido.TabIndex = 11;
            this.Apellido.Text = "Apellido";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(151, 101);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 10;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(151, 52);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 9;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(58, 59);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(60, 19);
            this.Nombre.TabIndex = 8;
            this.Nombre.Text = "Nombre";
            // 
            // frmcajadetexto
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
            this.Name = "frmcajadetexto";
            this.Text = "frmcajadetexto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCarrera;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.Label Carrera;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label Nombre;
    }
}
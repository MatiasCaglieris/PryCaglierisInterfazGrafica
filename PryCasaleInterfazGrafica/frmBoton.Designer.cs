namespace PryCasaleInterfazGrafica
{
    partial class frmBoton
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
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.LabelCarrera = new System.Windows.Forms.Label();
            this.LabelEdad = new System.Windows.Forms.Label();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.ButtonPresentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(167, 190);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(144, 20);
            this.txtCarrera.TabIndex = 23;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(167, 149);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(30, 20);
            this.txtEdad.TabIndex = 22;
            // 
            // LabelCarrera
            // 
            this.LabelCarrera.AutoSize = true;
            this.LabelCarrera.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCarrera.Location = new System.Drawing.Point(74, 191);
            this.LabelCarrera.Name = "LabelCarrera";
            this.LabelCarrera.Size = new System.Drawing.Size(56, 19);
            this.LabelCarrera.TabIndex = 21;
            this.LabelCarrera.Text = "Carrera";
            // 
            // LabelEdad
            // 
            this.LabelEdad.AutoSize = true;
            this.LabelEdad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEdad.Location = new System.Drawing.Point(74, 149);
            this.LabelEdad.Name = "LabelEdad";
            this.LabelEdad.Size = new System.Drawing.Size(41, 19);
            this.LabelEdad.TabIndex = 20;
            this.LabelEdad.Text = "Edad";
            // 
            // LabelApellido
            // 
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApellido.Location = new System.Drawing.Point(74, 105);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(60, 19);
            this.LabelApellido.TabIndex = 19;
            this.LabelApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(167, 102);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(167, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombre.Location = new System.Drawing.Point(74, 60);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(60, 19);
            this.LabelNombre.TabIndex = 16;
            this.LabelNombre.Text = "Nombre";
            // 
            // ButtonPresentar
            // 
            this.ButtonPresentar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPresentar.Location = new System.Drawing.Point(167, 233);
            this.ButtonPresentar.Name = "ButtonPresentar";
            this.ButtonPresentar.Size = new System.Drawing.Size(144, 39);
            this.ButtonPresentar.TabIndex = 24;
            this.ButtonPresentar.Text = "Presentar";
            this.ButtonPresentar.UseVisualStyleBackColor = true;
            this.ButtonPresentar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBoton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 324);
            this.Controls.Add(this.ButtonPresentar);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.LabelCarrera);
            this.Controls.Add(this.LabelEdad);
            this.Controls.Add(this.LabelApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.LabelNombre);
            this.Name = "frmBoton";
            this.Text = "frmBoton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label LabelCarrera;
        private System.Windows.Forms.Label LabelEdad;
        private System.Windows.Forms.Label LabelApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Button ButtonPresentar;
    }
}
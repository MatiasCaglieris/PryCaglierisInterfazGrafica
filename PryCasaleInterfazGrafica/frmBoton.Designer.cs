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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoton));
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.LabelCarrera = new System.Windows.Forms.Label();
            this.LabelEdad = new System.Windows.Forms.Label();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.ButtonPresentar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtCarrera
            // 
            this.txtCarrera.Enabled = false;
            this.txtCarrera.Location = new System.Drawing.Point(167, 190);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(144, 20);
            this.txtCarrera.TabIndex = 3;
            this.txtCarrera.TextChanged += new System.EventHandler(this.txtCarrera_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(167, 149);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(30, 20);
            this.txtEdad.TabIndex = 2;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // LabelCarrera
            // 
            this.LabelCarrera.AutoSize = true;
            this.LabelCarrera.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCarrera.Location = new System.Drawing.Point(74, 191);
            this.LabelCarrera.Name = "LabelCarrera";
            this.LabelCarrera.Size = new System.Drawing.Size(56, 19);
            this.LabelCarrera.TabIndex = 8;
            this.LabelCarrera.Text = "Carrera";
            // 
            // LabelEdad
            // 
            this.LabelEdad.AutoSize = true;
            this.LabelEdad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEdad.Location = new System.Drawing.Point(74, 149);
            this.LabelEdad.Name = "LabelEdad";
            this.LabelEdad.Size = new System.Drawing.Size(41, 19);
            this.LabelEdad.TabIndex = 7;
            this.LabelEdad.Text = "Edad";
            // 
            // LabelApellido
            // 
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApellido.Location = new System.Drawing.Point(74, 105);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(60, 19);
            this.LabelApellido.TabIndex = 6;
            this.LabelApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(167, 102);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(167, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombre.Location = new System.Drawing.Point(74, 60);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(60, 19);
            this.LabelNombre.TabIndex = 5;
            this.LabelNombre.Text = "Nombre";
            // 
            // ButtonPresentar
            // 
            this.ButtonPresentar.Enabled = false;
            this.ButtonPresentar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPresentar.Location = new System.Drawing.Point(167, 233);
            this.ButtonPresentar.Name = "ButtonPresentar";
            this.ButtonPresentar.Size = new System.Drawing.Size(144, 39);
            this.ButtonPresentar.TabIndex = 4;
            this.ButtonPresentar.Text = "Presentar";
            this.ButtonPresentar.UseVisualStyleBackColor = true;
            this.ButtonPresentar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(33, 291);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 9;
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.Location = new System.Drawing.Point(12, 9);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(139, 39);
            this.labelRegistro.TabIndex = 10;
            this.labelRegistro.Text = "Registrar";
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(78, 341);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(368, 186);
            this.lstDatos.TabIndex = 11;
            this.lstDatos.SelectedIndexChanged += new System.EventHandler(this.lstDatos_SelectedIndexChanged);
            // 
            // frmBoton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 592);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.ButtonPresentar);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.LabelCarrera);
            this.Controls.Add(this.LabelEdad);
            this.Controls.Add(this.LabelApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.LabelNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBoton";
            this.Text = "1";
            this.Load += new System.EventHandler(this.frmBoton_Load);
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
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.ListBox lstDatos;
    }
}
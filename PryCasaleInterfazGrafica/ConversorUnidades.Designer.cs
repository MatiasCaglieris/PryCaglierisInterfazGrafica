namespace PryCasaleInterfazGrafica
{
    partial class FormConversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConversor));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.lblkilometros = new System.Windows.Forms.Label();
            this.txtKilometros = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHacia = new System.Windows.Forms.Label();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.txtCentimetros = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.labelresultadoo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(158, 22);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(147, 27);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Conversor";
            // 
            // lblkilometros
            // 
            this.lblkilometros.AutoSize = true;
            this.lblkilometros.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkilometros.Location = new System.Drawing.Point(34, 88);
            this.lblkilometros.Name = "lblkilometros";
            this.lblkilometros.Size = new System.Drawing.Size(109, 19);
            this.lblkilometros.TabIndex = 1;
            this.lblkilometros.Text = "Kilometros";
            // 
            // txtKilometros
            // 
            this.txtKilometros.Location = new System.Drawing.Point(163, 87);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(155, 20);
            this.txtKilometros.TabIndex = 2;
            this.txtKilometros.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(33, 145);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(89, 19);
            this.lblDesde.TabIndex = 3;
            this.lblDesde.Text = "Metros :";
            // 
            // lblHacia
            // 
            this.lblHacia.AutoSize = true;
            this.lblHacia.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHacia.Location = new System.Drawing.Point(33, 193);
            this.lblHacia.Name = "lblHacia";
            this.lblHacia.Size = new System.Drawing.Size(119, 19);
            this.lblHacia.TabIndex = 4;
            this.lblHacia.Text = "Centimetros";
            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(163, 143);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(155, 20);
            this.txtMetros.TabIndex = 5;
            this.txtMetros.TextChanged += new System.EventHandler(this.textMetros_TextChanged);
            // 
            // txtCentimetros
            // 
            this.txtCentimetros.Location = new System.Drawing.Point(163, 195);
            this.txtCentimetros.Name = "txtCentimetros";
            this.txtCentimetros.Size = new System.Drawing.Size(155, 20);
            this.txtCentimetros.TabIndex = 6;
            this.txtCentimetros.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(91, 244);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(188, 58);
            this.btnConvertir.TabIndex = 7;
            this.btnConvertir.Text = "[CONVERTIR]";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(34, 339);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(119, 19);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "RESULTADO :";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // labelresultadoo
            // 
            this.labelresultadoo.AutoSize = true;
            this.labelresultadoo.Location = new System.Drawing.Point(187, 344);
            this.labelresultadoo.Name = "labelresultadoo";
            this.labelresultadoo.Size = new System.Drawing.Size(0, 13);
            this.labelresultadoo.TabIndex = 9;
            // 
            // FormConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(640, 580);
            this.Controls.Add(this.labelresultadoo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtCentimetros);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.lblHacia);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.txtKilometros);
            this.Controls.Add(this.lblkilometros);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormConversor";
            this.Text = "Conversor de Unidades";
            this.Load += new System.EventHandler(this.FormDescuentoTienda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label lblkilometros;
        private System.Windows.Forms.TextBox txtKilometros;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHacia;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.TextBox txtCentimetros;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label labelresultadoo;
    }
}
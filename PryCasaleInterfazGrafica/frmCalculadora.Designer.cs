namespace PryCasaleInterfazGrafica
{
    partial class frmCalculadora
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
            this.LabelNumero1 = new System.Windows.Forms.Label();
            this.LabelNumero2 = new System.Windows.Forms.Label();
            this.textNumero1 = new System.Windows.Forms.TextBox();
            this.textNumero2 = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.buttonSumar = new System.Windows.Forms.Button();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.buttonDividir = new System.Windows.Forms.Button();
            this.buttonRestar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelNumero1
            // 
            this.LabelNumero1.AutoSize = true;
            this.LabelNumero1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumero1.Location = new System.Drawing.Point(77, 85);
            this.LabelNumero1.Name = "LabelNumero1";
            this.LabelNumero1.Size = new System.Drawing.Size(144, 33);
            this.LabelNumero1.TabIndex = 0;
            this.LabelNumero1.Text = "Numero 1 :";
            // 
            // LabelNumero2
            // 
            this.LabelNumero2.AutoSize = true;
            this.LabelNumero2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumero2.Location = new System.Drawing.Point(81, 119);
            this.LabelNumero2.Name = "LabelNumero2";
            this.LabelNumero2.Size = new System.Drawing.Size(137, 33);
            this.LabelNumero2.TabIndex = 1;
            this.LabelNumero2.Text = "Numero2 :";
            // 
            // textNumero1
            // 
            this.textNumero1.Location = new System.Drawing.Point(262, 97);
            this.textNumero1.Name = "textNumero1";
            this.textNumero1.Size = new System.Drawing.Size(106, 20);
            this.textNumero1.TabIndex = 2;
            // 
            // textNumero2
            // 
            this.textNumero2.Location = new System.Drawing.Point(262, 131);
            this.textNumero2.Name = "textNumero2";
            this.textNumero2.Size = new System.Drawing.Size(106, 20);
            this.textNumero2.TabIndex = 3;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(163, 27);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(163, 23);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "CALCULADORA";
            // 
            // buttonSumar
            // 
            this.buttonSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSumar.Location = new System.Drawing.Point(81, 188);
            this.buttonSumar.Name = "buttonSumar";
            this.buttonSumar.Size = new System.Drawing.Size(70, 60);
            this.buttonSumar.TabIndex = 5;
            this.buttonSumar.Text = "[ + ]";
            this.buttonSumar.UseVisualStyleBackColor = true;
            // 
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplicar.Location = new System.Drawing.Point(402, 188);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(70, 60);
            this.buttonMultiplicar.TabIndex = 6;
            this.buttonMultiplicar.Text = "[ X ]";
            this.buttonMultiplicar.UseVisualStyleBackColor = true;
            // 
            // buttonDividir
            // 
            this.buttonDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDividir.Location = new System.Drawing.Point(298, 188);
            this.buttonDividir.Name = "buttonDividir";
            this.buttonDividir.Size = new System.Drawing.Size(70, 60);
            this.buttonDividir.TabIndex = 7;
            this.buttonDividir.Text = "[ ÷ ]";
            this.buttonDividir.UseVisualStyleBackColor = true;
            // 
            // buttonRestar
            // 
            this.buttonRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestar.Location = new System.Drawing.Point(193, 188);
            this.buttonRestar.Name = "buttonRestar";
            this.buttonRestar.Size = new System.Drawing.Size(70, 60);
            this.buttonRestar.TabIndex = 8;
            this.buttonRestar.Text = "[ - ]";
            this.buttonRestar.UseVisualStyleBackColor = true;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(75, 314);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(143, 33);
            this.labelResultado.TabIndex = 9;
            this.labelResultado.Text = "Resultado :";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(262, 326);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(106, 20);
            this.txtResultado.TabIndex = 10;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonRestar);
            this.Controls.Add(this.buttonDividir);
            this.Controls.Add(this.buttonMultiplicar);
            this.Controls.Add(this.buttonSumar);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.textNumero2);
            this.Controls.Add(this.textNumero1);
            this.Controls.Add(this.LabelNumero2);
            this.Controls.Add(this.LabelNumero1);
            this.Name = "frmCalculadora";
            this.Text = "Numero 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNumero1;
        private System.Windows.Forms.Label LabelNumero2;
        private System.Windows.Forms.TextBox textNumero1;
        private System.Windows.Forms.TextBox textNumero2;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button buttonSumar;
        private System.Windows.Forms.Button buttonMultiplicar;
        private System.Windows.Forms.Button buttonDividir;
        private System.Windows.Forms.Button buttonRestar;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox txtResultado;
    }
}
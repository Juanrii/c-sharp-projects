
namespace PreParcial2
{
    partial class ActualizarNota
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.labelMateria = new System.Windows.Forms.Label();
            this.labelLegajo = new System.Windows.Forms.Label();
            this.inputLegajo = new System.Windows.Forms.NumericUpDown();
            this.inputValorNota = new System.Windows.Forms.TextBox();
            this.inputMateria = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputFecha = new System.Windows.Forms.DateTimePicker();
            this.labelValorNota = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputLegajo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(184, 213);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(170, 67);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(8, 213);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(170, 67);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Location = new System.Drawing.Point(22, 133);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(45, 13);
            this.labelMateria.TabIndex = 4;
            this.labelMateria.Text = "Materia:";
            // 
            // labelLegajo
            // 
            this.labelLegajo.AutoSize = true;
            this.labelLegajo.Location = new System.Drawing.Point(22, 49);
            this.labelLegajo.Name = "labelLegajo";
            this.labelLegajo.Size = new System.Drawing.Size(42, 13);
            this.labelLegajo.TabIndex = 3;
            this.labelLegajo.Text = "Legajo:";
            // 
            // inputLegajo
            // 
            this.inputLegajo.Enabled = false;
            this.inputLegajo.Location = new System.Drawing.Point(86, 42);
            this.inputLegajo.Name = "inputLegajo";
            this.inputLegajo.Size = new System.Drawing.Size(267, 20);
            this.inputLegajo.TabIndex = 2;
            // 
            // inputValorNota
            // 
            this.inputValorNota.Location = new System.Drawing.Point(86, 168);
            this.inputValorNota.Name = "inputValorNota";
            this.inputValorNota.Size = new System.Drawing.Size(267, 20);
            this.inputValorNota.TabIndex = 1;
            // 
            // inputMateria
            // 
            this.inputMateria.Location = new System.Drawing.Point(86, 126);
            this.inputMateria.Name = "inputMateria";
            this.inputMateria.Size = new System.Drawing.Size(267, 20);
            this.inputMateria.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputFecha);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.labelValorNota);
            this.groupBox1.Controls.Add(this.labelMateria);
            this.groupBox1.Controls.Add(this.labelLegajo);
            this.groupBox1.Controls.Add(this.inputLegajo);
            this.groupBox1.Controls.Add(this.inputValorNota);
            this.groupBox1.Controls.Add(this.inputMateria);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 286);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha:";
            // 
            // inputFecha
            // 
            this.inputFecha.Location = new System.Drawing.Point(87, 84);
            this.inputFecha.Name = "inputFecha";
            this.inputFecha.Size = new System.Drawing.Size(267, 20);
            this.inputFecha.TabIndex = 11;
            // 
            // labelValorNota
            // 
            this.labelValorNota.AutoSize = true;
            this.labelValorNota.Location = new System.Drawing.Point(22, 175);
            this.labelValorNota.Name = "labelValorNota";
            this.labelValorNota.Size = new System.Drawing.Size(33, 13);
            this.labelValorNota.TabIndex = 5;
            this.labelValorNota.Text = "Nota:";
            // 
            // ActualizarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 308);
            this.Controls.Add(this.groupBox1);
            this.Name = "ActualizarNota";
            this.Text = "ActualizarNota";
            this.Load += new System.EventHandler(this.ActualizarNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputLegajo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.Label labelLegajo;
        private System.Windows.Forms.NumericUpDown inputLegajo;
        private System.Windows.Forms.TextBox inputValorNota;
        private System.Windows.Forms.TextBox inputMateria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelValorNota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker inputFecha;
    }
}
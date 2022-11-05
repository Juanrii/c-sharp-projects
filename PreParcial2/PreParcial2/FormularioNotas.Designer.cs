
namespace PreParcial2
{
    partial class FormularioNotas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputFecha = new System.Windows.Forms.DateTimePicker();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMateria = new System.Windows.Forms.Label();
            this.labelLegajo = new System.Windows.Forms.Label();
            this.inputLegajo = new System.Windows.Forms.NumericUpDown();
            this.inputNota = new System.Windows.Forms.TextBox();
            this.inputMateria = new System.Windows.Forms.TextBox();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputLegajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputFecha);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnBaja);
            this.groupBox1.Controls.Add(this.btnAlta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelMateria);
            this.groupBox1.Controls.Add(this.labelLegajo);
            this.groupBox1.Controls.Add(this.inputLegajo);
            this.groupBox1.Controls.Add(this.inputNota);
            this.groupBox1.Controls.Add(this.inputMateria);
            this.groupBox1.Location = new System.Drawing.Point(440, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 286);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha:";
            // 
            // inputFecha
            // 
            this.inputFecha.Location = new System.Drawing.Point(86, 81);
            this.inputFecha.Name = "inputFecha";
            this.inputFecha.Size = new System.Drawing.Size(267, 20);
            this.inputFecha.TabIndex = 9;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(248, 233);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 47);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(127, 233);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(105, 47);
            this.btnBaja.TabIndex = 7;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(6, 233);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(105, 47);
            this.btnAlta.TabIndex = 6;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nota:";
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Location = new System.Drawing.Point(27, 135);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(45, 13);
            this.labelMateria.TabIndex = 4;
            this.labelMateria.Text = "Materia:";
            // 
            // labelLegajo
            // 
            this.labelLegajo.AutoSize = true;
            this.labelLegajo.Location = new System.Drawing.Point(27, 41);
            this.labelLegajo.Name = "labelLegajo";
            this.labelLegajo.Size = new System.Drawing.Size(42, 13);
            this.labelLegajo.TabIndex = 3;
            this.labelLegajo.Text = "Legajo:";
            // 
            // inputLegajo
            // 
            this.inputLegajo.Location = new System.Drawing.Point(86, 34);
            this.inputLegajo.Name = "inputLegajo";
            this.inputLegajo.Size = new System.Drawing.Size(267, 20);
            this.inputLegajo.TabIndex = 2;
            // 
            // inputNota
            // 
            this.inputNota.Location = new System.Drawing.Point(86, 176);
            this.inputNota.Name = "inputNota";
            this.inputNota.Size = new System.Drawing.Size(267, 20);
            this.inputNota.TabIndex = 1;
            // 
            // inputMateria
            // 
            this.inputMateria.Location = new System.Drawing.Point(86, 126);
            this.inputMateria.Name = "inputMateria";
            this.inputMateria.Size = new System.Drawing.Size(267, 20);
            this.inputMateria.TabIndex = 0;
            // 
            // dgvNotas
            // 
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(12, 12);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotas.Size = new System.Drawing.Size(411, 286);
            this.dgvNotas.TabIndex = 2;
            // 
            // FormularioNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 308);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNotas);
            this.Name = "FormularioNotas";
            this.Text = "FormularioNotas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputLegajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.Label labelLegajo;
        private System.Windows.Forms.NumericUpDown inputLegajo;
        private System.Windows.Forms.TextBox inputNota;
        private System.Windows.Forms.TextBox inputMateria;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker inputFecha;
    }
}
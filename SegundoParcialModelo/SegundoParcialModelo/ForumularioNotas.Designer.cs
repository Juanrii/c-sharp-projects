
namespace SegundoParcialModelo
{
    partial class ForumularioNotas
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.inputModificarFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.inputModificarNota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputModificarMateria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputModificarLegajo = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputAltaFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAlta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputAltaLegajo = new System.Windows.Forms.NumericUpDown();
            this.inputAltaNota = new System.Windows.Forms.TextBox();
            this.inputAltaMateria = new System.Windows.Forms.TextBox();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputModificarLegajo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputAltaLegajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 400);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(219, 45);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "ELIMINAR SELECCIONADO";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.inputModificarFecha);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.inputModificarNota);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.inputModificarMateria);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.inputModificarLegajo);
            this.groupBox2.Location = new System.Drawing.Point(508, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 217);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Nota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fecha:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(29, 166);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(260, 45);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // inputModificarFecha
            // 
            this.inputModificarFecha.Location = new System.Drawing.Point(89, 140);
            this.inputModificarFecha.Name = "inputModificarFecha";
            this.inputModificarFecha.Size = new System.Drawing.Size(200, 20);
            this.inputModificarFecha.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nota:";
            // 
            // inputModificarNota
            // 
            this.inputModificarNota.Location = new System.Drawing.Point(90, 103);
            this.inputModificarNota.Name = "inputModificarNota";
            this.inputModificarNota.Size = new System.Drawing.Size(200, 20);
            this.inputModificarNota.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Materia:";
            // 
            // inputModificarMateria
            // 
            this.inputModificarMateria.Location = new System.Drawing.Point(90, 66);
            this.inputModificarMateria.Name = "inputModificarMateria";
            this.inputModificarMateria.Size = new System.Drawing.Size(200, 20);
            this.inputModificarMateria.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Legajo:";
            // 
            // inputModificarLegajo
            // 
            this.inputModificarLegajo.Enabled = false;
            this.inputModificarLegajo.Location = new System.Drawing.Point(90, 29);
            this.inputModificarLegajo.Name = "inputModificarLegajo";
            this.inputModificarLegajo.Size = new System.Drawing.Size(200, 20);
            this.inputModificarLegajo.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.inputAltaFecha);
            this.groupBox1.Controls.Add(this.btnAlta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputAltaLegajo);
            this.groupBox1.Controls.Add(this.inputAltaNota);
            this.groupBox1.Controls.Add(this.inputAltaMateria);
            this.groupBox1.Location = new System.Drawing.Point(508, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 217);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta Nota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fecha:";
            // 
            // inputAltaFecha
            // 
            this.inputAltaFecha.Location = new System.Drawing.Point(89, 139);
            this.inputAltaFecha.Name = "inputAltaFecha";
            this.inputAltaFecha.Size = new System.Drawing.Size(200, 20);
            this.inputAltaFecha.TabIndex = 18;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(29, 166);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(260, 45);
            this.btnAlta.TabIndex = 7;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Materia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Legajo:";
            // 
            // inputAltaLegajo
            // 
            this.inputAltaLegajo.Location = new System.Drawing.Point(89, 19);
            this.inputAltaLegajo.Name = "inputAltaLegajo";
            this.inputAltaLegajo.Size = new System.Drawing.Size(200, 20);
            this.inputAltaLegajo.TabIndex = 3;
            // 
            // inputAltaNota
            // 
            this.inputAltaNota.Location = new System.Drawing.Point(89, 99);
            this.inputAltaNota.Name = "inputAltaNota";
            this.inputAltaNota.Size = new System.Drawing.Size(200, 20);
            this.inputAltaNota.TabIndex = 2;
            // 
            // inputAltaMateria
            // 
            this.inputAltaMateria.Location = new System.Drawing.Point(89, 59);
            this.inputAltaMateria.Name = "inputAltaMateria";
            this.inputAltaMateria.Size = new System.Drawing.Size(200, 20);
            this.inputAltaMateria.TabIndex = 1;
            // 
            // dgvNotas
            // 
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(12, 5);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotas.Size = new System.Drawing.Size(490, 389);
            this.dgvNotas.TabIndex = 14;
            this.dgvNotas.SelectionChanged += new System.EventHandler(this.dgvNotas_SelectionChanged);
            // 
            // ForumularioNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNotas);
            this.Name = "ForumularioNotas";
            this.Text = "ForumularioNota";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputModificarLegajo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputAltaLegajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputModificarNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputModificarMateria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown inputModificarLegajo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inputAltaLegajo;
        private System.Windows.Forms.TextBox inputAltaNota;
        private System.Windows.Forms.TextBox inputAltaMateria;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker inputModificarFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker inputAltaFecha;
    }
}
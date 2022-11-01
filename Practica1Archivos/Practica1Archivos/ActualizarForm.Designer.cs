
namespace Practica1Archivos
{
    partial class ActualizarForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputDNI = new System.Windows.Forms.NumericUpDown();
            this.inputApellido = new System.Windows.Forms.TextBox();
            this.groupBoxAlumno = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputDNI)).BeginInit();
            this.groupBoxAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido:";
            // 
            // inputDNI
            // 
            this.inputDNI.Location = new System.Drawing.Point(86, 190);
            this.inputDNI.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.inputDNI.Name = "inputDNI";
            this.inputDNI.Size = new System.Drawing.Size(236, 20);
            this.inputDNI.TabIndex = 2;
            // 
            // inputApellido
            // 
            this.inputApellido.Location = new System.Drawing.Point(86, 116);
            this.inputApellido.Name = "inputApellido";
            this.inputApellido.Size = new System.Drawing.Size(236, 20);
            this.inputApellido.TabIndex = 1;
            // 
            // groupBoxAlumno
            // 
            this.groupBoxAlumno.Controls.Add(this.label3);
            this.groupBoxAlumno.Controls.Add(this.label2);
            this.groupBoxAlumno.Controls.Add(this.label1);
            this.groupBoxAlumno.Controls.Add(this.inputDNI);
            this.groupBoxAlumno.Controls.Add(this.inputApellido);
            this.groupBoxAlumno.Controls.Add(this.inputNombre);
            this.groupBoxAlumno.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAlumno.Name = "groupBoxAlumno";
            this.groupBoxAlumno.Size = new System.Drawing.Size(402, 239);
            this.groupBoxAlumno.TabIndex = 2;
            this.groupBoxAlumno.TabStop = false;
            this.groupBoxAlumno.Text = "Actualizar Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(86, 42);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(236, 20);
            this.inputNombre.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(98, 257);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 51);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(230, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 51);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ActualizarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 316);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBoxAlumno);
            this.Name = "ActualizarForm";
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.ActualizarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputDNI)).EndInit();
            this.groupBoxAlumno.ResumeLayout(false);
            this.groupBoxAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inputDNI;
        private System.Windows.Forms.TextBox inputApellido;
        private System.Windows.Forms.GroupBox groupBoxAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
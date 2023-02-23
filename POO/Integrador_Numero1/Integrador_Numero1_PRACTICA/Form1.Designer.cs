namespace Integrador_Numero1_PRACTICA
{
    partial class Form1
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
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.btnAsignarDuenio = new System.Windows.Forms.Button();
            this.dgvDueniosAutos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAutosPersona = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotal3 = new System.Windows.Forms.Label();
            this.labelTotal4 = new System.Windows.Forms.Label();
            this.labelTotal1 = new System.Windows.Forms.Label();
            this.labelTotal2 = new System.Windows.Forms.Label();
            this.btnBorrarPersona = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueniosAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(7, 36);
            this.dgvPersonas.MultiSelect = false;
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(386, 218);
            this.dgvPersonas.TabIndex = 0;
            this.dgvPersonas.SelectionChanged += new System.EventHandler(this.dgvPersonas_SelectionChanged);
            // 
            // dgvAutos
            // 
            this.dgvAutos.AllowUserToAddRows = false;
            this.dgvAutos.AllowUserToDeleteRows = false;
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutos.Location = new System.Drawing.Point(402, 36);
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.ReadOnly = true;
            this.dgvAutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutos.Size = new System.Drawing.Size(625, 218);
            this.dgvAutos.TabIndex = 1;
            this.dgvAutos.SelectionChanged += new System.EventHandler(this.dgvAutos_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de Personas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de Autos:";
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPersona.Location = new System.Drawing.Point(7, 260);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(193, 40);
            this.btnAgregarPersona.TabIndex = 4;
            this.btnAgregarPersona.Text = "Agregar Persona";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAuto.Location = new System.Drawing.Point(402, 260);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(312, 40);
            this.btnAgregarAuto.TabIndex = 5;
            this.btnAgregarAuto.Text = "Agregar Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // btnAsignarDuenio
            // 
            this.btnAsignarDuenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarDuenio.Location = new System.Drawing.Point(715, 260);
            this.btnAsignarDuenio.Name = "btnAsignarDuenio";
            this.btnAsignarDuenio.Size = new System.Drawing.Size(312, 40);
            this.btnAsignarDuenio.TabIndex = 6;
            this.btnAsignarDuenio.Text = "Asignar Dueño";
            this.btnAsignarDuenio.UseVisualStyleBackColor = true;
            this.btnAsignarDuenio.Click += new System.EventHandler(this.btnAsignarDuenio_Click);
            // 
            // dgvDueniosAutos
            // 
            this.dgvDueniosAutos.AllowUserToAddRows = false;
            this.dgvDueniosAutos.AllowUserToDeleteRows = false;
            this.dgvDueniosAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDueniosAutos.Location = new System.Drawing.Point(402, 386);
            this.dgvDueniosAutos.Name = "dgvDueniosAutos";
            this.dgvDueniosAutos.ReadOnly = true;
            this.dgvDueniosAutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDueniosAutos.Size = new System.Drawing.Size(625, 218);
            this.dgvDueniosAutos.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lista de Dueños y Autos:";
            // 
            // dgvAutosPersona
            // 
            this.dgvAutosPersona.AllowUserToAddRows = false;
            this.dgvAutosPersona.AllowUserToDeleteRows = false;
            this.dgvAutosPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutosPersona.Location = new System.Drawing.Point(7, 386);
            this.dgvAutosPersona.Name = "dgvAutosPersona";
            this.dgvAutosPersona.ReadOnly = true;
            this.dgvAutosPersona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutosPersona.Size = new System.Drawing.Size(386, 218);
            this.dgvAutosPersona.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Autos de la Persona Seleccionada";
            // 
            // labelTotal3
            // 
            this.labelTotal3.AutoSize = true;
            this.labelTotal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal3.Location = new System.Drawing.Point(2, 607);
            this.labelTotal3.Name = "labelTotal3";
            this.labelTotal3.Size = new System.Drawing.Size(117, 25);
            this.labelTotal3.TabIndex = 11;
            this.labelTotal3.Text = "Totales: 0";
            // 
            // labelTotal4
            // 
            this.labelTotal4.AutoSize = true;
            this.labelTotal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal4.Location = new System.Drawing.Point(397, 607);
            this.labelTotal4.Name = "labelTotal4";
            this.labelTotal4.Size = new System.Drawing.Size(117, 25);
            this.labelTotal4.TabIndex = 12;
            this.labelTotal4.Text = "Totales: 0";
            // 
            // labelTotal1
            // 
            this.labelTotal1.AutoSize = true;
            this.labelTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal1.Location = new System.Drawing.Point(2, 303);
            this.labelTotal1.Name = "labelTotal1";
            this.labelTotal1.Size = new System.Drawing.Size(117, 25);
            this.labelTotal1.TabIndex = 13;
            this.labelTotal1.Text = "Totales: 0";
            // 
            // labelTotal2
            // 
            this.labelTotal2.AutoSize = true;
            this.labelTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal2.Location = new System.Drawing.Point(397, 303);
            this.labelTotal2.Name = "labelTotal2";
            this.labelTotal2.Size = new System.Drawing.Size(117, 25);
            this.labelTotal2.TabIndex = 14;
            this.labelTotal2.Text = "Totales: 0";
            // 
            // btnBorrarPersona
            // 
            this.btnBorrarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarPersona.Location = new System.Drawing.Point(203, 260);
            this.btnBorrarPersona.Name = "btnBorrarPersona";
            this.btnBorrarPersona.Size = new System.Drawing.Size(193, 40);
            this.btnBorrarPersona.TabIndex = 15;
            this.btnBorrarPersona.Text = "Borrar Persona";
            this.btnBorrarPersona.UseVisualStyleBackColor = true;
            this.btnBorrarPersona.Click += new System.EventHandler(this.btnBorrarPersona_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 638);
            this.Controls.Add(this.btnBorrarPersona);
            this.Controls.Add(this.labelTotal2);
            this.Controls.Add(this.labelTotal1);
            this.Controls.Add(this.labelTotal4);
            this.Controls.Add(this.labelTotal3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvAutosPersona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDueniosAutos);
            this.Controls.Add(this.btnAsignarDuenio);
            this.Controls.Add(this.btnAgregarAuto);
            this.Controls.Add(this.btnAgregarPersona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAutos);
            this.Controls.Add(this.dgvPersonas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueniosAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.DataGridView dgvAutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Button btnAsignarDuenio;
        private System.Windows.Forms.DataGridView dgvDueniosAutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAutosPersona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotal3;
        private System.Windows.Forms.Label labelTotal4;
        private System.Windows.Forms.Label labelTotal1;
        private System.Windows.Forms.Label labelTotal2;
        private System.Windows.Forms.Button btnBorrarPersona;
    }
}


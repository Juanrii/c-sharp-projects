namespace UI
{
    partial class FormInformesFiltrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputPatente = new System.Windows.Forms.TextBox();
            this.dgvAutosFiltrados = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosFiltrados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputPatente);
            this.groupBox1.Controls.Add(this.dgvAutosFiltrados);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2123, 760);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Autos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patente:";
            // 
            // inputPatente
            // 
            this.inputPatente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.inputPatente.Location = new System.Drawing.Point(172, 57);
            this.inputPatente.Name = "inputPatente";
            this.inputPatente.Size = new System.Drawing.Size(287, 51);
            this.inputPatente.TabIndex = 1;
            this.inputPatente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputPatente_KeyPress);
            // 
            // dgvAutosFiltrados
            // 
            this.dgvAutosFiltrados.AllowUserToAddRows = false;
            this.dgvAutosFiltrados.AllowUserToDeleteRows = false;
            this.dgvAutosFiltrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutosFiltrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutosFiltrados.Location = new System.Drawing.Point(12, 123);
            this.dgvAutosFiltrados.Name = "dgvAutosFiltrados";
            this.dgvAutosFiltrados.ReadOnly = true;
            this.dgvAutosFiltrados.RowHeadersWidth = 82;
            this.dgvAutosFiltrados.RowTemplate.Height = 33;
            this.dgvAutosFiltrados.Size = new System.Drawing.Size(2105, 631);
            this.dgvAutosFiltrados.TabIndex = 0;
            // 
            // FormInformesFiltrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2147, 794);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInformesFiltrar";
            this.Text = "FormInformesFiltrar";
            this.Load += new System.EventHandler(this.FormInformesFiltrar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosFiltrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputPatente;
        private System.Windows.Forms.DataGridView dgvAutosFiltrados;
    }
}
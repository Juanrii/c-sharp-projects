namespace UI
{
    partial class FormEstadisticas
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
            this.dgvCanales = new System.Windows.Forms.DataGridView();
            this.labelPaqueteVendido = new System.Windows.Forms.GroupBox();
            this.dgvPaquetes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanales)).BeginInit();
            this.labelPaqueteVendido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCanales);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1145, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Series con Ranking > 3.5";
            // 
            // dgvCanales
            // 
            this.dgvCanales.AllowUserToAddRows = false;
            this.dgvCanales.AllowUserToDeleteRows = false;
            this.dgvCanales.AllowUserToResizeColumns = false;
            this.dgvCanales.AllowUserToResizeRows = false;
            this.dgvCanales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCanales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCanales.Location = new System.Drawing.Point(6, 30);
            this.dgvCanales.Name = "dgvCanales";
            this.dgvCanales.ReadOnly = true;
            this.dgvCanales.RowHeadersWidth = 82;
            this.dgvCanales.RowTemplate.Height = 33;
            this.dgvCanales.Size = new System.Drawing.Size(1127, 225);
            this.dgvCanales.TabIndex = 0;
            // 
            // labelPaqueteVendido
            // 
            this.labelPaqueteVendido.Controls.Add(this.dgvPaquetes);
            this.labelPaqueteVendido.Location = new System.Drawing.Point(26, 279);
            this.labelPaqueteVendido.Name = "labelPaqueteVendido";
            this.labelPaqueteVendido.Size = new System.Drawing.Size(1139, 261);
            this.labelPaqueteVendido.TabIndex = 1;
            this.labelPaqueteVendido.TabStop = false;
            this.labelPaqueteVendido.Text = "Paquete mas vendido: ";
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.AllowUserToAddRows = false;
            this.dgvPaquetes.AllowUserToDeleteRows = false;
            this.dgvPaquetes.AllowUserToResizeColumns = false;
            this.dgvPaquetes.AllowUserToResizeRows = false;
            this.dgvPaquetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaquetes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPaquetes.Location = new System.Drawing.Point(6, 30);
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.ReadOnly = true;
            this.dgvPaquetes.RowHeadersWidth = 82;
            this.dgvPaquetes.RowTemplate.Height = 33;
            this.dgvPaquetes.Size = new System.Drawing.Size(1127, 225);
            this.dgvPaquetes.TabIndex = 0;
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1076);
            this.Controls.Add(this.labelPaqueteVendido);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEstadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanales)).EndInit();
            this.labelPaqueteVendido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCanales;
        private System.Windows.Forms.GroupBox labelPaqueteVendido;
        private System.Windows.Forms.DataGridView dgvPaquetes;
    }
}
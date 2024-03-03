namespace UI
{
    partial class FormInformesListarDeBaja
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
            this.btnDesc = new System.Windows.Forms.RadioButton();
            this.btnAsc = new System.Windows.Forms.RadioButton();
            this.dgvListadoAutos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDesc);
            this.groupBox1.Controls.Add(this.btnAsc);
            this.groupBox1.Controls.Add(this.dgvListadoAutos);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2003, 731);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado Autos dados de baja";
            // 
            // btnDesc
            // 
            this.btnDesc.AutoSize = true;
            this.btnDesc.Location = new System.Drawing.Point(291, 40);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(252, 49);
            this.btnDesc.TabIndex = 2;
            this.btnDesc.TabStop = true;
            this.btnDesc.Text = "Descendente";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.CheckedChanged += new System.EventHandler(this.btnDesc_CheckedChanged);
            // 
            // btnAsc
            // 
            this.btnAsc.AutoSize = true;
            this.btnAsc.Location = new System.Drawing.Point(29, 40);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(234, 49);
            this.btnAsc.TabIndex = 1;
            this.btnAsc.TabStop = true;
            this.btnAsc.Text = "Ascendente";
            this.btnAsc.UseVisualStyleBackColor = true;
            this.btnAsc.CheckedChanged += new System.EventHandler(this.btnAsc_CheckedChanged);
            // 
            // dgvListadoAutos
            // 
            this.dgvListadoAutos.AllowUserToAddRows = false;
            this.dgvListadoAutos.AllowUserToDeleteRows = false;
            this.dgvListadoAutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoAutos.Location = new System.Drawing.Point(12, 94);
            this.dgvListadoAutos.Name = "dgvListadoAutos";
            this.dgvListadoAutos.ReadOnly = true;
            this.dgvListadoAutos.RowHeadersWidth = 82;
            this.dgvListadoAutos.RowTemplate.Height = 33;
            this.dgvListadoAutos.Size = new System.Drawing.Size(1985, 631);
            this.dgvListadoAutos.TabIndex = 0;
            // 
            // FormInformesListarDeBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2027, 756);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInformesListarDeBaja";
            this.Text = "FormInformesListarDeBaja";
            this.Load += new System.EventHandler(this.FormInformesListarDeBaja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListadoAutos;
        private System.Windows.Forms.RadioButton btnDesc;
        private System.Windows.Forms.RadioButton btnAsc;
    }
}

namespace PreParcial2
{
    partial class FormularioPromedios
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
            this.dgvPromedios = new System.Windows.Forms.DataGridView();
            this.labelPromedio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPromedios
            // 
            this.dgvPromedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromedios.Location = new System.Drawing.Point(12, 12);
            this.dgvPromedios.Name = "dgvPromedios";
            this.dgvPromedios.Size = new System.Drawing.Size(562, 319);
            this.dgvPromedios.TabIndex = 0;
            // 
            // labelPromedio
            // 
            this.labelPromedio.AutoSize = true;
            this.labelPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromedio.Location = new System.Drawing.Point(12, 334);
            this.labelPromedio.Name = "labelPromedio";
            this.labelPromedio.Size = new System.Drawing.Size(226, 31);
            this.labelPromedio.TabIndex = 1;
            this.labelPromedio.Text = "Mejor Promedio:";
            // 
            // FormularioPromedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPromedio);
            this.Controls.Add(this.dgvPromedios);
            this.Name = "FormularioPromedios";
            this.Text = "FormularioPromedios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPromedios;
        private System.Windows.Forms.Label labelPromedio;
    }
}
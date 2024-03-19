namespace UI
{
    partial class FormPersonas
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInternacional = new System.Windows.Forms.RadioButton();
            this.btnNacional = new System.Windows.Forms.RadioButton();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnAlta = new System.Windows.Forms.Button();
            this.uC_FechaNac1 = new WindowsFormsControlLibrary1.UC_FechaNac();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnInternacional);
            this.groupBox1.Controls.Add(this.btnNacional);
            this.groupBox1.Controls.Add(this.dgvPersonas);
            this.groupBox1.Controls.Add(this.btnAlta);
            this.groupBox1.Controls.Add(this.uC_FechaNac1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1479, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta de Personas";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(0, 328);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(384, 58);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(0, 264);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(384, 58);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInternacional
            // 
            this.btnInternacional.AutoSize = true;
            this.btnInternacional.Location = new System.Drawing.Point(193, 165);
            this.btnInternacional.Name = "btnInternacional";
            this.btnInternacional.Size = new System.Drawing.Size(166, 29);
            this.btnInternacional.TabIndex = 4;
            this.btnInternacional.TabStop = true;
            this.btnInternacional.Text = "Internacional";
            this.btnInternacional.UseVisualStyleBackColor = true;
            // 
            // btnNacional
            // 
            this.btnNacional.AutoSize = true;
            this.btnNacional.Location = new System.Drawing.Point(25, 165);
            this.btnNacional.Name = "btnNacional";
            this.btnNacional.Size = new System.Drawing.Size(127, 29);
            this.btnNacional.TabIndex = 3;
            this.btnNacional.TabStop = true;
            this.btnNacional.Text = "Nacional";
            this.btnNacional.UseVisualStyleBackColor = true;
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersonas.Location = new System.Drawing.Point(415, 48);
            this.dgvPersonas.MultiSelect = false;
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowHeadersWidth = 82;
            this.dgvPersonas.RowTemplate.Height = 33;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(1058, 338);
            this.dgvPersonas.TabIndex = 2;
            this.dgvPersonas.SelectionChanged += new System.EventHandler(this.dgvPersonas_SelectionChanged);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(0, 200);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(384, 58);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // uC_FechaNac1
            // 
            this.uC_FechaNac1.Location = new System.Drawing.Point(6, 48);
            this.uC_FechaNac1.Name = "uC_FechaNac1";
            this.uC_FechaNac1.Size = new System.Drawing.Size(384, 123);
            this.uC_FechaNac1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Alta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(384, 58);
            this.button3.TabIndex = 6;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 972);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPersonas";
            this.Text = "FormPersonas";
            this.Load += new System.EventHandler(this.FormPersonas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlta;
        private WindowsFormsControlLibrary1.UC_FechaNac uC_FechaNac1;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.RadioButton btnInternacional;
        private System.Windows.Forms.RadioButton btnNacional;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}
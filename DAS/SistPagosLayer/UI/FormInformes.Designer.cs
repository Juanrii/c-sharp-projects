namespace UI
{
    partial class FormInformes
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
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.labelPagosPersona = new System.Windows.Forms.GroupBox();
            this.dgvPagosPersona = new System.Windows.Forms.DataGridView();
            this.dgvFiltrarPersonas = new System.Windows.Forms.GroupBox();
            this.btnListarPersonas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputApellido = new System.Windows.Forms.TextBox();
            this.dgvPersonasXApellido = new System.Windows.Forms.DataGridView();
            this.btnEliminarPago = new System.Windows.Forms.Button();
            this.btnAgregarPago = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvGrilla4 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.labelPagosPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosPersona)).BeginInit();
            this.dgvFiltrarPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasXApellido)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPersonas);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1311, 543);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grilla 1: Todas las personas";
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersonas.Location = new System.Drawing.Point(12, 30);
            this.dgvPersonas.MultiSelect = false;
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowHeadersWidth = 82;
            this.dgvPersonas.RowTemplate.Height = 33;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(1293, 507);
            this.dgvPersonas.TabIndex = 0;
            this.dgvPersonas.SelectionChanged += new System.EventHandler(this.dgvPersonas_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPagos);
            this.groupBox2.Location = new System.Drawing.Point(12, 566);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1299, 330);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grilla 2: Todos los pagos";
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPagos.Location = new System.Drawing.Point(6, 30);
            this.dgvPagos.MultiSelect = false;
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowHeadersWidth = 82;
            this.dgvPagos.RowTemplate.Height = 33;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(1287, 357);
            this.dgvPagos.TabIndex = 0;
            // 
            // labelPagosPersona
            // 
            this.labelPagosPersona.Controls.Add(this.dgvPagosPersona);
            this.labelPagosPersona.Location = new System.Drawing.Point(1323, 0);
            this.labelPagosPersona.Name = "labelPagosPersona";
            this.labelPagosPersona.Size = new System.Drawing.Size(991, 332);
            this.labelPagosPersona.TabIndex = 2;
            this.labelPagosPersona.TabStop = false;
            this.labelPagosPersona.Text = "Grilla 3: Pagos de:  ";
            // 
            // dgvPagosPersona
            // 
            this.dgvPagosPersona.AllowUserToAddRows = false;
            this.dgvPagosPersona.AllowUserToDeleteRows = false;
            this.dgvPagosPersona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagosPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagosPersona.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPagosPersona.Location = new System.Drawing.Point(6, 30);
            this.dgvPagosPersona.MultiSelect = false;
            this.dgvPagosPersona.Name = "dgvPagosPersona";
            this.dgvPagosPersona.ReadOnly = true;
            this.dgvPagosPersona.RowHeadersWidth = 82;
            this.dgvPagosPersona.RowTemplate.Height = 33;
            this.dgvPagosPersona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagosPersona.Size = new System.Drawing.Size(979, 356);
            this.dgvPagosPersona.TabIndex = 0;
            // 
            // dgvFiltrarPersonas
            // 
            this.dgvFiltrarPersonas.Controls.Add(this.btnListarPersonas);
            this.dgvFiltrarPersonas.Controls.Add(this.label1);
            this.dgvFiltrarPersonas.Controls.Add(this.inputApellido);
            this.dgvFiltrarPersonas.Controls.Add(this.dgvPersonasXApellido);
            this.dgvFiltrarPersonas.Location = new System.Drawing.Point(1329, 597);
            this.dgvFiltrarPersonas.Name = "dgvFiltrarPersonas";
            this.dgvFiltrarPersonas.Size = new System.Drawing.Size(991, 332);
            this.dgvFiltrarPersonas.TabIndex = 3;
            this.dgvFiltrarPersonas.TabStop = false;
            this.dgvFiltrarPersonas.Text = "Grilla 5: Filtrar personas";
            // 
            // btnListarPersonas
            // 
            this.btnListarPersonas.Location = new System.Drawing.Point(664, 30);
            this.btnListarPersonas.Name = "btnListarPersonas";
            this.btnListarPersonas.Size = new System.Drawing.Size(321, 40);
            this.btnListarPersonas.TabIndex = 3;
            this.btnListarPersonas.Text = "Ver Todas";
            this.btnListarPersonas.UseVisualStyleBackColor = true;
            this.btnListarPersonas.Click += new System.EventHandler(this.btnListarPersonas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido:";
            // 
            // inputApellido
            // 
            this.inputApellido.Location = new System.Drawing.Point(107, 43);
            this.inputApellido.Name = "inputApellido";
            this.inputApellido.Size = new System.Drawing.Size(257, 31);
            this.inputApellido.TabIndex = 1;
            this.inputApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputApellido_KeyPress);
            // 
            // dgvPersonasXApellido
            // 
            this.dgvPersonasXApellido.AllowUserToAddRows = false;
            this.dgvPersonasXApellido.AllowUserToDeleteRows = false;
            this.dgvPersonasXApellido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonasXApellido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonasXApellido.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersonasXApellido.Location = new System.Drawing.Point(6, 80);
            this.dgvPersonasXApellido.MultiSelect = false;
            this.dgvPersonasXApellido.Name = "dgvPersonasXApellido";
            this.dgvPersonasXApellido.ReadOnly = true;
            this.dgvPersonasXApellido.RowHeadersWidth = 82;
            this.dgvPersonasXApellido.RowTemplate.Height = 33;
            this.dgvPersonasXApellido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonasXApellido.Size = new System.Drawing.Size(979, 244);
            this.dgvPersonasXApellido.TabIndex = 0;
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.Location = new System.Drawing.Point(1323, 338);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(979, 40);
            this.btnEliminarPago.TabIndex = 4;
            this.btnEliminarPago.Text = "Eliminar Pago";
            this.btnEliminarPago.UseVisualStyleBackColor = true;
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.Location = new System.Drawing.Point(18, 902);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(1287, 40);
            this.btnAgregarPago.TabIndex = 5;
            this.btnAgregarPago.Text = "Agregar Pago";
            this.btnAgregarPago.UseVisualStyleBackColor = true;
            this.btnAgregarPago.Click += new System.EventHandler(this.btnAgregarPago_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvGrilla4);
            this.groupBox3.Location = new System.Drawing.Point(1323, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(991, 199);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grilla 4";
            // 
            // dgvGrilla4
            // 
            this.dgvGrilla4.AllowUserToAddRows = false;
            this.dgvGrilla4.AllowUserToDeleteRows = false;
            this.dgvGrilla4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrilla4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGrilla4.Location = new System.Drawing.Point(6, 30);
            this.dgvGrilla4.MultiSelect = false;
            this.dgvGrilla4.Name = "dgvGrilla4";
            this.dgvGrilla4.ReadOnly = true;
            this.dgvGrilla4.RowHeadersWidth = 82;
            this.dgvGrilla4.RowTemplate.Height = 33;
            this.dgvGrilla4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla4.Size = new System.Drawing.Size(979, 158);
            this.dgvGrilla4.TabIndex = 0;
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2454, 1238);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAgregarPago);
            this.Controls.Add(this.btnEliminarPago);
            this.Controls.Add(this.dgvFiltrarPersonas);
            this.Controls.Add(this.labelPagosPersona);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInformes";
            this.Text = "FormInformes";
            this.Load += new System.EventHandler(this.FormInformes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.labelPagosPersona.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosPersona)).EndInit();
            this.dgvFiltrarPersonas.ResumeLayout(false);
            this.dgvFiltrarPersonas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasXApellido)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.GroupBox labelPagosPersona;
        private System.Windows.Forms.DataGridView dgvPagosPersona;
        private System.Windows.Forms.GroupBox dgvFiltrarPersonas;
        private System.Windows.Forms.DataGridView dgvPersonasXApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputApellido;
        private System.Windows.Forms.Button btnListarPersonas;
        private System.Windows.Forms.Button btnEliminarPago;
        private System.Windows.Forms.Button btnAgregarPago;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvGrilla4;
    }
}
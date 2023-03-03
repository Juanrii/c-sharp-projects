namespace _091_POO_Z8_1erParcial_Rios_JuanIgnacio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBeneficiarios = new System.Windows.Forms.DataGridView();
            this.dgvBeneficiariosAdelantosVista = new System.Windows.Forms.DataGridView();
            this.dgvAdelantos = new System.Windows.Forms.DataGridView();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.radioBtnAdministrativo = new System.Windows.Forms.RadioButton();
            this.radioBtnOperario = new System.Windows.Forms.RadioButton();
            this.radioBtnDirectivo = new System.Windows.Forms.RadioButton();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarAdelanto = new System.Windows.Forms.Button();
            this.btnModificarAdelanto = new System.Windows.Forms.Button();
            this.btnCrearAdelanto = new System.Windows.Forms.Button();
            this.btnAsignarAdelanto = new System.Windows.Forms.Button();
            this.btnCrearMultiples = new System.Windows.Forms.Button();
            this.btnPagarAdelanto = new System.Windows.Forms.Button();
            this.inputTotalImporteAsignado = new System.Windows.Forms.TextBox();
            this.totalImporteAsignado = new System.Windows.Forms.Label();
            this.totalAdeudado = new System.Windows.Forms.Label();
            this.inputTotalAdeudado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiariosAdelantosVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBeneficiarios
            // 
            this.dgvBeneficiarios.AllowUserToAddRows = false;
            this.dgvBeneficiarios.AllowUserToDeleteRows = false;
            this.dgvBeneficiarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeneficiarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBeneficiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiarios.Location = new System.Drawing.Point(12, 84);
            this.dgvBeneficiarios.MultiSelect = false;
            this.dgvBeneficiarios.Name = "dgvBeneficiarios";
            this.dgvBeneficiarios.ReadOnly = true;
            this.dgvBeneficiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeneficiarios.Size = new System.Drawing.Size(384, 234);
            this.dgvBeneficiarios.TabIndex = 0;
            this.dgvBeneficiarios.SelectionChanged += new System.EventHandler(this.dgvBeneficiarios_SelectionChanged);
            // 
            // dgvBeneficiariosAdelantosVista
            // 
            this.dgvBeneficiariosAdelantosVista.AllowUserToAddRows = false;
            this.dgvBeneficiariosAdelantosVista.AllowUserToDeleteRows = false;
            this.dgvBeneficiariosAdelantosVista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeneficiariosAdelantosVista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBeneficiariosAdelantosVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiariosAdelantosVista.Location = new System.Drawing.Point(15, 390);
            this.dgvBeneficiariosAdelantosVista.MultiSelect = false;
            this.dgvBeneficiariosAdelantosVista.Name = "dgvBeneficiariosAdelantosVista";
            this.dgvBeneficiariosAdelantosVista.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeneficiariosAdelantosVista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBeneficiariosAdelantosVista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeneficiariosAdelantosVista.Size = new System.Drawing.Size(1733, 281);
            this.dgvBeneficiariosAdelantosVista.TabIndex = 1;
            this.dgvBeneficiariosAdelantosVista.SelectionChanged += new System.EventHandler(this.dgvBeneficiariosAdelantosVista_SelectionChanged);
            // 
            // dgvAdelantos
            // 
            this.dgvAdelantos.AllowUserToAddRows = false;
            this.dgvAdelantos.AllowUserToDeleteRows = false;
            this.dgvAdelantos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdelantos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAdelantos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelantos.Location = new System.Drawing.Point(827, 85);
            this.dgvAdelantos.MultiSelect = false;
            this.dgvAdelantos.Name = "dgvAdelantos";
            this.dgvAdelantos.ReadOnly = true;
            this.dgvAdelantos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdelantos.Size = new System.Drawing.Size(921, 234);
            this.dgvAdelantos.TabIndex = 2;
            this.dgvAdelantos.SelectionChanged += new System.EventHandler(this.dgvAdelantos_SelectionChanged);
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCrearEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEmpleado.Location = new System.Drawing.Point(402, 84);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(82, 74);
            this.btnCrearEmpleado.TabIndex = 3;
            this.btnCrearEmpleado.Text = "Crear Empleado";
            this.btnCrearEmpleado.UseVisualStyleBackColor = false;
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // radioBtnAdministrativo
            // 
            this.radioBtnAdministrativo.AutoSize = true;
            this.radioBtnAdministrativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAdministrativo.Location = new System.Drawing.Point(488, 90);
            this.radioBtnAdministrativo.Name = "radioBtnAdministrativo";
            this.radioBtnAdministrativo.Size = new System.Drawing.Size(140, 24);
            this.radioBtnAdministrativo.TabIndex = 4;
            this.radioBtnAdministrativo.TabStop = true;
            this.radioBtnAdministrativo.Text = "Administrativo";
            this.radioBtnAdministrativo.UseVisualStyleBackColor = true;
            // 
            // radioBtnOperario
            // 
            this.radioBtnOperario.AutoSize = true;
            this.radioBtnOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnOperario.Location = new System.Drawing.Point(488, 113);
            this.radioBtnOperario.Name = "radioBtnOperario";
            this.radioBtnOperario.Size = new System.Drawing.Size(96, 24);
            this.radioBtnOperario.TabIndex = 5;
            this.radioBtnOperario.TabStop = true;
            this.radioBtnOperario.Text = "Operario";
            this.radioBtnOperario.UseVisualStyleBackColor = true;
            // 
            // radioBtnDirectivo
            // 
            this.radioBtnDirectivo.AutoSize = true;
            this.radioBtnDirectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnDirectivo.Location = new System.Drawing.Point(488, 136);
            this.radioBtnDirectivo.Name = "radioBtnDirectivo";
            this.radioBtnDirectivo.Size = new System.Drawing.Size(97, 24);
            this.radioBtnDirectivo.TabIndex = 6;
            this.radioBtnDirectivo.TabStop = true;
            this.radioBtnDirectivo.Text = "Directivo";
            this.radioBtnDirectivo.UseVisualStyleBackColor = true;
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.BackColor = System.Drawing.Color.Khaki;
            this.btnModificarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEmpleado.Location = new System.Drawing.Point(402, 243);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(82, 74);
            this.btnModificarEmpleado.TabIndex = 7;
            this.btnModificarEmpleado.Text = "Modificar Empleado";
            this.btnModificarEmpleado.UseVisualStyleBackColor = false;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(402, 164);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(82, 74);
            this.btnEliminarEmpleado.TabIndex = 8;
            this.btnEliminarEmpleado.Text = "Eliminar Empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnEliminarAdelanto
            // 
            this.btnEliminarAdelanto.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminarAdelanto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAdelanto.Location = new System.Drawing.Point(739, 165);
            this.btnEliminarAdelanto.Name = "btnEliminarAdelanto";
            this.btnEliminarAdelanto.Size = new System.Drawing.Size(82, 74);
            this.btnEliminarAdelanto.TabIndex = 11;
            this.btnEliminarAdelanto.Text = "Eliminar Adelanto";
            this.btnEliminarAdelanto.UseVisualStyleBackColor = false;
            this.btnEliminarAdelanto.Click += new System.EventHandler(this.btnEliminarAdelanto_Click);
            // 
            // btnModificarAdelanto
            // 
            this.btnModificarAdelanto.BackColor = System.Drawing.Color.Khaki;
            this.btnModificarAdelanto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAdelanto.Location = new System.Drawing.Point(739, 245);
            this.btnModificarAdelanto.Name = "btnModificarAdelanto";
            this.btnModificarAdelanto.Size = new System.Drawing.Size(82, 74);
            this.btnModificarAdelanto.TabIndex = 10;
            this.btnModificarAdelanto.Text = "Modificar Adelanto";
            this.btnModificarAdelanto.UseVisualStyleBackColor = false;
            this.btnModificarAdelanto.Click += new System.EventHandler(this.btnModificarAdelanto_Click);
            // 
            // btnCrearAdelanto
            // 
            this.btnCrearAdelanto.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCrearAdelanto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAdelanto.Location = new System.Drawing.Point(739, 85);
            this.btnCrearAdelanto.Name = "btnCrearAdelanto";
            this.btnCrearAdelanto.Size = new System.Drawing.Size(82, 74);
            this.btnCrearAdelanto.TabIndex = 9;
            this.btnCrearAdelanto.Text = "Crear Adelanto";
            this.btnCrearAdelanto.UseVisualStyleBackColor = false;
            this.btnCrearAdelanto.Click += new System.EventHandler(this.btnCrearAdelanto_Click);
            // 
            // btnAsignarAdelanto
            // 
            this.btnAsignarAdelanto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAsignarAdelanto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarAdelanto.Location = new System.Drawing.Point(827, 325);
            this.btnAsignarAdelanto.Name = "btnAsignarAdelanto";
            this.btnAsignarAdelanto.Size = new System.Drawing.Size(921, 59);
            this.btnAsignarAdelanto.TabIndex = 12;
            this.btnAsignarAdelanto.Text = "Asignar Adelanto";
            this.btnAsignarAdelanto.UseVisualStyleBackColor = false;
            this.btnAsignarAdelanto.Click += new System.EventHandler(this.btnAsignarAdelanto_Click);
            // 
            // btnCrearMultiples
            // 
            this.btnCrearMultiples.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCrearMultiples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearMultiples.Location = new System.Drawing.Point(490, 164);
            this.btnCrearMultiples.Name = "btnCrearMultiples";
            this.btnCrearMultiples.Size = new System.Drawing.Size(243, 153);
            this.btnCrearMultiples.TabIndex = 13;
            this.btnCrearMultiples.Text = "Crear Múltiples\r\nEmpleados - Adelantos\r\n(Por única vez)";
            this.btnCrearMultiples.UseVisualStyleBackColor = false;
            this.btnCrearMultiples.Click += new System.EventHandler(this.btnCrearMultiples_Click);
            // 
            // btnPagarAdelanto
            // 
            this.btnPagarAdelanto.BackColor = System.Drawing.Color.SpringGreen;
            this.btnPagarAdelanto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarAdelanto.Location = new System.Drawing.Point(15, 677);
            this.btnPagarAdelanto.Name = "btnPagarAdelanto";
            this.btnPagarAdelanto.Size = new System.Drawing.Size(1733, 59);
            this.btnPagarAdelanto.TabIndex = 14;
            this.btnPagarAdelanto.Text = "Pagar Adelanto";
            this.btnPagarAdelanto.UseVisualStyleBackColor = false;
            this.btnPagarAdelanto.Click += new System.EventHandler(this.btnPagarAdelanto_Click);
            // 
            // inputTotalImporteAsignado
            // 
            this.inputTotalImporteAsignado.Enabled = false;
            this.inputTotalImporteAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTotalImporteAsignado.Location = new System.Drawing.Point(280, 341);
            this.inputTotalImporteAsignado.Name = "inputTotalImporteAsignado";
            this.inputTotalImporteAsignado.Size = new System.Drawing.Size(171, 31);
            this.inputTotalImporteAsignado.TabIndex = 15;
            // 
            // totalImporteAsignado
            // 
            this.totalImporteAsignado.AutoSize = true;
            this.totalImporteAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalImporteAsignado.Location = new System.Drawing.Point(12, 345);
            this.totalImporteAsignado.Name = "totalImporteAsignado";
            this.totalImporteAsignado.Size = new System.Drawing.Size(262, 25);
            this.totalImporteAsignado.TabIndex = 16;
            this.totalImporteAsignado.Text = "Total Importe Asignado:";
            // 
            // totalAdeudado
            // 
            this.totalAdeudado.AutoSize = true;
            this.totalAdeudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAdeudado.Location = new System.Drawing.Point(459, 345);
            this.totalAdeudado.Name = "totalAdeudado";
            this.totalAdeudado.Size = new System.Drawing.Size(185, 25);
            this.totalAdeudado.TabIndex = 18;
            this.totalAdeudado.Text = "Total Adeudado:";
            // 
            // inputTotalAdeudado
            // 
            this.inputTotalAdeudado.Enabled = false;
            this.inputTotalAdeudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTotalAdeudado.Location = new System.Drawing.Point(650, 342);
            this.inputTotalAdeudado.MaximumSize = new System.Drawing.Size(600, 50);
            this.inputTotalAdeudado.Name = "inputTotalAdeudado";
            this.inputTotalAdeudado.Size = new System.Drawing.Size(171, 31);
            this.inputTotalAdeudado.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lista Empleados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(822, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lista Adelantos:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(1447, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(301, 53);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1760, 748);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalAdeudado);
            this.Controls.Add(this.inputTotalAdeudado);
            this.Controls.Add(this.totalImporteAsignado);
            this.Controls.Add(this.inputTotalImporteAsignado);
            this.Controls.Add(this.btnPagarAdelanto);
            this.Controls.Add(this.btnCrearMultiples);
            this.Controls.Add(this.btnAsignarAdelanto);
            this.Controls.Add(this.btnEliminarAdelanto);
            this.Controls.Add(this.btnModificarAdelanto);
            this.Controls.Add(this.btnCrearAdelanto);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnModificarEmpleado);
            this.Controls.Add(this.radioBtnDirectivo);
            this.Controls.Add(this.radioBtnOperario);
            this.Controls.Add(this.radioBtnAdministrativo);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Controls.Add(this.dgvAdelantos);
            this.Controls.Add(this.dgvBeneficiariosAdelantosVista);
            this.Controls.Add(this.dgvBeneficiarios);
            this.Name = "Form1";
            this.Text = "Administración de Adelantos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiariosAdelantosVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBeneficiarios;
        private System.Windows.Forms.DataGridView dgvBeneficiariosAdelantosVista;
        private System.Windows.Forms.DataGridView dgvAdelantos;
        private System.Windows.Forms.Button btnCrearEmpleado;
        private System.Windows.Forms.RadioButton radioBtnAdministrativo;
        private System.Windows.Forms.RadioButton radioBtnOperario;
        private System.Windows.Forms.RadioButton radioBtnDirectivo;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnEliminarAdelanto;
        private System.Windows.Forms.Button btnModificarAdelanto;
        private System.Windows.Forms.Button btnCrearAdelanto;
        private System.Windows.Forms.Button btnAsignarAdelanto;
        private System.Windows.Forms.Button btnCrearMultiples;
        private System.Windows.Forms.Button btnPagarAdelanto;
        private System.Windows.Forms.TextBox inputTotalImporteAsignado;
        private System.Windows.Forms.Label totalImporteAsignado;
        private System.Windows.Forms.Label totalAdeudado;
        private System.Windows.Forms.TextBox inputTotalAdeudado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}


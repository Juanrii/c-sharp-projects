namespace SegundoParcialRiosJuanIgnacio
{
    partial class Form1
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
            this.dgv1Socios = new System.Windows.Forms.DataGridView();
            this.dgv2CuotasAsginadas = new System.Windows.Forms.DataGridView();
            this.dgv5CobrosPagados = new System.Windows.Forms.DataGridView();
            this.dgv3CuotasPagadas = new System.Windows.Forms.DataGridView();
            this.dgv4CuotasOrdenadas = new System.Windows.Forms.DataGridView();
            this.btnAgregarSocio = new System.Windows.Forms.Button();
            this.radioBtnSocioNormal = new System.Windows.Forms.RadioButton();
            this.radioBtnSocioEspecial = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarSocio = new System.Windows.Forms.Button();
            this.btnModificarSocio = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCuotaPorLote = new System.Windows.Forms.Button();
            this.btnPagarCuota = new System.Windows.Forms.Button();
            this.btnAsignarCuota = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioBtnDesc = new System.Windows.Forms.RadioButton();
            this.radioBtnASC = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1Socios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2CuotasAsginadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv5CobrosPagados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3CuotasPagadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4CuotasOrdenadas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1Socios
            // 
            this.dgv1Socios.AllowUserToAddRows = false;
            this.dgv1Socios.AllowUserToDeleteRows = false;
            this.dgv1Socios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1Socios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1Socios.Location = new System.Drawing.Point(6, 28);
            this.dgv1Socios.MultiSelect = false;
            this.dgv1Socios.Name = "dgv1Socios";
            this.dgv1Socios.ReadOnly = true;
            this.dgv1Socios.RowHeadersWidth = 82;
            this.dgv1Socios.RowTemplate.Height = 33;
            this.dgv1Socios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1Socios.Size = new System.Drawing.Size(809, 413);
            this.dgv1Socios.TabIndex = 0;
            this.dgv1Socios.SelectionChanged += new System.EventHandler(this.dgv1Socios_SelectionChanged);
            // 
            // dgv2CuotasAsginadas
            // 
            this.dgv2CuotasAsginadas.AllowUserToAddRows = false;
            this.dgv2CuotasAsginadas.AllowUserToDeleteRows = false;
            this.dgv2CuotasAsginadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2CuotasAsginadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2CuotasAsginadas.Location = new System.Drawing.Point(6, 30);
            this.dgv2CuotasAsginadas.MultiSelect = false;
            this.dgv2CuotasAsginadas.Name = "dgv2CuotasAsginadas";
            this.dgv2CuotasAsginadas.ReadOnly = true;
            this.dgv2CuotasAsginadas.RowHeadersWidth = 82;
            this.dgv2CuotasAsginadas.RowTemplate.Height = 33;
            this.dgv2CuotasAsginadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2CuotasAsginadas.Size = new System.Drawing.Size(1169, 411);
            this.dgv2CuotasAsginadas.TabIndex = 1;
            this.dgv2CuotasAsginadas.SelectionChanged += new System.EventHandler(this.dgv2CuotasAsginadas_SelectionChanged);
            // 
            // dgv5CobrosPagados
            // 
            this.dgv5CobrosPagados.AllowUserToAddRows = false;
            this.dgv5CobrosPagados.AllowUserToDeleteRows = false;
            this.dgv5CobrosPagados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv5CobrosPagados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv5CobrosPagados.Location = new System.Drawing.Point(6, 30);
            this.dgv5CobrosPagados.MultiSelect = false;
            this.dgv5CobrosPagados.Name = "dgv5CobrosPagados";
            this.dgv5CobrosPagados.ReadOnly = true;
            this.dgv5CobrosPagados.RowHeadersWidth = 82;
            this.dgv5CobrosPagados.RowTemplate.Height = 33;
            this.dgv5CobrosPagados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv5CobrosPagados.Size = new System.Drawing.Size(827, 1120);
            this.dgv5CobrosPagados.TabIndex = 2;
            // 
            // dgv3CuotasPagadas
            // 
            this.dgv3CuotasPagadas.AllowUserToAddRows = false;
            this.dgv3CuotasPagadas.AllowUserToDeleteRows = false;
            this.dgv3CuotasPagadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv3CuotasPagadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3CuotasPagadas.Location = new System.Drawing.Point(6, 30);
            this.dgv3CuotasPagadas.MultiSelect = false;
            this.dgv3CuotasPagadas.Name = "dgv3CuotasPagadas";
            this.dgv3CuotasPagadas.ReadOnly = true;
            this.dgv3CuotasPagadas.RowHeadersWidth = 82;
            this.dgv3CuotasPagadas.RowTemplate.Height = 33;
            this.dgv3CuotasPagadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv3CuotasPagadas.Size = new System.Drawing.Size(803, 494);
            this.dgv3CuotasPagadas.TabIndex = 3;
            // 
            // dgv4CuotasOrdenadas
            // 
            this.dgv4CuotasOrdenadas.AllowUserToAddRows = false;
            this.dgv4CuotasOrdenadas.AllowUserToDeleteRows = false;
            this.dgv4CuotasOrdenadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv4CuotasOrdenadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv4CuotasOrdenadas.Location = new System.Drawing.Point(6, 53);
            this.dgv4CuotasOrdenadas.MultiSelect = false;
            this.dgv4CuotasOrdenadas.Name = "dgv4CuotasOrdenadas";
            this.dgv4CuotasOrdenadas.ReadOnly = true;
            this.dgv4CuotasOrdenadas.RowHeadersWidth = 82;
            this.dgv4CuotasOrdenadas.RowTemplate.Height = 33;
            this.dgv4CuotasOrdenadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv4CuotasOrdenadas.Size = new System.Drawing.Size(1169, 459);
            this.dgv4CuotasOrdenadas.TabIndex = 4;
            // 
            // btnAgregarSocio
            // 
            this.btnAgregarSocio.BackColor = System.Drawing.Color.Beige;
            this.btnAgregarSocio.Location = new System.Drawing.Point(6, 493);
            this.btnAgregarSocio.Name = "btnAgregarSocio";
            this.btnAgregarSocio.Size = new System.Drawing.Size(242, 93);
            this.btnAgregarSocio.TabIndex = 5;
            this.btnAgregarSocio.Text = "Agregar";
            this.btnAgregarSocio.UseVisualStyleBackColor = false;
            this.btnAgregarSocio.Click += new System.EventHandler(this.btnAgregarSocio_Click);
            // 
            // radioBtnSocioNormal
            // 
            this.radioBtnSocioNormal.AutoSize = true;
            this.radioBtnSocioNormal.Location = new System.Drawing.Point(6, 458);
            this.radioBtnSocioNormal.Name = "radioBtnSocioNormal";
            this.radioBtnSocioNormal.Size = new System.Drawing.Size(111, 29);
            this.radioBtnSocioNormal.TabIndex = 6;
            this.radioBtnSocioNormal.TabStop = true;
            this.radioBtnSocioNormal.Text = "Normal";
            this.radioBtnSocioNormal.UseVisualStyleBackColor = true;
            // 
            // radioBtnSocioEspecial
            // 
            this.radioBtnSocioEspecial.AutoSize = true;
            this.radioBtnSocioEspecial.Location = new System.Drawing.Point(123, 458);
            this.radioBtnSocioEspecial.Name = "radioBtnSocioEspecial";
            this.radioBtnSocioEspecial.Size = new System.Drawing.Size(125, 29);
            this.radioBtnSocioEspecial.TabIndex = 7;
            this.radioBtnSocioEspecial.TabStop = true;
            this.radioBtnSocioEspecial.Text = "Especial";
            this.radioBtnSocioEspecial.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarSocio);
            this.groupBox1.Controls.Add(this.btnModificarSocio);
            this.groupBox1.Controls.Add(this.dgv1Socios);
            this.groupBox1.Controls.Add(this.radioBtnSocioEspecial);
            this.groupBox1.Controls.Add(this.btnAgregarSocio);
            this.groupBox1.Controls.Add(this.radioBtnSocioNormal);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 592);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Socios";
            // 
            // btnEliminarSocio
            // 
            this.btnEliminarSocio.BackColor = System.Drawing.Color.Salmon;
            this.btnEliminarSocio.Location = new System.Drawing.Point(572, 493);
            this.btnEliminarSocio.Name = "btnEliminarSocio";
            this.btnEliminarSocio.Size = new System.Drawing.Size(242, 93);
            this.btnEliminarSocio.TabIndex = 9;
            this.btnEliminarSocio.Text = "Eliminar";
            this.btnEliminarSocio.UseVisualStyleBackColor = false;
            this.btnEliminarSocio.Click += new System.EventHandler(this.btnEliminarSocio_Click);
            // 
            // btnModificarSocio
            // 
            this.btnModificarSocio.Location = new System.Drawing.Point(289, 493);
            this.btnModificarSocio.Name = "btnModificarSocio";
            this.btnModificarSocio.Size = new System.Drawing.Size(242, 93);
            this.btnModificarSocio.TabIndex = 8;
            this.btnModificarSocio.Text = "Modificar";
            this.btnModificarSocio.UseVisualStyleBackColor = true;
            this.btnModificarSocio.Click += new System.EventHandler(this.btnModificarSocio_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCuotaPorLote);
            this.groupBox2.Controls.Add(this.btnPagarCuota);
            this.groupBox2.Controls.Add(this.btnAsignarCuota);
            this.groupBox2.Controls.Add(this.dgv2CuotasAsginadas);
            this.groupBox2.Location = new System.Drawing.Point(839, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1181, 592);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuotas";
            // 
            // btnCuotaPorLote
            // 
            this.btnCuotaPorLote.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCuotaPorLote.Location = new System.Drawing.Point(398, 493);
            this.btnCuotaPorLote.Name = "btnCuotaPorLote";
            this.btnCuotaPorLote.Size = new System.Drawing.Size(392, 93);
            this.btnCuotaPorLote.TabIndex = 12;
            this.btnCuotaPorLote.Text = "Cuota \r\npor Lote";
            this.btnCuotaPorLote.UseVisualStyleBackColor = false;
            this.btnCuotaPorLote.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPagarCuota
            // 
            this.btnPagarCuota.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPagarCuota.Location = new System.Drawing.Point(790, 493);
            this.btnPagarCuota.Name = "btnPagarCuota";
            this.btnPagarCuota.Size = new System.Drawing.Size(392, 93);
            this.btnPagarCuota.TabIndex = 11;
            this.btnPagarCuota.Text = "Pagar";
            this.btnPagarCuota.UseVisualStyleBackColor = false;
            this.btnPagarCuota.Click += new System.EventHandler(this.btnPagarCuota_Click);
            // 
            // btnAsignarCuota
            // 
            this.btnAsignarCuota.BackColor = System.Drawing.Color.Beige;
            this.btnAsignarCuota.Location = new System.Drawing.Point(6, 493);
            this.btnAsignarCuota.Name = "btnAsignarCuota";
            this.btnAsignarCuota.Size = new System.Drawing.Size(392, 93);
            this.btnAsignarCuota.TabIndex = 10;
            this.btnAsignarCuota.Text = "Asignar";
            this.btnAsignarCuota.UseVisualStyleBackColor = false;
            this.btnAsignarCuota.Click += new System.EventHandler(this.btnAsignarCuota_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv3CuotasPagadas);
            this.groupBox3.Location = new System.Drawing.Point(18, 647);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(815, 537);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cuotas Pagadas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioBtnDesc);
            this.groupBox4.Controls.Add(this.radioBtnASC);
            this.groupBox4.Controls.Add(this.dgv4CuotasOrdenadas);
            this.groupBox4.Location = new System.Drawing.Point(839, 659);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1181, 525);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cuotas Pagadas Ordenadas por Importe";
            // 
            // radioBtnDesc
            // 
            this.radioBtnDesc.AutoSize = true;
            this.radioBtnDesc.Location = new System.Drawing.Point(834, 18);
            this.radioBtnDesc.Name = "radioBtnDesc";
            this.radioBtnDesc.Size = new System.Drawing.Size(170, 29);
            this.radioBtnDesc.TabIndex = 14;
            this.radioBtnDesc.TabStop = true;
            this.radioBtnDesc.Text = "Descendente";
            this.radioBtnDesc.UseVisualStyleBackColor = true;
            this.radioBtnDesc.CheckedChanged += new System.EventHandler(this.radioBtnDesc_CheckedChanged);
            // 
            // radioBtnASC
            // 
            this.radioBtnASC.AutoSize = true;
            this.radioBtnASC.Location = new System.Drawing.Point(653, 18);
            this.radioBtnASC.Name = "radioBtnASC";
            this.radioBtnASC.Size = new System.Drawing.Size(157, 29);
            this.radioBtnASC.TabIndex = 13;
            this.radioBtnASC.TabStop = true;
            this.radioBtnASC.Text = "Ascendente";
            this.radioBtnASC.UseVisualStyleBackColor = true;
            this.radioBtnASC.CheckedChanged += new System.EventHandler(this.radioBtnASC_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgv5CobrosPagados);
            this.groupBox5.Location = new System.Drawing.Point(2020, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(839, 1163);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cuotas Pagadas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2871, 1319);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Club Social";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1Socios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2CuotasAsginadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv5CobrosPagados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3CuotasPagadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4CuotasOrdenadas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1Socios;
        private System.Windows.Forms.DataGridView dgv2CuotasAsginadas;
        private System.Windows.Forms.DataGridView dgv5CobrosPagados;
        private System.Windows.Forms.DataGridView dgv3CuotasPagadas;
        private System.Windows.Forms.DataGridView dgv4CuotasOrdenadas;
        private System.Windows.Forms.Button btnAgregarSocio;
        private System.Windows.Forms.RadioButton radioBtnSocioNormal;
        private System.Windows.Forms.RadioButton radioBtnSocioEspecial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarSocio;
        private System.Windows.Forms.Button btnModificarSocio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAsignarCuota;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCuotaPorLote;
        private System.Windows.Forms.Button btnPagarCuota;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioBtnDesc;
        private System.Windows.Forms.RadioButton radioBtnASC;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}


namespace UI
{
    partial class FormPaquetes
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxPaquete = new System.Windows.Forms.GroupBox();
            this.labelRecaudado = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPaquetes = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dropDownClientes = new System.Windows.Forms.ComboBox();
            this.btnSilver = new System.Windows.Forms.RadioButton();
            this.btnPremium = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputGenero = new System.Windows.Forms.ComboBox();
            this.btnAgregarCanal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCanales = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputDirector = new System.Windows.Forms.TextBox();
            this.inputTemporada = new System.Windows.Forms.TextBox();
            this.inputEpisodio = new System.Windows.Forms.TextBox();
            this.inputDuracion = new System.Windows.Forms.TextBox();
            this.inputRanking = new System.Windows.Forms.TextBox();
            this.inputSerie = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dgvPaqueteCanales = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxPaquete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaqueteCanales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPaquete
            // 
            this.groupBoxPaquete.Controls.Add(this.labelRecaudado);
            this.groupBoxPaquete.Controls.Add(this.button2);
            this.groupBoxPaquete.Controls.Add(this.button1);
            this.groupBoxPaquete.Controls.Add(this.dgvPaquetes);
            this.groupBoxPaquete.Controls.Add(this.label8);
            this.groupBoxPaquete.Controls.Add(this.dropDownClientes);
            this.groupBoxPaquete.Controls.Add(this.btnSilver);
            this.groupBoxPaquete.Controls.Add(this.btnPremium);
            this.groupBoxPaquete.Location = new System.Drawing.Point(12, 438);
            this.groupBoxPaquete.Name = "groupBoxPaquete";
            this.groupBoxPaquete.Size = new System.Drawing.Size(2353, 418);
            this.groupBoxPaquete.TabIndex = 0;
            this.groupBoxPaquete.TabStop = false;
            this.groupBoxPaquete.Text = "Paquete";
            // 
            // labelRecaudado
            // 
            this.labelRecaudado.AutoSize = true;
            this.labelRecaudado.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labelRecaudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecaudado.Location = new System.Drawing.Point(23, 360);
            this.labelRecaudado.Name = "labelRecaudado";
            this.labelRecaudado.Size = new System.Drawing.Size(330, 42);
            this.labelRecaudado.TabIndex = 18;
            this.labelRecaudado.Text = "Total Recaudado:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 60);
            this.button2.TabIndex = 17;
            this.button2.Text = "Agregar Canal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 60);
            this.button1.TabIndex = 15;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.AllowUserToAddRows = false;
            this.dgvPaquetes.AllowUserToDeleteRows = false;
            this.dgvPaquetes.AllowUserToResizeColumns = false;
            this.dgvPaquetes.AllowUserToResizeRows = false;
            this.dgvPaquetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaquetes.ColumnHeadersHeight = 46;
            this.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPaquetes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPaquetes.Location = new System.Drawing.Point(807, 30);
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.ReadOnly = true;
            this.dgvPaquetes.RowHeadersWidth = 82;
            this.dgvPaquetes.RowTemplate.Height = 33;
            this.dgvPaquetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaquetes.Size = new System.Drawing.Size(1540, 382);
            this.dgvPaquetes.TabIndex = 4;
            this.dgvPaquetes.SelectionChanged += new System.EventHandler(this.dgvPaquetes_SelectionChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cliente:";
            // 
            // dropDownClientes
            // 
            this.dropDownClientes.FormattingEnabled = true;
            this.dropDownClientes.Location = new System.Drawing.Point(133, 132);
            this.dropDownClientes.Name = "dropDownClientes";
            this.dropDownClientes.Size = new System.Drawing.Size(248, 33);
            this.dropDownClientes.TabIndex = 2;
            // 
            // btnSilver
            // 
            this.btnSilver.AutoSize = true;
            this.btnSilver.Location = new System.Drawing.Point(206, 47);
            this.btnSilver.Name = "btnSilver";
            this.btnSilver.Size = new System.Drawing.Size(97, 29);
            this.btnSilver.TabIndex = 1;
            this.btnSilver.TabStop = true;
            this.btnSilver.Text = "Silver";
            this.btnSilver.UseVisualStyleBackColor = true;
            // 
            // btnPremium
            // 
            this.btnPremium.AutoSize = true;
            this.btnPremium.Location = new System.Drawing.Point(25, 47);
            this.btnPremium.Name = "btnPremium";
            this.btnPremium.Size = new System.Drawing.Size(127, 29);
            this.btnPremium.TabIndex = 0;
            this.btnPremium.TabStop = true;
            this.btnPremium.Text = "Premium";
            this.btnPremium.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.inputGenero);
            this.groupBox2.Controls.Add(this.btnAgregarCanal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgvCanales);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.inputDirector);
            this.groupBox2.Controls.Add(this.inputTemporada);
            this.groupBox2.Controls.Add(this.inputEpisodio);
            this.groupBox2.Controls.Add(this.inputDuracion);
            this.groupBox2.Controls.Add(this.inputRanking);
            this.groupBox2.Controls.Add(this.inputSerie);
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(2353, 388);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Canales";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // inputGenero
            // 
            this.inputGenero.FormattingEnabled = true;
            this.inputGenero.Location = new System.Drawing.Point(528, 167);
            this.inputGenero.Name = "inputGenero";
            this.inputGenero.Size = new System.Drawing.Size(222, 33);
            this.inputGenero.TabIndex = 15;
            // 
            // btnAgregarCanal
            // 
            this.btnAgregarCanal.Location = new System.Drawing.Point(22, 306);
            this.btnAgregarCanal.Name = "btnAgregarCanal";
            this.btnAgregarCanal.Size = new System.Drawing.Size(239, 60);
            this.btnAgregarCanal.TabIndex = 14;
            this.btnAgregarCanal.Text = "Agregar";
            this.btnAgregarCanal.UseVisualStyleBackColor = true;
            this.btnAgregarCanal.Click += new System.EventHandler(this.btnAgregarCanal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Genero:";
            // 
            // dgvCanales
            // 
            this.dgvCanales.AllowUserToAddRows = false;
            this.dgvCanales.AllowUserToDeleteRows = false;
            this.dgvCanales.AllowUserToResizeColumns = false;
            this.dgvCanales.AllowUserToResizeRows = false;
            this.dgvCanales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCanales.ColumnHeadersHeight = 46;
            this.dgvCanales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCanales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCanales.Location = new System.Drawing.Point(807, 39);
            this.dgvCanales.Name = "dgvCanales";
            this.dgvCanales.ReadOnly = true;
            this.dgvCanales.RowHeadersWidth = 82;
            this.dgvCanales.RowTemplate.Height = 33;
            this.dgvCanales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCanales.Size = new System.Drawing.Size(1540, 343);
            this.dgvCanales.TabIndex = 3;
            this.dgvCanales.SelectionChanged += new System.EventHandler(this.dgvCanales_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Duracion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Temporada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Director:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ranking:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Episodio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Serie:";
            // 
            // inputDirector
            // 
            this.inputDirector.Location = new System.Drawing.Point(124, 230);
            this.inputDirector.Name = "inputDirector";
            this.inputDirector.Size = new System.Drawing.Size(222, 31);
            this.inputDirector.TabIndex = 5;
            // 
            // inputTemporada
            // 
            this.inputTemporada.Location = new System.Drawing.Point(528, 39);
            this.inputTemporada.Name = "inputTemporada";
            this.inputTemporada.Size = new System.Drawing.Size(222, 31);
            this.inputTemporada.TabIndex = 4;
            // 
            // inputEpisodio
            // 
            this.inputEpisodio.Location = new System.Drawing.Point(124, 98);
            this.inputEpisodio.Name = "inputEpisodio";
            this.inputEpisodio.Size = new System.Drawing.Size(222, 31);
            this.inputEpisodio.TabIndex = 3;
            // 
            // inputDuracion
            // 
            this.inputDuracion.Location = new System.Drawing.Point(528, 98);
            this.inputDuracion.Name = "inputDuracion";
            this.inputDuracion.Size = new System.Drawing.Size(222, 31);
            this.inputDuracion.TabIndex = 2;
            // 
            // inputRanking
            // 
            this.inputRanking.Location = new System.Drawing.Point(124, 164);
            this.inputRanking.Name = "inputRanking";
            this.inputRanking.Size = new System.Drawing.Size(222, 31);
            this.inputRanking.TabIndex = 1;
            // 
            // inputSerie
            // 
            this.inputSerie.Location = new System.Drawing.Point(124, 39);
            this.inputSerie.Name = "inputSerie";
            this.inputSerie.Size = new System.Drawing.Size(222, 31);
            this.inputSerie.TabIndex = 0;
            // 
            // dgvPaqueteCanales
            // 
            this.dgvPaqueteCanales.AllowUserToAddRows = false;
            this.dgvPaqueteCanales.AllowUserToDeleteRows = false;
            this.dgvPaqueteCanales.AllowUserToResizeColumns = false;
            this.dgvPaqueteCanales.AllowUserToResizeRows = false;
            this.dgvPaqueteCanales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaqueteCanales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaqueteCanales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPaqueteCanales.Location = new System.Drawing.Point(22, 49);
            this.dgvPaqueteCanales.MultiSelect = false;
            this.dgvPaqueteCanales.Name = "dgvPaqueteCanales";
            this.dgvPaqueteCanales.RowHeadersWidth = 82;
            this.dgvPaqueteCanales.RowTemplate.Height = 33;
            this.dgvPaqueteCanales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPaqueteCanales.Size = new System.Drawing.Size(2325, 449);
            this.dgvPaqueteCanales.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPaqueteCanales);
            this.groupBox1.Location = new System.Drawing.Point(12, 882);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2353, 377);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canales Incluidos";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 60);
            this.button3.TabIndex = 16;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2377, 1298);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxPaquete);
            this.Name = "FormPaquetes";
            this.Text = "FormPaquetes";
            this.groupBoxPaquete.ResumeLayout(false);
            this.groupBoxPaquete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaqueteCanales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxPaquete;
        private System.Windows.Forms.RadioButton btnSilver;
        private System.Windows.Forms.RadioButton btnPremium;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox inputTemporada;
        private System.Windows.Forms.TextBox inputEpisodio;
        private System.Windows.Forms.TextBox inputDuracion;
        private System.Windows.Forms.TextBox inputRanking;
        private System.Windows.Forms.TextBox inputSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputDirector;
        private System.Windows.Forms.Button btnAgregarCanal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCanales;
        private System.Windows.Forms.DataGridView dgvPaquetes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dropDownClientes;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPaqueteCanales;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelRecaudado;
        private System.Windows.Forms.ComboBox inputGenero;
        private System.Windows.Forms.Button button3;
    }
}
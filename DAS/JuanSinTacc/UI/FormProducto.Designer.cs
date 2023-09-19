
namespace UI
{
    partial class FormProducto
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
            this.radioBtnVeganos = new System.Windows.Forms.RadioButton();
            this.radioBtnCeliacos = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputCantidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputStock = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.inputProducto = new System.Windows.Forms.ComboBox();
            this.campoRequerido2 = new System.Windows.Forms.Label();
            this.campoRequerido1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPrecio = new System.Windows.Forms.TextBox();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnVeganos);
            this.groupBox1.Controls.Add(this.radioBtnCeliacos);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvProductos);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1552, 875);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // radioBtnVeganos
            // 
            this.radioBtnVeganos.AutoSize = true;
            this.radioBtnVeganos.Location = new System.Drawing.Point(163, 52);
            this.radioBtnVeganos.Name = "radioBtnVeganos";
            this.radioBtnVeganos.Size = new System.Drawing.Size(128, 29);
            this.radioBtnVeganos.TabIndex = 3;
            this.radioBtnVeganos.TabStop = true;
            this.radioBtnVeganos.Text = "Veganos";
            this.radioBtnVeganos.UseVisualStyleBackColor = true;
            this.radioBtnVeganos.CheckedChanged += new System.EventHandler(this.radioBtnVeganos_CheckedChanged);
            // 
            // radioBtnCeliacos
            // 
            this.radioBtnCeliacos.AutoSize = true;
            this.radioBtnCeliacos.Location = new System.Drawing.Point(12, 52);
            this.radioBtnCeliacos.Name = "radioBtnCeliacos";
            this.radioBtnCeliacos.Size = new System.Drawing.Size(126, 29);
            this.radioBtnCeliacos.TabIndex = 2;
            this.radioBtnCeliacos.TabStop = true;
            this.radioBtnCeliacos.Text = "Celiacos";
            this.radioBtnCeliacos.UseVisualStyleBackColor = true;
            this.radioBtnCeliacos.CheckedChanged += new System.EventHandler(this.radioBtnCeliacos_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputCantidad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.inputStock);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.inputProducto);
            this.groupBox2.Controls.Add(this.campoRequerido2);
            this.groupBox2.Controls.Add(this.campoRequerido1);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.inputPrecio);
            this.groupBox2.Controls.Add(this.inputNombre);
            this.groupBox2.Location = new System.Drawing.Point(12, 504);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1528, 359);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestionar Productos";
            // 
            // inputCantidad
            // 
            this.inputCantidad.FormattingEnabled = true;
            this.inputCantidad.Location = new System.Drawing.Point(525, 235);
            this.inputCantidad.Name = "inputCantidad";
            this.inputCantidad.Size = new System.Drawing.Size(197, 33);
            this.inputCantidad.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cantidad:";
            // 
            // inputStock
            // 
            this.inputStock.Location = new System.Drawing.Point(523, 292);
            this.inputStock.Name = "inputStock";
            this.inputStock.Size = new System.Drawing.Size(199, 31);
            this.inputStock.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Stock:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // inputProducto
            // 
            this.inputProducto.FormattingEnabled = true;
            this.inputProducto.Location = new System.Drawing.Point(151, 235);
            this.inputProducto.Name = "inputProducto";
            this.inputProducto.Size = new System.Drawing.Size(199, 33);
            this.inputProducto.TabIndex = 13;
            // 
            // campoRequerido2
            // 
            this.campoRequerido2.AutoSize = true;
            this.campoRequerido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoRequerido2.ForeColor = System.Drawing.Color.Red;
            this.campoRequerido2.Location = new System.Drawing.Point(520, 190);
            this.campoRequerido2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.campoRequerido2.Name = "campoRequerido2";
            this.campoRequerido2.Size = new System.Drawing.Size(204, 26);
            this.campoRequerido2.TabIndex = 12;
            this.campoRequerido2.Text = "Campo Requerido";
            // 
            // campoRequerido1
            // 
            this.campoRequerido1.AutoSize = true;
            this.campoRequerido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoRequerido1.ForeColor = System.Drawing.Color.Red;
            this.campoRequerido1.Location = new System.Drawing.Point(146, 190);
            this.campoRequerido1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.campoRequerido1.Name = "campoRequerido1";
            this.campoRequerido1.Size = new System.Drawing.Size(204, 26);
            this.campoRequerido1.TabIndex = 11;
            this.campoRequerido1.Text = "Campo Requerido";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1304, 146);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(216, 133);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Gold;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(1052, 146);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(216, 133);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(802, 146);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(216, 133);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // inputPrecio
            // 
            this.inputPrecio.Location = new System.Drawing.Point(526, 146);
            this.inputPrecio.Margin = new System.Windows.Forms.Padding(6);
            this.inputPrecio.Name = "inputPrecio";
            this.inputPrecio.Size = new System.Drawing.Size(196, 31);
            this.inputPrecio.TabIndex = 1;
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(152, 146);
            this.inputNombre.Margin = new System.Windows.Forms.Padding(6);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(198, 31);
            this.inputNombre.TabIndex = 0;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 90);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(6);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 82;
            this.dgvProductos.Size = new System.Drawing.Size(1516, 402);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1801, 1057);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label campoRequerido2;
        private System.Windows.Forms.Label campoRequerido1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputPrecio;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ComboBox inputProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown inputStock;
        private System.Windows.Forms.ComboBox inputCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioBtnVeganos;
        private System.Windows.Forms.RadioButton radioBtnCeliacos;
    }
}
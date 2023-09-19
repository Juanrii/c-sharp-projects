
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
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.inputClientes = new System.Windows.Forms.ComboBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnMasVendidos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvMasVendidos = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnConsultarStock = new System.Windows.Forms.Button();
            this.inputStock = new System.Windows.Forms.TextBox();
            this.inputCantidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtnVeganos = new System.Windows.Forms.RadioButton();
            this.radioBtnCeliacos = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelRealizadas = new System.Windows.Forms.Label();
            this.labelTotalVendido = new System.Windows.Forms.Label();
            this.labelProdCeliacos = new System.Windows.Forms.Label();
            this.labelProdVeganos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasVendidos)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(382, 30);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersWidth = 82;
            this.dgvDetalleVenta.RowTemplate.Height = 33;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(926, 276);
            this.dgvDetalleVenta.TabIndex = 0;
            this.dgvDetalleVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleVenta_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.labelTotal);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputClientes);
            this.groupBox1.Controls.Add(this.dgvDetalleVenta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1314, 643);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Ventas:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProductos);
            this.groupBox2.Location = new System.Drawing.Point(382, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(926, 257);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(15, 30);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 82;
            this.dgvProductos.RowTemplate.Height = 33;
            this.dgvProductos.Size = new System.Drawing.Size(905, 221);
            this.dgvProductos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente:";
            // 
            // inputClientes
            // 
            this.inputClientes.FormattingEnabled = true;
            this.inputClientes.Location = new System.Drawing.Point(97, 70);
            this.inputClientes.Name = "inputClientes";
            this.inputClientes.Size = new System.Drawing.Size(262, 33);
            this.inputClientes.TabIndex = 2;
            this.inputClientes.SelectedIndexChanged += new System.EventHandler(this.inputClientes_SelectedIndexChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(1042, 590);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(150, 42);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total: $";
            // 
            // btnMasVendidos
            // 
            this.btnMasVendidos.Location = new System.Drawing.Point(6, 172);
            this.btnMasVendidos.Name = "btnMasVendidos";
            this.btnMasVendidos.Size = new System.Drawing.Size(348, 93);
            this.btnMasVendidos.TabIndex = 2;
            this.btnMasVendidos.Text = "Consultar";
            this.btnMasVendidos.UseVisualStyleBackColor = true;
            this.btnMasVendidos.Click += new System.EventHandler(this.btnMasVendidos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelProdVeganos);
            this.groupBox3.Controls.Add(this.labelProdCeliacos);
            this.groupBox3.Controls.Add(this.dgvMasVendidos);
            this.groupBox3.Controls.Add(this.btnMasVendidos);
            this.groupBox3.Location = new System.Drawing.Point(23, 679);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1303, 287);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos Mas Vendidos:";
            // 
            // dgvMasVendidos
            // 
            this.dgvMasVendidos.AllowUserToAddRows = false;
            this.dgvMasVendidos.AllowUserToDeleteRows = false;
            this.dgvMasVendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasVendidos.Location = new System.Drawing.Point(386, 30);
            this.dgvMasVendidos.Name = "dgvMasVendidos";
            this.dgvMasVendidos.ReadOnly = true;
            this.dgvMasVendidos.RowHeadersWidth = 82;
            this.dgvMasVendidos.RowTemplate.Height = 33;
            this.dgvMasVendidos.Size = new System.Drawing.Size(905, 235);
            this.dgvMasVendidos.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioBtnVeganos);
            this.groupBox4.Controls.Add(this.radioBtnCeliacos);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.inputCantidad);
            this.groupBox4.Controls.Add(this.inputStock);
            this.groupBox4.Controls.Add(this.dgvStock);
            this.groupBox4.Controls.Add(this.btnConsultarStock);
            this.groupBox4.Location = new System.Drawing.Point(23, 981);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1303, 372);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stock Productos:";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(386, 62);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersWidth = 82;
            this.dgvStock.RowTemplate.Height = 33;
            this.dgvStock.Size = new System.Drawing.Size(905, 304);
            this.dgvStock.TabIndex = 7;
            // 
            // btnConsultarStock
            // 
            this.btnConsultarStock.Location = new System.Drawing.Point(6, 273);
            this.btnConsultarStock.Name = "btnConsultarStock";
            this.btnConsultarStock.Size = new System.Drawing.Size(348, 93);
            this.btnConsultarStock.TabIndex = 2;
            this.btnConsultarStock.Text = "Consultar Stock";
            this.btnConsultarStock.UseVisualStyleBackColor = true;
            this.btnConsultarStock.Click += new System.EventHandler(this.btnConsultarStock_Click);
            // 
            // inputStock
            // 
            this.inputStock.Location = new System.Drawing.Point(194, 111);
            this.inputStock.Name = "inputStock";
            this.inputStock.Size = new System.Drawing.Size(154, 31);
            this.inputStock.TabIndex = 9;
            // 
            // inputCantidad
            // 
            this.inputCantidad.FormattingEnabled = true;
            this.inputCantidad.Location = new System.Drawing.Point(194, 164);
            this.inputCantidad.Name = "inputCantidad";
            this.inputCantidad.Size = new System.Drawing.Size(154, 33);
            this.inputCantidad.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Menor o igual a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidades:";
            // 
            // radioBtnVeganos
            // 
            this.radioBtnVeganos.AutoSize = true;
            this.radioBtnVeganos.Location = new System.Drawing.Point(538, 27);
            this.radioBtnVeganos.Name = "radioBtnVeganos";
            this.radioBtnVeganos.Size = new System.Drawing.Size(128, 29);
            this.radioBtnVeganos.TabIndex = 12;
            this.radioBtnVeganos.TabStop = true;
            this.radioBtnVeganos.Text = "Veganos";
            this.radioBtnVeganos.UseVisualStyleBackColor = true;
            // 
            // radioBtnCeliacos
            // 
            this.radioBtnCeliacos.AutoSize = true;
            this.radioBtnCeliacos.Location = new System.Drawing.Point(387, 27);
            this.radioBtnCeliacos.Name = "radioBtnCeliacos";
            this.radioBtnCeliacos.Size = new System.Drawing.Size(126, 29);
            this.radioBtnCeliacos.TabIndex = 11;
            this.radioBtnCeliacos.TabStop = true;
            this.radioBtnCeliacos.Text = "Celiacos";
            this.radioBtnCeliacos.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelTotalVendido);
            this.groupBox5.Controls.Add(this.labelRealizadas);
            this.groupBox5.Location = new System.Drawing.Point(11, 334);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(353, 257);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ventas:";
            // 
            // labelRealizadas
            // 
            this.labelRealizadas.AutoSize = true;
            this.labelRealizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRealizadas.Location = new System.Drawing.Point(9, 81);
            this.labelRealizadas.Name = "labelRealizadas";
            this.labelRealizadas.Size = new System.Drawing.Size(179, 33);
            this.labelRealizadas.TabIndex = 14;
            this.labelRealizadas.Text = "Realizadas:";
            // 
            // labelTotalVendido
            // 
            this.labelTotalVendido.AutoSize = true;
            this.labelTotalVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVendido.Location = new System.Drawing.Point(6, 146);
            this.labelTotalVendido.Name = "labelTotalVendido";
            this.labelTotalVendido.Size = new System.Drawing.Size(205, 29);
            this.labelTotalVendido.TabIndex = 15;
            this.labelTotalVendido.Text = "Total Vendido: $";
            // 
            // labelProdCeliacos
            // 
            this.labelProdCeliacos.AutoSize = true;
            this.labelProdCeliacos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdCeliacos.Location = new System.Drawing.Point(20, 58);
            this.labelProdCeliacos.Name = "labelProdCeliacos";
            this.labelProdCeliacos.Size = new System.Drawing.Size(145, 33);
            this.labelProdCeliacos.TabIndex = 16;
            this.labelProdCeliacos.Text = "Celiacos:";
            // 
            // labelProdVeganos
            // 
            this.labelProdVeganos.AutoSize = true;
            this.labelProdVeganos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdVeganos.Location = new System.Drawing.Point(20, 118);
            this.labelProdVeganos.Name = "labelProdVeganos";
            this.labelProdVeganos.Size = new System.Drawing.Size(145, 33);
            this.labelProdVeganos.TabIndex = 17;
            this.labelProdVeganos.Text = "Veganos:";
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2879, 1365);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInformes";
            this.Text = "FormInformes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasVendidos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inputClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnMasVendidos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvMasVendidos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inputCantidad;
        private System.Windows.Forms.TextBox inputStock;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnConsultarStock;
        private System.Windows.Forms.RadioButton radioBtnVeganos;
        private System.Windows.Forms.RadioButton radioBtnCeliacos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelTotalVendido;
        private System.Windows.Forms.Label labelRealizadas;
        private System.Windows.Forms.Label labelProdVeganos;
        private System.Windows.Forms.Label labelProdCeliacos;
    }
}
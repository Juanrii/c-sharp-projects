
namespace TP4_ListasEjercicio4
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
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.inputEdad = new System.Windows.Forms.TextBox();
            this.inputDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.inputApellido = new System.Windows.Forms.TextBox();
            this.listaJugadores = new System.Windows.Forms.ListBox();
            this.btnEliminarSeleccionado = new System.Windows.Forms.Button();
            this.btnActualizarSeleccionado = new System.Windows.Forms.Button();
            this.btnAgregarDespues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(62, 17);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(100, 20);
            this.inputNombre.TabIndex = 0;
            // 
            // inputEdad
            // 
            this.inputEdad.Location = new System.Drawing.Point(62, 150);
            this.inputEdad.Name = "inputEdad";
            this.inputEdad.Size = new System.Drawing.Size(100, 20);
            this.inputEdad.TabIndex = 2;
            // 
            // inputDNI
            // 
            this.inputDNI.Location = new System.Drawing.Point(62, 220);
            this.inputDNI.Name = "inputDNI";
            this.inputDNI.Size = new System.Drawing.Size(100, 20);
            this.inputDNI.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DNI:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(180, 188);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 52);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // inputApellido
            // 
            this.inputApellido.Location = new System.Drawing.Point(62, 81);
            this.inputApellido.Name = "inputApellido";
            this.inputApellido.Size = new System.Drawing.Size(100, 20);
            this.inputApellido.TabIndex = 1;
            // 
            // listaJugadores
            // 
            this.listaJugadores.FormattingEnabled = true;
            this.listaJugadores.Location = new System.Drawing.Point(178, 17);
            this.listaJugadores.Name = "listaJugadores";
            this.listaJugadores.Size = new System.Drawing.Size(371, 147);
            this.listaJugadores.TabIndex = 4;
            this.listaJugadores.SelectedIndexChanged += new System.EventHandler(this.listaJugadores_SelectedIndexChanged);
            // 
            // btnEliminarSeleccionado
            // 
            this.btnEliminarSeleccionado.Location = new System.Drawing.Point(462, 188);
            this.btnEliminarSeleccionado.Name = "btnEliminarSeleccionado";
            this.btnEliminarSeleccionado.Size = new System.Drawing.Size(87, 52);
            this.btnEliminarSeleccionado.TabIndex = 8;
            this.btnEliminarSeleccionado.Text = "Eliminar\r\nSeleccionado";
            this.btnEliminarSeleccionado.UseVisualStyleBackColor = true;
            this.btnEliminarSeleccionado.Click += new System.EventHandler(this.btnEliminarSeleccionado_Click);
            // 
            // btnActualizarSeleccionado
            // 
            this.btnActualizarSeleccionado.Location = new System.Drawing.Point(274, 188);
            this.btnActualizarSeleccionado.Name = "btnActualizarSeleccionado";
            this.btnActualizarSeleccionado.Size = new System.Drawing.Size(87, 52);
            this.btnActualizarSeleccionado.TabIndex = 6;
            this.btnActualizarSeleccionado.Text = "Actualizar\r\nSeleccionado";
            this.btnActualizarSeleccionado.UseVisualStyleBackColor = true;
            this.btnActualizarSeleccionado.Click += new System.EventHandler(this.btnActualizarSeleccionado_Click);
            // 
            // btnAgregarDespues
            // 
            this.btnAgregarDespues.Location = new System.Drawing.Point(368, 188);
            this.btnAgregarDespues.Name = "btnAgregarDespues";
            this.btnAgregarDespues.Size = new System.Drawing.Size(87, 52);
            this.btnAgregarDespues.TabIndex = 7;
            this.btnAgregarDespues.Text = "Agregar\r\nDespues\r\nSeleccionado\r\n";
            this.btnAgregarDespues.UseVisualStyleBackColor = true;
            this.btnAgregarDespues.Click += new System.EventHandler(this.btnAgregarDespues_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 252);
            this.Controls.Add(this.btnAgregarDespues);
            this.Controls.Add(this.btnActualizarSeleccionado);
            this.Controls.Add(this.btnEliminarSeleccionado);
            this.Controls.Add(this.listaJugadores);
            this.Controls.Add(this.inputApellido);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputDNI);
            this.Controls.Add(this.inputEdad);
            this.Controls.Add(this.inputNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.TextBox inputEdad;
        private System.Windows.Forms.TextBox inputDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox inputApellido;
        private System.Windows.Forms.ListBox listaJugadores;
        private System.Windows.Forms.Button btnEliminarSeleccionado;
        private System.Windows.Forms.Button btnActualizarSeleccionado;
        private System.Windows.Forms.Button btnAgregarDespues;
    }
}


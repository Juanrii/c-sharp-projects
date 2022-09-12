
namespace TP4_ListasEjercicio1
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
            this.inputTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listaPacientes = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputDireccion = new System.Windows.Forms.TextBox();
            this.inputCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputApellido = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(125, 140);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(100, 20);
            this.inputNombre.TabIndex = 1;
            // 
            // inputTel
            // 
            this.inputTel.Location = new System.Drawing.Point(125, 263);
            this.inputTel.Name = "inputTel";
            this.inputTel.Size = new System.Drawing.Size(100, 20);
            this.inputTel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefono";
            // 
            // listaPacientes
            // 
            this.listaPacientes.FormattingEnabled = true;
            this.listaPacientes.Location = new System.Drawing.Point(416, 71);
            this.listaPacientes.Name = "listaPacientes";
            this.listaPacientes.Size = new System.Drawing.Size(265, 212);
            this.listaPacientes.TabIndex = 4;
            this.listaPacientes.SelectedIndexChanged += new System.EventHandler(this.listaPacientes_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(252, 71);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(126, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Registrar Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Codigo Paciente";
            // 
            // inputDireccion
            // 
            this.inputDireccion.Location = new System.Drawing.Point(125, 219);
            this.inputDireccion.Name = "inputDireccion";
            this.inputDireccion.Size = new System.Drawing.Size(100, 20);
            this.inputDireccion.TabIndex = 3;
            // 
            // inputCodigo
            // 
            this.inputCodigo.Location = new System.Drawing.Point(125, 101);
            this.inputCodigo.Name = "inputCodigo";
            this.inputCodigo.Size = new System.Drawing.Size(100, 20);
            this.inputCodigo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Apellido";
            // 
            // inputApellido
            // 
            this.inputApellido.Location = new System.Drawing.Point(125, 180);
            this.inputApellido.Name = "inputApellido";
            this.inputApellido.Size = new System.Drawing.Size(100, 20);
            this.inputApellido.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(252, 261);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(126, 23);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar Listado";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(252, 290);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(126, 23);
            this.btnOcultar.TabIndex = 12;
            this.btnOcultar.Text = "Ocultar Listado";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.Location = new System.Drawing.Point(252, 101);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(126, 23);
            this.btnEliminarPaciente.TabIndex = 13;
            this.btnEliminarPaciente.Text = "Eliminar Paciente";
            this.btnEliminarPaciente.UseVisualStyleBackColor = true;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(252, 130);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(126, 23);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar Paciente";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminarPaciente);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputDireccion);
            this.Controls.Add(this.inputCodigo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listaPacientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTel);
            this.Controls.Add(this.inputNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.TextBox inputTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listaPacientes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputDireccion;
        private System.Windows.Forms.TextBox inputCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputApellido;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.Button btnActualizar;
    }
}


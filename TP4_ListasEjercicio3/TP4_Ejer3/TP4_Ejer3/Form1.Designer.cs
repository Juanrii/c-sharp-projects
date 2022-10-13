
namespace TP4_Ejer3
{
    partial class CineForm
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
            this.btnGenerarAleatorios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listaPersonas = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregarDespues = new System.Windows.Forms.Button();
            this.btnOcultarMostrarLsitado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarAleatorios
            // 
            this.btnGenerarAleatorios.BackColor = System.Drawing.Color.Green;
            this.btnGenerarAleatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarAleatorios.ForeColor = System.Drawing.Color.White;
            this.btnGenerarAleatorios.Location = new System.Drawing.Point(34, 88);
            this.btnGenerarAleatorios.Name = "btnGenerarAleatorios";
            this.btnGenerarAleatorios.Size = new System.Drawing.Size(116, 61);
            this.btnGenerarAleatorios.TabIndex = 0;
            this.btnGenerarAleatorios.Text = "Generar\r\nAleatorios";
            this.btnGenerarAleatorios.UseVisualStyleBackColor = false;
            this.btnGenerarAleatorios.Click += new System.EventHandler(this.btnGenerarAleatorios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "CineArg";
            // 
            // listaPersonas
            // 
            this.listaPersonas.FormattingEnabled = true;
            this.listaPersonas.Location = new System.Drawing.Point(208, 88);
            this.listaPersonas.Name = "listaPersonas";
            this.listaPersonas.Size = new System.Drawing.Size(332, 316);
            this.listaPersonas.TabIndex = 2;
            this.listaPersonas.SelectedIndexChanged += new System.EventHandler(this.listaPersonas_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(604, 88);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 61);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar\r\nSeleccionado";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(604, 155);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 61);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar\r\nSeleccionado";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnAgregarDespues
            // 
            this.btnAgregarDespues.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarDespues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDespues.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDespues.Location = new System.Drawing.Point(604, 222);
            this.btnAgregarDespues.Name = "btnAgregarDespues";
            this.btnAgregarDespues.Size = new System.Drawing.Size(116, 61);
            this.btnAgregarDespues.TabIndex = 5;
            this.btnAgregarDespues.Text = "Agregar\r\nDespues del \r\nSeleccionado\r\n";
            this.btnAgregarDespues.UseVisualStyleBackColor = false;
            this.btnAgregarDespues.Click += new System.EventHandler(this.btnAgregarDespues_Click);
            // 
            // btnOcultarMostrarLsitado
            // 
            this.btnOcultarMostrarLsitado.BackColor = System.Drawing.Color.Goldenrod;
            this.btnOcultarMostrarLsitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultarMostrarLsitado.ForeColor = System.Drawing.Color.White;
            this.btnOcultarMostrarLsitado.Location = new System.Drawing.Point(604, 289);
            this.btnOcultarMostrarLsitado.Name = "btnOcultarMostrarLsitado";
            this.btnOcultarMostrarLsitado.Size = new System.Drawing.Size(116, 61);
            this.btnOcultarMostrarLsitado.TabIndex = 6;
            this.btnOcultarMostrarLsitado.Text = "Ocultar Listado";
            this.btnOcultarMostrarLsitado.UseVisualStyleBackColor = false;
            this.btnOcultarMostrarLsitado.Click += new System.EventHandler(this.btnOcultarMostrarLsitado_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(688, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOcultarMostrarLsitado);
            this.Controls.Add(this.btnAgregarDespues);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.listaPersonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerarAleatorios);
            this.Name = "CineForm";
            this.Text = "Cinema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarAleatorios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaPersonas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregarDespues;
        private System.Windows.Forms.Button btnOcultarMostrarLsitado;
        private System.Windows.Forms.Button button1;
    }
}


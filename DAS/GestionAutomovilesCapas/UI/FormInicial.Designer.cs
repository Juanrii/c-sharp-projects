namespace UI
{
    partial class FormInicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAutosDeBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarAutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesToolStripMenuItem,
            this.gestionarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1235, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarAutosToolStripMenuItem,
            this.listarAutosDeBajaToolStripMenuItem,
            this.filtrarAutosToolStripMenuItem});
            this.informesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(207, 54);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // listarAutosToolStripMenuItem
            // 
            this.listarAutosToolStripMenuItem.Name = "listarAutosToolStripMenuItem";
            this.listarAutosToolStripMenuItem.Size = new System.Drawing.Size(525, 58);
            this.listarAutosToolStripMenuItem.Text = "Listar Autos";
            this.listarAutosToolStripMenuItem.Click += new System.EventHandler(this.listarAutosToolStripMenuItem_Click);
            // 
            // listarAutosDeBajaToolStripMenuItem
            // 
            this.listarAutosDeBajaToolStripMenuItem.Name = "listarAutosDeBajaToolStripMenuItem";
            this.listarAutosDeBajaToolStripMenuItem.Size = new System.Drawing.Size(525, 58);
            this.listarAutosDeBajaToolStripMenuItem.Text = "Listar Autos de Baja";
            this.listarAutosDeBajaToolStripMenuItem.Click += new System.EventHandler(this.listarAutosDeBajaToolStripMenuItem_Click);
            // 
            // filtrarAutosToolStripMenuItem
            // 
            this.filtrarAutosToolStripMenuItem.Name = "filtrarAutosToolStripMenuItem";
            this.filtrarAutosToolStripMenuItem.Size = new System.Drawing.Size(525, 58);
            this.filtrarAutosToolStripMenuItem.Text = "Filtrar Autos";
            this.filtrarAutosToolStripMenuItem.Click += new System.EventHandler(this.filtrarAutosToolStripMenuItem_Click);
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autosToolStripMenuItem});
            this.gestionarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(217, 54);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            // 
            // autosToolStripMenuItem
            // 
            this.autosToolStripMenuItem.Name = "autosToolStripMenuItem";
            this.autosToolStripMenuItem.Size = new System.Drawing.Size(359, 58);
            this.autosToolStripMenuItem.Text = "Autos";
            this.autosToolStripMenuItem.Click += new System.EventHandler(this.autosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(122, 54);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 456);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInicial";
            this.Text = "Autos Organization LLC";
            this.Load += new System.EventHandler(this.FormInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAutosDeBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarAutosToolStripMenuItem;
    }
}


using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                Close();
        }

        private void autosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionAutos form = new FormGestionAutos();
            form.MdiParent = this;
            form.Show();
        }

        private void listarAutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformesListar form = new FormInformesListar();
            form.MdiParent = this;
            form.Show();
        }

        private void listarAutosDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformesListarDeBaja form = new FormInformesListarDeBaja();
            form.MdiParent = this;
            form.Show();
        }

        private void filtrarAutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformesFiltrar form = new FormInformesFiltrar();
            form.MdiParent = this;
            form.Show();
        }
    }
}

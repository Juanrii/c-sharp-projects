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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                Close();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersonas form = new FormPersonas();
            form.MdiParent = this;
            form.Show();
        }

        private void listarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformes form = new FormInformes();
            form.MdiParent = this;
            form.Show();
        }
    }
}

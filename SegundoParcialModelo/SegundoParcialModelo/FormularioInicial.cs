using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialModelo
{
    public partial class FormularioInicial : Form
    {
        public FormularioInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioAlumnos formAlumnos = new FormularioAlumnos();
            formAlumnos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForumularioNotas formNotas= new ForumularioNotas();
            formNotas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormularioPromedios formPromedios = new FormularioPromedios();
            formPromedios.Show();
        }
    }
}

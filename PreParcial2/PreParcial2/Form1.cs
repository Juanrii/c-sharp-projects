using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreParcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            FormularioAlumnos formAlumnos = new FormularioAlumnos();
            formAlumnos.Show();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            FormularioNotas formNotas = new FormularioNotas();
            formNotas.Show();
        }
    }
}

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
    public partial class FormularioPromedios : Form
    {
        GestorAlumnos gestorAlumnos = new GestorAlumnos();
        GestorNotas gestorNotas = new GestorNotas();
        GestorPromedios gestorPromedios = new GestorPromedios();
        public FormularioPromedios()
        {
            InitializeComponent();
            LlenarDataGridViewAlumnos();
            LlenarDataGridViewNotas();
            LlenarDataGridViewNotasPromedios();
        }

        private void LlenarDataGridViewNotasPromedios()
        {
            dgvNotas.DataSource = null;
            dgvNotas.DataSource = gestorNotas.Ordernar(gestorNotas.Listar());
        }

        private void LlenarDataGridViewNotas()
        {
            dgvNotas.DataSource = null;
            dgvNotas.DataSource = gestorNotas.Ordernar(gestorNotas.Listar());
        }


        private void LlenarDataGridViewAlumnos()
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = gestorAlumnos.Ordernar(gestorAlumnos.Listar());
        }

    }
}

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
    public partial class ActualizarAlumno : Form
    {
        public Alumno alumnoSelect;
        public GestorAlumnos gestorAlumnos;

        public ActualizarAlumno(Alumno alumnoSelect, GestorAlumnos gestorAlumnos)
        {
            InitializeComponent();
            this.alumnoSelect = alumnoSelect;
            this.gestorAlumnos = gestorAlumnos;
        }

        private void ActualizarAlumno_Load(object sender, EventArgs e)
        {
            this.inputLegajo.Value = alumnoSelect.Legajo;
            this.inputNombre.Text = alumnoSelect.Nombre;
            this.inputApellido.Text = alumnoSelect.Apellido;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Alumno alumnoActualizado = new Alumno(Convert.ToInt32(this.inputLegajo.Value))
            {
                Nombre = inputNombre.Text,
                Apellido = inputApellido.Text,
            };
            gestorAlumnos.Actualizar(alumnoActualizado);
            Close();
            MessageBox.Show("Alumno actualizado correctamente.", "Actualizado");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

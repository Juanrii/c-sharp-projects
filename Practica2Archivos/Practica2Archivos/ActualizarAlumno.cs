using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2Archivos
{
    public partial class ActualizarAlumno : Form
    {

        public Alumno alumnoSeleccionado = null;
        public Form1 form1 = null;
        public GestorAlumnos alumnos = null;

        public ActualizarAlumno()
        {
            InitializeComponent();
        }

        private void ActualizarAlumno_Load(object sender, EventArgs e)
        {
            inputApellido.Text = alumnoSeleccionado.Apellido;
            inputNombre.Text = alumnoSeleccionado.Nombre;
            inputDNI.Value = alumnoSeleccionado.DNI;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Alumno alumnoActualizado = new Alumno((long)inputDNI.Value);
                alumnoActualizado.Apellido = inputApellido.Text;
                alumnoActualizado.Nombre = inputNombre.Text;
                alumnos.Actualizar(alumnoActualizado, alumnoSeleccionado);
                form1.LlenarGrilla();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarDatos()
        {
            if (String.IsNullOrEmpty(inputApellido.Text) || String.IsNullOrEmpty(inputNombre.Text))
            {
                MessageBox.Show("Datos incorrectos. Por favor vuelva a ingresarlos.", "Error");
                return false;
            }

            return true;
        }
    }
}

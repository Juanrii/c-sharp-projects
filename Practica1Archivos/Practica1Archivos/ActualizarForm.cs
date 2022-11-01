using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1Archivos
{
    public partial class ActualizarForm : Form
    {
        public Alumno alumnoSeleccionado = null;
        public GestorAlumnos alumnos = null;
        public Form1 form1 = null;

        public ActualizarForm()
        {
            InitializeComponent();
        }

        private void ActualizarForm_Load(object sender, EventArgs e)
        {
            this.inputDNI.Value = alumnoSeleccionado.DNI;
            this.inputNombre.Text = alumnoSeleccionado.Nombre;
            this.inputApellido.Text = alumnoSeleccionado.Apellido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Alumno alumnoActualizado = new Alumno((long)this.inputDNI.Value)
            {
                Apellido = this.inputApellido.Text,
                Nombre = this.inputNombre.Text
            };
            alumnos.Actualizar(alumnoSeleccionado, alumnoActualizado);
            form1.LlenarGrilla();
            Close();
        }
    }
}

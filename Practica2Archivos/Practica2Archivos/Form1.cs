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
    public partial class Form1 : Form
    {

        GestorAlumnos alumnos = new GestorAlumnos();

        public Form1()
        {
            InitializeComponent();
            /* Ya lo agregue desde las properties
            this.dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            */
            LlenarGrilla();
        }

        public void LlenarGrilla()
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = alumnos.Listar();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Alumno nuevoAlumno = new Alumno((long)inputDNI.Value);
                nuevoAlumno.Nombre = inputNombre.Text;
                nuevoAlumno.Apellido = inputApellido.Text;
                alumnos.Alta(nuevoAlumno);
                LlenarGrilla();
                LimpiarInputs();
            }
            
        }

        private void LimpiarInputs()
        {
            inputApellido.Text = String.Empty;
            inputNombre.Text = String.Empty;
            inputDNI.Value = Decimal.Zero;
        }

        private bool ValidarDatos()
        {
            if (String.IsNullOrEmpty(inputApellido.Text) || String.IsNullOrEmpty(inputNombre.Text))
            {
                MessageBox.Show("Datos incorrectos. Por favor vuelva a ingresarlos.", "Error");
                return false;
            }

            bool dniExistente = alumnos.BuscarDniExistente((long)inputDNI.Value);

            if (dniExistente)
            {
                MessageBox.Show($"El DNI ingresado: {inputDNI.Value} ya existe. Por favor ingrese otro DNI.", "DNI existente");
                return false;
            }

            return true;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count == 1)
            {
                Alumno alumnoSeleccionado = (Alumno)dgvAlumnos.SelectedRows[0].DataBoundItem;
                alumnos.Baja(alumnoSeleccionado.DNI);
                LlenarGrilla();
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count == 1)
            {
                Alumno alumnoSeleccionado = (Alumno)dgvAlumnos.SelectedRows[0].DataBoundItem;
                ActualizarAlumno actualizarForm = new ActualizarAlumno();
                actualizarForm.alumnoSeleccionado = alumnoSeleccionado;
                actualizarForm.form1 = this;
                actualizarForm.alumnos = alumnos;
                actualizarForm.Show();
            }
        }
    }
}

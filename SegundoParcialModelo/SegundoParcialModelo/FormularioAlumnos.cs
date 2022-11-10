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
    public partial class FormularioAlumnos : Form
    {
        private int Legajo;
        private string Nombre = string.Empty;
        private string Apellido = string.Empty;

        GestorAlumnos gestorAlumnos = new GestorAlumnos();

        public FormularioAlumnos()
        {
            InitializeComponent();
            LlenarDataGridView();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            CargarDatos();
            if (ValidarDatos())
            {
                if (gestorAlumnos.BuscarLegajo(Legajo) == false)
                {
                    Alumno nuevoAlumno = new Alumno(Legajo)
                    {
                        Nombre = this.Nombre,
                        Apellido = this.Apellido
                    };
                    gestorAlumnos.Alta(nuevoAlumno);
                    LimpiarInputs();
                    LlenarDataGridView();
                }
                else
                    MostrarLegajoRepetido(Legajo);
            } 
            else
                MostrarErrorDeCarga();
        }

        private bool ValidarDatos()
        {
            if (Legajo <= 0 || String.IsNullOrEmpty(Nombre) || String.IsNullOrEmpty(Apellido)) return false;
            return true;
        }

        private void LlenarDataGridView()
        {
            this.dgvAlumnos.DataSource = null;
            this.dgvAlumnos.DataSource = gestorAlumnos.Listar();
        }

        private void LimpiarInputs()
        {
            this.inputAltaLegajo.Value = 0;
            this.inputAltaNombre.Text = string.Empty;
            this.inputAltaApellido.Text = string.Empty;
        }

        private void CargarDatos()
        {
            try
            {
                Legajo = Convert.ToInt32(this.inputAltaLegajo.Value);
                Nombre = this.inputAltaNombre.Text;
                Apellido = this.inputAltaApellido.Text;
            }
            catch (Exception)
            {
                MostrarErrorDeCarga();
                return;
            }
        }

        private void MostrarErrorDeCarga()
        {
            MessageBox.Show("Datos incorrectos. Por favor vuelva a ingresarlos.", "Error");
        }
        private void MostrarLegajoRepetido(int legajo)
        {
            MessageBox.Show($"El legajo: {legajo} ya existe. Por favor ingrese otro.", "Legajo existente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionado())
            {
                Alumno alumnoSeleccionado = (Alumno)dgvAlumnos.SelectedRows[0].DataBoundItem;
                gestorAlumnos.Baja(alumnoSeleccionado.Legajo);
                LlenarDataGridView();
            }
        }

        private bool ValidarSeleccionado()
        {
            bool seleccionado = dgvAlumnos.SelectedRows.Count == 1 ? true : false;

            if (seleccionado)
            {
                DialogResult op = MessageBox.Show("Esta seguro que desa elimnar el alumno seleccionado?", "Alerta", MessageBoxButtons.YesNo);
                if (op == DialogResult.Yes) return true;
            }
            return false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count == 1)
            {
                if (ValidarDatosModificados())
                {
                    Alumno alumnoSeleccionado = (Alumno)dgvAlumnos.SelectedRows[0].DataBoundItem;
                    string nombreActualizado = this.inputModificarNombre.Text;
                    string apellidoActualizado = this.inputModificarApellido.Text;
                    gestorAlumnos.Modificar(alumnoSeleccionado.Legajo, nombreActualizado, apellidoActualizado);
                    LlenarDataGridView();
                }
                
            }
        }

        private bool ValidarDatosModificados()
        {
            return String.IsNullOrEmpty(this.inputModificarNombre.Text) || String.IsNullOrEmpty(this.inputModificarApellido.Text) ? false : true;
        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count == 1)
            {
                Alumno alumnoSeleccionado = (Alumno)dgvAlumnos.SelectedRows[0].DataBoundItem;
                this.inputModificarLegajo.Value = alumnoSeleccionado.Legajo;
                this.inputModificarNombre.Text = alumnoSeleccionado.Nombre;
                this.inputModificarApellido.Text = alumnoSeleccionado.Apellido;
            }
        }
    }
}
